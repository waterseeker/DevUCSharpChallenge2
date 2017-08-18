using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpChallenge2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void additionButton_Click(object sender, EventArgs e)
        {
            string firstInputString = firstValueTextBox.Text;
            int parsedFirstInputString = int.Parse(firstInputString);

            string secondInputString = secondValueTextBox.Text;
            int parsedSecondInputString = int.Parse(secondInputString);

            int userSum = parsedFirstInputString + parsedSecondInputString;
            string userSumString = userSum.ToString();

            resultLabel.Text = userSumString;
        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            string firstInputString = firstValueTextBox.Text;
            int parsedFirstInputString = int.Parse(firstInputString);

            string secondInputString = secondValueTextBox.Text;
            int parsedSecondInputString = int.Parse(secondInputString);

            int userDifference = parsedFirstInputString - parsedSecondInputString;
            string userDifferenceString = userDifference.ToString();

            resultLabel.Text = userDifferenceString;
        }

        protected void multiplicationButton_Click(object sender, EventArgs e)
        {
            string firstInputString = firstValueTextBox.Text;
            int parsedFirstInputString = int.Parse(firstInputString);

            string secondInputString = secondValueTextBox.Text;
            int parsedSecondInputString = int.Parse(secondInputString);

            int userProduct = parsedFirstInputString * parsedSecondInputString;
            string userProductString = userProduct.ToString();

            resultLabel.Text = userProductString;
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            string firstInputString = firstValueTextBox.Text;
            int parsedFirstInputString = int.Parse(firstInputString);

            string secondInputString = secondValueTextBox.Text;
            int parsedSecondInputString = int.Parse(secondInputString);

            int userQuotient = parsedFirstInputString / parsedSecondInputString;
            string userQuotientString = userQuotient.ToString();

            resultLabel.Text = userQuotientString;
        }
    }
}