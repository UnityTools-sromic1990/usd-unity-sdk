//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class VtMatrix2dArray : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VtMatrix2dArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.VtMatrix2dArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtMatrix2dArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtMatrix2dArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_VtMatrix2dArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	  public GfMatrix2d this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtMatrix2dArray() : this(UsdCsPINVOKE.new_VtMatrix2dArray__SWIG_0(), true) {
  }

  public VtMatrix2dArray(Vt_ArrayForeignDataSource foreignSrc, GfMatrix2d data, uint size, bool addRef) : this(UsdCsPINVOKE.new_VtMatrix2dArray__SWIG_1(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), GfMatrix2d.getCPtr(data), size, addRef), true) {
  }

  public VtMatrix2dArray(Vt_ArrayForeignDataSource foreignSrc, GfMatrix2d data, uint size) : this(UsdCsPINVOKE.new_VtMatrix2dArray__SWIG_2(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), GfMatrix2d.getCPtr(data), size), true) {
  }

  public VtMatrix2dArray(VtMatrix2dArray other) : this(UsdCsPINVOKE.new_VtMatrix2dArray__SWIG_3(VtMatrix2dArray.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtMatrix2dArray(uint n) : this(UsdCsPINVOKE.new_VtMatrix2dArray__SWIG_5(n), true) {
  }

  public VtMatrix2dArray(uint n, GfMatrix2d value) : this(UsdCsPINVOKE.new_VtMatrix2dArray__SWIG_6(n, GfMatrix2d.getCPtr(value)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void push_back(GfMatrix2d elem) {
    UsdCsPINVOKE.VtMatrix2dArray_push_back(swigCPtr, GfMatrix2d.getCPtr(elem));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back() {
    UsdCsPINVOKE.VtMatrix2dArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = UsdCsPINVOKE.VtMatrix2dArray_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = UsdCsPINVOKE.VtMatrix2dArray_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = UsdCsPINVOKE.VtMatrix2dArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    UsdCsPINVOKE.VtMatrix2dArray_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    UsdCsPINVOKE.VtMatrix2dArray_resize(swigCPtr, newSize);
  }

  public void clear() {
    UsdCsPINVOKE.VtMatrix2dArray_clear(swigCPtr);
  }

  public void swap(VtMatrix2dArray other) {
    UsdCsPINVOKE.VtMatrix2dArray_swap(swigCPtr, VtMatrix2dArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtMatrix2dArray other) {
    bool ret = UsdCsPINVOKE.VtMatrix2dArray_IsIdentical(swigCPtr, VtMatrix2dArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtMatrix2dArray lhs, VtMatrix2dArray rhs) {
    bool ret = UsdCsPINVOKE.VtMatrix2dArray_Equals(VtMatrix2dArray.getCPtr(lhs), VtMatrix2dArray.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = UsdCsPINVOKE.VtMatrix2dArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(GfMatrix2d[] dest) {
    UsdCsPINVOKE.VtMatrix2dArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(GfMatrix2d[] src) {
    UsdCsPINVOKE.VtMatrix2dArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    UsdCsPINVOKE.VtMatrix2dArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    UsdCsPINVOKE.VtMatrix2dArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected GfMatrix2d GetValue(int index) {
    GfMatrix2d ret = new GfMatrix2d(UsdCsPINVOKE.VtMatrix2dArray_GetValue(swigCPtr, index), false);
    return ret;
  }

  protected void SetValue(int index, GfMatrix2d value) {
    UsdCsPINVOKE.VtMatrix2dArray_SetValue(swigCPtr, index, GfMatrix2d.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
