using Lesson_practice.Models;
using System;

namespace Lesson_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Implicit
            //Dollar dollar = new Dollar(99);
            //Manat manat = dollar;

            //Console.WriteLine(manat.Azn);


            //Manat manat = new Manat(100);

            //Dollar dollar = manat;

            //Console.WriteLine(dollar.Usd);

            //DateTime date = DateTime.Now;
            //Console.WriteLine(date);
            #endregion

            #region Generic list
            //StringList list = new StringList();

            //list.Add("Goshgar");
            //list.Add("Goshgar2");
            //list.Add("Goshgar3");

            //list.GetAll();

            //IntList ages = new IntList();

            //ages.Add(29);
            //ages.Add(30);
            //ages.Add(31);

            //ages.GetAll();
            //BookList books = new BookList();

            //books.Add(new Book {Name = "Kitab" });
            //books.Add(new Book { Name = "Kitab1" });
            //books.Add(new Book { Name = "Kitab3" });

            //books.GetAll();


            //DataList<int> ages = new DataList<int>();

            //ages.Add(29);
            //ages.Add(30);
            //ages.Add(31);

            //ages.GetAll();

            //DataList<string> list = new DataList<string>();

            //list.Add("Goshgar");
            //list.Add("Goshgar2");
            //list.Add("Goshgar3");

            //list.GetAll();

            //DataList<bool> married = new DataList<bool>();

            //married.Add(true);
            //married.Add(true);
            //married.Add(false);

            //married.GetAll();
            #endregion

            //Repository<int> number = new Repository<int>();

            //Repository<double> number1 = new Repository<double>();

            //Repository<string> number2 = new Repository<string>();

            //Repository<Student> student = new Repository<Student>();

            //Repository<Employee> employee = new Repository<Employee >();

            //Repository<Student, Common> student1 = new Repository<Student, Common>();

            //Repository<Employee, Common> employee1 = new Repository<Employee, Common>();


            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddDays(10);

            //Console.WriteLine($"Start date : {start} - End date : {end} ");

            GetProductsByDate(start, end, 1500);

        }
        public static void GetProductsByDate(DateTime start, DateTime end, double price)
        {



            if ((start > end) && price > 1000)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

    }

  


    public class DataList<T>
    {
        private T[] _datas;

        public DataList()
        {
            _datas = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }

        public void GetAll()
        {
            //for (int i = 0; i <_datas.Length; i++)
            //{
            //    Console.WriteLine(_datas[i]);
            //}

            foreach (var item in _datas)
            {
                Console.WriteLine(item);
            }


        }

    }





    public class StringList
    {
        private string[] _arr;

        public StringList()
        {
            _arr = new string[0];
        }

        public void Add(string str)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = str;

        }

        public void GetAll()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine(_arr[i]);

            }
        }


    }

    public class IntList
    {
        private int[] _arr;

        public IntList()
        {
            _arr = new int[0];
        }

        public void Add(int num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = num;

        }

        public void GetAll()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine(_arr[i]);

            }
        }
    }


    public class BookList
    {
        private Book[] _arr;

        public BookList()
        {
            _arr = new Book[0];
        }

        public void Add(Book book)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = book;

        }

        public void GetAll()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine(_arr[i].Name);

            }
        }


    }





    public class Dollar
    {
        public double Usd { get; set; }

        public Dollar(double usd)
        {
            Usd = usd;
        }

        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.Usd * 1.7);
        }
    }
    public class Manat
    {
        public double Azn { get; set; }

        public Manat(double azn)
        {
            Azn = azn;
        }

        public static implicit operator Dollar(Manat manat)
        {
            //Dollar dollar = new Dollar(manat.Azn / 1.7);
            return new Dollar(manat.Azn / 1.7);
        }
    }


}
