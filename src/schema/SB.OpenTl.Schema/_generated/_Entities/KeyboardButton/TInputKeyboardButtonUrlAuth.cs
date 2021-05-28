﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd02e7fd4)]
	public sealed class TInputKeyboardButtonUrlAuth : IKeyboardButton
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool RequestWriteAccess {get; set;}

       /// <summary>Binary representation for the 'Text' property</summary>
       [SerializationOrder(2)]
       public byte[] TextAsBinary { get => _TextAsBinary; set { _Text = Encoding.UTF8.GetString(value); _TextAsBinary = value; }}
       private byte[] _TextAsBinary;
       private string _Text;
       public string Text { get => _Text; set { TextAsBinary = Encoding.UTF8.GetBytes(value); _Text = value; }}

       /// <summary>Binary representation for the 'FwdText' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public byte[] FwdTextAsBinary { get => _FwdTextAsBinary; set { _FwdText = Encoding.UTF8.GetString(value); _FwdTextAsBinary = value; }}
       private byte[] _FwdTextAsBinary;
       private string _FwdText;
       public string FwdText { get => _FwdText; set { FwdTextAsBinary = Encoding.UTF8.GetBytes(value); _FwdText = value; }}

       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(4)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       [SerializationOrder(5)]
       public OpenTl.Schema.IInputUser Bot {get; set;}

	}
}
