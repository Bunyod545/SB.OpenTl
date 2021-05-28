// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8c39793f)]
	public sealed class TPromoData : IPromoData
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Proxy {get; set;}

       [SerializationOrder(2)]
       public int Expires {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

       /// <summary>Binary representation for the 'PsaType' property</summary>
       [SerializationOrder(6)]
       [CanSerialize("Flags", 1)]
       public byte[] PsaTypeAsBinary { get => _PsaTypeAsBinary; set { _PsaType = Encoding.UTF8.GetString(value); _PsaTypeAsBinary = value; }}
       private byte[] _PsaTypeAsBinary;
       private string _PsaType;
       public string PsaType { get => _PsaType; set { PsaTypeAsBinary = Encoding.UTF8.GetBytes(value); _PsaType = value; }}

       /// <summary>Binary representation for the 'PsaMessage' property</summary>
       [SerializationOrder(7)]
       [CanSerialize("Flags", 2)]
       public byte[] PsaMessageAsBinary { get => _PsaMessageAsBinary; set { _PsaMessage = Encoding.UTF8.GetString(value); _PsaMessageAsBinary = value; }}
       private byte[] _PsaMessageAsBinary;
       private string _PsaMessage;
       public string PsaMessage { get => _PsaMessage; set { PsaMessageAsBinary = Encoding.UTF8.GetBytes(value); _PsaMessage = value; }}

	}
}
