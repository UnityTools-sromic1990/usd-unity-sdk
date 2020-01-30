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

public class VtVec2fArray : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VtVec2fArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.VtVec2fArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtVec2fArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtVec2fArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_VtVec2fArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	  public GfVec2f this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtVec2fArray() : this(UsdCsPINVOKE.new_VtVec2fArray__SWIG_0(), true) {
  }

  public VtVec2fArray(Vt_ArrayForeignDataSource foreignSrc, GfVec2f data, uint size, bool addRef) : this(UsdCsPINVOKE.new_VtVec2fArray__SWIG_1(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), GfVec2f.getCPtr(data), size, addRef), true) {
  }

  public VtVec2fArray(Vt_ArrayForeignDataSource foreignSrc, GfVec2f data, uint size) : this(UsdCsPINVOKE.new_VtVec2fArray__SWIG_2(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), GfVec2f.getCPtr(data), size), true) {
  }

  public VtVec2fArray(VtVec2fArray other) : this(UsdCsPINVOKE.new_VtVec2fArray__SWIG_3(VtVec2fArray.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtVec2fArray(uint n) : this(UsdCsPINVOKE.new_VtVec2fArray__SWIG_5(n), true) {
  }

  public VtVec2fArray(uint n, GfVec2f value) : this(UsdCsPINVOKE.new_VtVec2fArray__SWIG_6(n, GfVec2f.getCPtr(value)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void push_back(GfVec2f elem) {
    UsdCsPINVOKE.VtVec2fArray_push_back(swigCPtr, GfVec2f.getCPtr(elem));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back() {
    UsdCsPINVOKE.VtVec2fArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = UsdCsPINVOKE.VtVec2fArray_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = UsdCsPINVOKE.VtVec2fArray_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = UsdCsPINVOKE.VtVec2fArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    UsdCsPINVOKE.VtVec2fArray_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    UsdCsPINVOKE.VtVec2fArray_resize(swigCPtr, newSize);
  }

  public void clear() {
    UsdCsPINVOKE.VtVec2fArray_clear(swigCPtr);
  }

  public void swap(VtVec2fArray other) {
    UsdCsPINVOKE.VtVec2fArray_swap(swigCPtr, VtVec2fArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtVec2fArray other) {
    bool ret = UsdCsPINVOKE.VtVec2fArray_IsIdentical(swigCPtr, VtVec2fArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtVec2fArray lhs, VtVec2fArray rhs) {
    bool ret = UsdCsPINVOKE.VtVec2fArray_Equals(VtVec2fArray.getCPtr(lhs), VtVec2fArray.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = UsdCsPINVOKE.VtVec2fArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(GfVec2f[] dest) {
    UsdCsPINVOKE.VtVec2fArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(GfVec2f[] src) {
    UsdCsPINVOKE.VtVec2fArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    UsdCsPINVOKE.VtVec2fArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    UsdCsPINVOKE.VtVec2fArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected GfVec2f GetValue(int index) {
    GfVec2f ret = new GfVec2f(UsdCsPINVOKE.VtVec2fArray_GetValue(swigCPtr, index), false);
    return ret;
  }

  protected void SetValue(int index, GfVec2f value) {
    UsdCsPINVOKE.VtVec2fArray_SetValue(swigCPtr, index, GfVec2f.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
