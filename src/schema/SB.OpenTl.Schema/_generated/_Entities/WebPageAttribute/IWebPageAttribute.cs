// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IWebPageAttribute : IObject
    {
       BitArray Flags {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IDocument> Documents {get; set;}

       OpenTl.Schema.IThemeSettings Settings {get; set;}

    }
}
