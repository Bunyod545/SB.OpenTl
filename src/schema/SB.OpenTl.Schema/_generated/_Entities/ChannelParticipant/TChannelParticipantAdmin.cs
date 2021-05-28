// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xccbebbaf)]
	public sealed class TChannelParticipantAdmin : IChannelParticipant
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool CanEdit {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Self {get; set;}

       [SerializationOrder(3)]
       public int UserId {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public int InviterId {get; set;}

       [SerializationOrder(5)]
       public int PromotedBy {get; set;}

       [SerializationOrder(6)]
       public int Date {get; set;}

       [SerializationOrder(7)]
       public OpenTl.Schema.IChatAdminRights AdminRights {get; set;}

       /// <summary>Binary representation for the 'Rank' property</summary>
       [SerializationOrder(8)]
       [CanSerialize("Flags", 2)]
       public byte[] RankAsBinary { get => _RankAsBinary; set { _Rank = Encoding.UTF8.GetString(value); _RankAsBinary = value; }}
       private byte[] _RankAsBinary;
       private string _Rank;
       public string Rank { get => _Rank; set { RankAsBinary = Encoding.UTF8.GetBytes(value); _Rank = value; }}

	}
}
