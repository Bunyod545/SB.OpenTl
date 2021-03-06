// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeba80ff0)]
    public sealed class RequestGetAllChats : IRequest<OpenTl.Schema.Messages.IChats>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<int> ExceptIds {get; set;}

    }
}
