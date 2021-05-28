// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1eb3758)]
	public sealed class TUserInfo : IUserInfo
	{
       /// <summary>Binary representation for the 'Message' property</summary>
       [SerializationOrder(0)]
       public byte[] MessageAsBinary { get => _MessageAsBinary; set { _Message = Encoding.UTF8.GetString(value); _MessageAsBinary = value; }}
       private byte[] _MessageAsBinary;
       private string _Message;
       public string Message { get => _Message; set { MessageAsBinary = Encoding.UTF8.GetBytes(value); _Message = value; }}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

       /// <summary>Binary representation for the 'Author' property</summary>
       [SerializationOrder(2)]
       public byte[] AuthorAsBinary { get => _AuthorAsBinary; set { _Author = Encoding.UTF8.GetString(value); _AuthorAsBinary = value; }}
       private byte[] _AuthorAsBinary;
       private string _Author;
       public string Author { get => _Author; set { AuthorAsBinary = Encoding.UTF8.GetBytes(value); _Author = value; }}

       [SerializationOrder(3)]
       public int Date {get; set;}

	}
}
