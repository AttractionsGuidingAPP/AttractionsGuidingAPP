// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/yolo_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yolo {

  /// <summary>Holder for reflection information generated from protos/yolo_service.proto</summary>
  public static partial class YoloServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/yolo_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static YoloServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chlwcm90b3MveW9sb19zZXJ2aWNlLnByb3RvIiEKEERldGVjdGlvblJlcXVl",
            "c3QSDQoFaW1hZ2UYASABKAwiVQoRRGV0ZWN0aW9uUmVzcG9uc2USIwoJeW9s",
            "b0l0ZW1zGAEgAygLMhAuRGV0ZWN0aW9uUmVzdWx0EhsKE2VsYXBzZWRNaWxs",
            "aXNlY29uZHMYAiABKAUiaAoPRGV0ZWN0aW9uUmVzdWx0EgwKBHR5cGUYASAB",
            "KAkSEgoKY29uZmlkZW5jZRgCIAEoARIJCgF4GAMgASgFEgkKAXkYBCABKAUS",
            "DQoFd2lkdGgYBSABKAUSDgoGaGVpZ2h0GAYgASgFMkIKC1lvbG9TZXJ2aWNl",
            "EjMKBkRldGVjdBIRLkRldGVjdGlvblJlcXVlc3QaEi5EZXRlY3Rpb25SZXNw",
            "b25zZSIAMAFCB6oCBFlvbG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yolo.DetectionRequest), global::Yolo.DetectionRequest.Parser, new[]{ "Image" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yolo.DetectionResponse), global::Yolo.DetectionResponse.Parser, new[]{ "YoloItems", "ElapsedMilliseconds" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yolo.DetectionResult), global::Yolo.DetectionResult.Parser, new[]{ "Type", "Confidence", "X", "Y", "Width", "Height" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DetectionRequest : pb::IMessage<DetectionRequest> {
    private static readonly pb::MessageParser<DetectionRequest> _parser = new pb::MessageParser<DetectionRequest>(() => new DetectionRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DetectionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yolo.YoloServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetectionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetectionRequest(DetectionRequest other) : this() {
      image_ = other.image_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetectionRequest Clone() {
      return new DetectionRequest(this);
    }

    /// <summary>Field number for the "image" field.</summary>
    public const int ImageFieldNumber = 1;
    private pb::ByteString image_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Image {
      get { return image_; }
      set {
        image_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DetectionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DetectionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Image != other.Image) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Image.Length != 0) hash ^= Image.GetHashCode();
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
      if (Image.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Image);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Image.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Image);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DetectionRequest other) {
      if (other == null) {
        return;
      }
      if (other.Image.Length != 0) {
        Image = other.Image;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Image = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DetectionResponse : pb::IMessage<DetectionResponse> {
    private static readonly pb::MessageParser<DetectionResponse> _parser = new pb::MessageParser<DetectionResponse>(() => new DetectionResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DetectionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yolo.YoloServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetectionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetectionResponse(DetectionResponse other) : this() {
      yoloItems_ = other.yoloItems_.Clone();
      elapsedMilliseconds_ = other.elapsedMilliseconds_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetectionResponse Clone() {
      return new DetectionResponse(this);
    }

    /// <summary>Field number for the "yoloItems" field.</summary>
    public const int YoloItemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yolo.DetectionResult> _repeated_yoloItems_codec
        = pb::FieldCodec.ForMessage(10, global::Yolo.DetectionResult.Parser);
    private readonly pbc::RepeatedField<global::Yolo.DetectionResult> yoloItems_ = new pbc::RepeatedField<global::Yolo.DetectionResult>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yolo.DetectionResult> YoloItems {
      get { return yoloItems_; }
    }

    /// <summary>Field number for the "elapsedMilliseconds" field.</summary>
    public const int ElapsedMillisecondsFieldNumber = 2;
    private int elapsedMilliseconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ElapsedMilliseconds {
      get { return elapsedMilliseconds_; }
      set {
        elapsedMilliseconds_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DetectionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DetectionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!yoloItems_.Equals(other.yoloItems_)) return false;
      if (ElapsedMilliseconds != other.ElapsedMilliseconds) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= yoloItems_.GetHashCode();
      if (ElapsedMilliseconds != 0) hash ^= ElapsedMilliseconds.GetHashCode();
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
      yoloItems_.WriteTo(output, _repeated_yoloItems_codec);
      if (ElapsedMilliseconds != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ElapsedMilliseconds);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += yoloItems_.CalculateSize(_repeated_yoloItems_codec);
      if (ElapsedMilliseconds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ElapsedMilliseconds);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DetectionResponse other) {
      if (other == null) {
        return;
      }
      yoloItems_.Add(other.yoloItems_);
      if (other.ElapsedMilliseconds != 0) {
        ElapsedMilliseconds = other.ElapsedMilliseconds;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            yoloItems_.AddEntriesFrom(input, _repeated_yoloItems_codec);
            break;
          }
          case 16: {
            ElapsedMilliseconds = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DetectionResult : pb::IMessage<DetectionResult> {
    private static readonly pb::MessageParser<DetectionResult> _parser = new pb::MessageParser<DetectionResult>(() => new DetectionResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DetectionResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yolo.YoloServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetectionResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetectionResult(DetectionResult other) : this() {
      type_ = other.type_;
      confidence_ = other.confidence_;
      x_ = other.x_;
      y_ = other.y_;
      width_ = other.width_;
      height_ = other.height_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetectionResult Clone() {
      return new DetectionResult(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private string type_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "confidence" field.</summary>
    public const int ConfidenceFieldNumber = 2;
    private double confidence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Confidence {
      get { return confidence_; }
      set {
        confidence_ = value;
      }
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 3;
    private int x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 4;
    private int y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 5;
    private int width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Width {
      get { return width_; }
      set {
        width_ = value;
      }
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 6;
    private int height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DetectionResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DetectionResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Confidence, other.Confidence)) return false;
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Width != other.Width) return false;
      if (Height != other.Height) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Confidence != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Confidence);
      if (X != 0) hash ^= X.GetHashCode();
      if (Y != 0) hash ^= Y.GetHashCode();
      if (Width != 0) hash ^= Width.GetHashCode();
      if (Height != 0) hash ^= Height.GetHashCode();
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
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (Confidence != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Confidence);
      }
      if (X != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(X);
      }
      if (Y != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Y);
      }
      if (Width != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Width);
      }
      if (Height != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Height);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Confidence != 0D) {
        size += 1 + 8;
      }
      if (X != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(X);
      }
      if (Y != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Y);
      }
      if (Width != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Width);
      }
      if (Height != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Height);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DetectionResult other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Confidence != 0D) {
        Confidence = other.Confidence;
      }
      if (other.X != 0) {
        X = other.X;
      }
      if (other.Y != 0) {
        Y = other.Y;
      }
      if (other.Width != 0) {
        Width = other.Width;
      }
      if (other.Height != 0) {
        Height = other.Height;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Type = input.ReadString();
            break;
          }
          case 17: {
            Confidence = input.ReadDouble();
            break;
          }
          case 24: {
            X = input.ReadInt32();
            break;
          }
          case 32: {
            Y = input.ReadInt32();
            break;
          }
          case 40: {
            Width = input.ReadInt32();
            break;
          }
          case 48: {
            Height = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code