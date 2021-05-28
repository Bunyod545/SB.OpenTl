// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IRestrictionReason : IObject
    {
       byte[] PlatformAsBinary {get; set;}
       string Platform {get; set;}

       byte[] ReasonAsBinary {get; set;}
       string Reason {get; set;}

       byte[] TextAsBinary {get; set;}
       string Text {get; set;}

    }
}
