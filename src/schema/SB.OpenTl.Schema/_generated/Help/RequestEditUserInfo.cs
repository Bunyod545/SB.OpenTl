// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x66b91b70)]
    public sealed class RequestEditUserInfo : IRequest<OpenTl.Schema.Help.IUserInfo>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

       /// <summary>Binary representation for the 'Message' property</summary>
       [SerializationOrder(1)]
       public byte[] MessageAsBinary { get => _MessageAsBinary; set { _Message = Encoding.UTF8.GetString(value); _MessageAsBinary = value; }}
       private byte[] _MessageAsBinary;
       private string _Message;
       public string Message { get => _Message; set { MessageAsBinary = Encoding.UTF8.GetBytes(value); _Message = value; }}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

    }
}
