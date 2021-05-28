// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IVideoSize : IObject
    {
       BitArray Flags {get; set;}

       byte[] TypeAsBinary {get; set;}
       string Type {get; set;}

       OpenTl.Schema.IFileLocation Location {get; set;}

       int W {get; set;}

       int H {get; set;}

       int Size {get; set;}

       double VideoStartTs {get; set;}

    }
}
