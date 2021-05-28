// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputFolderPeer : IObject
    {
       OpenTl.Schema.IInputPeer Peer {get; set;}

       int FolderId {get; set;}

    }
}
