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

public class SdrRegistry : NdrRegistry {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SdrRegistry(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.SdrRegistry_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdrRegistry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new static SdrRegistry GetInstance() {
    SdrRegistry ret = new SdrRegistry(UsdCsPINVOKE.SdrRegistry_GetInstance(), false);
    return ret;
  }

  public SdrShaderNode GetShaderNodeByIdentifier(TfToken identifier, TfTokenVector typePriority) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeByIdentifier__SWIG_0(swigCPtr, TfToken.getCPtr(identifier), TfTokenVector.getCPtr(typePriority));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeByIdentifier(TfToken identifier) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeByIdentifier__SWIG_1(swigCPtr, TfToken.getCPtr(identifier));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeByIdentifierAndType(TfToken identifier, TfToken nodeType) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeByIdentifierAndType(swigCPtr, TfToken.getCPtr(identifier), TfToken.getCPtr(nodeType));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeByName(string name, TfTokenVector typePriority, NdrVersionFilter filter) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeByName__SWIG_0(swigCPtr, name, TfTokenVector.getCPtr(typePriority), (int)filter);
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeByName(string name, TfTokenVector typePriority) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeByName__SWIG_1(swigCPtr, name, TfTokenVector.getCPtr(typePriority));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeByName(string name) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeByName__SWIG_2(swigCPtr, name);
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeByNameAndType(string name, TfToken nodeType, NdrVersionFilter filter) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeByNameAndType__SWIG_0(swigCPtr, name, TfToken.getCPtr(nodeType), (int)filter);
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeByNameAndType(string name, TfToken nodeType) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeByNameAndType__SWIG_1(swigCPtr, name, TfToken.getCPtr(nodeType));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeFromAsset(SdfAssetPath shaderAsset, SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t metadata, TfToken subIdentifier, TfToken sourceType) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeFromAsset__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(shaderAsset), SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t.getCPtr(metadata), TfToken.getCPtr(subIdentifier), TfToken.getCPtr(sourceType));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeFromAsset(SdfAssetPath shaderAsset, SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t metadata, TfToken subIdentifier) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeFromAsset__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(shaderAsset), SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t.getCPtr(metadata), TfToken.getCPtr(subIdentifier));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeFromAsset(SdfAssetPath shaderAsset, SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t metadata) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeFromAsset__SWIG_2(swigCPtr, SdfAssetPath.getCPtr(shaderAsset), SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t.getCPtr(metadata));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeFromAsset(SdfAssetPath shaderAsset) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeFromAsset__SWIG_3(swigCPtr, SdfAssetPath.getCPtr(shaderAsset));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeFromSourceCode(string sourceCode, TfToken sourceType, SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t metadata) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeFromSourceCode__SWIG_0(swigCPtr, sourceCode, TfToken.getCPtr(sourceType), SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t.getCPtr(metadata));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeFromSourceCode(string sourceCode, TfToken sourceType) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeFromSourceCode__SWIG_1(swigCPtr, sourceCode, TfToken.getCPtr(sourceType));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdrShaderNode GetShaderNodeByURI(string uri) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdrRegistry_GetShaderNodeByURI(swigCPtr, uri);
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByIdentifier(TfToken identifier) {
    SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t ret = new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(UsdCsPINVOKE.SdrRegistry_GetShaderNodesByIdentifier(swigCPtr, TfToken.getCPtr(identifier)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByName(string name, NdrVersionFilter filter) {
    SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t ret = new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(UsdCsPINVOKE.SdrRegistry_GetShaderNodesByName__SWIG_0(swigCPtr, name, (int)filter), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByName(string name) {
    SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t ret = new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(UsdCsPINVOKE.SdrRegistry_GetShaderNodesByName__SWIG_1(swigCPtr, name), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByFamily(TfToken family, NdrVersionFilter filter) {
    SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t ret = new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(UsdCsPINVOKE.SdrRegistry_GetShaderNodesByFamily__SWIG_0(swigCPtr, TfToken.getCPtr(family), (int)filter), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByFamily(TfToken family) {
    SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t ret = new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(UsdCsPINVOKE.SdrRegistry_GetShaderNodesByFamily__SWIG_1(swigCPtr, TfToken.getCPtr(family)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByFamily() {
    SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t ret = new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(UsdCsPINVOKE.SdrRegistry_GetShaderNodesByFamily__SWIG_2(swigCPtr), true);
    return ret;
  }

}

}
