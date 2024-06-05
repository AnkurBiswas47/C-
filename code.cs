namespace ye
{

    public class Code
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            String Email = Convert.ToString(Console.ReadLine());
            Console.WriteLine(emailValidation(Email));
        }

        public static string emailValidation(string eMail)

        {
            if (!char.IsDigit(eMail[0]) && eMail.Contains("@") && eMail.EndsWith(".com"))
            {

                return "Email validation sucessful";
            }
            else
            {
                if (char.IsDigit(eMail[0]))
                {
                    Console.WriteLine("Please start your email with an alphabate");
                } else if (!eMail.Contains("@"))
                {
                    Console.WriteLine("Please add @ in your email");
                } else if (!eMail.EndsWith(".com"))
                {
                    Console.WriteLine($"Please put {".com"} at the end of your email.");
                }
                
                return "Email validation failed";
            }
        }
    }
}