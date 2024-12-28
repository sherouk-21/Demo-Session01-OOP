namespace Demo_Session01
{
    enum gender:int
    {
        Male=1, Femala=2,

    }
    enum Days
    {
        Saturday=10, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
    }
    enum Grades
    {
        A,B,C,D,F
    }
    enum Branches:byte // 0:255
    {
        NasrCity,Maddi=251,Alex,Dokki,Enhass,SmartVillage
    } 
    internal class Program
    {
        public static void DoSomeCode()
        {
            try
            {
                int x, y, z;
                x = int.Parse(Console.ReadLine());//formateException
                y = int.Parse(Console.ReadLine());
                z = x / y;//dived by zero Exception
                int[] Numbers = { 1, 2, 3 };
                Numbers[10] = 100; //IndexOutOfRangeException
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //log in file
                //store in your datbase
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }



        public static void DoSomeProtectiveCode()
        {

            {

                int x, y, z;
                bool flag;
                //x = int.Parse(Console.ReadLine());//formateException
                do
                {
                    Console.WriteLine("Enter First Number");
                    flag = int.TryParse(Console.ReadLine(), out x);
                } while (!flag);

                //y = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Enter Second Number");
                    flag = int.TryParse(Console.ReadLine(), out y);
                } while (!flag || y == 0);
                z = x / y;//dived by zero Exception

                //int[] Numbers = { 1, 2, 3 };
                //if (Numbers.Length > 10)
                //{
                //    Numbers[10] = 100; //IndexOutOfRangeException }

                //}
                int[] Numbers = null;
                if (Numbers?.Length > 10)
                {
                    Numbers[10] = 100; //IndexOutOfRangeException }

                }


            }
        }
        static void Main(string[] args)
        {
            #region Exception Handiling
            //DoSomeCode();
            //// Exceptions
            //// 1. System Exceptions
            ////// 1.1 Format Exception
            ////// 1.2 Index Out Of Range Exception
            ////// 1.3 Null Reference Exception
            ////// 1.4 Invalid Operation Exception
            ////// 1.5 Arithmetic Exception
            //////  1.5.1 Divided By Zero Exception
            //////  1.5.2 Overflow Exception
            //// 2. Application Exception
            //try
            //{
            //    DoSomeProtectiveCode();
            //    throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //close - free - delete - Dealocate Unmanged Resources
            //    //open file 
            //    //open Conetection Database
            //    Console.WriteLine("Finally");
            //}
            ////DoSomeProtectiveCode();
            ////throw new Exception();
            //Console.WriteLine("After Try Catch ");
            #endregion

            #region Accsess Modifer

            //TypeA typeA = new TypeA();
            //TypeA.x = 10;
            //TypeB //
            //typeA.y = 10;
            //typeA.z = 10;

            #endregion


            #region Enums
            #region Ex01
            //string Day = "Hamadaa";
            //Days Day = Days.Friday;
            Grades Grade = Grades.A;
            if (Grade == Grades.A)
            {
                Console.WriteLine("Smile Face");
            }
            else 
                Console.WriteLine("Bad Face");
            #endregion
            #region Ex02
            ////Grades grade = (Grades)2;//Explecit Casting
            ////Console.WriteLine(grade);
            //Grades grade = (Grades)10;//Explecit Casting 
            //Console.WriteLine(grade);//c 


            #endregion
            #region Ex03
            //Grades Grade=Console.ReadLine();
            //Grades grade = (Grades)Enum.Parse(typeof(Grades),Console.ReadLine());
            //too much boxing and unBoxing
            //Enum.TryParse(typeof(Grades), Console.ReadLine(), out object result);
            //Grades grade = (Grades)result;
            //Console.WriteLine(result);

            #endregion

            #region Ex04
            //string Gender = "male";
            ////Enum.TryParse(typeof(gender), Gender, out object result);
            ////Console.WriteLine(result);  
            //Enum.TryParse<gender>(Gender, true,out gender result);
            //Console.WriteLine(result);


            #endregion

            //gender Gender=new gender();
            //Console.WriteLine(Gender);


            #endregion

            #region Permissions


            #endregion
        }
        enum Roles
        {
            Admin=10,Veiwer=20,Editor=30
        }
        class Employee
        {
            string Name;
            int age;
            decimal sallary;
            gender gender;//Male or female
            //Admin, viewier,editor
            //string Role;

        }
    }
}
