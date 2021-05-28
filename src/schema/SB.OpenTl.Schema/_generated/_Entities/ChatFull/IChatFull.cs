// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChatFull : IObject
    {
       BitArray Flags {get; set;}

       int Id {get; set;}

       byte[] AboutAsBinary {get; set;}
       string About {get; set;}

       OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

       OpenTl.Schema.IExportedChatInvite ExportedInvite {get; set;}

       int FolderId {get; set;}

    }
}
