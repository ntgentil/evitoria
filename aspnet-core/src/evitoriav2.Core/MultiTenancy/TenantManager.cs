﻿using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using evitoriav2.Authorization.Users;
using evitoriav2.Editions;

namespace evitoriav2.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
