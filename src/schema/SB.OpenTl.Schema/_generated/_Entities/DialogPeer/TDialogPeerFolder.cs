// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x514519e2)]
	public sealed class TDialogPeerFolder : IDialogPeer
	{
       [SerializationOrder(0)]
       public int FolderId {get; set;}

	}
}
