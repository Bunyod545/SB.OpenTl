// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x635fe375)]
	public sealed class TPhoneConnectionWebrtc : IPhoneConnection
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Turn {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Stun {get; set;}

       [SerializationOrder(3)]
       public long Id {get; set;}

       /// <summary>Binary representation for the 'Ip' property</summary>
       [SerializationOrder(4)]
       public byte[] IpAsBinary { get => _IpAsBinary; set { _Ip = Encoding.UTF8.GetString(value); _IpAsBinary = value; }}
       private byte[] _IpAsBinary;
       private string _Ip;
       public string Ip { get => _Ip; set { IpAsBinary = Encoding.UTF8.GetBytes(value); _Ip = value; }}

       /// <summary>Binary representation for the 'Ipv6' property</summary>
       [SerializationOrder(5)]
       public byte[] Ipv6AsBinary { get => _Ipv6AsBinary; set { _Ipv6 = Encoding.UTF8.GetString(value); _Ipv6AsBinary = value; }}
       private byte[] _Ipv6AsBinary;
       private string _Ipv6;
       public string Ipv6 { get => _Ipv6; set { Ipv6AsBinary = Encoding.UTF8.GetBytes(value); _Ipv6 = value; }}

       [SerializationOrder(6)]
       public int Port {get; set;}

       /// <summary>Binary representation for the 'Username' property</summary>
       [SerializationOrder(7)]
       public byte[] UsernameAsBinary { get => _UsernameAsBinary; set { _Username = Encoding.UTF8.GetString(value); _UsernameAsBinary = value; }}
       private byte[] _UsernameAsBinary;
       private string _Username;
       public string Username { get => _Username; set { UsernameAsBinary = Encoding.UTF8.GetBytes(value); _Username = value; }}

       /// <summary>Binary representation for the 'Password' property</summary>
       [SerializationOrder(8)]
       public byte[] PasswordAsBinary { get => _PasswordAsBinary; set { _Password = Encoding.UTF8.GetString(value); _PasswordAsBinary = value; }}
       private byte[] _PasswordAsBinary;
       private string _Password;
       public string Password { get => _Password; set { PasswordAsBinary = Encoding.UTF8.GetBytes(value); _Password = value; }}

	}
}
