// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xff544e65)]
	public sealed class TFolder : IFolder
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool AutofillNewBroadcasts {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool AutofillPublicGroups {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool AutofillNewCorrespondents {get; set;}

       [SerializationOrder(4)]
       public int Id {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(5)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.IChatPhoto Photo {get; set;}

	}
}
