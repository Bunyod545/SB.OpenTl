// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7438f7e8)]
	public sealed class TDialogFilter : IDialogFilter
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Contacts {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool NonContacts {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool Groups {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool Broadcasts {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 4)]
       public bool Bots {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 11)]
       public bool ExcludeMuted {get; set;}

       [SerializationOrder(7)]
       [FromFlag("Flags", 12)]
       public bool ExcludeRead {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 13)]
       public bool ExcludeArchived {get; set;}

       [SerializationOrder(9)]
       public int Id {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(10)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       /// <summary>Binary representation for the 'Emoticon' property</summary>
       [SerializationOrder(11)]
       [CanSerialize("Flags", 25)]
       public byte[] EmoticonAsBinary { get => _EmoticonAsBinary; set { _Emoticon = Encoding.UTF8.GetString(value); _EmoticonAsBinary = value; }}
       private byte[] _EmoticonAsBinary;
       private string _Emoticon;
       public string Emoticon { get => _Emoticon; set { EmoticonAsBinary = Encoding.UTF8.GetBytes(value); _Emoticon = value; }}

       [SerializationOrder(12)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputPeer> PinnedPeers {get; set;}

       [SerializationOrder(13)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputPeer> IncludePeers {get; set;}

       [SerializationOrder(14)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputPeer> ExcludePeers {get; set;}

	}
}
