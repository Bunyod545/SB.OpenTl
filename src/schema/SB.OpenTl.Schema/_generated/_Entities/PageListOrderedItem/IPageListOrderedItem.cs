// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPageListOrderedItem : IObject
    {
       byte[] NumAsBinary {get; set;}
       string Num {get; set;}

    }
}
