using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string str = "select * from ipl.csv where season > 2014 and city = 'Bangalore'";

            string[] expected = new string[] {
            "select","*", "from" ,"ipl.csv","where" ,"season" ,">","2014","and","city","=","'Bangalore'" };
            ClassLibrary1.Class1 x = new ClassLibrary1.Class1();
            string[] actual = x.Task1("select * from ipl.csv where season > 2014 and city = 'Bangalore'");
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Test2()
        {
            string str = "select * from ipl.csv where season > 2014 and city = 'Bangalore'";

           
            string expected = "ipl.csv";
            ClassLibrary1.Class1 x = new ClassLibrary1.Class1();
            string actual = x.Task2("select * from ipl.csv where season > 2014 and city = 'Bangalore'");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            string str = "select * from ipl.csv where season > 2014 and city = 'Bangalore'";

            string expected = "select * from ipl.csv";
           
            ClassLibrary1.Class1 x = new ClassLibrary1.Class1();
            string actual = x.Task3("select * from ipl.csv where season > 2014 and city = 'Bangalore'");
            Assert.Equal(expected, actual);
        }
    }
}
