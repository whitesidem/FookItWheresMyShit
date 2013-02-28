using System;
using NUnit.Framework;
using OpenQA.Selenium;
using DRL.SeleniumBase;

namespace Specs.PageObjects
{
    class LendAnItemPage : SeleniumDriver
    {
        private static readonly IWebElement NameOfPersonField = I.TextField(id: "nameOfPerson");
        private static readonly IWebElement ItemDescriptionField = I.TextField(id: "itemDescription");
        private static readonly IWebElement OkayButton = I.Submit(id: "submit");
        private static readonly IWebElement ConfirmationMessage = I.Div(className: "confirm");

        public void Visit()
        {
            const string url = "http://fookitwheresmyshit";
            Visit(new Uri(url));
        }

        public void EnterItemDescription(string itemDescription)
        {
            ItemDescriptionField.SendKeys(itemDescription);
        }

        public void EnterNameOfPerson(string nameOfPerson)
        {
            NameOfPersonField.SendKeys(nameOfPerson);
        }

        public void ClickOkButton()
        {
            OkayButton.Click();
        }

        public void VerifyConfirmationMessageVisibility(bool isVisible)
        {
            Assert.That(ConfirmationMessage.Displayed);
        }
    }
}
