// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfc8ddbea)]
    public sealed class RequestGetWallPaper : IRequest<OpenTl.Schema.IWallPaper>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputWallPaper Wallpaper {get; set;}

    }
}
