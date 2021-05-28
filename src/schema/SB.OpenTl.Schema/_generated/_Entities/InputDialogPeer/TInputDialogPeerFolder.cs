// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x64600527)]
	public sealed class TInputDialogPeerFolder : IInputDialogPeer
	{
       [SerializationOrder(0)]
       public int FolderId {get; set;}

	}
}
