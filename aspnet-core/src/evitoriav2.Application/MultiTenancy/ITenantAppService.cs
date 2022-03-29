using Abp.Application.Services;
using evitoriav2.MultiTenancy.Dto;

namespace evitoriav2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

