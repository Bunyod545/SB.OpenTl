// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf94e5f1)]
	public sealed class TInputMediaPoll : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IPoll Poll {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.TVector<byte[]> CorrectAnswers {get; set;}

       /// <summary>Binary representation for the 'Solution' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public byte[] SolutionAsBinary { get => _SolutionAsBinary; set { _Solution = Encoding.UTF8.GetString(value); _SolutionAsBinary = value; }}
       private byte[] _SolutionAsBinary;
       private string _Solution;
       public string Solution { get => _Solution; set { SolutionAsBinary = Encoding.UTF8.GetBytes(value); _Solution = value; }}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> SolutionEntities {get; set;}

	}
}
