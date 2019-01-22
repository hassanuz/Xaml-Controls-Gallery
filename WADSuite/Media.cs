using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;

namespace UWPControls
{
    [TestClass]
    public class Media : Test_Base
    {
        private static WindowsElement mediaElement1 = null;
        private static WindowsElement mediaElement2 = null;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
            //NavigateTo("Selection and picker controls", "RadioButton");

            var buttonTab = session.FindElementByName("Media");
            buttonTab.Click();
            var button = session.FindElementByName("MediaElement");
            button.Click();
            Thread.Sleep(1500);
            var mediaElements = session.FindElementsByClassName("MediaElement");
            Assert.IsTrue(mediaElements.Count >= 2);
            mediaElement1 = mediaElements[0];
            mediaElement2 = mediaElements[1];
            Assert.IsNotNull(mediaElement1);
            Assert.IsNotNull(mediaElement2);
            Thread.Sleep(1500);

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }

        [TestMethod]
        [Priority(0)]
        public void PlayMedia()
        {
            WindowsElement play = session.FindElementByAccessibilityId("PlayPauseButton");
            Assert.IsNotNull(play);
            Assert.IsNotNull(session.FindElementByAccessibilityId("svPanel"));
            play.Click();
            Thread.Sleep(1000);

        }
        [TestMethod]
        [Priority(1)]
        public void FullWindow()
        {
            WindowsElement fullWindow = session.FindElementByAccessibilityId("FullWindowButton");
            Assert.IsNotNull(fullWindow);
            fullWindow.Click();
            Thread.Sleep(2000);
            Assert.IsNotNull(session.FindElementByClassName("FullWindowMedia"));
            fullWindow.Click();
            Thread.Sleep(2000);
        }
    }


   
    [TestClass]
    public class PersonPicture : Test_Base
    {
        private static WindowsElement mediaElement1 = null;
        private static WindowsElement mediaElement2 = null;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
            //NavigateTo("Selection and picker controls", "RadioButton");

            var buttonTab = session.FindElementByName("Media");
            buttonTab.Click();
            var button = session.FindElementByName("PersonPicture");
            button.Click();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }

        [TestMethod]
        [Priority(0)]
        public void PlayMedia()
        {

        //    var button = session.FindElementByName("PersonPicture");

        }

    }
    
}
