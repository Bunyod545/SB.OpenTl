// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ICodeSettings : IObject
    {
       BitArray Flags {get; set;}

       bool AllowFlashcall {get; set;}

       bool CurrentNumber {get; set;}

       bool AllowAppHash {get; set;}

    }
}
