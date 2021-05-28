// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x629f1980)]
	public sealed class TLoginToken : ILoginToken
	{
       [SerializationOrder(0)]
       public int Expires {get; set;}

       [SerializationOrder(1)]
       public byte[] Token {get; set;}

	}
}
