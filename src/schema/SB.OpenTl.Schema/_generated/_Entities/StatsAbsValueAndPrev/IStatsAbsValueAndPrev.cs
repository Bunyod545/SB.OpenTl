// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStatsAbsValueAndPrev : IObject
    {
       double Current {get; set;}

       double Previous {get; set;}

    }
}
