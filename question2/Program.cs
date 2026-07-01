using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    public class DailyPurchase
    {
        public DateTime Date {  get; set; }
        public string Item { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity {  get; set; }
        public decimal TotalAmount => UnitPrice * Quantity;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DailyPurchase> purchases = new List<DailyPurchase>
            {
                new DailyPurchase { Date = DateTime.Parse("2016-07-03"), Item = "Pen", UnitPrice = 30, Quantity = 2 },
                new DailyPurchase { Date = DateTime.Parse("2016-07-09"), Item = "Travel Bag", UnitPrice = 350, Quantity = 1 },
                new DailyPurchase { Date = DateTime.Parse("2016-07-13"), Item = "Tooth paste", UnitPrice = 80, Quantity = 1 },
                new DailyPurchase { Date = DateTime.Parse("2016-07-22"), Item = "Pillow Cover", UnitPrice = 120, Quantity = 2 },
                new DailyPurchase { Date = DateTime.Parse("2016-07-27"), Item = "Coffee", UnitPrice = 210, Quantity = 1 }
            };

            //1
            var lastMonthExpenses = purchases
              .Where(p => p.Date.Month == 7 && p.Date.Year == 2016);
            foreach (var item in lastMonthExpenses)
            {
                Console.WriteLine($"Date: {item.Date:yyyy-MM-dd} | Item: {item.Item} | Total Cost: {item.TotalAmount}");
            }

            //2
            var mostExpensive = purchases
                .OrderByDescending(p => p.UnitPrice).FirstOrDefault();
            Console.WriteLine($"\nMost expensive product: {mostExpensive?.Item} at {mostExpensive?.UnitPrice}");
            //3
            var totalAmountLastMonth = lastMonthExpenses
                .Sum(p => p.UnitPrice * p.Quantity);
            Console.WriteLine($"\nTotal amount in last month: {totalAmountLastMonth}");


        }
    }
}
