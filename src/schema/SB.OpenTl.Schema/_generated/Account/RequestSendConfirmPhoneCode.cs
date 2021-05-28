// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1b3faa88)]
    public sealed class RequestSendConfirmPhoneCode : IRequest<OpenTl.Schema.Auth.ISentCode>
    {
       /// <summary>Binary representation for the 'Hash' property</summary>
       [SerializationOrder(0)]
       public byte[] HashAsBinary { get => _HashAsBinary; set { _Hash = Encoding.UTF8.GetString(value); _HashAsBinary = value; }}
       private byte[] _HashAsBinary;
       private string _Hash;
       public string Hash { get => _Hash; set { HashAsBinary = Encoding.UTF8.GetBytes(value); _Hash = value; }}

       [SerializationOrder(1)]
       public OpenTl.Schema.ICodeSettings Settings {get; set;}

    }
}
