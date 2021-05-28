// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb390dc08)]
	public sealed class TPageRelatedArticle : IPageRelatedArticle
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(1)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       [SerializationOrder(2)]
       public long WebpageId {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       /// <summary>Binary representation for the 'Description' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public byte[] DescriptionAsBinary { get => _DescriptionAsBinary; set { _Description = Encoding.UTF8.GetString(value); _DescriptionAsBinary = value; }}
       private byte[] _DescriptionAsBinary;
       private string _Description;
       public string Description { get => _Description; set { DescriptionAsBinary = Encoding.UTF8.GetBytes(value); _Description = value; }}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public long PhotoId {get; set;}

       /// <summary>Binary representation for the 'Author' property</summary>
       [SerializationOrder(6)]
       [CanSerialize("Flags", 3)]
       public byte[] AuthorAsBinary { get => _AuthorAsBinary; set { _Author = Encoding.UTF8.GetString(value); _AuthorAsBinary = value; }}
       private byte[] _AuthorAsBinary;
       private string _Author;
       public string Author { get => _Author; set { AuthorAsBinary = Encoding.UTF8.GetBytes(value); _Author = value; }}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 4)]
       public int PublishedDate {get; set;}

	}
}
