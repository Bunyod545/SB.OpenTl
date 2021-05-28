﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageViews : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IMessageViews> Views {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
