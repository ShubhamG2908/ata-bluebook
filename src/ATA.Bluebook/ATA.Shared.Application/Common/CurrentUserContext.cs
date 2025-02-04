
using ATA.Shared.Application.Interface;

using Microsoft.AspNetCore.Http;

namespace ATA.Shared.Application.Common
{
    public class CurrentUserContext : ICurrentUserContext
    {
        private readonly IGenericRepositoryBuilder<>
        public CurrentUserContext(IHttpContextAccessor httpContextAccessor)
        {
            this.TokenId  = Guid.Parse(httpContextAccessor.HttpContext.User.Claims.SingleOrDefault(x => x.Type == "TokenId")?.Value!);
            this.User
        }

        public Guid TokenId { get;}

        public Guid UserId => throw new NotImplementedException();

        public Guid EmailAddress => throw new NotImplementedException();

        public Guid TenantId => throw new NotImplementedException();

        public string PolicyPermission => throw new NotImplementedException();

        public bool HasValidPermission(string permissionType, string moduleName)
        {
            throw new NotImplementedException();
        }
    }
}
