﻿// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x50a04e45)]
	public sealed class TPrivacyRules : IPrivacyRules
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPrivacyRule> Rules {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
