// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x86e18161)]
	public sealed class TPoll : IPoll
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public BitArray Flags {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 0)]
       public bool Closed {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 1)]
       public bool PublicVoters {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 2)]
       public bool MultipleChoice {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 3)]
       public bool Quiz {get; set;}

       /// <summary>Binary representation for the 'Question' property</summary>
       [SerializationOrder(6)]
       public byte[] QuestionAsBinary { get => _QuestionAsBinary; set { _Question = Encoding.UTF8.GetString(value); _QuestionAsBinary = value; }}
       private byte[] _QuestionAsBinary;
       private string _Question;
       public string Question { get => _Question; set { QuestionAsBinary = Encoding.UTF8.GetBytes(value); _Question = value; }}

       [SerializationOrder(7)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPollAnswer> Answers {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 4)]
       public int ClosePeriod {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 5)]
       public int CloseDate {get; set;}

	}
}
