// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPageCaption : IObject
    {
       OpenTl.Schema.IRichText Text {get; set;}

       OpenTl.Schema.IRichText Credit {get; set;}

    }
}
