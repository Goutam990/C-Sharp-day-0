// ===================================
            // String Interpolation
            // just like js -- to use varible value within a string .. we use string interpolation. 

            // $ (doller) symbol string ki starting m 
            // then double quotes ke andr jaha bhi value access krni h vha variable ke name likhdo {} ke andr. 

            string first_name = "Goutam";
            string second_name = "Tiwari";

            string Full_name = $"My full name is : {first_name} {second_name}";
            Console.WriteLine(Full_name);

            // ===========================================================
            // Accessing the strings
            // indexing starts from 0 
            string str5 = "MyNameIsTiwariji";
            Console.Write(str5[0]);
            Console.Write(str5[1]);

            Console.WriteLine();
            // IndexOf() method - to find the index position of a specific character.
            // stringkaname.IndexOf(passthecharacter);

            string str6 = "Lucifer";
            Console.WriteLine(str6.IndexOf('L'));
            Console.WriteLine(str6.IndexOf('u'));

            // ===============================================================
            Console.WriteLine();

