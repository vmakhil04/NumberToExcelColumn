class Program  
    {  
              public static String reverse(String input)
        {
            char[] reversedString = input.ToCharArray();
            Array.Reverse(reversedString);
            return new String(reversedString);
        }
         private static void printString(int columnNumber)
        {

            // To store result (Excel column name)
            String columnName = "";

            while (columnNumber > 0)
            {

                // Find remainder
                int rem = columnNumber % 26;

                // If remainder is 0, then a
                // 'Z' must be there in output
                if (rem == 0)
                {
                    columnName += "Z";
                    columnNumber = (columnNumber / 26) - 1;
                }

                // If remainder is non-zero
                else
                {
                    columnName += (char)((rem - 1) + 'A');
                    columnNumber = columnNumber / 26;
                }
            }

            // Reverse the string
            columnName = reverse(columnName);

            // Print result
            Console.WriteLine("Excel Column Name :" + columnName.ToString());
        }
        static void Main(string[] args)  
        {  
            int Number1;  
            Console.WriteLine("please enter the Number");  
            Number1 = Convert.ToInt32(Console.ReadLine());
            printString(Number1);   
        }  
    }  
