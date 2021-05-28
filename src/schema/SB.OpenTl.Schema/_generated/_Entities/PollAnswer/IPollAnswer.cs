// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPollAnswer : IObject
    {
       byte[] TextAsBinary {get; set;}
       string Text {get; set;}

       byte[] Option {get; set;}

    }
}
