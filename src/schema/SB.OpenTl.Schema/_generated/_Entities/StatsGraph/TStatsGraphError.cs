// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbedc9822)]
	public sealed class TStatsGraphError : IStatsGraph
	{
       /// <summary>Binary representation for the 'Error' property</summary>
       [SerializationOrder(0)]
       public byte[] ErrorAsBinary { get => _ErrorAsBinary; set { _Error = Encoding.UTF8.GetString(value); _ErrorAsBinary = value; }}
       private byte[] _ErrorAsBinary;
       private string _Error;
       public string Error { get => _Error; set { ErrorAsBinary = Encoding.UTF8.GetBytes(value); _Error = value; }}

	}
}
