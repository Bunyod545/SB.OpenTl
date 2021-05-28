// ReSharper disable All

namespace OpenTl.Schema.Folders
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6847d0ab)]
    public sealed class RequestEditPeerFolders : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputFolderPeer> FolderPeers {get; set;}

    }
}
