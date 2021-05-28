// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStatsPercentValue : IObject
    {
       double Part {get; set;}

       double Total {get; set;}

    }
}
