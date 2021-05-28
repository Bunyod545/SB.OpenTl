// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IEmojiURL : IObject
    {
       byte[] UrlAsBinary {get; set;}
       string Url {get; set;}

    }
}
