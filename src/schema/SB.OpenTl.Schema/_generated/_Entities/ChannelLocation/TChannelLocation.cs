// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x209b82db)]
	public sealed class TChannelLocation : IChannelLocation
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IGeoPoint GeoPoint {get; set;}

       /// <summary>Binary representation for the 'Address' property</summary>
       [SerializationOrder(1)]
       public byte[] AddressAsBinary { get => _AddressAsBinary; set { _Address = Encoding.UTF8.GetString(value); _AddressAsBinary = value; }}
       private byte[] _AddressAsBinary;
       private string _Address;
       public string Address { get => _Address; set { AddressAsBinary = Encoding.UTF8.GetBytes(value); _Address = value; }}

	}
}
