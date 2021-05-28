// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa677244f)]
    public sealed class RequestSendCode : IRequest<OpenTl.Schema.Auth.ISentCode>
    {
       /// <summary>Binary representation for the 'PhoneNumber' property</summary>
       [SerializationOrder(0)]
       public byte[] PhoneNumberAsBinary { get => _PhoneNumberAsBinary; set { _PhoneNumber = Encoding.UTF8.GetString(value); _PhoneNumberAsBinary = value; }}
       private byte[] _PhoneNumberAsBinary;
       private string _PhoneNumber;
       public string PhoneNumber { get => _PhoneNumber; set { PhoneNumberAsBinary = Encoding.UTF8.GetBytes(value); _PhoneNumber = value; }}

       [SerializationOrder(1)]
       public int ApiId {get; set;}

       /// <summary>Binary representation for the 'ApiHash' property</summary>
       [SerializationOrder(2)]
       public byte[] ApiHashAsBinary { get => _ApiHashAsBinary; set { _ApiHash = Encoding.UTF8.GetString(value); _ApiHashAsBinary = value; }}
       private byte[] _ApiHashAsBinary;
       private string _ApiHash;
       public string ApiHash { get => _ApiHash; set { ApiHashAsBinary = Encoding.UTF8.GetBytes(value); _ApiHash = value; }}

       [SerializationOrder(3)]
       public OpenTl.Schema.ICodeSettings Settings {get; set;}

    }
}
