// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf5dad378)]
    public sealed class RequestGetGroupsForDiscussion : IRequest<OpenTl.Schema.Messages.IChats>
    {

    }
}
