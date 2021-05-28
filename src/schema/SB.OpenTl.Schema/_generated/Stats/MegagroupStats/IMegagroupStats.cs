// ReSharper disable All

namespace OpenTl.Schema.Stats
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMegagroupStats : IObject
    {
       OpenTl.Schema.IStatsDateRangeDays Period {get; set;}

       OpenTl.Schema.IStatsAbsValueAndPrev Members {get; set;}

       OpenTl.Schema.IStatsAbsValueAndPrev Messages {get; set;}

       OpenTl.Schema.IStatsAbsValueAndPrev Viewers {get; set;}

       OpenTl.Schema.IStatsAbsValueAndPrev Posters {get; set;}

       OpenTl.Schema.IStatsGraph GrowthGraph {get; set;}

       OpenTl.Schema.IStatsGraph MembersGraph {get; set;}

       OpenTl.Schema.IStatsGraph NewMembersBySourceGraph {get; set;}

       OpenTl.Schema.IStatsGraph LanguagesGraph {get; set;}

       OpenTl.Schema.IStatsGraph MessagesGraph {get; set;}

       OpenTl.Schema.IStatsGraph ActionsGraph {get; set;}

       OpenTl.Schema.IStatsGraph TopHoursGraph {get; set;}

       OpenTl.Schema.IStatsGraph WeekdaysGraph {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IStatsGroupTopPoster> TopPosters {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IStatsGroupTopAdmin> TopAdmins {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IStatsGroupTopInviter> TopInviters {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
