// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4facb138)]
    public sealed class RequestHidePeerSettingsBar : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

    }
}
