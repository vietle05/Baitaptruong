
namespace baitapbuoi1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            baitap01();
            baitap02();
            baitap03();
            baitap04();
            baitap05();
            baitap06();
            baitap08();
            baitap09();
            baitap10();


        }



        static void baitap01()
        {
            Console.WriteLine("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("Tong cua a va b la: " + sum);
        }
        static void baitap02()
        {
            Console.WriteLine("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Sau khi hoan doi:");
            Console.WriteLine("Gia tri cua a: " + a);
            Console.WriteLine("Gia tri cua b: " + b);
        }
        static void baitap03()
        {
            Console.WriteLine("Nhap so a");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap so b");
            float b = Convert.ToSingle(Console.ReadLine());
            float muti = a * b;
            Console.WriteLine("Tích cua {0} và {1} là: {2}", a, b, muti);


        }
        static void baitap04()
        {
            Console.Write("Nhập số feet: ");
            float feet = Convert.ToSingle(Console.ReadLine());


            float meters = feet * 0.3048f;


            Console.WriteLine("{0} feet bằng {1} meters", feet, meters);
        }
        static void baitap05()
        {
            Console.WriteLine("Chọn chế độ chuyển đổi:");
            Console.WriteLine("1. Celsius sang Fahrenheit");
            Console.WriteLine("2. Fahrenheit sang Celsius");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Nhập nhiệt độ Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = CelsiusToFahrenheit(celsius);
                Console.WriteLine($"{celsius}°C bằng {fahrenheit}°F");
            }
            else if (choice == 2)
            {
                Console.Write("Nhập nhiệt độ Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"{fahrenheit}°F bằng {celsius}°C");
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
            }
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static void baitap06()
        {
            {
                Console.WriteLine("Kích thước của int: " + sizeof(int) + " bytes");
                Console.WriteLine("Kích thước của float: " + sizeof(float) + " bytes");
                Console.WriteLine("Kích thước của double: " + sizeof(double) + " bytes");
                Console.WriteLine("Kích thước của char: " + sizeof(char) + " bytes");
            }

        }
        static void baitap08()
        {
            Console.WriteLine("Ban kinh hinh tron la");
            float r = Convert.ToSingle(Console.ReadLine());
            const float PI = 3.14f;
            double s = PI * r * r;
            Console.WriteLine("Dien tich hinh tron la" + s);
        }
        static void baitap09()
        {
            Console.WriteLine("Chieu dai canh hinh vuong");
            float a = Convert.ToSingle(Console.ReadLine());

            double area = a * a;
            Console.WriteLine("Dien tich hinh vuong la" + area);
        }
        static void baitap10()
        {
            int ndays, year, week, days;
            const int DAYS_IN_WEEK = 7;
            const int DAYS_IN_YEAR = 365;

            Console.WriteLine("Nhap so ngay:");
            ndays = int.Parse(Console.ReadLine());

            year = ndays / DAYS_IN_YEAR;
            week = (ndays % DAYS_IN_YEAR) / DAYS_IN_WEEK;
            days = (ndays % DAYS_IN_YEAR) % DAYS_IN_WEEK;

            Console.WriteLine("{0} ngay tuong duong voi {1} nam, {2} tuan và {3} ngay", ndays, year, week, days);


        }
    }
}
