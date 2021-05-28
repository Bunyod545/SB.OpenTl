// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2e79d779)]
    public sealed class RequestGetBankCardData : IRequest<OpenTl.Schema.Payments.IBankCardData>
    {
       /// <summary>Binary representation for the 'Number' property</summary>
       [SerializationOrder(0)]
       public byte[] NumberAsBinary { get => _NumberAsBinary; set { _Number = Encoding.UTF8.GetString(value); _NumberAsBinary = value; }}
       private byte[] _NumberAsBinary;
       private string _Number;
       public string Number { get => _Number; set { NumberAsBinary = Encoding.UTF8.GetBytes(value); _Number = value; }}

    }
}
