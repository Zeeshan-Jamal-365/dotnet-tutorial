// See https://aka.ms/new-console-template for more information
namespace project_7_linq_sql
{

    class Program
    {
        static void Main(string[] args)
        {


            List<Item> items = new List<Item>()
            {
                new Item{ItemId=1, ItemName="Pen" },
                new Item{ItemId=2, ItemName="Pencil" },
                new Item{ItemId=3, ItemName="Notebook" },
                new Item{ItemId=4, ItemName="Khata" },
                new Item{ItemId=5, ItemName="Eraser"  }
            };
            List<Customer> cust = new List<Customer>()
            {
                new Customer{CustomerId=1, CustomerName="Sumon",Area="Dhanmondi" },
                new Customer{CustomerId=2, CustomerName="Salhin",Area="Mirpur" },
                new Customer{CustomerId=3, CustomerName="Sagar",Area="Banani" },
                new Customer{CustomerId=4, CustomerName="Rabbi",Area="Dhanmondi" },
                new Customer{CustomerId=5, CustomerName="Jahid" ,Area="Mirpur" }
            };


            List<Orders> ord = new List<Orders>()
            {
                new Orders{OrderId=1,OrderDate =Convert.ToDateTime("2023-1-1"), CustomerId=1,ItemId =1,ItemRate =30, Quantity=10 },
                
                new Orders{OrderId=2,OrderDate =Convert.ToDateTime ("2023-2-2"), CustomerId=2,ItemId =2,ItemRate =20,Quantity=50 },
                new Orders{OrderId=3,OrderDate =Convert.ToDateTime ("2023-3-3"), CustomerId=3,ItemId =3,ItemRate =50,Quantity=15 },
                new Orders{OrderId=4,OrderDate =Convert.ToDateTime ("2023-4-4"), CustomerId=4,ItemId =4,ItemRate =40,Quantity= 60},
                new Orders{OrderId=5,OrderDate =Convert.ToDateTime ("2023-5-5"), CustomerId=5,ItemId =5,ItemRate =30,Quantity=80 }
            };

            //query1
            //var query1 = from c in cust 
            //             select c; 

            //foreach(Customer q in query1)
            //{
            //    Console.WriteLine("{0}  {1}   {2}",
            //    q.CustomerId, q.CustomerName,q.Area);
            //}

            //Console.WriteLine();

            ////query 2
            //var query2 = from c in cust
            //             where c.CustomerName=="Jahid" 
            //             select c;

            //foreach (Customer q in query2)
            //{
            //    Console.WriteLine("{0}  {1}   {2}",
            //    q.CustomerId, q.CustomerName, q.Area);
            //}


            //Console.WriteLine();
            ////query 3
            //var query3 = from c in cust
            //             where c.CustomerId == 3
            //             select new { c.CustomerId, c.CustomerName };

            //foreach (var q in query3)
            //{
            //    Console.WriteLine("{0}  {1}  ",
            //    q.CustomerId, q.CustomerName);
            //}

            //Console.WriteLine();
            //query 4
            //var query4 = from o in ord
            //             join c in cust
            //             on o.CustomerId equals c.CustomerId
            //             join i in items on o.ItemId equals i.ItemId
            //             select new
            //             {
            //                 o.OrderDate,
            //                 c.CustomerName,
            //                 i.ItemName,
            //                 o.ItemRate,
            //                 o.Quantity,
            //                 total = o.ItemRate * o.Quantity
            //             };

            //foreach (var f in query4)
            //{
            //    Console.WriteLine("{0}   {1}   {2}   {3}  {4}  {5}",
            //     f.OrderDate, f.CustomerName, f.ItemName, f.ItemRate, f.Quantity, f.total);
            //}
            //Console.WriteLine();

            ////query 5 
            var query5 = from o in ord
                         join c in cust
                         on o.CustomerId equals c.CustomerId
                         join i in items on o.ItemId equals i.ItemId
                         orderby c.CustomerName ascending
                         select new
                         {
                             o.OrderDate,
                             c.CustomerName,
                             i.ItemName,
                             o.ItemRate,
                             o.Quantity,
                             total = o.ItemRate * o.Quantity
                         };

            foreach (var f in query5)
            {
                Console.WriteLine("{0}   {1}   {2}   {3}  {4}  {5}",
                 f.OrderDate, f.CustomerName, f.ItemName, f.ItemRate, f.Quantity, f.total);
            }
            Console.WriteLine();
            ////query 6
            var q6 = from o in ord
                         join c in cust
                         on o.CustomerId equals c.CustomerId
                         join i in items on o.ItemId equals i.ItemId
                         orderby c.CustomerName descending
                         select new
                         {
                             o.OrderDate,
                             c.CustomerName,
                             i.ItemName,
                             o.ItemRate,
                             o.Quantity,
                             total = o.ItemRate * o.Quantity
                         };

            foreach (var f in q6)
            {
                Console.WriteLine("{0}   {1}   {2}   {3}  {4}  {5}",
                 f.OrderDate, f.CustomerName, f.ItemName, f.ItemRate, f.Quantity, f.total);
            }
            Console.WriteLine();

            ////query 7
            //var q7 = from c in cust
            //         where c.CustomerId == 3
            //         select c;

            //foreach (Customer q in q7)
            //{
            //    Console.WriteLine("{0}  {1}   {2}",
            //    q.CustomerId, q.CustomerName, q.Area);
            //}






        }
    }
}