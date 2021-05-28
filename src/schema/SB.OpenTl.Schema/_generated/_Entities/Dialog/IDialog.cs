// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IDialog : IObject
    {
       BitArray Flags {get; set;}

       bool Pinned {get; set;}

       OpenTl.Schema.IPeer Peer {get; set;}

       int TopMessage {get; set;}

    }
}
