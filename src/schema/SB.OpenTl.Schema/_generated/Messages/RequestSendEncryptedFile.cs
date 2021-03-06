// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5559481d)]
    public sealed class RequestSendEncryptedFile : IRequest<OpenTl.Schema.Messages.ISentEncryptedMessage>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Silent {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputEncryptedChat Peer {get; set;}

       [SerializationOrder(3)]
       public long RandomId {get; set;}

       [SerializationOrder(4)]
       public byte[] Data {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.IInputEncryptedFile File {get; set;}

    }
}
