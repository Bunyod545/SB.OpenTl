// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ITheme : IObject
    {
       BitArray Flags {get; set;}

       bool Creator {get; set;}

       bool Default {get; set;}

       long Id {get; set;}

       long AccessHash {get; set;}

       byte[] SlugAsBinary {get; set;}
       string Slug {get; set;}

       byte[] TitleAsBinary {get; set;}
       string Title {get; set;}

       OpenTl.Schema.IDocument Document {get; set;}

       OpenTl.Schema.IThemeSettings Settings {get; set;}

       int InstallsCount {get; set;}

    }
}
