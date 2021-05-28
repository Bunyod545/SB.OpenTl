// ReSharper disable All

namespace OpenTl.Schema.Stats
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xef7ff916)]
	public sealed class TMegagroupStats : IMegagroupStats
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IStatsDateRangeDays Period {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IStatsAbsValueAndPrev Members {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IStatsAbsValueAndPrev Messages {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IStatsAbsValueAndPrev Viewers {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.IStatsAbsValueAndPrev Posters {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.IStatsGraph GrowthGraph {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.IStatsGraph MembersGraph {get; set;}

       [SerializationOrder(7)]
       public OpenTl.Schema.IStatsGraph NewMembersBySourceGraph {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.IStatsGraph LanguagesGraph {get; set;}

       [SerializationOrder(9)]
       public OpenTl.Schema.IStatsGraph MessagesGraph {get; set;}

       [SerializationOrder(10)]
       public OpenTl.Schema.IStatsGraph ActionsGraph {get; set;}

       [SerializationOrder(11)]
       public OpenTl.Schema.IStatsGraph TopHoursGraph {get; set;}

       [SerializationOrder(12)]
       public OpenTl.Schema.IStatsGraph WeekdaysGraph {get; set;}

       [SerializationOrder(13)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IStatsGroupTopPoster> TopPosters {get; set;}

       [SerializationOrder(14)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IStatsGroupTopAdmin> TopAdmins {get; set;}

       [SerializationOrder(15)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IStatsGroupTopInviter> TopInviters {get; set;}

       [SerializationOrder(16)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
