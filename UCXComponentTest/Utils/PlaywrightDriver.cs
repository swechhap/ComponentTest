using Microsoft.Playwright;
using System.Threading.Tasks;
namespace UCXComponentTest.Utils
{
    public static class PlaywrightDriver
    {
        public static IPlaywright Playwright;
        public static IBrowser Browser;
        public static IBrowserContext Context;
        public static IPage Page;
        public static async Task InitializeAsync()
        {
            Playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            Browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            Context = await Browser.NewContextAsync();
            Page = await Context.NewPageAsync();
        }

        public static async Task CloseAsync()
        {
            await Browser.CloseAsync();
        }
    }
}