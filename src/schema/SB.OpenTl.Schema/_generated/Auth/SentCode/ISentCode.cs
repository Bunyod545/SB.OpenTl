﻿// ReSharper disable All

namespace OpenTl.Schema.Auth
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISentCode : IObject
    {
       BitArray Flags {get; set;}

       OpenTl.Schema.Auth.ISentCodeType Type {get; set;}

       byte[] PhoneCodeHashAsBinary {get; set;}
       string PhoneCodeHash {get; set;}

       OpenTl.Schema.Auth.ICodeType NextType {get; set;}

       int Timeout {get; set;}

    }
}
