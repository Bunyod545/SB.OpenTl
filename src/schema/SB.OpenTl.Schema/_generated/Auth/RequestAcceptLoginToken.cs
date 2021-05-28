// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe894ad4d)]
    public sealed class RequestAcceptLoginToken : IRequest<OpenTl.Schema.IAuthorization>
    {
       [SerializationOrder(0)]
       public byte[] Token {get; set;}

    }
}
