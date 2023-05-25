//string s = "";
//string dhaka = "dhaka";
//string[] cities=new string[10];
//int count = 0;
//while (s.ToLower() != dhaka)
//{
//    Console.WriteLine("enter a city");
//    s = Console.ReadLine();
//    s.ToLower();
//    cities[count] = s;
//    count++;
//}
//Console.WriteLine("number of attempts {0}", (count));
//foreach(string c in cities)
//{
//    Console.WriteLine(c);
////}
//int[] number = new int[5] { 10, 19, 10, 11, 112 };
//int[,] no = new int[3, 2] {
//    {12, 19 },
//    {20, 25 },
//    {23, 34 },
//};
////Console.WriteLine(no[1,1]);

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.Write(no[i,j]+" ");
//    }
//    Console.WriteLine();
//}


using System.Collections;

ArrayList city = new ArrayList();
string[] c = new string[3] { "Faridpur", "Jessore", "Narail" };
city.Add("Dhaka");
city.Add("Pabna");
city.Add("Khulna");

city.AddRange(c);
city.Insert(2, "Madaripur");
city.RemoveAt(2);
city.Add(8989);
foreach (var ct in city)
{
    Console.WriteLine(ct);
}
////id, name, address , phone, email, 2 arraylists 1st(id, name, address , phone, email) in loop, 2nd()
//ArrayList a1 = new ArrayList(){ "ID", "Name", "Address", "Email", "Phone" };
//ArrayList a2 = new ArrayList();

//for (int i = 0; i < a1.Count; i++)
//{
//    Console.WriteLine("Please enter {0}", a1[i]);
//    a2.Add(Console.ReadLine());
//}
//for (int i = 0; i < a2.Count; i++)
//{
//    Console.WriteLine("{0}:{1}", a1[i], a2[i]);
//}

//Queue q = new Queue();
//q.Enqueue("Dhaka");
//q.Enqueue("Pabna");
//q.Enqueue("Khulna");
//foreach (string x in q)
//{
//    Console.WriteLine(x);
//}
//Console.WriteLine();
//Stack s = new Stack();
//s.Push("Dhaka");
//s.Push("Pabna");
//s.Push("Khulna");

//foreach (string x in s)
//{
//    Console.WriteLine(x);
//}
//Console.WriteLine();
//Hashtable country = new Hashtable();

//country.Add("BD", "Bangladesh");
//country.Add("IN", "India");
//country.Add("PAK", "Pakistan");
//country.Add("USA", "United States of America");

//foreach (DictionaryEntry entry in country)
//{
//    Console.WriteLine("{0}:{1}", entry.Key, entry.Value);
//}

//Console.WriteLine();
//SortedList cty = new SortedList();

//cty.Add("BD", "Bangladesh");
//cty.Add("IN", "India");
//cty.Add("PAK", "Pakistan");
//cty.Add("USA", "United States of America");

//foreach (DictionaryEntry entry in cty)
//{
//    Console.WriteLine("{0}:{1}", entry.Key, entry.Value);
//}





