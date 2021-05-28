// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStatsGroupTopInviter : IObject
    {
       int UserId {get; set;}

       int Invitations {get; set;}

    }
}
