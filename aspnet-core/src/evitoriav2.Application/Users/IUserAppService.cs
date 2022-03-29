using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using evitoriav2.Roles.Dto;
using evitoriav2.Users.Dto;

namespace evitoriav2.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task DeActivate(EntityDto<long> user);
        Task Activate(EntityDto<long> user);
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
