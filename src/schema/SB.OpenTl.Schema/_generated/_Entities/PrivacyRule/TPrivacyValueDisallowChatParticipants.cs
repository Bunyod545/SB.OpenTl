// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xacae0690)]
	public sealed class TPrivacyValueDisallowChatParticipants : IPrivacyRule
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<int> Chats {get; set;}

	}
}
