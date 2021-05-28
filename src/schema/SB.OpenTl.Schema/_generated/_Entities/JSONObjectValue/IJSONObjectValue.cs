// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IJSONObjectValue : IObject
    {
       byte[] KeyAsBinary {get; set;}
       string Key {get; set;}

       OpenTl.Schema.IJSONValue Value {get; set;}

    }
}
