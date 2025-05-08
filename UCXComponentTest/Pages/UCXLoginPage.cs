using Microsoft.Playwright;
using System.Threading.Tasks;
namespace UCXComponentTest.Pages
{
    public class UCXLoginPage
    {
        private readonly IPage _page;
        public UCXLoginPage(IPage page)
        {
            _page = page;
        }

        private ILocator UsernameInput => _page.Locator("#username");
        private ILocator PasswordInput => _page.Locator("#password");
        private ILocator LoginButton => _page.Locator("#login");

        public async Task LoginAsync(string username, string password)
        {
            await UsernameInput.FillAsync(username);
            await PasswordInput.FillAsync(password);
            await LoginButton.ClickAsync();
        }
    }
}