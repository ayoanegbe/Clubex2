using Clubex2.Data;
using Clubex2.Interfaces;
using Clubex2.Models;
using Microsoft.EntityFrameworkCore;

namespace Clubex2.Repositories
{
    public class TenantRepository : ITenantRepository
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession Session => _httpContextAccessor.HttpContext.Session;
        private readonly ApplicationDbContext _context;

        public TenantRepository(IHttpContextAccessor httpContextAccessor, ApplicationDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        public async Task<string> GetTenantId(Guid apiKey)
        {
            try
            {
                var tenant = await _context.Tenants.Where(x => x.ApiKey.Equals(apiKey)).FirstOrDefaultAsync();
                return tenant.TenantId.ToString();
            }
            catch 
            {
                return null;
            }
        }

        public async Task<string> GetTenantId()
        {
            return await Task.FromResult(Session.GetString("TenantId"));
        }

        public async Task<string> GetTenantId(string tenantName)
        {
            return await Task.FromResult(Session.GetString(tenantName));
        }

        public async Task<string> GetTenantName(Guid tenantId)
        {
            try
            {
                var tenant = await _context.Tenants.Where(x => x.TenantId.Equals(tenantId)).FirstOrDefaultAsync();
                return tenant.Name;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> IsTenant(string tenantName)
        {
            return await _context.Tenants.AnyAsync(x => x.Name.Equals(tenantName));
        }

    }
}
