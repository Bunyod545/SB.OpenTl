// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x95ac5ce4)]
    public sealed class RequestImportLoginToken : IRequest<OpenTl.Schema.Auth.ILoginToken>
    {
       [SerializationOrder(0)]
       public byte[] Token {get; set;}

    }
}
