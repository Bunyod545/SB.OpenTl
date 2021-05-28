// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IGlobalPrivacySettings : IObject
    {
       BitArray Flags {get; set;}

       bool ArchiveAndMuteNewNoncontactPeers {get; set;}

    }
}
