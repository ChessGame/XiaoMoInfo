// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GMMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GMMessage.proto</summary>
public static partial class GMMessageReflection {

  #region Descriptor
  /// <summary>File descriptor for GMMessage.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GMMessageReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg9HTU1lc3NhZ2UucHJvdG8aD01lc3NhZ2VJZC5wcm90byI7ChBSZXFHTUNs",
          "b3NlU2VydmVyEhcKBW1zZ0lkGAEgASgOMgguR01Nc2dJZBIOCgZyZXNNc2cY",
          "AiABKAkiOwoQUmVzR01DbG9zZVNlcnZlchIXCgVtc2dJZBgBIAEoDjIILkdN",
          "TXNnSWQSDgoGcmVzTXNnGAIgASgJQikKJWluZm8ueGlhb21vLnNlcnZlci5z",
          "aGFyZWQucHJvdG9jb2wuZ21QAWIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::MessageIdReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ReqGMCloseServer), global::ReqGMCloseServer.Parser, new[]{ "MsgId", "ResMsg" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ResGMCloseServer), global::ResGMCloseServer.Parser, new[]{ "MsgId", "ResMsg" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ReqGMCloseServer : pb::IMessage<ReqGMCloseServer>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ReqGMCloseServer> _parser = new pb::MessageParser<ReqGMCloseServer>(() => new ReqGMCloseServer());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ReqGMCloseServer> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GMMessageReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ReqGMCloseServer() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ReqGMCloseServer(ReqGMCloseServer other) : this() {
    msgId_ = other.msgId_;
    resMsg_ = other.resMsg_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ReqGMCloseServer Clone() {
    return new ReqGMCloseServer(this);
  }

  /// <summary>Field number for the "msgId" field.</summary>
  public const int MsgIdFieldNumber = 1;
  private global::GMMsgId msgId_ = global::GMMsgId.GmUnknown;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::GMMsgId MsgId {
    get { return msgId_; }
    set {
      msgId_ = value;
    }
  }

  /// <summary>Field number for the "resMsg" field.</summary>
  public const int ResMsgFieldNumber = 2;
  private string resMsg_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string ResMsg {
    get { return resMsg_; }
    set {
      resMsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ReqGMCloseServer);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ReqGMCloseServer other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MsgId != other.MsgId) return false;
    if (ResMsg != other.ResMsg) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (MsgId != global::GMMsgId.GmUnknown) hash ^= MsgId.GetHashCode();
    if (ResMsg.Length != 0) hash ^= ResMsg.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (MsgId != global::GMMsgId.GmUnknown) {
      output.WriteRawTag(8);
      output.WriteEnum((int) MsgId);
    }
    if (ResMsg.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(ResMsg);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (MsgId != global::GMMsgId.GmUnknown) {
      output.WriteRawTag(8);
      output.WriteEnum((int) MsgId);
    }
    if (ResMsg.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(ResMsg);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (MsgId != global::GMMsgId.GmUnknown) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MsgId);
    }
    if (ResMsg.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ResMsg);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ReqGMCloseServer other) {
    if (other == null) {
      return;
    }
    if (other.MsgId != global::GMMsgId.GmUnknown) {
      MsgId = other.MsgId;
    }
    if (other.ResMsg.Length != 0) {
      ResMsg = other.ResMsg;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          MsgId = (global::GMMsgId) input.ReadEnum();
          break;
        }
        case 18: {
          ResMsg = input.ReadString();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          MsgId = (global::GMMsgId) input.ReadEnum();
          break;
        }
        case 18: {
          ResMsg = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class ResGMCloseServer : pb::IMessage<ResGMCloseServer>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ResGMCloseServer> _parser = new pb::MessageParser<ResGMCloseServer>(() => new ResGMCloseServer());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ResGMCloseServer> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GMMessageReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ResGMCloseServer() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ResGMCloseServer(ResGMCloseServer other) : this() {
    msgId_ = other.msgId_;
    resMsg_ = other.resMsg_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ResGMCloseServer Clone() {
    return new ResGMCloseServer(this);
  }

  /// <summary>Field number for the "msgId" field.</summary>
  public const int MsgIdFieldNumber = 1;
  private global::GMMsgId msgId_ = global::GMMsgId.GmUnknown;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::GMMsgId MsgId {
    get { return msgId_; }
    set {
      msgId_ = value;
    }
  }

  /// <summary>Field number for the "resMsg" field.</summary>
  public const int ResMsgFieldNumber = 2;
  private string resMsg_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string ResMsg {
    get { return resMsg_; }
    set {
      resMsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ResGMCloseServer);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ResGMCloseServer other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MsgId != other.MsgId) return false;
    if (ResMsg != other.ResMsg) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (MsgId != global::GMMsgId.GmUnknown) hash ^= MsgId.GetHashCode();
    if (ResMsg.Length != 0) hash ^= ResMsg.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (MsgId != global::GMMsgId.GmUnknown) {
      output.WriteRawTag(8);
      output.WriteEnum((int) MsgId);
    }
    if (ResMsg.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(ResMsg);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (MsgId != global::GMMsgId.GmUnknown) {
      output.WriteRawTag(8);
      output.WriteEnum((int) MsgId);
    }
    if (ResMsg.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(ResMsg);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (MsgId != global::GMMsgId.GmUnknown) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MsgId);
    }
    if (ResMsg.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ResMsg);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ResGMCloseServer other) {
    if (other == null) {
      return;
    }
    if (other.MsgId != global::GMMsgId.GmUnknown) {
      MsgId = other.MsgId;
    }
    if (other.ResMsg.Length != 0) {
      ResMsg = other.ResMsg;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          MsgId = (global::GMMsgId) input.ReadEnum();
          break;
        }
        case 18: {
          ResMsg = input.ReadString();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          MsgId = (global::GMMsgId) input.ReadEnum();
          break;
        }
        case 18: {
          ResMsg = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code