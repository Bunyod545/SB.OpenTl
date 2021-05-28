// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x98914110)]
    public sealed class RequestGetAppConfig : IRequest<OpenTl.Schema.IJSONValue>
    {

    }
}
