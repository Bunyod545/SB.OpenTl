// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcff43f61)]
    public sealed class RequestSetContactSignUpNotification : IRequest<bool>
    {
       [SerializationOrder(0)]
       public bool Silent {get; set;}

    }
}
