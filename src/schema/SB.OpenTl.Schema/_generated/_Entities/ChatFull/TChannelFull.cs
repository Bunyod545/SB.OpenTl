// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf0e6672a)]
	public sealed class TChannelFull : IChatFull
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 3)]
       public bool CanViewParticipants {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 6)]
       public bool CanSetUsername {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 7)]
       public bool CanSetStickers {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 10)]
       public bool HiddenPrehistory {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 16)]
       public bool CanSetLocation {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 19)]
       public bool HasScheduled {get; set;}

       [SerializationOrder(7)]
       [FromFlag("Flags", 20)]
       public bool CanViewStats {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 22)]
       public bool Blocked {get; set;}

       [SerializationOrder(9)]
       public int Id {get; set;}

       /// <summary>Binary representation for the 'About' property</summary>
       [SerializationOrder(10)]
       public byte[] AboutAsBinary { get => _AboutAsBinary; set { _About = Encoding.UTF8.GetString(value); _AboutAsBinary = value; }}
       private byte[] _AboutAsBinary;
       private string _About;
       public string About { get => _About; set { AboutAsBinary = Encoding.UTF8.GetBytes(value); _About = value; }}

       [SerializationOrder(11)]
       [CanSerialize("Flags", 0)]
       public int ParticipantsCount {get; set;}

       [SerializationOrder(12)]
       [CanSerialize("Flags", 1)]
       public int AdminsCount {get; set;}

       [SerializationOrder(13)]
       [CanSerialize("Flags", 2)]
       public int KickedCount {get; set;}

       [SerializationOrder(14)]
       [CanSerialize("Flags", 2)]
       public int BannedCount {get; set;}

       [SerializationOrder(15)]
       [CanSerialize("Flags", 13)]
       public int OnlineCount {get; set;}

       [SerializationOrder(16)]
       public int ReadInboxMaxId {get; set;}

       [SerializationOrder(17)]
       public int ReadOutboxMaxId {get; set;}

       [SerializationOrder(18)]
       public int UnreadCount {get; set;}

       [SerializationOrder(19)]
       public OpenTl.Schema.IPhoto ChatPhoto {get; set;}

       [SerializationOrder(20)]
       public OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

       [SerializationOrder(21)]
       public OpenTl.Schema.IExportedChatInvite ExportedInvite {get; set;}

       [SerializationOrder(22)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IBotInfo> BotInfo {get; set;}

       [SerializationOrder(23)]
       [CanSerialize("Flags", 4)]
       public int MigratedFromChatId {get; set;}

       [SerializationOrder(24)]
       [CanSerialize("Flags", 4)]
       public int MigratedFromMaxId {get; set;}

       [SerializationOrder(25)]
       [CanSerialize("Flags", 5)]
       public int PinnedMsgId {get; set;}

       [SerializationOrder(26)]
       [CanSerialize("Flags", 8)]
       public OpenTl.Schema.IStickerSet Stickerset {get; set;}

       [SerializationOrder(27)]
       [CanSerialize("Flags", 9)]
       public int AvailableMinId {get; set;}

       [SerializationOrder(28)]
       [CanSerialize("Flags", 11)]
       public int FolderId {get; set;}

       [SerializationOrder(29)]
       [CanSerialize("Flags", 14)]
       public int LinkedChatId {get; set;}

       [SerializationOrder(30)]
       [CanSerialize("Flags", 15)]
       public OpenTl.Schema.IChannelLocation Location {get; set;}

       [SerializationOrder(31)]
       [CanSerialize("Flags", 17)]
       public int SlowmodeSeconds {get; set;}

       [SerializationOrder(32)]
       [CanSerialize("Flags", 18)]
       public int SlowmodeNextSendDate {get; set;}

       [SerializationOrder(33)]
       [CanSerialize("Flags", 12)]
       public int StatsDc {get; set;}

       [SerializationOrder(34)]
       public int Pts {get; set;}

	}
}
