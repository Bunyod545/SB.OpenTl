// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IDialogFilter : IObject
    {
       BitArray Flags {get; set;}

       bool Contacts {get; set;}

       bool NonContacts {get; set;}

       bool Groups {get; set;}

       bool Broadcasts {get; set;}

       bool Bots {get; set;}

       bool ExcludeMuted {get; set;}

       bool ExcludeRead {get; set;}

       bool ExcludeArchived {get; set;}

       int Id {get; set;}

       byte[] TitleAsBinary {get; set;}
       string Title {get; set;}

       byte[] EmoticonAsBinary {get; set;}
       string Emoticon {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IInputPeer> PinnedPeers {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IInputPeer> IncludePeers {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IInputPeer> ExcludePeers {get; set;}

    }
}
