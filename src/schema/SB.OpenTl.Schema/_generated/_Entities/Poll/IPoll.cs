﻿// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPoll : IObject
    {
       long Id {get; set;}

       BitArray Flags {get; set;}

       bool Closed {get; set;}

       bool PublicVoters {get; set;}

       bool MultipleChoice {get; set;}

       bool Quiz {get; set;}

       byte[] QuestionAsBinary {get; set;}
       string Question {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IPollAnswer> Answers {get; set;}

       int ClosePeriod {get; set;}

       int CloseDate {get; set;}

    }
}
