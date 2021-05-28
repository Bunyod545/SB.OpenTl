// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9f07c728)]
    public sealed class RequestGetContactSignUpNotification : IRequest<bool>
    {

    }
}
