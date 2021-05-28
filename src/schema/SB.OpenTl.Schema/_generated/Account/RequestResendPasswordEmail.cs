// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7a7f2a15)]
    public sealed class RequestResendPasswordEmail : IRequest<bool>
    {

    }
}
