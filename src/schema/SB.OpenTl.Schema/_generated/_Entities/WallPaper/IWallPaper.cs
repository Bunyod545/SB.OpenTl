// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IWallPaper : IObject
    {
       BitArray Flags {get; set;}

       bool Default {get; set;}

       bool Dark {get; set;}

       OpenTl.Schema.IWallPaperSettings Settings {get; set;}

    }
}
