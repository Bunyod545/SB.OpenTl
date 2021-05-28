// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ILangPackLanguage : IObject
    {
       BitArray Flags {get; set;}

       bool Official {get; set;}

       bool Rtl {get; set;}

       bool Beta {get; set;}

       byte[] NameAsBinary {get; set;}
       string Name {get; set;}

       byte[] NativeNameAsBinary {get; set;}
       string NativeName {get; set;}

       byte[] LangCodeAsBinary {get; set;}
       string LangCode {get; set;}

       byte[] BaseLangCodeAsBinary {get; set;}
       string BaseLangCode {get; set;}

       byte[] PluralCodeAsBinary {get; set;}
       string PluralCode {get; set;}

       int StringsCount {get; set;}

       int TranslatedCount {get; set;}

       byte[] TranslationsUrlAsBinary {get; set;}
       string TranslationsUrl {get; set;}

    }
}
