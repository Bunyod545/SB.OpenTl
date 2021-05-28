// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageUserVote : IObject
    {
       int UserId {get; set;}

       int Date {get; set;}

    }
}
