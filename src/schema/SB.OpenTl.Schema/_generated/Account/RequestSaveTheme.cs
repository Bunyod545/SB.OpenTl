// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf257106c)]
    public sealed class RequestSaveTheme : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputTheme Theme {get; set;}

       [SerializationOrder(1)]
       public bool Unsave {get; set;}

    }
}
