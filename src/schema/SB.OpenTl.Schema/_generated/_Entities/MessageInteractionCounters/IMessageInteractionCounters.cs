// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageInteractionCounters : IObject
    {
       int MsgId {get; set;}

       int Views {get; set;}

       int Forwards {get; set;}

    }
}
