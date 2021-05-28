// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe9baa668)]
	public sealed class TFolderPeer : IFolderPeer
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int FolderId {get; set;}

	}
}
