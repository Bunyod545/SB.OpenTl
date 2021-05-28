// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa4bcc6fe)]
	public sealed class TChannelDifferenceTooLong : IChannelDifference
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Final {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public int Timeout {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IDialog Dialog {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessage> Messages {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
