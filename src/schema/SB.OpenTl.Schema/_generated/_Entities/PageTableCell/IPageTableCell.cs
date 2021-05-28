// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPageTableCell : IObject
    {
       BitArray Flags {get; set;}

       bool Header {get; set;}

       bool AlignCenter {get; set;}

       bool AlignRight {get; set;}

       bool ValignMiddle {get; set;}

       bool ValignBottom {get; set;}

       OpenTl.Schema.IRichText Text {get; set;}

       int Colspan {get; set;}

       int Rowspan {get; set;}

    }
}
