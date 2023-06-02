
//1.which of the following keyword is used for including the namespaces in in the program in C#? A. Import B. Using

//2.which of the following converts a type to a string in C#? A. ToString B. ToInt32

//3.which of the following operator represents a conditional operation in C#? A. = B. ?

//4. What is a correct syntax to output "Hello world" in C#? A. Console B. Print

//5. C# is an aias of C++ A. True B. False


using System.Collections;

//string[] q =
//{
//    "1.which of the following keyword is used for including the namespaces in in the program in C#? A. Import B. Using",
//    "2.which of the following converts a type to a string in C#? A. ToString B. ToInt32",
//    "3.which of the following operator represents a conditional operation in C#? A. = B. ?" ,
//    "4. What is a correct syntax to output 'Hello world' in C#? A. Console B. Print" ,
//    "5. C# is an aias of C++ A. True B. False"
//};



//foreach (string s in q)
//{
//    Console.WriteLine(s);

//}


namespace quiz_problem
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Q_A> list = new List<Q_A>()
            {
                new Q_A{questions="1.which of the following keyword is used for including the namespaces in in the program in C#? A. Import B. Using",answers="B" },
                new Q_A{questions="2.which of the following converts a type to a string in C#? A. ToString B. ToInt32",answers="A" },
                new Q_A{questions="3.which of the following operator represents a conditional operation in C#? A. = B. ?",answers="A" },
                new Q_A{questions= "4. What is a correct syntax to output 'Hello world' in C#? A. Console.Writeline() B. Print",answers="A" },
                new Q_A{questions="5. C# is an aias of C++ A. True B. False",answers="A" }
            };

            //string[] yourans = new string[100];
            int point = 0;


            //yourans[i] = Console.ReadLine();
            foreach (Q_A q in list)
            {
                Console.WriteLine(q.questions);
                q.yourans = Console.ReadLine();

                if (q.yourans == q.answers)
                {
                    point += 10;
                }
                else
                {
                    point += 0;
                }
            }
            foreach (Q_A q in list)
            {
                Console.WriteLine(q.questions+" "+q.yourans+" "+q.answers); 
            }








        }




    }
}
