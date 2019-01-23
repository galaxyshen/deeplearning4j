// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace nd4j.graph
{

using global::System;
using global::FlatBuffers;

public struct UIVariable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static UIVariable GetRootAsUIVariable(ByteBuffer _bb) { return GetRootAsUIVariable(_bb, new UIVariable()); }
  public static UIVariable GetRootAsUIVariable(ByteBuffer _bb, UIVariable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public UIVariable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public IntPair? Id { get { int o = __p.__offset(4); return o != 0 ? (IntPair?)(new IntPair()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
  public VarType Type { get { int o = __p.__offset(8); return o != 0 ? (VarType)__p.bb.GetSbyte(o + __p.bb_pos) : VarType.VARIABLE; } }
  public string OutputOfOp { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetOutputOfOpBytes() { return __p.__vector_as_arraysegment(10); }
  public string InputsForOp(int j) { int o = __p.__offset(12); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int InputsForOpLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ControlDepsForOp(int j) { int o = __p.__offset(14); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ControlDepsForOpLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ControlDepsForVar(int j) { int o = __p.__offset(16); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ControlDepsForVarLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string GradientVariable { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetGradientVariableBytes() { return __p.__vector_as_arraysegment(18); }

  public static Offset<UIVariable> CreateUIVariable(FlatBufferBuilder builder,
      Offset<IntPair> idOffset = default(Offset<IntPair>),
      StringOffset nameOffset = default(StringOffset),
      VarType type = VarType.VARIABLE,
      StringOffset outputOfOpOffset = default(StringOffset),
      VectorOffset inputsForOpOffset = default(VectorOffset),
      VectorOffset controlDepsForOpOffset = default(VectorOffset),
      VectorOffset controlDepsForVarOffset = default(VectorOffset),
      StringOffset gradientVariableOffset = default(StringOffset)) {
    builder.StartObject(8);
    UIVariable.AddGradientVariable(builder, gradientVariableOffset);
    UIVariable.AddControlDepsForVar(builder, controlDepsForVarOffset);
    UIVariable.AddControlDepsForOp(builder, controlDepsForOpOffset);
    UIVariable.AddInputsForOp(builder, inputsForOpOffset);
    UIVariable.AddOutputOfOp(builder, outputOfOpOffset);
    UIVariable.AddName(builder, nameOffset);
    UIVariable.AddId(builder, idOffset);
    UIVariable.AddType(builder, type);
    return UIVariable.EndUIVariable(builder);
  }

  public static void StartUIVariable(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, Offset<IntPair> idOffset) { builder.AddOffset(0, idOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, VarType type) { builder.AddSbyte(2, (sbyte)type, 0); }
  public static void AddOutputOfOp(FlatBufferBuilder builder, StringOffset outputOfOpOffset) { builder.AddOffset(3, outputOfOpOffset.Value, 0); }
  public static void AddInputsForOp(FlatBufferBuilder builder, VectorOffset inputsForOpOffset) { builder.AddOffset(4, inputsForOpOffset.Value, 0); }
  public static VectorOffset CreateInputsForOpVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartInputsForOpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddControlDepsForOp(FlatBufferBuilder builder, VectorOffset controlDepsForOpOffset) { builder.AddOffset(5, controlDepsForOpOffset.Value, 0); }
  public static VectorOffset CreateControlDepsForOpVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartControlDepsForOpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddControlDepsForVar(FlatBufferBuilder builder, VectorOffset controlDepsForVarOffset) { builder.AddOffset(6, controlDepsForVarOffset.Value, 0); }
  public static VectorOffset CreateControlDepsForVarVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartControlDepsForVarVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGradientVariable(FlatBufferBuilder builder, StringOffset gradientVariableOffset) { builder.AddOffset(7, gradientVariableOffset.Value, 0); }
  public static Offset<UIVariable> EndUIVariable(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<UIVariable>(o);
  }
};


}