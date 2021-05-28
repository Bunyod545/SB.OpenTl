// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x16115a96)]
	public sealed class TPageBlockRelatedArticles : IPageBlock
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Title {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPageRelatedArticle> Articles {get; set;}

	}
}
