// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x98dd8936)]
	public sealed class TPageListOrderedItemBlocks : IPageListOrderedItem
	{
       /// <summary>Binary representation for the 'Num' property</summary>
       [SerializationOrder(0)]
       public byte[] NumAsBinary { get => _NumAsBinary; set { _Num = Encoding.UTF8.GetString(value); _NumAsBinary = value; }}
       private byte[] _NumAsBinary;
       private string _Num;
       public string Num { get => _Num; set { NumAsBinary = Encoding.UTF8.GetBytes(value); _Num = value; }}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPageBlock> Blocks {get; set;}

	}
}
