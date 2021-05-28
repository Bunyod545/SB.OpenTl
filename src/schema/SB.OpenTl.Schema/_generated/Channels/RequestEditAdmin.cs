// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd33c8902)]
    public sealed class RequestEditAdmin : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IChatAdminRights AdminRights {get; set;}

       /// <summary>Binary representation for the 'Rank' property</summary>
       [SerializationOrder(3)]
       public byte[] RankAsBinary { get => _RankAsBinary; set { _Rank = Encoding.UTF8.GetString(value); _RankAsBinary = value; }}
       private byte[] _RankAsBinary;
       private string _Rank;
       public string Rank { get => _Rank; set { RankAsBinary = Encoding.UTF8.GetBytes(value); _Rank = value; }}

    }
}
