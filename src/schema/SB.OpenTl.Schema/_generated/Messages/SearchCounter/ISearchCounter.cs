// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISearchCounter : IObject
    {
       BitArray Flags {get; set;}

       bool Inexact {get; set;}

       OpenTl.Schema.IMessagesFilter Filter {get; set;}

       int Count {get; set;}

    }
}
