// ReSharper disable All

namespace OpenTl.Schema.Stats
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbdf78394)]
	public sealed class TBroadcastStats : IBroadcastStats
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IStatsDateRangeDays Period {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IStatsAbsValueAndPrev Followers {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IStatsAbsValueAndPrev ViewsPerPost {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IStatsAbsValueAndPrev SharesPerPost {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.IStatsPercentValue EnabledNotifications {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.IStatsGraph GrowthGraph {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.IStatsGraph FollowersGraph {get; set;}

       [SerializationOrder(7)]
       public OpenTl.Schema.IStatsGraph MuteGraph {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.IStatsGraph TopHoursGraph {get; set;}

       [SerializationOrder(9)]
       public OpenTl.Schema.IStatsGraph InteractionsGraph {get; set;}

       [SerializationOrder(10)]
       public OpenTl.Schema.IStatsGraph IvInteractionsGraph {get; set;}

       [SerializationOrder(11)]
       public OpenTl.Schema.IStatsGraph ViewsBySourceGraph {get; set;}

       [SerializationOrder(12)]
       public OpenTl.Schema.IStatsGraph NewFollowersBySourceGraph {get; set;}

       [SerializationOrder(13)]
       public OpenTl.Schema.IStatsGraph LanguagesGraph {get; set;}

       [SerializationOrder(14)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageInteractionCounters> RecentMessageInteractions {get; set;}

	}
}
