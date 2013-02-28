using Specs.PageObjects;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    // ReSharper disable InconsistentNaming

    [Binding]
    public class LendAnItemSteps
    {
        private readonly LendAnItemPage _lendAnItemPage;

        public LendAnItemSteps()
        {
            _lendAnItemPage = new LendAnItemPage();
        }

        [Given(@"that I want to enter details of a loaned item")]
        public void GivenThatIWantToEnterDetailsOfALoanedItem()
        {
        }
        
        [Given(@"I have navigated to the page for entering loaned items")]
        public void GivenIHaveNavigatedToThePageForEnteringLoanedItems()
        {
            _lendAnItemPage.Visit();
        }
        
        [When(@"I enter item description as ""(.*)""")]
        public void WhenIEnterItemDescriptionAs(string itemDescription)
        {
            _lendAnItemPage.EnterItemDescription(itemDescription);
        }
        
        [When(@"I enter name of person as ""(.*)""")]
        public void WhenIEnterNameOfPersonAs(string nameOfPerson)
        {
            _lendAnItemPage.EnterNameOfPerson(nameOfPerson);
        }
        
        [When(@"I click on OK button")]
        public void WhenIClickOnOKButton()
        {
            _lendAnItemPage.ClickOkButton();
        }
        
        [Then(@"I see a submission confirmation message")]
        public void ThenISeeASubmissionConfirmationMessage()
        {
            _lendAnItemPage.VerifyConfirmationMessageVisibility(true);
        }
    }
}
