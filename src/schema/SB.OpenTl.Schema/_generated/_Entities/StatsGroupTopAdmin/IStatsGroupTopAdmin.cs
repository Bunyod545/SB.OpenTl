// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStatsGroupTopAdmin : IObject
    {
       int UserId {get; set;}

       int Deleted {get; set;}

       int Kicked {get; set;}

       int Banned {get; set;}

    }
}
