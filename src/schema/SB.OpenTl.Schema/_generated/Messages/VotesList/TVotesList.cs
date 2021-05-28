// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x823f649)]
	public sealed class TVotesList : IVotesList
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int Count {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageUserVote> Votes {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

       /// <summary>Binary representation for the 'NextOffset' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public byte[] NextOffsetAsBinary { get => _NextOffsetAsBinary; set { _NextOffset = Encoding.UTF8.GetString(value); _NextOffsetAsBinary = value; }}
       private byte[] _NextOffsetAsBinary;
       private string _NextOffset;
       public string NextOffset { get => _NextOffset; set { NextOffsetAsBinary = Encoding.UTF8.GetBytes(value); _NextOffset = value; }}

	}
}
