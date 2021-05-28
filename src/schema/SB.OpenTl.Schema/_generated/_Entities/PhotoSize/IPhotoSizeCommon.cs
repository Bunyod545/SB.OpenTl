// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhotoSizeCommon : IObject
    {
       byte[] TypeAsBinary {get; set;}
       string Type {get; set;}

    }
}
