// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe04b5ceb)]
	public sealed class TChannelParticipantsMentions : IChannelParticipantsFilter
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'Q' property</summary>
       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public byte[] QAsBinary { get => _QAsBinary; set { _Q = Encoding.UTF8.GetString(value); _QAsBinary = value; }}
       private byte[] _QAsBinary;
       private string _Q;
       public string Q { get => _Q; set { QAsBinary = Encoding.UTF8.GetBytes(value); _Q = value; }}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public int TopMsgId {get; set;}

	}
}
