// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPageRelatedArticle : IObject
    {
       BitArray Flags {get; set;}

       byte[] UrlAsBinary {get; set;}
       string Url {get; set;}

       long WebpageId {get; set;}

       byte[] TitleAsBinary {get; set;}
       string Title {get; set;}

       byte[] DescriptionAsBinary {get; set;}
       string Description {get; set;}

       long PhotoId {get; set;}

       byte[] AuthorAsBinary {get; set;}
       string Author {get; set;}

       int PublishedDate {get; set;}

    }
}
