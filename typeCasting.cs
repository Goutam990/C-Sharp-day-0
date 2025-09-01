
            // ================================================
            // Type Casting 
            // 1. implicit Casting -- automatically coverts larger to smaller size type. 
            // 2. explicit Casting -- manually coverting datatypes
            //   by writing the datatype in parenthesis.


            // Implicit TypeCasting - Automatically converting smaller to larger DT.
            int integerValue = 5;
            double doubledValue = integerValue;  //automatically converts int to double.

            //  parenthesis m likhne ki jarurt nhi type ko 
            Console.WriteLine(doubledValue);




            // Explicit TypeCasting - Manually converting larger DT to smaller DT.(double to int)
            double x01 = 2.34;
            int x02 = (int)x01;

            Console.WriteLine("Before Type Casting:- " + x01);
            Console.WriteLine("After Type Casting double to int:- " + x02);

            //    =====================Build-in methods - for TypeCasting=======================
            // Convert.ToBoolean, Convert.ToDouble, Convert.ToString, 

            int n1 = 1;
            Console.WriteLine(Convert.ToBoolean(n1));
            Console.WriteLine(Convert.ToString(n1));
            Console.WriteLine(Convert.ToInt32(n1));


            //    Coverting boolean to string
            bool Marital_status = false;
            Console.WriteLine("Before converting bool to stirng - " + Marital_status);
            Console.WriteLine("converting Bool to string - " + Convert.ToString(Marital_status));
            
            
            