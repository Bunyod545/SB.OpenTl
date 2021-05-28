// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IUserFull : IObject
    {
       BitArray Flags {get; set;}

       bool Blocked {get; set;}

       bool PhoneCallsAvailable {get; set;}

       bool PhoneCallsPrivate {get; set;}

       bool CanPinMessage {get; set;}

       bool HasScheduled {get; set;}

       bool VideoCallsAvailable {get; set;}

       OpenTl.Schema.IUser User {get; set;}

       byte[] AboutAsBinary {get; set;}
       string About {get; set;}

       OpenTl.Schema.IPeerSettings Settings {get; set;}

       OpenTl.Schema.IPhoto ProfilePhoto {get; set;}

       OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

       OpenTl.Schema.IBotInfo BotInfo {get; set;}

       int PinnedMsgId {get; set;}

       int CommonChatsCount {get; set;}

       int FolderId {get; set;}

    }
}
