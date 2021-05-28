// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStatsURL : IObject
    {
       byte[] UrlAsBinary {get; set;}
       string Url {get; set;}

    }
}
