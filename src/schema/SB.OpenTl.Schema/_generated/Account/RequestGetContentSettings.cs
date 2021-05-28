// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8b9b4dae)]
    public sealed class RequestGetContentSettings : IRequest<OpenTl.Schema.Account.IContentSettings>
    {

    }
}
