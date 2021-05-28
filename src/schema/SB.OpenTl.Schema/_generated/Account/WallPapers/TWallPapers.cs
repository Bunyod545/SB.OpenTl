// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x702b65a9)]
	public sealed class TWallPapers : IWallPapers
	{
       [SerializationOrder(0)]
       public int Hash {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IWallPaper> Wallpapers {get; set;}

	}
}
