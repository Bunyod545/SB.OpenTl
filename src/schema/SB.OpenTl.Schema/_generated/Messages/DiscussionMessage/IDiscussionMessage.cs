﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IDiscussionMessage : IObject
    {
       BitArray Flags {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IMessage> Messages {get; set;}

       int MaxId {get; set;}

       int ReadInboxMaxId {get; set;}

       int ReadOutboxMaxId {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
