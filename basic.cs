using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // printing text to console
            // WriteLine() is a method of Console class . 
            // Console is a class under System namespace.
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Goutam_Tiwari");
            Console.WriteLine("Akki_Fighter");
            Console.WriteLine("Ajay_Devgan");

            // we can also print result of numeric data - example - sum
            Console.WriteLine(2 + 5);

            // Write() method --> similar to WriteLine(). 
            // diffrence is --> new line add nhi krta --> Write() ye method.
            Console.Write("Started Knowing about you C#");
            Console.Write(" Showing the use of Write() method --> not adding a new line");

            // Giving commands - similar to java

            Console.WriteLine();

            // Variable - A Container to hold some data
            // 1. int - Integer values only
            // 2. double - Storing floating point number --> decimal number
            // 3. char   - Stores single character. Such as 'a' , 'B' . 
            //   Important -- character hmesa single quotes m rhega.

            // 4.string   - stores text -- string values are surronded by double quotes
            // 5. bool    - stores values as "true" or "false"


            // --------------------------------------------------------
            // ==================Declaring Variable===================

            string name = "Goutam";
            Console.WriteLine(name);

            int num = 34;
            Console.WriteLine(num);

            char ch = 'a';
            Console.WriteLine(ch);

            char ch2 = 'A';
            Console.WriteLine(ch2);

            bool LieDetector = false;
            Console.WriteLine(LieDetector);

            // Similar to java.
            // also declare variable then assign value to it
            int firstNumber;   // only declare variable. 
            firstNumber = 2;
            Console.WriteLine(firstNumber);


            // Double  as a datatype
            double doubled_num = 22.4D;
            Console.WriteLine(doubled_num);

            // constant --- want to declare a fixed variable.. ( unchangeable and read-only:)
            // const int Pi = 3.14; // Error --> 3.14 is decimal value
            const double Pi = 3.14;   //3.14 is a decimal value , must be stored in double
            Console.WriteLine(Pi);

            // Showing variables values onto the screen directly.
            Console.WriteLine(3 + 2);

            // concatination operator  - (text + value)
            Console.WriteLine("Sum of two numbers- " + (3 + 5));

            // String concatenation
            string Company_firstName = "HomePage";
            string Company_lastName = "It Solution";
            Console.WriteLine(Company_firstName + " " + Company_lastName);


            //    As we know + operator in between integer value will act like mathematical additon operator
            // Console.WriteLine(3 + 5);


            // ==========================================
            // ===============Declaring multiple int in one line ====
            int x = 2, y = 3, z = 5;
            Console.WriteLine(x + y + z);

            // String Declarations in one line.
            string str1 = "My Name is", str2 = " Goutam Tiwari";
            Console.WriteLine(str1 + str2);

            // ========================
            // Revision --- Identifiers --- Names that given to any variable.
            // Identifiers -- could be short as (x,y) or Descriptive as (age,Name)
            // Descriptive names in order to create understandable code.
            int _Iam_a_Number = 34;
            Console.WriteLine(_Iam_a_Number);


            //    ===============================
            //    Naming conventions of a variable.
            // 1. C# allows us to start varible name with (_)underscore also.
            // 2. should start with small letter
            // 3. variable names are case sensitive --> myVar nd MyVar both are diff.
            // 4. As we know Keywords are the reserved words . 
            //   can not be given as a name to any variable.


            // Always try to give a meaningfull name 
            /*
            int m = 20;
            int minutes = 20;
            */
            // here both hold same value. but more descriptive name(minutes) provides more 
            // understanding of code.

            // =============================================
            // Integer type data ke liye --> int aur long (will depend on the value)
            // Decimal values            --> float aur double ()

            // numbers are int (for whole numbers) and double (for floating point numbers).

            // =================================================
            // when int is not large enough to store the value then long will be used. 

            // ================================================
            // float or double ke bech m precision matter krti h.
            // precision of float is only 6 or 7 decimal digits. whereas
            // precision of doublt is about 15 decimal digits.
            // Its safer to use double 

            // ================================================




        }
    }
}


// 1. C# is similar to java . 
        //    using System;   // sabse upar hona chahiye
// 2.  C# ke har statement ke end mein semicolon lagana zaroori h.
// 3.  C# case-sensitive h, matlab "MyClass" aur "myclass" alag alag maayne rakhte h. Mujhe  capitalization ka dhyaan rakhna padega.
// 4. C# -> jaruri nhi ki class ka name aur file ka name match hona jaruri nhi h.lekin
//          better organize krne ke liye match kr skte ho names
// 5. "using System" likhne se m System namespace ke andar jo classes h unhe use kar sakte hu
//         apne code m. 
//         Yeh bahut zaroori classes provide karta h basic operations ke liye.
// 6.  khali line se C# ko koi fark nahi padta
// 7. "namespace" mere code ko organize karne ke liye use hota h.
//     Yeh ek container ki tarah kaam karta h jiske andar m
//     classes aur doosre namespaces ko rakh sakte hain.
//     Isse code organized rehta h aur naming conflicts bhi nahi hote.
// 8. {} curly braces --> code ke ek block ki shuruaat aur end ko dikhayega.
// 9. "class" ek container ki tarah kaam karti h jisme m data aur methods rakh sakte hu.
//      Methods mere program ko functionality provide krti h. 
//      C# m har line of code kisi na kisi class ke andar hi hona chahiye. 
// 10. ek "Main" method hmesa hota h . "Main" method ke andr curly braces ka code
//     execute hota h. 
// 11. "Console" ek class h System namespace ki. 
//  Isme ek "WriteLine()" method hota hai, jo text ko output ya print karne ke liye use hota hai. 
// Hamare example m, yeh "Hello World!" print karega.
// 12. "using System" code m include krne s / likhne s mujhe br br "System." nhi likhna padhta 
//      direct Console.WriteLine() likh skta hu text ko print krne ke liye
// 13. C# code save karte h, toh file ka naam aap apni pasand se rakh sakte h,
//     bas uske end mein ".cs" lagana zaroori h. Java ki tarah, file ka naam class ke naam jaisa hona zaroori nhi h. 

// Note:- Top-level statements aur traditional M method ek hi project/file me mix nhi karne.
// Dono valid h, bas ek choose karna h.