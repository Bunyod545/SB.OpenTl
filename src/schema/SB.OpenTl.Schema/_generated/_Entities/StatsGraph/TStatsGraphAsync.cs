// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4a27eb2d)]
	public sealed class TStatsGraphAsync : IStatsGraph
	{
       /// <summary>Binary representation for the 'Token' property</summary>
       [SerializationOrder(0)]
       public byte[] TokenAsBinary { get => _TokenAsBinary; set { _Token = Encoding.UTF8.GetString(value); _TokenAsBinary = value; }}
       private byte[] _TokenAsBinary;
       private string _Token;
       public string Token { get => _Token; set { TokenAsBinary = Encoding.UTF8.GetBytes(value); _Token = value; }}

	}
}
