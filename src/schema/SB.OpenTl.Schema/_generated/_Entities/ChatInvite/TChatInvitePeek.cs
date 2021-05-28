// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x61695cb0)]
	public sealed class TChatInvitePeek : IChatInvite
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IChat Chat {get; set;}

       [SerializationOrder(1)]
       public int Expires {get; set;}

	}
}
