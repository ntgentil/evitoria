using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using evitoriav2.MultiTenancy;

namespace evitoriav2.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
