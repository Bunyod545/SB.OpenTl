// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x236df622)]
	public sealed class TEmojiKeywordDeleted : IEmojiKeyword
	{
       /// <summary>Binary representation for the 'Keyword' property</summary>
       [SerializationOrder(0)]
       public byte[] KeywordAsBinary { get => _KeywordAsBinary; set { _Keyword = Encoding.UTF8.GetString(value); _KeywordAsBinary = value; }}
       private byte[] _KeywordAsBinary;
       private string _Keyword;
       public string Keyword { get => _Keyword; set { KeywordAsBinary = Encoding.UTF8.GetBytes(value); _Keyword = value; }}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<string> Emoticons {get; set;}

	}
}
