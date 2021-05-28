// ReSharper disable All

namespace OpenTl.Schema.Payments
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBankCardData : IObject
    {
       byte[] TitleAsBinary {get; set;}
       string Title {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IBankCardOpenUrl> OpenUrls {get; set;}

    }
}
