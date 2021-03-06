// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x566decd0)]
    public sealed class RequestEditTitle : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(1)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

    }
}
