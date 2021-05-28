// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1edaaac2)]
    public sealed class RequestSetGlobalPrivacySettings : IRequest<OpenTl.Schema.IGlobalPrivacySettings>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IGlobalPrivacySettings Settings {get; set;}

    }
}
