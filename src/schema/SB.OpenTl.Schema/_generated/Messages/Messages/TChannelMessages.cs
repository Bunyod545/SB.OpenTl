// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x64479808)]
	public sealed class TChannelMessages : IMessages
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Inexact {get; set;}

       [SerializationOrder(2)]
       public int Pts {get; set;}

       [SerializationOrder(3)]
       public int Count {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public int OffsetIdOffset {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessage> Messages {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       [SerializationOrder(7)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
