// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhoneCallCommon : IObject
    {
       BitArray Flags {get; set;}

       bool Video {get; set;}

       long Id {get; set;}

    }
}
