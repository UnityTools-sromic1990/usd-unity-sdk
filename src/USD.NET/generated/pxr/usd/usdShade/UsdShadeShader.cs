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

public class UsdShadeShader : UsdTyped {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdShadeShader(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdShadeShader_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdShadeShader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdShadeShader() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdShadeShader(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdShadeShader(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdShadeShader__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdShadeShader() : this(UsdCsPINVOKE.new_UsdShadeShader__SWIG_1(), true) {
  }

  public UsdShadeShader(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdShadeShader__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdShadeShader_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdShadeShader_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdShadeShader Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdShadeShader ret = new UsdShadeShader(UsdCsPINVOKE.UsdShadeShader_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdShadeShader Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdShadeShader ret = new UsdShadeShader(UsdCsPINVOKE.UsdShadeShader_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetImplementationSourceAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdShadeShader_GetImplementationSourceAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateImplementationSourceAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdShadeShader_CreateImplementationSourceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateImplementationSourceAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdShadeShader_CreateImplementationSourceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateImplementationSourceAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdShadeShader_CreateImplementationSourceAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetIdAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdShadeShader_GetIdAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateIdAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdShadeShader_CreateIdAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateIdAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdShadeShader_CreateIdAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateIdAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdShadeShader_CreateIdAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdShadeShader(UsdShadeConnectableAPI connectable) : this(UsdCsPINVOKE.new_UsdShadeShader__SWIG_3(UsdShadeConnectableAPI.getCPtr(connectable)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdShadeConnectableAPI ConnectableAPI() {
    UsdShadeConnectableAPI ret = new UsdShadeConnectableAPI(UsdCsPINVOKE.UsdShadeShader_ConnectableAPI(swigCPtr), true);
    return ret;
  }

  public UsdShadeOutput CreateOutput(TfToken name, SdfValueTypeName typeName) {
    UsdShadeOutput ret = new UsdShadeOutput(UsdCsPINVOKE.UsdShadeShader_CreateOutput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeOutput GetOutput(TfToken name) {
    UsdShadeOutput ret = new UsdShadeOutput(UsdCsPINVOKE.UsdShadeShader_GetOutput(swigCPtr, TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeOutputVector GetOutputs() {
    UsdShadeOutputVector ret = new UsdShadeOutputVector(UsdCsPINVOKE.UsdShadeShader_GetOutputs(swigCPtr), true);
    return ret;
  }

  public UsdShadeInput CreateInput(TfToken name, SdfValueTypeName typeName) {
    UsdShadeInput ret = new UsdShadeInput(UsdCsPINVOKE.UsdShadeShader_CreateInput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeInput GetInput(TfToken name) {
    UsdShadeInput ret = new UsdShadeInput(UsdCsPINVOKE.UsdShadeShader_GetInput(swigCPtr, TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeInputVector GetInputs() {
    UsdShadeInputVector ret = new UsdShadeInputVector(UsdCsPINVOKE.UsdShadeShader_GetInputs(swigCPtr), true);
    return ret;
  }

  public TfToken GetImplementationSource() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdShadeShader_GetImplementationSource(swigCPtr), true);
    return ret;
  }

  public bool SetShaderId(TfToken id) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_SetShaderId(swigCPtr, TfToken.getCPtr(id));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetShaderId(TfToken id) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_GetShaderId(swigCPtr, TfToken.getCPtr(id));
    return ret;
  }

  public bool SetSourceAsset(SdfAssetPath sourceAsset, TfToken sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_SetSourceAsset__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(sourceAsset), TfToken.getCPtr(sourceType));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetSourceAsset(SdfAssetPath sourceAsset) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_SetSourceAsset__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(sourceAsset));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetSourceAsset(SdfAssetPath sourceAsset, TfToken sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_GetSourceAsset__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(sourceAsset), TfToken.getCPtr(sourceType));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetSourceAsset(SdfAssetPath sourceAsset) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_GetSourceAsset__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(sourceAsset));
    return ret;
  }

  public bool SetSourceAssetSubIdentifier(TfToken subIdentifier, TfToken sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_SetSourceAssetSubIdentifier__SWIG_0(swigCPtr, TfToken.getCPtr(subIdentifier), TfToken.getCPtr(sourceType));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetSourceAssetSubIdentifier(TfToken subIdentifier) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_SetSourceAssetSubIdentifier__SWIG_1(swigCPtr, TfToken.getCPtr(subIdentifier));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetSourceAssetSubIdentifier(TfToken subIdentifier, TfToken sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_GetSourceAssetSubIdentifier__SWIG_0(swigCPtr, TfToken.getCPtr(subIdentifier), TfToken.getCPtr(sourceType));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetSourceAssetSubIdentifier(TfToken subIdentifier) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_GetSourceAssetSubIdentifier__SWIG_1(swigCPtr, TfToken.getCPtr(subIdentifier));
    return ret;
  }

  public bool SetSourceCode(string sourceCode, TfToken sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_SetSourceCode__SWIG_0(swigCPtr, sourceCode, TfToken.getCPtr(sourceType));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetSourceCode(string sourceCode) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_SetSourceCode__SWIG_1(swigCPtr, sourceCode);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetSourceCode(/*cstype*/ out string sourceCode, TfToken sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_GetSourceCode__SWIG_0(swigCPtr, out sourceCode, TfToken.getCPtr(sourceType));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetSourceCode(/*cstype*/ out string sourceCode) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_GetSourceCode__SWIG_1(swigCPtr, out sourceCode);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t GetSdrMetadata() {
    SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t ret = new SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t(UsdCsPINVOKE.UsdShadeShader_GetSdrMetadata(swigCPtr), true);
    return ret;
  }

  public string GetSdrMetadataByKey(TfToken key) {
    string ret = UsdCsPINVOKE.UsdShadeShader_GetSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSdrMetadata(SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t sdrMetadata) {
    UsdCsPINVOKE.UsdShadeShader_SetSdrMetadata(swigCPtr, SWIGTYPE_p_std__unordered_mapT_TfToken_std__string_TfToken__HashFunctor_t.getCPtr(sdrMetadata));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSdrMetadataByKey(TfToken key, string value) {
    UsdCsPINVOKE.UsdShadeShader_SetSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key), value);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasSdrMetadata() {
    bool ret = UsdCsPINVOKE.UsdShadeShader_HasSdrMetadata(swigCPtr);
    return ret;
  }

  public bool HasSdrMetadataByKey(TfToken key) {
    bool ret = UsdCsPINVOKE.UsdShadeShader_HasSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ClearSdrMetadata() {
    UsdCsPINVOKE.UsdShadeShader_ClearSdrMetadata(swigCPtr);
  }

  public void ClearSdrMetadataByKey(TfToken key) {
    UsdCsPINVOKE.UsdShadeShader_ClearSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdrShaderNode GetShaderNodeForSourceType(TfToken sourceType) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.UsdShadeShader_GetShaderNodeForSourceType(swigCPtr, TfToken.getCPtr(sourceType));
    SdrShaderNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdrShaderNode(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
