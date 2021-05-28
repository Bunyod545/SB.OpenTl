// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPeerBlocked : IObject
    {
       OpenTl.Schema.IPeer PeerId {get; set;}

       int Date {get; set;}

    }
}
