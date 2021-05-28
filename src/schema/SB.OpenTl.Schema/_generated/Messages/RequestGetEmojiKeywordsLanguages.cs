// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4e9963b2)]
    public sealed class RequestGetEmojiKeywordsLanguages : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IEmojiLanguage>>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<string> LangCodes {get; set;}

    }
}
