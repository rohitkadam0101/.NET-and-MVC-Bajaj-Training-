// See https://aka.ms/new-console-template for more information
class Program
{
    static bool checkPalindrome(string s)
    {
        string revs = "";
        for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
        {
            revs += s[i].ToString();
        }
        if (revs == s) // Checking whether string is palindrome or not  
        {
            return true;
        }
        else
        {
            return false;
        }
        return false;
    }
    public static void Main(String[] args)
    {
        string[] names = { "Iron Man", "SuperMan", "Vision" };
        string temp = "Hello World";
        Console.WriteLine(temp[0..3]); // 0 to 2 (3 is exclusive)
        Console.WriteLine(temp[^1]); // len -1   
        Console.WriteLine(temp[^4 .. ^3]); //len-4 len -3
        string[] newArray = names[^3 ..^2];
        foreach(string i in newArray)
        {
            Console.WriteLine(i);
        }

        // Null Colescing 
        string? t = null;
        t ??= "Hello"; // As t is null so it is assigned as Hello
        Console.WriteLine(t);
        t ??= "Hello World"; // As t is not null it will be Hello only not Hello World
        Console.WriteLine(t);

        // First Case Study
        // 5 Users along with name,email and phone
        string[,] jacob = new string[5, 3];
        for(int i = 0; i < 5; i++)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            jacob[i, 0] = name;
            jacob[i, 1] = phone;
            jacob[i,2] = email;
        }
        for(int i = 0; i < jacob.GetLength(0); i++)
        {
            for(int j = 0; j < jacob.GetLength(1); j++)
            {
                Console.WriteLine(jacob[i, j]);
            }
        }

        // Second Case study
        string[] array2 = new string[5];
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter String in array: ");
            string entered = Console.ReadLine();
            if (entered.Length >= 3)
            {
                array2[i] = entered;
            }
            if (checkPalindrome(entered))
            {
                Console.WriteLine(entered + "is palindrome");
            }
      
        }
        Array.Sort(array2);
        for(int i = 0; i <= array2.Length - 1; i++)
            {
            for (int j = i + 1; j < array2.Length; j++)
            {
                if (string.Compare(array2[i], array2[j]) > 0)
                {
                    temp = array2[i];
                    array2[i] = array2[j];
                    array2[j] = temp;
                }
            }
        }
        foreach (string s in array2)
        {
            Console.WriteLine(s);
        }


    }
}
