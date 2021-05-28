// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPage : IObject
    {
       BitArray Flags {get; set;}

       bool Part {get; set;}

       bool Rtl {get; set;}

       bool V2 {get; set;}

       byte[] UrlAsBinary {get; set;}
       string Url {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IPageBlock> Blocks {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IPhoto> Photos {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IDocument> Documents {get; set;}

       int Views {get; set;}

    }
}
