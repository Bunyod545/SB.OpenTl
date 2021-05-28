// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd072acb4)]
	public sealed class TRestrictionReason : IRestrictionReason
	{
       /// <summary>Binary representation for the 'Platform' property</summary>
       [SerializationOrder(0)]
       public byte[] PlatformAsBinary { get => _PlatformAsBinary; set { _Platform = Encoding.UTF8.GetString(value); _PlatformAsBinary = value; }}
       private byte[] _PlatformAsBinary;
       private string _Platform;
       public string Platform { get => _Platform; set { PlatformAsBinary = Encoding.UTF8.GetBytes(value); _Platform = value; }}

       /// <summary>Binary representation for the 'Reason' property</summary>
       [SerializationOrder(1)]
       public byte[] ReasonAsBinary { get => _ReasonAsBinary; set { _Reason = Encoding.UTF8.GetString(value); _ReasonAsBinary = value; }}
       private byte[] _ReasonAsBinary;
       private string _Reason;
       public string Reason { get => _Reason; set { ReasonAsBinary = Encoding.UTF8.GetBytes(value); _Reason = value; }}

       /// <summary>Binary representation for the 'Text' property</summary>
       [SerializationOrder(2)]
       public byte[] TextAsBinary { get => _TextAsBinary; set { _Text = Encoding.UTF8.GetString(value); _TextAsBinary = value; }}
       private byte[] _TextAsBinary;
       private string _Text;
       public string Text { get => _Text; set { TextAsBinary = Encoding.UTF8.GetBytes(value); _Text = value; }}

	}
}
