// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBankCardOpenUrl : IObject
    {
       byte[] UrlAsBinary {get; set;}
       string Url {get; set;}

       byte[] NameAsBinary {get; set;}
       string Name {get; set;}

    }
}
