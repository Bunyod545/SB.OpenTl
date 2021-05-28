// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStatsDateRangeDays : IObject
    {
       int MinDate {get; set;}

       int MaxDate {get; set;}

    }
}
