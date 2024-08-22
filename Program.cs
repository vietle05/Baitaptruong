namespace BaitapOperatorsBuoi3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //baitap01();
            //baitap02();
            //baitap03();
            //baitap04();
            baitap05();
        }
        static void baitap01()
        {
            Console.WriteLine("Nhap so a");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap so b");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("a / b =" + (a / b));
            Console.WriteLine("a * b =" + (a * b));
            Console.WriteLine("a + b =" + (a + b));
            Console.WriteLine("a - b =" + (a - b));
        }
        static void baitap02()
        {
            for (int y = 0; y < 10; y++)

            {
                Console.WriteLine($"The certain value of the function x = y*y + 2*y + 1 when y = {y} la x = " + ((Math.Pow(y, 2) + 2 * y + 1)));
            }
        }
        static void baitap03()
        {
            Console.WriteLine("Enter the  distance, if you enter in km, choose 1 else in miles you choose 2");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t == 1)
            {
                Console.WriteLine("Enter distance in km");
                float s = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter time in turn in hours, minutes, seconds");
                float a = Convert.ToSingle(Console.ReadLine());
                float b = Convert.ToSingle(Console.ReadLine());
                float c = Convert.ToSingle(Console.ReadLine());
                b = b / 60;
                c = c / 3600;
                float miles = s * 0.62f;
                Console.WriteLine($"Speed in km/h is {Math.Round(s / (a + b + c),2)} and in miles/h is {miles / (a + b + c)}");
            }
            if (t == 2)
            {
                Console.WriteLine("Enter distance in miles");
                float miles = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter time in turn in hours, minutes, seconds");
                float a = Convert.ToSingle(Console.ReadLine());
                float b = Convert.ToSingle(Console.ReadLine());
                float c = Convert.ToSingle(Console.ReadLine());
                b = b / 60;
                c = c / 3600;
                float s = miles * 1.6f;
                Console.WriteLine($"Speed in km/h is {Math.Round(s / (a + b + c),2)} and in miles/h is {miles / (a + b + c)}");
            }




        }
        static void baitap04()
        {
            Console.WriteLine("Enter Radius of sphere");
            float R = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Suface of Sphere is{4*Math.PI*Math.Pow(R,2)} and volume of sphere is {4/3 * Math.PI * Math.Pow(R,3)}");
        }
        static void baitap05()
        {
            
            Console.WriteLine("Input the Symbol");
           char symbol = Convert.ToChar(Console.ReadLine());
            if ((symbol == 'u') || (symbol == 'e') || (symbol == 'o') || (symbol == 'a') || (symbol == 'i'))
            {
                Console.WriteLine("IT IS A VOWEL");
            }
            else if ((symbol >= '0') && (symbol <= '9'))
                {
                Console.WriteLine("IT IS A DIGIT");
            }
            else {
                Console.WriteLine("other symbol");
            }
        }
    }
}
