// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeeca5ce3)]
	public sealed class TLangPackLanguage : ILangPackLanguage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Official {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 2)]
       public bool Rtl {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 3)]
       public bool Beta {get; set;}

       /// <summary>Binary representation for the 'Name' property</summary>
       [SerializationOrder(4)]
       public byte[] NameAsBinary { get => _NameAsBinary; set { _Name = Encoding.UTF8.GetString(value); _NameAsBinary = value; }}
       private byte[] _NameAsBinary;
       private string _Name;
       public string Name { get => _Name; set { NameAsBinary = Encoding.UTF8.GetBytes(value); _Name = value; }}

       /// <summary>Binary representation for the 'NativeName' property</summary>
       [SerializationOrder(5)]
       public byte[] NativeNameAsBinary { get => _NativeNameAsBinary; set { _NativeName = Encoding.UTF8.GetString(value); _NativeNameAsBinary = value; }}
       private byte[] _NativeNameAsBinary;
       private string _NativeName;
       public string NativeName { get => _NativeName; set { NativeNameAsBinary = Encoding.UTF8.GetBytes(value); _NativeName = value; }}

       /// <summary>Binary representation for the 'LangCode' property</summary>
       [SerializationOrder(6)]
       public byte[] LangCodeAsBinary { get => _LangCodeAsBinary; set { _LangCode = Encoding.UTF8.GetString(value); _LangCodeAsBinary = value; }}
       private byte[] _LangCodeAsBinary;
       private string _LangCode;
       public string LangCode { get => _LangCode; set { LangCodeAsBinary = Encoding.UTF8.GetBytes(value); _LangCode = value; }}

       /// <summary>Binary representation for the 'BaseLangCode' property</summary>
       [SerializationOrder(7)]
       [CanSerialize("Flags", 1)]
       public byte[] BaseLangCodeAsBinary { get => _BaseLangCodeAsBinary; set { _BaseLangCode = Encoding.UTF8.GetString(value); _BaseLangCodeAsBinary = value; }}
       private byte[] _BaseLangCodeAsBinary;
       private string _BaseLangCode;
       public string BaseLangCode { get => _BaseLangCode; set { BaseLangCodeAsBinary = Encoding.UTF8.GetBytes(value); _BaseLangCode = value; }}

       /// <summary>Binary representation for the 'PluralCode' property</summary>
       [SerializationOrder(8)]
       public byte[] PluralCodeAsBinary { get => _PluralCodeAsBinary; set { _PluralCode = Encoding.UTF8.GetString(value); _PluralCodeAsBinary = value; }}
       private byte[] _PluralCodeAsBinary;
       private string _PluralCode;
       public string PluralCode { get => _PluralCode; set { PluralCodeAsBinary = Encoding.UTF8.GetBytes(value); _PluralCode = value; }}

       [SerializationOrder(9)]
       public int StringsCount {get; set;}

       [SerializationOrder(10)]
       public int TranslatedCount {get; set;}

       /// <summary>Binary representation for the 'TranslationsUrl' property</summary>
       [SerializationOrder(11)]
       public byte[] TranslationsUrlAsBinary { get => _TranslationsUrlAsBinary; set { _TranslationsUrl = Encoding.UTF8.GetString(value); _TranslationsUrlAsBinary = value; }}
       private byte[] _TranslationsUrlAsBinary;
       private string _TranslationsUrl;
       public string TranslationsUrl { get => _TranslationsUrl; set { TranslationsUrlAsBinary = Encoding.UTF8.GetBytes(value); _TranslationsUrl = value; }}

	}
}
