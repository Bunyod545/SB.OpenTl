// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IThemeSettings : IObject
    {
       BitArray Flags {get; set;}

       OpenTl.Schema.IBaseTheme BaseTheme {get; set;}

       int AccentColor {get; set;}

       int MessageTopColor {get; set;}

       int MessageBottomColor {get; set;}

       OpenTl.Schema.IWallPaper Wallpaper {get; set;}

    }
}
