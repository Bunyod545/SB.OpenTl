// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb1b41517)]
    public sealed class RequestExportLoginToken : IRequest<OpenTl.Schema.Auth.ILoginToken>
    {
       [SerializationOrder(0)]
       public int ApiId {get; set;}

       /// <summary>Binary representation for the 'ApiHash' property</summary>
       [SerializationOrder(1)]
       public byte[] ApiHashAsBinary { get => _ApiHashAsBinary; set { _ApiHash = Encoding.UTF8.GetString(value); _ApiHashAsBinary = value; }}
       private byte[] _ApiHashAsBinary;
       private string _ApiHash;
       public string ApiHash { get => _ApiHash; set { ApiHashAsBinary = Encoding.UTF8.GetBytes(value); _ApiHash = value; }}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<int> ExceptIds {get; set;}

    }
}
