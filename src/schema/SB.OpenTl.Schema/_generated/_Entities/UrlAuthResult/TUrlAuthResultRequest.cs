// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x92d33a0e)]
	public sealed class TUrlAuthResultRequest : IUrlAuthResult
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool RequestWriteAccess {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IUser Bot {get; set;}

       /// <summary>Binary representation for the 'Domain' property</summary>
       [SerializationOrder(3)]
       public byte[] DomainAsBinary { get => _DomainAsBinary; set { _Domain = Encoding.UTF8.GetString(value); _DomainAsBinary = value; }}
       private byte[] _DomainAsBinary;
       private string _Domain;
       public string Domain { get => _Domain; set { DomainAsBinary = Encoding.UTF8.GetBytes(value); _Domain = value; }}

	}
}
