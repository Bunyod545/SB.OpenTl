// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe04232f3)]
	public sealed class TAutoDownloadSettings : IAutoDownloadSettings
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Disabled {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool VideoPreloadLarge {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool AudioPreloadNext {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool PhonecallsLessData {get; set;}

       [SerializationOrder(5)]
       public int PhotoSizeMax {get; set;}

       [SerializationOrder(6)]
       public int VideoSizeMax {get; set;}

       [SerializationOrder(7)]
       public int FileSizeMax {get; set;}

       [SerializationOrder(8)]
       public int VideoUploadMaxbitrate {get; set;}

	}
}
