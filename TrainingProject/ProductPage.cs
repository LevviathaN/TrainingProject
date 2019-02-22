using System;
namespace TrainingProject
{
    public class ProductPage
    {
        //Class attributes
        private string btnLocator = "/some/btn/locator";

        //Class methods
        public void clickOnBtn()
        {
            Console.WriteLine("Clicking on button, located by: " + btnLocator);
        }
    }
}
