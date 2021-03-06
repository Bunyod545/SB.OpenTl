// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x77744d4a)]
	public sealed class TDialogFilterSuggested : IDialogFilterSuggested
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IDialogFilter Filter {get; set;}

       /// <summary>Binary representation for the 'Description' property</summary>
       [SerializationOrder(1)]
       public byte[] DescriptionAsBinary { get => _DescriptionAsBinary; set { _Description = Encoding.UTF8.GetString(value); _DescriptionAsBinary = value; }}
       private byte[] _DescriptionAsBinary;
       private string _Description;
       public string Description { get => _Description; set { DescriptionAsBinary = Encoding.UTF8.GetBytes(value); _Description = value; }}

	}
}
