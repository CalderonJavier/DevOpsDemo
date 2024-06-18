using DevOpsDemo.Controllers;
using DevOpsDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsDemo.Test
{
    //Error con playwright
    //https://stackoverflow.com/questions/75011395/unable-to-install-playwright-on-a-windows-due-to-not-recognizing-argument#:~:text=Install%20the%20PowerShell%20tool%3A%20dotnet%20tool%20install%20--global,try%20to%20install%20playwright%20CLI%20and%20the%20browsers.
    [TestClass]
    public class PostTestController : PageTest
    {/*
        [TestMethod]
        public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
        {
            await Page.GotoAsync("https://playwright.dev");

            // Expect a title "to contain" a substring.
            await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

            // create a locator
            var getStarted = Page.Locator("text=Get Started");

            // Expect an attribute "to be strictly equal" to the value.
            await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

            // Click the get started link.
            await getStarted.ClickAsync();

            // Expects the URL to contain intro.
            await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
        }*/

        private PostRepository repository;

        public PostTestController() { 
            repository = new PostRepository();
        }

        [TestMethod]
        public async Task Test_Index_View_Result()
        {
            //Arrange
            var controller = new HomeController(repository);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsInstanceOfType<ViewResult>(result);
        }

        [TestMethod]
        public async Task Test_Index_Return_Result()
        {
            //Arrange
            var controller = new HomeController(repository);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
