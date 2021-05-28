// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPeerSettings : IObject
    {
       BitArray Flags {get; set;}

       bool ReportSpam {get; set;}

       bool AddContact {get; set;}

       bool BlockContact {get; set;}

       bool ShareContact {get; set;}

       bool NeedContactsException {get; set;}

       bool ReportGeo {get; set;}

       bool Autoarchived {get; set;}

       bool InviteMembers {get; set;}

       int GeoDistance {get; set;}

    }
}
