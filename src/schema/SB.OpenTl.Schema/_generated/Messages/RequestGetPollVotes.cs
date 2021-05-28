﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb86e380e)]
    public sealed class RequestGetPollVotes : IRequest<OpenTl.Schema.Messages.IVotesList>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(2)]
       public int Id {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public byte[] Option {get; set;}

       /// <summary>Binary representation for the 'Offset' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public byte[] OffsetAsBinary { get => _OffsetAsBinary; set { _Offset = Encoding.UTF8.GetString(value); _OffsetAsBinary = value; }}
       private byte[] _OffsetAsBinary;
       private string _Offset;
       public string Offset { get => _Offset; set { OffsetAsBinary = Encoding.UTF8.GetBytes(value); _Offset = value; }}

       [SerializationOrder(5)]
       public int Limit {get; set;}

    }
}
