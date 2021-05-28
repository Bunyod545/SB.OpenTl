// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeb2b4cf6)]
    public sealed class RequestGetGlobalPrivacySettings : IRequest<OpenTl.Schema.IGlobalPrivacySettings>
    {

    }
}
