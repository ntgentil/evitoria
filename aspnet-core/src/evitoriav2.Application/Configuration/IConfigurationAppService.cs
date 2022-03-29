using System.Threading.Tasks;
using evitoriav2.Configuration.Dto;

namespace evitoriav2.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
