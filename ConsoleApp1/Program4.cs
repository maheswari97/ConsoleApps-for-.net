using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program4
    {
      //  public static void Main(string[] args)
      //  {
      //      phone ph= new phone();
      //      // Console.WriteLine( ph.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
      //      // Console.WriteLine(ph.ConsecutiveDucks(9));
      //     // Console.WriteLine(ph.InviteMoreWomen(new int[] { 1, -1,1 }));




      //      var items = new List<Item> {
      //    new Item { Quantity = 10, UnitPrice = 100m, UnitMargin = 1m },
      //    new Item { Quantity = 10, UnitPrice = 110m, UnitMargin = 1.1m }
      //};
      //      Quoter q1 = new Quoter(items);
      //      Console.WriteLine(q1.GetQuote(10));
      //  }
    }
    public class phone
    {
        public  string CreatePhoneNumber(int[] numbers)
        {
            string res = string.Empty;
           

            
                res = "(" + numbers[0].ToString() + numbers[1].ToString() + numbers[2].ToString() + ")";
                res = res + " " + numbers[3].ToString() + numbers[4].ToString() + numbers[5].ToString() + "-";
                res = res + numbers[6].ToString() + numbers[7].ToString() + numbers[8].ToString() + numbers[9].ToString();


           return long.Parse( string.Concat(numbers)).ToString("000-000-0000");
            

           // return res;

        }

        public bool ConsecutiveDucks(int n)
        {

            return (((n & (n - 1)) != 0) && n != 0);
        }
        public bool InviteMoreWomen(int[] L)
        {
            //coding and coding..


            return L.Sum() > 0;

        }
    }

    public class Item: IComparable<Item>
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitMargin { get; set; }

        public int CompareTo(Item item)
        {
            
            if(this.UnitMargin<item.UnitMargin) return 1;
            if (this.UnitMargin > item.UnitMargin) return -1; return 0;
        }
    }

    public class Quoter
    {
        private List<Item> Items { get; set; }

        public Quoter(List<Item> items)
        {
            this.Items = items;
        }

        public string GetQuote(int quantity)
        {
            decimal total = 0;
            int SaveQunatity = quantity;
            if (Items.Count > 0)
            {
               // Items.Sort();
                Items.Sort((x, y) => y.UnitMargin.CompareTo(x.UnitMargin));
               // Items.Sort((x, y) => x.Quantity.CompareTo(y.Quantity));
                foreach (Item item in Items)
                {
                    if (quantity <= item.Quantity)
                    {
                        total += quantity * item.UnitPrice;
                        return "Your best quote for " + SaveQunatity + " items is " + total+".00";
                    }
                    else if (quantity >= item.Quantity)
                    {
                        total += item.Quantity * item.UnitPrice;
                        quantity = quantity - item.Quantity;
                    }
                }
                return "Your order cannot be fulfilled, try lower quantity";

            }
            else
                return "Your order cannot be fulfilled, try lower quantity";
            
        }
    }


    public class BooleanExclusive
    {
        public bool Disjunction(bool[] operands, bool isExclusive = false)
        {

            bool Res=true ;

            for(int i=0;i<operands.Length;i++)
            {
                if (i == 0)
                    Res = operands[i];
                else
                {
                    if (isExclusive)
                        Res = Res || operands[i];
                    else
                        Res = Res ^ operands[i];
                }
            }

            return Res;
            // TODO Write Disjunction method

        }
    }
}
