// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x38a08d3)]
    public sealed class RequestGetUserInfo : IRequest<OpenTl.Schema.Help.IUserInfo>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

    }
}
