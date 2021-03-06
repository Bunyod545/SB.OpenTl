// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x220815b0)]
    public sealed class RequestSendInlineBotResult : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 5)]
       public bool Silent {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 6)]
       public bool Background {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 7)]
       public bool ClearDraft {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 11)]
       public bool HideVia {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 0)]
       public int ReplyToMsgId {get; set;}

       [SerializationOrder(7)]
       public long RandomId {get; set;}

       [SerializationOrder(8)]
       public long QueryId {get; set;}

       /// <summary>Binary representation for the 'Id' property</summary>
       [SerializationOrder(9)]
       public byte[] IdAsBinary { get => _IdAsBinary; set { _Id = Encoding.UTF8.GetString(value); _IdAsBinary = value; }}
       private byte[] _IdAsBinary;
       private string _Id;
       public string Id { get => _Id; set { IdAsBinary = Encoding.UTF8.GetBytes(value); _Id = value; }}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 10)]
       public int ScheduleDate {get; set;}

    }
}
