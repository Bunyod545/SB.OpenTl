// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x11e831ee)]
    public sealed class RequestGetInactiveChannels : IRequest<OpenTl.Schema.Messages.IInactiveChats>
    {

    }
}
