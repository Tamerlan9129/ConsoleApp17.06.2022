using ConsoleApp8.Helpers;
using System;

namespace ConsoleApp8
{
    class Program
    {

        static void Main(string[] args)
        {
            Library lib = new Library();

            //Student stud = new Student();
            //stud.Name = "Tamerlan";
            //stud.Grade = 100;
            //(string, int) res = GetnameAndGrade(stud);
            //Console.WriteLine(res);
            while (true)
            {
                
                Helper.Printer("1) Kitabxanaya ishci elave et ", ConsoleColor.White);
                Helper.Printer("2) Muellif elave et ", ConsoleColor.White);
                Helper.Printer("3) Kitabxanaya kitab elave et ", ConsoleColor.White);
                Helper.Printer("4) Kitabxanada ishci sil ", ConsoleColor.White);
                Helper.Printer("5) Kitabxanaya kitab sil ", ConsoleColor.White);

                string choseMenu = Console.ReadLine();
                bool isMenu = int.TryParse(choseMenu, out int menu);
                if (isMenu)
                {
                    switch (menu)
                    {
                        case 1:
                            
                            Helper.Printer("Ishcinin adini daxil edin", ConsoleColor.Blue);
                            string empName = Console.ReadLine();
                            bool isEmpName = string.IsNullOrEmpty(empName);
                            if (isEmpName) 
                            {
                                Helper.ErrorAndSucces("Duzgun ad daxil edin !", ConsoleColor.Red);
                                goto case 1;
                            }
                            empSurname:
                            Helper.Printer("Ishcinin soyadini daxil edin", ConsoleColor.Blue);
                            string empSurname = Console.ReadLine();
                            bool isemSurname = string.IsNullOrEmpty(empSurname);
                            if (isemSurname)
                            {
                                Helper.ErrorAndSucces("Duzgun soyad daxil edin !", ConsoleColor.Red);
                                goto  empSurname;
                            }
                            Position:
                            Helper.Printer("Ishcinin vezifesini daxil edin", ConsoleColor.Blue);
                            string empPosition = Console.ReadLine();
                            bool isPosition = string.IsNullOrEmpty(empPosition);
                            if (isPosition)
                            {
                                Helper.ErrorAndSucces("Duzgun vezife daxil edin !", ConsoleColor.Red);
                                goto Position;
                            }
                            Emploee empl = new Emploee(empName, empSurname, empPosition);
                            lib.emploees.Add(empl);
                            Helper.ErrorAndSucces($"{empl.Name}    {empl.Surname}   adli ishci ugurla elave olundu", ConsoleColor.Green);
                            break;
                        case 2:
                            Helper.Printer(" Muellifin adini  daxil edin : ", ConsoleColor.Cyan);
                            string autName = Console.ReadLine();
                            bool isAutName = string.IsNullOrEmpty(autName);
                            if (isAutName)
                            {
                                Helper.ErrorAndSucces("Duzgun muellif adi daxil edin !", ConsoleColor.Red);
                                goto case 2;
                            }
                            autSurname:
                            Helper.Printer(" Muellifin soyadini daxil edin : ", ConsoleColor.Cyan);
                            string autSurname = Console.ReadLine();
                            bool isAutSurname = string.IsNullOrEmpty(autSurname);
                            if (isAutSurname)
                            {
                                Helper.ErrorAndSucces("Duzgun muellif soyadi daxil edin !", ConsoleColor.Red);
                                goto autSurname;
                            }
                            Authors autor = new Authors(autName, autSurname);
                            lib.authors.Add(autor);
                            Helper.ErrorAndSucces($"{autor.Name}   {autor.Surname}    adli muellif ugurla elave olundu", ConsoleColor.Green);
                            break;
                        case 3:
                            if (lib.authors.Count == 0)
                            {
                                Helper.ErrorAndSucces("Muellif yoxdur.Zehmet olmasa muellif elave edin. ", ConsoleColor.Red);
                                goto case 2;
                            }
                            bookName:
                            Helper.Printer("Kitabin adini daxil edin", ConsoleColor.Yellow);
                            string bookName = Console.ReadLine();
                            bool isBookName = string.IsNullOrEmpty(bookName);
                            if (isBookName)
                            {
                                Helper.ErrorAndSucces("Duzgun kitab adi daxil edin !", ConsoleColor.Red);
                                goto bookName;
                            }
                            bookGenre:
                            Helper.Printer("Kitabin janrini daxil edin", ConsoleColor.Yellow);
                            string bookGenre = Console.ReadLine();
                            bool isBookGenre = string.IsNullOrEmpty(bookGenre);
                            if (isBookGenre)
                            {
                                Helper.ErrorAndSucces("Duzgun janr adi daxil edin !", ConsoleColor.Red);
                                goto bookGenre;
                            }
                            Helper.Printer("Kitab hansi dilde oldugunu daxil edin", ConsoleColor.Yellow);
                            string bookLanguage = Console.ReadLine();
                            Books book = new Books(bookName, bookGenre, bookLanguage);
                            AutSelect:
                            foreach (var aut in lib.authors)
                            {
                                Helper.Printer($"Muellifin adi : {aut.Name}   Muellifin soyadi : {aut.Surname}   Muellifin ID : {aut.Id} ", ConsoleColor.Green);
                            }
                            Helper.Printer("Secmek istediyiniz  muellifin ID daxil edin : ", ConsoleColor.White);
                            string choseAut = Console.ReadLine();
                            string[] selecAut = choseAut.Split(",");
                            foreach (var item in selecAut)
                            {
                                bool isAut = int.TryParse(item, out int aut);
                                if (!isAut)
                                {
                                    Helper.ErrorAndSucces("Duzgun daxil edin", ConsoleColor.Red);
                                    goto AutSelect;
                                }
                                foreach (var id in lib.authors)
                                {
                                    if (id.Id == aut) 
                                    {
                                        book.authors.Add(id);
                                        id.bookAuthors.Add(book);
                                    }
                                }
                            }
                            lib.books.Add(book);
                           
                            Helper.ErrorAndSucces($"{book.Name} adli kitab elave olundu ", ConsoleColor.Green);
                            
                            break;
                        case 4:
                            foreach (var emplo in lib.emploees)
                            {
                                Helper.Printer($"Ishcinin adi : {emplo.Name}  Ishcinin soyadi : {emplo.Surname}    Ishcinin ID : {emplo.Id}", ConsoleColor.Yellow);
                            }
                            delete:
                            Helper.Printer("Silmek istediyiniz ishcinin ID daxil edin : ", ConsoleColor.Yellow);
                            string delEmp = Console.ReadLine();
                            bool isDelEmp = int.TryParse(delEmp, out int delete);
                            if (!isDelEmp) 
                            {
                                Helper.Printer("Duzgun daxil edin ! ", ConsoleColor.Red);
                                goto delete;
                            }
                            foreach ( var em in lib.emploees)
                            {
                                if (em.Id == delete) 
                                {
                                    lib.emploees.Remove(em);
                                    Helper.ErrorAndSucces($"{em.Name}  {em.Surname}  adli ishci silindi ", ConsoleColor.Green);
                                    break;
                                }
                            }
                            
                            break;
                        case 5:
                            foreach (var boo in lib.books)
                            {
                                Helper.Printer($"Kitabin adi : {boo.Name}      Kitabin  ID : {boo.Id}", ConsoleColor.Yellow);
                            }
                        deleteBook:
                            Helper.Printer("Silmek istediyiniz ishcinin ID daxil edin : ", ConsoleColor.Yellow);
                            string delBook = Console.ReadLine();
                            bool isDelBook = int.TryParse(delBook, out int deleBoo);
                            if (!isDelBook)
                            {
                                Helper.Printer("Duzgun daxil edin ! ", ConsoleColor.Red);
                                goto deleteBook;
                            }
                            foreach (var boo in lib.books)
                            {
                                if (boo.Id == deleBoo)
                                {
                                    lib.books.Remove(boo);
                                    Helper.ErrorAndSucces($"{boo.Name}   adli kitab silindi ", ConsoleColor.Green);
                                }
                            }
                            break;

                    }


                }
            }
        }
        //    public static (string, int) GetnameAndGrade(Student stud)
        //    {
        //        return (stud.Name,stud.Grade);
        //    }
    }

    //class Student 
    //{

    //    public string Name { get; set; }
    //    public int Grade { get; set; }


    //} 
}
