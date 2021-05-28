// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x58ae39c9)]
	public sealed class TMessage : IMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Out {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 4)]
       public bool Mentioned {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 5)]
       public bool MediaUnread {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 13)]
       public bool Silent {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 14)]
       public bool Post {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 18)]
       public bool FromScheduled {get; set;}

       [SerializationOrder(7)]
       [FromFlag("Flags", 19)]
       public bool Legacy {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 21)]
       public bool EditHide {get; set;}

       [SerializationOrder(9)]
       [FromFlag("Flags", 24)]
       public bool Pinned {get; set;}

       [SerializationOrder(10)]
       public int Id {get; set;}

       [SerializationOrder(11)]
       [CanSerialize("Flags", 8)]
       public OpenTl.Schema.IPeer FromId {get; set;}

       [SerializationOrder(12)]
       public OpenTl.Schema.IPeer PeerId {get; set;}

       [SerializationOrder(13)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IMessageFwdHeader FwdFrom {get; set;}

       [SerializationOrder(14)]
       [CanSerialize("Flags", 11)]
       public int ViaBotId {get; set;}

       [SerializationOrder(15)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.IMessageReplyHeader ReplyTo {get; set;}

       [SerializationOrder(16)]
       public int Date {get; set;}

       /// <summary>Binary representation for the 'Message' property</summary>
       [SerializationOrder(17)]
       public byte[] MessageAsBinary { get => _MessageAsBinary; set { _Message = Encoding.UTF8.GetString(value); _MessageAsBinary = value; }}
       private byte[] _MessageAsBinary;
       private string _Message;
       public string Message { get => _Message; set { MessageAsBinary = Encoding.UTF8.GetBytes(value); _Message = value; }}

       [SerializationOrder(18)]
       [CanSerialize("Flags", 9)]
       public OpenTl.Schema.IMessageMedia Media {get; set;}

       [SerializationOrder(19)]
       [CanSerialize("Flags", 6)]
       public OpenTl.Schema.IReplyMarkup ReplyMarkup {get; set;}

       [SerializationOrder(20)]
       [CanSerialize("Flags", 7)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

       [SerializationOrder(21)]
       [CanSerialize("Flags", 10)]
       public int Views {get; set;}

       [SerializationOrder(22)]
       [CanSerialize("Flags", 10)]
       public int Forwards {get; set;}

       [SerializationOrder(23)]
       [CanSerialize("Flags", 23)]
       public OpenTl.Schema.IMessageReplies Replies {get; set;}

       [SerializationOrder(24)]
       [CanSerialize("Flags", 15)]
       public int EditDate {get; set;}

       /// <summary>Binary representation for the 'PostAuthor' property</summary>
       [SerializationOrder(25)]
       [CanSerialize("Flags", 16)]
       public byte[] PostAuthorAsBinary { get => _PostAuthorAsBinary; set { _PostAuthor = Encoding.UTF8.GetString(value); _PostAuthorAsBinary = value; }}
       private byte[] _PostAuthorAsBinary;
       private string _PostAuthor;
       public string PostAuthor { get => _PostAuthor; set { PostAuthorAsBinary = Encoding.UTF8.GetBytes(value); _PostAuthor = value; }}

       [SerializationOrder(26)]
       [CanSerialize("Flags", 17)]
       public long GroupedId {get; set;}

       [SerializationOrder(27)]
       [CanSerialize("Flags", 22)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IRestrictionReason> RestrictionReason {get; set;}

	}
}
