// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8fdf1920)]
    public sealed class RequestConfirmPasswordEmail : IRequest<bool>
    {
       /// <summary>Binary representation for the 'Code' property</summary>
       [SerializationOrder(0)]
       public byte[] CodeAsBinary { get => _CodeAsBinary; set { _Code = Encoding.UTF8.GetString(value); _CodeAsBinary = value; }}
       private byte[] _CodeAsBinary;
       private string _Code;
       public string Code { get => _Code; set { CodeAsBinary = Encoding.UTF8.GetBytes(value); _Code = value; }}

    }
}
