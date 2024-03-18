using Application.Features.Brands.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Caching;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Queries.GetAll;

public class GetAllBrandsQuery : IRequest<List<GetAllBrandsResponse>>,ICachableRequest
{
    public bool BypassCache { get; set; }

    public string CacheKey => "brand-list";

    public TimeSpan? SlidingExpiration { get; }
    public class GetAllBrandsQueryHandler : IRequestHandler<GetAllBrandsQuery, List<GetAllBrandsResponse>>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public GetAllBrandsQueryHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllBrandsResponse>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            List<Brand> brands = await _brandRepository.GetAllAsync();
            List<GetAllBrandsResponse> responses = _mapper.Map<List<GetAllBrandsResponse>>(brands);
            return responses;
        }
    }
}