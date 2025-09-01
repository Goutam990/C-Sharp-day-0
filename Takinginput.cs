// =====================Taking input From users=========================
            // Console.ReadLine() is used to get input from the user. 
            
            Console.WriteLine("Enter Your Name Mahasaye :- ");
            string Name = Console.ReadLine();
            Console.WriteLine("You Entered :- " + Name);
            

            // ====================================================================
            // Note - Console.ReadLine(); -- returns a string. You cannot catch or receive it in  int D.T

            // Example 
            
            int yourAge = Console.ReadLine();   // Error -- string retured by ReadLine() method.But storing result in integer -- will through an error. 
            Console.WriteLine(yourAge);
            

            // ===========Fixing this  ===========================
            // 1. catching the result into string variable.
            // 2. using explicit type casting
            
            string yourAge = Console.ReadLine();   // Error -- string retured by ReadLine() method.But storing result in integer -- will through an error. 
            Console.WriteLine(yourAge);
            

            
            Console.WriteLine("Enter Your age:- ");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you entered : - " + yourAge);
            
            
