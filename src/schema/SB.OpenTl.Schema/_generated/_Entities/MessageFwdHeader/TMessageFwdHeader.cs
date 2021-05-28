// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5f777dce)]
	public sealed class TMessageFwdHeader : IMessageFwdHeader
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 7)]
       public bool Imported {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IPeer FromId {get; set;}

       /// <summary>Binary representation for the 'FromName' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 5)]
       public byte[] FromNameAsBinary { get => _FromNameAsBinary; set { _FromName = Encoding.UTF8.GetString(value); _FromNameAsBinary = value; }}
       private byte[] _FromNameAsBinary;
       private string _FromName;
       public string FromName { get => _FromName; set { FromNameAsBinary = Encoding.UTF8.GetBytes(value); _FromName = value; }}

       [SerializationOrder(4)]
       public int Date {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public int ChannelPost {get; set;}

       /// <summary>Binary representation for the 'PostAuthor' property</summary>
       [SerializationOrder(6)]
       [CanSerialize("Flags", 3)]
       public byte[] PostAuthorAsBinary { get => _PostAuthorAsBinary; set { _PostAuthor = Encoding.UTF8.GetString(value); _PostAuthorAsBinary = value; }}
       private byte[] _PostAuthorAsBinary;
       private string _PostAuthor;
       public string PostAuthor { get => _PostAuthor; set { PostAuthorAsBinary = Encoding.UTF8.GetBytes(value); _PostAuthor = value; }}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 4)]
       public OpenTl.Schema.IPeer SavedFromPeer {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 4)]
       public int SavedFromMsgId {get; set;}

       /// <summary>Binary representation for the 'PsaType' property</summary>
       [SerializationOrder(9)]
       [CanSerialize("Flags", 6)]
       public byte[] PsaTypeAsBinary { get => _PsaTypeAsBinary; set { _PsaType = Encoding.UTF8.GetString(value); _PsaTypeAsBinary = value; }}
       private byte[] _PsaTypeAsBinary;
       private string _PsaType;
       public string PsaType { get => _PsaType; set { PsaTypeAsBinary = Encoding.UTF8.GetBytes(value); _PsaType = value; }}

	}
}
