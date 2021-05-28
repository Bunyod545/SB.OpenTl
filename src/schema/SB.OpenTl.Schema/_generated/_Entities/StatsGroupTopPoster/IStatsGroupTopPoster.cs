// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStatsGroupTopPoster : IObject
    {
       int UserId {get; set;}

       int Messages {get; set;}

       int AvgChars {get; set;}

    }
}
