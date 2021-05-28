// ReSharper disable All

namespace OpenTl.Schema.Stats
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBroadcastStats : IObject
    {
       OpenTl.Schema.IStatsDateRangeDays Period {get; set;}

       OpenTl.Schema.IStatsAbsValueAndPrev Followers {get; set;}

       OpenTl.Schema.IStatsAbsValueAndPrev ViewsPerPost {get; set;}

       OpenTl.Schema.IStatsAbsValueAndPrev SharesPerPost {get; set;}

       OpenTl.Schema.IStatsPercentValue EnabledNotifications {get; set;}

       OpenTl.Schema.IStatsGraph GrowthGraph {get; set;}

       OpenTl.Schema.IStatsGraph FollowersGraph {get; set;}

       OpenTl.Schema.IStatsGraph MuteGraph {get; set;}

       OpenTl.Schema.IStatsGraph TopHoursGraph {get; set;}

       OpenTl.Schema.IStatsGraph InteractionsGraph {get; set;}

       OpenTl.Schema.IStatsGraph IvInteractionsGraph {get; set;}

       OpenTl.Schema.IStatsGraph ViewsBySourceGraph {get; set;}

       OpenTl.Schema.IStatsGraph NewFollowersBySourceGraph {get; set;}

       OpenTl.Schema.IStatsGraph LanguagesGraph {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IMessageInteractionCounters> RecentMessageInteractions {get; set;}

    }
}
