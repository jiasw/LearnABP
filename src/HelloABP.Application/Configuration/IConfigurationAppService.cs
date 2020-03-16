using System.Threading.Tasks;
using HelloABP.Configuration.Dto;

namespace HelloABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
