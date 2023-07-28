using Clubex2.Interfaces;
using Clubex2.Repositories;
using Microsoft.AspNetCore.Http;

namespace Clubex2.Services
{
    public class TenantSecurityMiddleware
    {
        private readonly RequestDelegate next;
        //private readonly ITenantRepository tenant;

        public TenantSecurityMiddleware(RequestDelegate next)
        {
            this.next = next;
            //this.tenant = tenant;
        }

        public async Task Invoke(HttpContext context)
        {
            string tenantIdentifier = context.Session.GetString("TenantId");
            if (string.IsNullOrEmpty(tenantIdentifier))
            {
                //var apiKey = context.Request.Headers["X-Api-Key"].FirstOrDefault();
                //if (string.IsNullOrEmpty(apiKey))
                //{
                //    return;
                //}

                //if (!Guid.TryParse(apiKey, out Guid apiKeyGuid))
                //{
                //    return;
                //}

                //string tenantId = await tenant.GetTenantId(apiKeyGuid);
                //context.Session.SetString("TenantId", tenantId);
            }
            await next.Invoke(context);
        }
    }
}
