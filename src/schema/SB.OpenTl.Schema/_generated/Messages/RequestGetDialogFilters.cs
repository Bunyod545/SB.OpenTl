// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf19ed96d)]
    public sealed class RequestGetDialogFilters : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IDialogFilter>>
    {

    }
}
