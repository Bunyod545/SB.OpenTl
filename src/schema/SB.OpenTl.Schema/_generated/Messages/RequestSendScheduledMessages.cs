﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbd38850a)]
    public sealed class RequestSendScheduledMessages : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<int> Id {get; set;}

    }
}
