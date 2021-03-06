// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5d2f3aa9)]
	public sealed class TUpdateBotPrecheckoutQuery : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long QueryId {get; set;}

       [SerializationOrder(2)]
       public int UserId {get; set;}

       [SerializationOrder(3)]
       public byte[] Payload {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IPaymentRequestedInfo Info {get; set;}

       /// <summary>Binary representation for the 'ShippingOptionId' property</summary>
       [SerializationOrder(5)]
       [CanSerialize("Flags", 1)]
       public byte[] ShippingOptionIdAsBinary { get => _ShippingOptionIdAsBinary; set { _ShippingOptionId = Encoding.UTF8.GetString(value); _ShippingOptionIdAsBinary = value; }}
       private byte[] _ShippingOptionIdAsBinary;
       private string _ShippingOptionId;
       public string ShippingOptionId { get => _ShippingOptionId; set { ShippingOptionIdAsBinary = Encoding.UTF8.GetBytes(value); _ShippingOptionId = value; }}

       /// <summary>Binary representation for the 'Currency' property</summary>
       [SerializationOrder(6)]
       public byte[] CurrencyAsBinary { get => _CurrencyAsBinary; set { _Currency = Encoding.UTF8.GetString(value); _CurrencyAsBinary = value; }}
       private byte[] _CurrencyAsBinary;
       private string _Currency;
       public string Currency { get => _Currency; set { CurrencyAsBinary = Encoding.UTF8.GetBytes(value); _Currency = value; }}

       [SerializationOrder(7)]
       public long TotalAmount {get; set;}

	}
}
