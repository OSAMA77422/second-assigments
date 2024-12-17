namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region format
            ////string format
            ////1- string concat
            //int x = 1, y = 2;
            ////string Sum = x + " " + "+" + " " + y + " " + "equal" + (x + y);
            ////Console.WriteLine(Sum);
            ////issue here that take alot of memory each single string among (+) treat as single string object and even after concat them
            ////2- built in method (format)
            //string test = String.Format("{0} + {1} = {2}", x, y, x + y);
            //Console.WriteLine(test);
            ////treat all string as one object
            ////3 - interpolation
            #endregion

            #region control
            //1- conditonal and loop statmenet
            //check in if statment is linear check, check line by line untill find the true if stament
            //check in switch stament is by build hash table so only jump on right statment
            //switch cant use with logcoal operator
            //string input = Console.ReadLine();
            //switch (input)
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine("HI AHHMED");
            //        break;
            //    case "Omar":
            //    case "omar":
            //        Console.WriteLine("hi omar");
            //        break;
            //}
            //after case in switch must be constant to just create one hash or jump table 
            //evoulation in c# switch ==> 1- MATCHING batteren feature
            //object obj;
            //obj = 1;
            //obj = "ahmed";
            //switch (obj)
            //{
            //    case int x when x < 2: //==> when use to make condition
            //        Console.WriteLine("INT");
            //        break;
            //    case String x when x.Length > 3:
            //        obj = 3;
            //        Console.WriteLine(obj);
            //        break;
            //}

            //syntax sugar feature in c# 8 remove case and break
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(x switch { { x: > 0 }  => $"love u", 1 => 2, 2 => -3, _ => "not excit"});
            //object x;
            //x = 3;
            //Console.WriteLine(
            //    x switch
            //    {
            //        int => "love u",   // x > 0
            //        char => "2",          // x == 1
            //        double => "-3",         // x == 2
            //        _ => "not excit"   // Default case for any other input
            //    }
            // foreach loop is for collection doesnt have index and only used to iterate along any container
            //do while operate code then check and while loop check then operate code

            #endregion

            #region string
            ////reference type
            //String x; //create reference in stack will hold address of object in heap
            //x = new string("AHMESD"); //==> alocate for object in heap, operate constructor, assign address to reference in stack, make reference refer to first char address
            //Console.WriteLine(x);
            //Console.WriteLine(x.GetHashCode());
            ////string is immutable type so cant change his value after creation so if i edit string it will create new string
            //x = "osama";
            //Console.WriteLine(x);
            //Console.WriteLine(x.GetHashCode());


            #endregion

        }

   
    }
}
