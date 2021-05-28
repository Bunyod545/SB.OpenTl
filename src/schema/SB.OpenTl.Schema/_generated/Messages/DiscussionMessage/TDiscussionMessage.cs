// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf5dd8f9d)]
	public sealed class TDiscussionMessage : IDiscussionMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessage> Messages {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public int MaxId {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public int ReadInboxMaxId {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public int ReadOutboxMaxId {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
