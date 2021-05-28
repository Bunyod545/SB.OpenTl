// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfbd2c296)]
	public sealed class TInputFolderPeer : IInputFolderPeer
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int FolderId {get; set;}

	}
}
