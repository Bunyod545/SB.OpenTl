// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x77fa99f)]
    public sealed class RequestDismissSuggestion : IRequest<bool>
    {
       /// <summary>Binary representation for the 'Suggestion' property</summary>
       [SerializationOrder(0)]
       public byte[] SuggestionAsBinary { get => _SuggestionAsBinary; set { _Suggestion = Encoding.UTF8.GetString(value); _SuggestionAsBinary = value; }}
       private byte[] _SuggestionAsBinary;
       private string _Suggestion;
       public string Suggestion { get => _Suggestion; set { SuggestionAsBinary = Encoding.UTF8.GetBytes(value); _Suggestion = value; }}

    }
}
