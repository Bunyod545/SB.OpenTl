﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa29cd42c)]
    public sealed class RequestGetSuggestedDialogFilters : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IDialogFilterSuggested>>
    {

    }
}
