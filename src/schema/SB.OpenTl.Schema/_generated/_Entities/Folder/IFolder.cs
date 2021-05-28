// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IFolder : IObject
    {
       BitArray Flags {get; set;}

       bool AutofillNewBroadcasts {get; set;}

       bool AutofillPublicGroups {get; set;}

       bool AutofillNewCorrespondents {get; set;}

       int Id {get; set;}

       byte[] TitleAsBinary {get; set;}
       string Title {get; set;}

       OpenTl.Schema.IChatPhoto Photo {get; set;}

    }
}
