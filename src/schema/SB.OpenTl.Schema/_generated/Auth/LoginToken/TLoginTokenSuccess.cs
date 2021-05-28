// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x390d5c5e)]
	public sealed class TLoginTokenSuccess : ILoginToken
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.Auth.IAuthorization Authorization {get; set;}

	}
}
