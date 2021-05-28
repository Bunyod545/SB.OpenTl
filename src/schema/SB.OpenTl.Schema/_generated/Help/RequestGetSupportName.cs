// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd360e72c)]
    public sealed class RequestGetSupportName : IRequest<OpenTl.Schema.Help.ISupportName>
    {

    }
}
