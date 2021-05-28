// ReSharper disable All

namespace OpenTl.Schema.Bots
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x805d46f6)]
    public sealed class RequestSetBotCommands : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IBotCommand> Commands {get; set;}

    }
}
