using ATA.Application.Interface;

using Microsoft.AspNetCore.Http;

namespace ATA.Application.Common.Context
{
    public class TenantContext : ITenantContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TenantContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private string GetClaimValue(string claimName)
        {
            var claim = _httpContextAccessor.HttpContext.User.Claims.SingleOrDefault(x => x.Type == claimName);

            if (claim == null)
                throw new UnauthorizedAccessException("Unauthorized Access Detected.");

            return claim.Value;
        }

        public Guid TenantId => Guid.Parse(GetClaimValue(ClaimConstants.TenantId));
    }
}
