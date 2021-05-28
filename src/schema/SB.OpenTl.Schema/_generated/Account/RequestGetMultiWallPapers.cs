// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x65ad71dc)]
    public sealed class RequestGetMultiWallPapers : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IWallPaper>>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputWallPaper> Wallpapers {get; set;}

    }
}
