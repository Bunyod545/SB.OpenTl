// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xedf17c12)]
	public sealed class TUserFull : IUserFull
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Blocked {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 4)]
       public bool PhoneCallsAvailable {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 5)]
       public bool PhoneCallsPrivate {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 7)]
       public bool CanPinMessage {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 12)]
       public bool HasScheduled {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 13)]
       public bool VideoCallsAvailable {get; set;}

       [SerializationOrder(7)]
       public OpenTl.Schema.IUser User {get; set;}

       /// <summary>Binary representation for the 'About' property</summary>
       [SerializationOrder(8)]
       [CanSerialize("Flags", 1)]
       public byte[] AboutAsBinary { get => _AboutAsBinary; set { _About = Encoding.UTF8.GetString(value); _AboutAsBinary = value; }}
       private byte[] _AboutAsBinary;
       private string _About;
       public string About { get => _About; set { AboutAsBinary = Encoding.UTF8.GetBytes(value); _About = value; }}

       [SerializationOrder(9)]
       public OpenTl.Schema.IPeerSettings Settings {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IPhoto ProfilePhoto {get; set;}

       [SerializationOrder(11)]
       public OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

       [SerializationOrder(12)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.IBotInfo BotInfo {get; set;}

       [SerializationOrder(13)]
       [CanSerialize("Flags", 6)]
       public int PinnedMsgId {get; set;}

       [SerializationOrder(14)]
       public int CommonChatsCount {get; set;}

       [SerializationOrder(15)]
       [CanSerialize("Flags", 11)]
       public int FolderId {get; set;}

	}
}
