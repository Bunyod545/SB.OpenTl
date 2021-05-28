// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbb3b9804)]
    public sealed class RequestResetWallPapers : IRequest<bool>
    {

    }
}
