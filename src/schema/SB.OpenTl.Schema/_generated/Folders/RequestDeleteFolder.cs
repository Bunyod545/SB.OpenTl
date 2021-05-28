// ReSharper disable All

namespace OpenTl.Schema.Folders
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1c295881)]
    public sealed class RequestDeleteFolder : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public int FolderId {get; set;}

    }
}
