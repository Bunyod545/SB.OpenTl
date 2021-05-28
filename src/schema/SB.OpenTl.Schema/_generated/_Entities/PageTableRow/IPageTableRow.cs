// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPageTableRow : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IPageTableCell> Cells {get; set;}

    }
}
