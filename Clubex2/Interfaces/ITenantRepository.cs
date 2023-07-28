﻿namespace Clubex2.Interfaces
{
    public interface ITenantRepository
    {
        Task<string> GetTenantId(Guid apiKey);
        Task<string> GetTenantId();
        Task<string> GetTenantId(string tenantName);
        Task<string> GetTenantName(Guid tenantId);
        Task<bool> IsTenant(string tenantName);
    }
}
