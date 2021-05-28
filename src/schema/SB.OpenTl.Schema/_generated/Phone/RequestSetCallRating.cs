// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x59ead627)]
    public sealed class RequestSetCallRating : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool UserInitiative {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputPhoneCall Peer {get; set;}

       [SerializationOrder(3)]
       public int Rating {get; set;}

       /// <summary>Binary representation for the 'Comment' property</summary>
       [SerializationOrder(4)]
       public byte[] CommentAsBinary { get => _CommentAsBinary; set { _Comment = Encoding.UTF8.GetString(value); _CommentAsBinary = value; }}
       private byte[] _CommentAsBinary;
       private string _Comment;
       public string Comment { get => _Comment; set { CommentAsBinary = Encoding.UTF8.GetBytes(value); _Comment = value; }}

    }
}
