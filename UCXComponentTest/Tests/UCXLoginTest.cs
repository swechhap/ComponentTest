using NUnit.Framework;
using UCXComponentTest.Pages;
using UCXComponentTest.Utils;
using System.Threading.Tasks;
namespace UCXComponentTest.Tests
{
    [TestFixture]
    public class UCXLoginTest
    {
        [SetUp]
        public async Task SetUp()
        {
            await PlaywrightDriver.InitializeAsync();
        }
        [Test]
        public async Task SuccessfulLoginTest()
        {
            await PlaywrightDriver.Page.GotoAsync(TestConfigReader.GetAppUrl());

            var loginPage = new UCXLoginPage(PlaywrightDriver.Page);
            await loginPage.LoginAsync("testuser", "testpass");

            //Assert.That(await PlaywrightDriver.Page.Url, Does.Contain("/home"));
        }

        [TearDown]
        public async Task TearDown()
        {
            await PlaywrightDriver.CloseAsync();
        }
    }

}