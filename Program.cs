using System;
using System.Collections.Generic;
enum Menu
{
    RegisterNewStudent = 1,
    RegisterNewTeacher,
    GetListPersons
}
namespace HW3_num1
{
    class Program
    {
        static PersonList personList;
        static void Main(string[] args)
        {
            PreparePersonListWhenProgramIsLoad();
            PrintMenuScreen();
        }

        static void PreparePersonListWhenProgramIsLoad()
        {
            Program.personList = new PersonList();
        }
        static void PrintMenuScreen()
        {
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyBoard();
        }
        static void PrintHeader()
        {
            Console.WriteLine("Welcome to registration new user school application");
            Console.WriteLine("------------------------------------------------------");
        }
        static void PrintListMenu()
        {
            Console.WriteLine("1.register New Student");
            Console.WriteLine("2.Register New Teacher");
            Console.WriteLine("3.Get List Person");
        }
        static void InputMenuFromKeyBoard()
        {
            Console.Write("Please Select Menu : ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentToMenu(menu);

        }
        static void PresentToMenu(Menu menu)
        {
            if (menu == Menu.RegisterNewStudent)
            {
                ShowInputRegisterScreen(menu);
            }
            else if (menu == Menu.RegisterNewTeacher)
            {
                ShowInputRegisterScreen(menu);
            }
            else if (menu == Menu.GetListPersons)
            {
                ShowGetListPersonScreen();
            }
            else
            {
                ShowMessageInputMenuIdInCorrect();
            }
            static void ShowInputRegisterScreen(Menu menu)/*รวมเมธอดที่โชว์หน้าแรกของ registerscreen ของทั้งครูและนักเรียนเป็นเมธอดเดียวกัน*/
            {
                Console.Clear();
                int total = TotalOfEachType(menu);
                if (menu == Menu.RegisterNewStudent)
                {
                    PrintHeaderRegisterStudent();
                }
                else if (menu == Menu.RegisterNewTeacher)
                {
                    PrintHeaderRegisterTeacher();
                }
                InputNewPersonsFromKeyboard(total, menu);/*รวมเมธอดที่รับค่าข้อมูลและการเพิ่มลงlistของทั้งครูและนักเรียนเป็นเมธอดเดียวกัน*/
                PrintMenuScreen();
            }
            static int TotalOfEachType(Menu menu)/*รวมเมธอดของการรับค่าจำนวนของคนทั้งครูและนักเรียนเป็นเมธอดเดียวกัน*/
            {
                if (menu == Menu.RegisterNewStudent)
                {
                    Console.Write("Input total of Students  : ");
                }
                else if (menu == Menu.RegisterNewTeacher)
                {
                    Console.Write("Input total of Teachers  : ");
                }
                return int.Parse(Console.ReadLine());
            }
            static void PrintHeaderRegisterStudent()
            {
                Console.WriteLine("Register new Student");
                Console.WriteLine("---------------------");
            }
            static void PrintHeaderRegisterTeacher()
            {
                Console.WriteLine("Register new teacher");
                Console.WriteLine("---------------------");
            }
            static void InputNewPersonsFromKeyboard(int total, Menu menu)/*รวมเมธอดที่รับค่าข้อมูลและการเพิ่มลงlistของทั้งครูและนักเรียนเป็นเมธอดเดียวกัน*/
            {
                for (int i = 0; i < total; i++)
                {
                    Console.Clear();
                    if (menu == Menu.RegisterNewStudent)
                    {
                        PrintHeaderRegisterStudent();
                        Student student = CreateNewStudent();
                        Program.personList.AddNewPerson(student);
                    }
                    else if (menu == Menu.RegisterNewTeacher)
                    {
                        PrintHeaderRegisterTeacher();
                        Teacher teacher = CreateNewTeacher();
                        Program.personList.AddNewPerson(teacher);
                    }
                }
            }
            static Student CreateNewStudent()
            {
                return new Student(InputName(), InputAddress(), InputCitizenID(), InputStudentID());
            }
            static Teacher CreateNewTeacher()
            {
                return new Teacher(InputName(), InputAddress(), InputCitizenID(), InputenployeeID());
            }
            static string InputenployeeID()
            {
                Console.Write("EnployeeID: ");

                return Console.ReadLine();
            }
            static string InputName()
            {
                Console.Write("Name: ");

                return Console.ReadLine();
            }
            static string InputAddress()
            {
                Console.Write("Address: ");

                return Console.ReadLine();
            }
            static string InputCitizenID()
            {
                Console.Write("Citizen: ");

                return Console.ReadLine();
            }
            static string InputStudentID()
            {
                Console.Write("StudentID:");

                return Console.ReadLine();
            }
            static void ShowMessageInputMenuIdInCorrect()
            {
                Console.Clear();
                Console.WriteLine("Menu incorrect Please try again");
                InputMenuFromKeyBoard();
            }
            static void ShowGetListPersonScreen()
            {
                Console.Clear();
                Program.personList.FetchPersonList();
                InputExistFromKeyboard();
            }
            static void InputExistFromKeyboard()
            {
                string text = "";
                while (text != "exit")
                {
                    Console.Write("\nInput exit to end program : ");
                    text = Console.ReadLine();
                }
                Console.Clear();
                PrintMenuScreen();
            }
        }
    }
}
