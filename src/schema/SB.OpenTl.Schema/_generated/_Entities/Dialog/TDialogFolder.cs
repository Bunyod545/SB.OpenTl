// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x71bd134c)]
	public sealed class TDialogFolder : IDialog
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 2)]
       public bool Pinned {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IFolder Folder {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(4)]
       public int TopMessage {get; set;}

       [SerializationOrder(5)]
       public int UnreadMutedPeersCount {get; set;}

       [SerializationOrder(6)]
       public int UnreadUnmutedPeersCount {get; set;}

       [SerializationOrder(7)]
       public int UnreadMutedMessagesCount {get; set;}

       [SerializationOrder(8)]
       public int UnreadUnmutedMessagesCount {get; set;}

	}
}
