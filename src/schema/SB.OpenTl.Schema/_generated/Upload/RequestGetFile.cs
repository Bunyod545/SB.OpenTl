// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb15a9afc)]
    public sealed class RequestGetFile : IRequest<OpenTl.Schema.Upload.IFile>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Precise {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool CdnSupported {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IInputFileLocation Location {get; set;}

       [SerializationOrder(4)]
       public int Offset {get; set;}

       [SerializationOrder(5)]
       public int Limit {get; set;}

    }
}
