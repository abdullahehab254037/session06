using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //1-Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region question2
            //2-Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1,0]);


            #endregion
            #region question3
            //3-Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.
            //void printwelcome()
            //{
            //    Console.WriteLine("Welcome to the Library!");
            //}
            //printwelcome();

            #endregion
            #region question4
            //4-Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            //"Clean Code".
            //void PrintBookTitle(string title)
            //{
            //    Console.WriteLine("book title:" + title);
            //}
            //string title = "clean code";
            //PrintBookTitle(title);


            #endregion
            #region question5
            //5-Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?
            //void AddBonus(int pages)
            //{
            //    pages += 50;
            //}
            //int pages = 400;
            //AddBonus(pages);
            //Console.WriteLine(pages);
            //same value,because parameter is by value

            #endregion
            #region question6
            //6-Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?
            //void ApplyDiscount(double[]prices)
            //{
            //    prices[0] -= 5;
            //}
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            //the value will change, because array is automatic refrence type

            #endregion
            #region question7
            //7-Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?
            //void AddBonus( ref int pages)
            //{
            //    pages += 50;
            //}
            //int pages = 400;
            //AddBonus(ref pages);
            //Console.WriteLine(pages);
            //the value will change, because the parameter is by refrence 


            #endregion
        }
    }
}
