// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x62718a82)]
	public sealed class TEncryptedChatRequested : IEncryptedChat
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public int FolderId {get; set;}

       [SerializationOrder(2)]
       public int Id {get; set;}

       [SerializationOrder(3)]
       public long AccessHash {get; set;}

       [SerializationOrder(4)]
       public int Date {get; set;}

       [SerializationOrder(5)]
       public int AdminId {get; set;}

       [SerializationOrder(6)]
       public int ParticipantId {get; set;}

       [SerializationOrder(7)]
       public byte[] GA {get; set;}

	}
}
