// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x68e9916)]
	public sealed class TLoginTokenMigrateTo : ILoginToken
	{
       [SerializationOrder(0)]
       public int DcId {get; set;}

       [SerializationOrder(1)]
       public byte[] Token {get; set;}

	}
}
