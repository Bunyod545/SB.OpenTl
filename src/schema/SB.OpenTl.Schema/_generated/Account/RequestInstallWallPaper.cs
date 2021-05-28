﻿// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfeed5769)]
    public sealed class RequestInstallWallPaper : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputWallPaper Wallpaper {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IWallPaperSettings Settings {get; set;}

    }
}
