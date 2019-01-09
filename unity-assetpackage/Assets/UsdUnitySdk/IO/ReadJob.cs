﻿using System;
using System.Collections.Generic;
using UnityEngine;
using Unity.Jobs;
using pxr;
using System.Collections;
using System.Threading;

namespace USD.NET.Unity {

  public struct ReadAllJob<T> :
      IEnumerator<SampleEnumerator<T>.SampleHolder>,
      IEnumerable<SampleEnumerator<T>.SampleHolder>,
      IJobParallelFor
      where T : SampleBase, new() {
    static private Scene m_scene;
    static private SdfPath[] m_paths;
    static private T[] m_results;
    static private bool[] m_done;
    static private bool[] m_written;
    static SampleEnumerator<T>.SampleHolder m_current;
    static private AutoResetEvent m_ready;

    public SampleEnumerator<T>.SampleHolder Current
    {
      get {
        return m_current;
      }
    }

    object IEnumerator.Current
    {
      get {
        return m_current;
      }
    }

    public ReadAllJob(Scene scene, SdfPath[] paths) {
      m_ready = new AutoResetEvent(false);
      m_scene = scene;
      m_results = new T[paths.Length];
      m_done = new bool[paths.Length];
      m_written = new bool[paths.Length];
      m_current = new SampleEnumerator<T>.SampleHolder();
      m_paths = paths;
    }

    public void WaitOnce() {
      m_ready.WaitOne(25);
    }

    private bool ShouldReadPath(Scene scene, SdfPath path) {
      return scene.AccessMask == null
          || scene.IsPopulatingAccessMask
          || scene.AccessMask.Included.ContainsKey(path);
    }

    public void Execute(int index) {
      var sample = new T();
      if (ShouldReadPath(m_scene, m_paths[index])) {
        m_scene.Read(m_paths[index], sample);
      } else {
        sample = null;
        m_done[index] = true;
      }
      m_results[index] = sample;
      m_written[index] = true;
      m_ready.Set();
    }

    public bool MoveNext() {
      bool hasWork = true;

      int j = 0;
      while (hasWork) {
        hasWork = false;
        for (int i = 0; i < m_done.Length; i++) {
          hasWork = hasWork || (m_done[i] == false);
        }

        if (!hasWork) {
          return false;
        }

        //m_ready.WaitOne(5);
        for (int i = 0; i < m_done.Length; i++) {
          if (m_done[i] == false && m_written[i] == true) {
            m_current.path = m_paths[i];
            m_current.sample = m_results[i];
            m_done[i] = true;
            return true;
          }
        }
        j++;
        if (j % 40 == 39) {
          Thread.Sleep(1);
        }
        if (j > 40 * 20) {
          Debug.LogWarning("Exiting after 20 sleeps");
          return false;
        }
      }

      return false;
    }

    public void Reset() {
      for (int i = 0; i < m_done.Length; i++) {
        m_done[i] = false;
      }
    }

    public void Dispose() {
    }

    public IEnumerator<SampleEnumerator<T>.SampleHolder> GetEnumerator() {
      return this;
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return this;
    }
  }
}