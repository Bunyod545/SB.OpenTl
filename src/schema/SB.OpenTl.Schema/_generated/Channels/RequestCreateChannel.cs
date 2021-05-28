// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3d5fb10f)]
    public sealed class RequestCreateChannel : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Broadcast {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Megagroup {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 3)]
       public bool ForImport {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(4)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       /// <summary>Binary representation for the 'About' property</summary>
       [SerializationOrder(5)]
       public byte[] AboutAsBinary { get => _AboutAsBinary; set { _About = Encoding.UTF8.GetString(value); _AboutAsBinary = value; }}
       private byte[] _AboutAsBinary;
       private string _About;
       public string About { get => _About; set { AboutAsBinary = Encoding.UTF8.GetBytes(value); _About = value; }}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IInputGeoPoint GeoPoint {get; set;}

       /// <summary>Binary representation for the 'Address' property</summary>
       [SerializationOrder(7)]
       [CanSerialize("Flags", 2)]
       public byte[] AddressAsBinary { get => _AddressAsBinary; set { _Address = Encoding.UTF8.GetString(value); _AddressAsBinary = value; }}
       private byte[] _AddressAsBinary;
       private string _Address;
       public string Address { get => _Address; set { AddressAsBinary = Encoding.UTF8.GetBytes(value); _Address = value; }}

    }
}
