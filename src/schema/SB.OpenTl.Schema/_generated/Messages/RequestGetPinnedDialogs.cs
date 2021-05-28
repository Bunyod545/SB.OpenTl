// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd6b94df2)]
    public sealed class RequestGetPinnedDialogs : IRequest<OpenTl.Schema.Messages.IPeerDialogs>
    {
       [SerializationOrder(0)]
       public int FolderId {get; set;}

    }
}
