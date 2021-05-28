// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbf4dea82)]
	public sealed class TPageBlockTable : IPageBlock
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Bordered {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Striped {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IRichText Title {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPageTableRow> Rows {get; set;}

	}
}
