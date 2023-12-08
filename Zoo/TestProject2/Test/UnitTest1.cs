using System.Reflection.Emit;
using System.Windows.Forms;

namespace TestProject2
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GetLionIncomeTest()
        {
            //arrange
            int expected = 100;

            //act
            WinFormsApp1.Lion lion =  new WinFormsApp1.Lion();
            int actual = lion.get_income();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetOutputAfterBuyAviary()
        {
            //arrange
            string expected = "Недостаточно средств";
            //string expected = "Куплен вальер площадью 200\n";

            //act
            WinFormsApp1.Zoo zoo = new WinFormsApp1.Zoo();
            zoo.set_money(100);
            int area = 200;
            System.Windows.Forms.Label place = new System.Windows.Forms.Label();
            System.Windows.Forms.ListBox listbox = new System.Windows.Forms.ListBox();
            zoo.buy_aviary(area, place, listbox);

            //assert
            Assert.AreEqual(place.Text, expected);
        }
    }
}