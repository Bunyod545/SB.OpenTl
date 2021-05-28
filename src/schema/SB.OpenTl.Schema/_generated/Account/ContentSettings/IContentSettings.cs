// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IContentSettings : IObject
    {
       BitArray Flags {get; set;}

       bool SensitiveEnabled {get; set;}

       bool SensitiveCanChange {get; set;}

    }
}
