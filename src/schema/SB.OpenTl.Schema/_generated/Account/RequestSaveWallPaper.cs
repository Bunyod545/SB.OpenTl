// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6c5a5b37)]
    public sealed class RequestSaveWallPaper : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputWallPaper Wallpaper {get; set;}

       [SerializationOrder(1)]
       public bool Unsave {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IWallPaperSettings Settings {get; set;}

    }
}
