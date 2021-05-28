// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IEmojiLanguage : IObject
    {
       byte[] LangCodeAsBinary {get; set;}
       string LangCode {get; set;}

    }
}
