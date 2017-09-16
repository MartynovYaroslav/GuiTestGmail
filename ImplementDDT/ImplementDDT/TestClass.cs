using ImplementDDT.Pages;
using NUnit.Framework;
namespace ImplementDDT
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [TestFixture]
    public class TestClass : InitializeTest
    {

        [TestCase(0), Repeat(4)]
        public void AuthorisationUser(int numm)
        {
            numm++;

            new LandingPage().EnterLandingPage();

            new SignInGmail().PassLogin(numm);

            new SignInPassword().PassPassword(numm);
        }
    }
}

