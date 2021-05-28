// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xaabb1763)]
    public sealed class RequestGetWallPapers : IRequest<OpenTl.Schema.Account.IWallPapers>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
