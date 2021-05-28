// ReSharper disable All

namespace OpenTl.Schema.Help
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISupportName : IObject
    {
       byte[] NameAsBinary {get; set;}
       string Name {get; set;}

    }
}
