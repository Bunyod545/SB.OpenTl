// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x48f71778)]
    public sealed class RequestEditMessage : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool NoWebpage {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(3)]
       public int Id {get; set;}

       /// <summary>Binary representation for the 'Message' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 11)]
       public byte[] MessageAsBinary { get => _MessageAsBinary; set { _Message = Encoding.UTF8.GetString(value); _MessageAsBinary = value; }}
       private byte[] _MessageAsBinary;
       private string _Message;
       public string Message { get => _Message; set { MessageAsBinary = Encoding.UTF8.GetBytes(value); _Message = value; }}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 14)]
       public OpenTl.Schema.IInputMedia Media {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IReplyMarkup ReplyMarkup {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 15)]
       public int ScheduleDate {get; set;}

    }
}
