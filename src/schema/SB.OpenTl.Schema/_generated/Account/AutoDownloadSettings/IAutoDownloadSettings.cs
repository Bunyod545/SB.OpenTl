// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IAutoDownloadSettings : IObject
    {
       OpenTl.Schema.IAutoDownloadSettings Low {get; set;}

       OpenTl.Schema.IAutoDownloadSettings Medium {get; set;}

       OpenTl.Schema.IAutoDownloadSettings High {get; set;}

    }
}
