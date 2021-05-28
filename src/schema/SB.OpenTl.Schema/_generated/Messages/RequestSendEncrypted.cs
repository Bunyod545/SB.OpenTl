// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x44fa7a15)]
    public sealed class RequestSendEncrypted : IRequest<OpenTl.Schema.Messages.ISentEncryptedMessage>
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

    }
}
