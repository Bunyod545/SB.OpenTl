// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x87d0759e)]
	public sealed class TCountriesList : ICountriesList
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.Help.ICountry> Countries {get; set;}

       [SerializationOrder(1)]
       public int Hash {get; set;}

	}
}
