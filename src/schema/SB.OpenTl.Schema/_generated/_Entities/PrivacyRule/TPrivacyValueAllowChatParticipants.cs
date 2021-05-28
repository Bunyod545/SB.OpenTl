// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x18be796b)]
	public sealed class TPrivacyValueAllowChatParticipants : IPrivacyRule
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<int> Chats {get; set;}

	}
}
