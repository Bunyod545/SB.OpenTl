// ReSharper disable All

namespace OpenTl.Schema.Stats
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageStats : IObject
    {
       OpenTl.Schema.IStatsGraph ViewsGraph {get; set;}

    }
}
