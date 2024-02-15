namespace Dars_TryCatch_Delegate
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int EnrollNumber { get; set; }
    }
    public class Program
    {
        public delegate void Feedback(string message);

        // public delegate TResult MyDelegate<T, TResult>(T value);

        public static void Main(string[] args)
        {
            Feedback feedback = new Feedback(FeedbackToConsole);
            feedback.Invoke("Salom hammaga!");
        }
        public static void FeedbackToConsole(string message)
        {
            Console.WriteLine(message); // => feedback("Salom hammaga!"); ConvertCharArrayToString
        }

        //public static int Increment(int arg)
        //{
        //    return ++arg;
        //}

        //MyDelegate<int, int> myDelegate = new MyDelegate<int, int>(Increment);
        //Console.WriteLine(myDelegate(1));

        //List<Student> students = new()
        //{
        //    new() { Age = 24, Name = "Sevinch", EnrollNumber = 2000 },
        //    new() { Age = 26, Name = "Akbarali", EnrollNumber = 1998},
        //};

        //Func<Student, string> stdNam = student => student.Name;
        //IEnumerable<string> studentsNames = students.Select(stdNam);

        //foreach(var name in studentsNames)
        //{
        //    Console.WriteLine(name);
        //}

        //Action<Student> studentAction = student => Console.WriteLine(student.Name);

        //students.ForEach(studentAction);

        //Predicate<Student> isAdult = student => student.Age > 18;

        //List<Student> adultStudents = students.FindAll(isAdult);

        //foreach(var student in adultStudents)
        //{
        //    Console.WriteLine(Student.Age);
        //}

    }
}


/*
 * Agar bu holatda int yoki dcimal tipdagi qiymat 0 ga bo'linadigan bo'lsa,
 * catch bloki ishga tushadi. Aks holda, try blokidan tashqari chiqmaydi.
 */

//  try
//  {
//     int i = 22;
//     int result = i / 1;

//     Console.WriteLine(result);
//  }
//  catch(DivideByZeroException ex)
//  {
//         Console.WriteLine("You cannot divide number with zero", ex.Message);
//  }

//// Bu holatda dastur o'zi istisno otib yuboradi.
// int i = 22;
// int result = i / 0;
// Console.WriteLine(result);

//int n = int.MaxValue;
//int m = int.MaxValue;
//int p = n + m;

///*
// * 1 - logikada, NullReferenceException chiqaradi.
// * 2 - logikada, 2 - catch bloki ishga tushadi.
// * 3 - logikada, 3 - catch bloki ishga tushadi.
// *\

//try
//{
//    // 1 - logika
//    string mystring = default; // string.Empty => ""
//    mystring.Insert(0, "hello");

//    // 2 - logika
//    int i = 20;
//    int j = 0;
//    double result = DivideNumber(i, j);

//    // 3 - logika 
//    object obj = 0.1;
//    int i2 = (int)obj;
//    // Suspect of casting error
//}
// catch (StackOverflowExceptionex)
// {
//      Console.WriteLine("Overflow. {0}", ex.Message);
// }
// catch (DivideByZeroException ex)
// {
//      Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
// }
// catch (InvalidCastException ex)
// {
//      Console.WriteLine("Invalid casting. {0}", ex.Message);  
// }
// catch (Exception ex)
// {
//      Console.WriteLine("General exception. {0}", ex.Message);
// }  

// ststic int DivideNumber(int num1, int num2)
// {
//      if (num1 < num2)
//          num1 += 20;
//      return num1 / num2;
// }