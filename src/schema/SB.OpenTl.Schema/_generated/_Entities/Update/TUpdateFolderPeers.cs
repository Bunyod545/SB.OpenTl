// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x19360dc0)]
	public sealed class TUpdateFolderPeers : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IFolderPeer> FolderPeers {get; set;}

       [SerializationOrder(1)]
       public int Pts {get; set;}

       [SerializationOrder(2)]
       public int PtsCount {get; set;}

	}
}
