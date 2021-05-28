// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IEmojiKeyword : IObject
    {
       byte[] KeywordAsBinary {get; set;}
       string Keyword {get; set;}

       OpenTl.Schema.TVector<string> Emoticons {get; set;}

    }
}
