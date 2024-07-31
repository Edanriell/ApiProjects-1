﻿using CqrsWebApi.Core.Models.Dto;
using MediatR;

namespace CqrsWebApi.Core.Queries;

public class GetInvoiceListQuery(int pageIndex, int pageSize) : IRequest<List<InvoiceWithoutItemsDto>>
{
	public int PageIndex { get; set; } = pageIndex;
	public int PageSize { get; set; } = pageSize;
}