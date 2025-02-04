using ATA.Application.Interface;

using Microsoft.AspNetCore.Http;

using System.Security.Claims;

namespace ATA.Application.Common.Context
{
    public class CurrentUserContext : ICurrentUserContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CurrentUserContext(IHttpContextAccessor httpContextAccessor, IUserContextService userContextService)
        { _httpContextAccessor = httpContextAccessor; }

        public Guid TokenId => Guid.Parse(GetClaimValue(ClaimTypes.NameIdentifier));

        public Guid UserId => Guid.Parse(GetClaimValue(ClaimConstants.UserId));

        public string EmailAddress => GetClaimValue(ClaimTypes.Email);

        private string PolicyPermission => GetSessionValue(ClaimConstants.Permission);

        public string Role => GetSessionValue(ClaimConstants.UserRole);

        public bool HasValidPermission(string permissionName) => PolicyPermission.Contains(permissionName);

        private string GetClaimValue(string claimName)
        {
            var claim = _httpContextAccessor.HttpContext.User.Claims.SingleOrDefault(x => x.Type == claimName);

            if (claim == null)
                throw new UnauthorizedAccessException("Unauthorized Access Detected.");

            return claim.Value;
        }

        private string GetSessionValue(string claimName)
        {
            var value = _httpContextAccessor.HttpContext.Session.GetString(claimName);

            if (string.IsNullOrWhiteSpace(value))
                throw new UnauthorizedAccessException("Unauthorized Access Detected.");

            return value;
        }
    }
}
