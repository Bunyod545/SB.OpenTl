// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IWallPaperSettings : IObject
    {
       BitArray Flags {get; set;}

       bool Blur {get; set;}

       bool Motion {get; set;}

       int BackgroundColor {get; set;}

       int SecondBackgroundColor {get; set;}

       int Intensity {get; set;}

       int Rotation {get; set;}

    }
}
