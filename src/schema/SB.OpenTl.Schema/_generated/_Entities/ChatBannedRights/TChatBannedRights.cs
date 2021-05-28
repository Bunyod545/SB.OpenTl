// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9f120418)]
	public sealed class TChatBannedRights : IChatBannedRights
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool ViewMessages {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool SendMessages {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool SendMedia {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool SendStickers {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 4)]
       public bool SendGifs {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 5)]
       public bool SendGames {get; set;}

       [SerializationOrder(7)]
       [FromFlag("Flags", 6)]
       public bool SendInline {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 7)]
       public bool EmbedLinks {get; set;}

       [SerializationOrder(9)]
       [FromFlag("Flags", 8)]
       public bool SendPolls {get; set;}

       [SerializationOrder(10)]
       [FromFlag("Flags", 10)]
       public bool ChangeInfo {get; set;}

       [SerializationOrder(11)]
       [FromFlag("Flags", 15)]
       public bool InviteUsers {get; set;}

       [SerializationOrder(12)]
       [FromFlag("Flags", 17)]
       public bool PinMessages {get; set;}

       [SerializationOrder(13)]
       public int UntilDate {get; set;}

	}
}
