// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1b7c9db3)]
	public sealed class TChatFull : IChatFull
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 7)]
       public bool CanSetUsername {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 8)]
       public bool HasScheduled {get; set;}

       [SerializationOrder(3)]
       public int Id {get; set;}

       /// <summary>Binary representation for the 'About' property</summary>
       [SerializationOrder(4)]
       public byte[] AboutAsBinary { get => _AboutAsBinary; set { _About = Encoding.UTF8.GetString(value); _AboutAsBinary = value; }}
       private byte[] _AboutAsBinary;
       private string _About;
       public string About { get => _About; set { AboutAsBinary = Encoding.UTF8.GetBytes(value); _About = value; }}

       [SerializationOrder(5)]
       public OpenTl.Schema.IChatParticipants Participants {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IPhoto ChatPhoto {get; set;}

       [SerializationOrder(7)]
       public OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.IExportedChatInvite ExportedInvite {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IBotInfo> BotInfo {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 6)]
       public int PinnedMsgId {get; set;}

       [SerializationOrder(11)]
       [CanSerialize("Flags", 11)]
       public int FolderId {get; set;}

	}
}
