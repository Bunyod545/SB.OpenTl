// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9b2754a8)]
    public sealed class RequestReuploadCdnFile : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IFileHash>>
    {
       [SerializationOrder(0)]
       public byte[] FileToken {get; set;}

       [SerializationOrder(1)]
       public byte[] RequestToken {get; set;}

    }
}
