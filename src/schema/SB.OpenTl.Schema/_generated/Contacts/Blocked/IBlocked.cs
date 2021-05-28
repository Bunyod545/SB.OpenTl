﻿// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBlocked : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IPeerBlocked> Blocked {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
