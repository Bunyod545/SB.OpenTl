﻿// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xedd49ef0)]
    public sealed class RequestToggleSlowMode : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public int Seconds {get; set;}

    }
}
