// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x68976c6f)]
    public sealed class RequestRegisterDevice : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool NoMuted {get; set;}

       [SerializationOrder(2)]
       public int TokenType {get; set;}

       /// <summary>Binary representation for the 'Token' property</summary>
       [SerializationOrder(3)]
       public byte[] TokenAsBinary { get => _TokenAsBinary; set { _Token = Encoding.UTF8.GetString(value); _TokenAsBinary = value; }}
       private byte[] _TokenAsBinary;
       private string _Token;
       public string Token { get => _Token; set { TokenAsBinary = Encoding.UTF8.GetBytes(value); _Token = value; }}

       [SerializationOrder(4)]
       public bool AppSandbox {get; set;}

       [SerializationOrder(5)]
       public byte[] Secret {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.TVector<int> OtherUids {get; set;}

    }
}
