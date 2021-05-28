// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9c95f7bb)]
	public sealed class TInputPeerChannelFromMessage : IInputPeer
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int MsgId {get; set;}

       [SerializationOrder(2)]
       public int ChannelId {get; set;}

	}
}
