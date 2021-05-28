// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbadcc1a3)]
	public sealed class TPollResults : IPollResults
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Min {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPollAnswerVoters> Results {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public int TotalVoters {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.TVector<int> RecentVoters {get; set;}

       /// <summary>Binary representation for the 'Solution' property</summary>
       [SerializationOrder(5)]
       [CanSerialize("Flags", 4)]
       public byte[] SolutionAsBinary { get => _SolutionAsBinary; set { _Solution = Encoding.UTF8.GetString(value); _SolutionAsBinary = value; }}
       private byte[] _SolutionAsBinary;
       private string _Solution;
       public string Solution { get => _Solution; set { SolutionAsBinary = Encoding.UTF8.GetBytes(value); _Solution = value; }}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> SolutionEntities {get; set;}

	}
}
