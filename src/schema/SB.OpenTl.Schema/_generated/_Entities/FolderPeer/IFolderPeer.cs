// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IFolderPeer : IObject
    {
       OpenTl.Schema.IPeer Peer {get; set;}

       int FolderId {get; set;}

    }
}
