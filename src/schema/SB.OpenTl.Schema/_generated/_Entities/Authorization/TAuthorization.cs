// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xad01d61d)]
	public sealed class TAuthorization : IAuthorization
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Current {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool OfficialApp {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool PasswordPending {get; set;}

       [SerializationOrder(4)]
       public long Hash {get; set;}

       /// <summary>Binary representation for the 'DeviceModel' property</summary>
       [SerializationOrder(5)]
       public byte[] DeviceModelAsBinary { get => _DeviceModelAsBinary; set { _DeviceModel = Encoding.UTF8.GetString(value); _DeviceModelAsBinary = value; }}
       private byte[] _DeviceModelAsBinary;
       private string _DeviceModel;
       public string DeviceModel { get => _DeviceModel; set { DeviceModelAsBinary = Encoding.UTF8.GetBytes(value); _DeviceModel = value; }}

       /// <summary>Binary representation for the 'Platform' property</summary>
       [SerializationOrder(6)]
       public byte[] PlatformAsBinary { get => _PlatformAsBinary; set { _Platform = Encoding.UTF8.GetString(value); _PlatformAsBinary = value; }}
       private byte[] _PlatformAsBinary;
       private string _Platform;
       public string Platform { get => _Platform; set { PlatformAsBinary = Encoding.UTF8.GetBytes(value); _Platform = value; }}

       /// <summary>Binary representation for the 'SystemVersion' property</summary>
       [SerializationOrder(7)]
       public byte[] SystemVersionAsBinary { get => _SystemVersionAsBinary; set { _SystemVersion = Encoding.UTF8.GetString(value); _SystemVersionAsBinary = value; }}
       private byte[] _SystemVersionAsBinary;
       private string _SystemVersion;
       public string SystemVersion { get => _SystemVersion; set { SystemVersionAsBinary = Encoding.UTF8.GetBytes(value); _SystemVersion = value; }}

       [SerializationOrder(8)]
       public int ApiId {get; set;}

       /// <summary>Binary representation for the 'AppName' property</summary>
       [SerializationOrder(9)]
       public byte[] AppNameAsBinary { get => _AppNameAsBinary; set { _AppName = Encoding.UTF8.GetString(value); _AppNameAsBinary = value; }}
       private byte[] _AppNameAsBinary;
       private string _AppName;
       public string AppName { get => _AppName; set { AppNameAsBinary = Encoding.UTF8.GetBytes(value); _AppName = value; }}

       /// <summary>Binary representation for the 'AppVersion' property</summary>
       [SerializationOrder(10)]
       public byte[] AppVersionAsBinary { get => _AppVersionAsBinary; set { _AppVersion = Encoding.UTF8.GetString(value); _AppVersionAsBinary = value; }}
       private byte[] _AppVersionAsBinary;
       private string _AppVersion;
       public string AppVersion { get => _AppVersion; set { AppVersionAsBinary = Encoding.UTF8.GetBytes(value); _AppVersion = value; }}

       [SerializationOrder(11)]
       public int DateCreated {get; set;}

       [SerializationOrder(12)]
       public int DateActive {get; set;}

       /// <summary>Binary representation for the 'Ip' property</summary>
       [SerializationOrder(13)]
       public byte[] IpAsBinary { get => _IpAsBinary; set { _Ip = Encoding.UTF8.GetString(value); _IpAsBinary = value; }}
       private byte[] _IpAsBinary;
       private string _Ip;
       public string Ip { get => _Ip; set { IpAsBinary = Encoding.UTF8.GetBytes(value); _Ip = value; }}

       /// <summary>Binary representation for the 'Country' property</summary>
       [SerializationOrder(14)]
       public byte[] CountryAsBinary { get => _CountryAsBinary; set { _Country = Encoding.UTF8.GetString(value); _CountryAsBinary = value; }}
       private byte[] _CountryAsBinary;
       private string _Country;
       public string Country { get => _Country; set { CountryAsBinary = Encoding.UTF8.GetBytes(value); _Country = value; }}

       /// <summary>Binary representation for the 'Region' property</summary>
       [SerializationOrder(15)]
       public byte[] RegionAsBinary { get => _RegionAsBinary; set { _Region = Encoding.UTF8.GetString(value); _RegionAsBinary = value; }}
       private byte[] _RegionAsBinary;
       private string _Region;
       public string Region { get => _Region; set { RegionAsBinary = Encoding.UTF8.GetBytes(value); _Region = value; }}

	}
}
