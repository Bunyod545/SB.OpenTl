// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPollResults : IObject
    {
       BitArray Flags {get; set;}

       bool Min {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IPollAnswerVoters> Results {get; set;}

       int TotalVoters {get; set;}

       OpenTl.Schema.TVector<int> RecentVoters {get; set;}

       byte[] SolutionAsBinary {get; set;}
       string Solution {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> SolutionEntities {get; set;}

    }
}
