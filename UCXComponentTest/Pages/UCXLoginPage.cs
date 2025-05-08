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

        private ILocator LoginBtn => _page.Locator("#login-btn");
        private ILocator UsernameInput => _page.Locator("#identifier");
        private ILocator PasswordInput => _page.Locator("#credentials.passcode");
        private ILocator NextBtn => _page.Locator("//button[contains(text(),'Next')]");
        private ILocator VerfiyBtn => _page.Locator("//button[contains(text(),'Verify')]");
        public async Task LoginAsync(string username, string password)
        {
            await LoginBtn.ClickAsync();
            await UsernameInput.FillAsync(username);
            await NextBtn.ClickAsync();
            
            await PasswordInput.FillAsync(password);
            await VerfiyBtn.ClickAsync();
        }
    }
}