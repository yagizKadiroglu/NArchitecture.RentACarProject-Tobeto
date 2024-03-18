using Application.Features.Brands.Models;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using MediatR;

namespace Application.Features.Brands.Queries.GetListPagination;

public class GetListPaginationBrandQuery : IRequest<BrandListModel>, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public bool BypassCache { get; set; }

    public string CacheKey => "brand-list";

    public TimeSpan? SlidingExpiration { get; }
}
