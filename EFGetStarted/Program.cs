using System;
using System.Collections.Generic;
using System.Linq;

namespace EFGetStarted
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (DataBase db = new DataBase())
            {
                Console.WriteLine("Будь ласка введiть команду : Add або Read");
                Tool t = new Tool(Console.ReadLine());
            }
        }
    }
    class Tool
    {

        private void Add()
        {
            using (DataBase db = new DataBase())
            {
                /*
                 Console.Write("к-сть студентiв,яку ви б хотiли добавити = ");
                 int q_o_s = Convert.ToInt32(Console.ReadLine());
                 if(q_o_s!=0)
                 {
                 for(int i=0;i<q_o_s;i++)
                 {
                 string name,surname;
                 Console.Write("Name:");
                 name=Console.ReadLine();
                 Console.Write("Surname:");
                 surname=Console.ReadLine();
                 Student student_ = new Student{ Name = name , Surname = surname };
                 db.Add(student_);
                 }
                 db.SaveChanges();
                 }
                */
                Student student1 = new Student { Name = "Єгор", Surname = "Бестаченко" };
                db.Add(student1);
                Student student2 = new Student { Name = "Владислав", Surname = "Балко" };
                db.Add(student2);
                Student student3 = new Student { Name = "Тарас", Surname = "Шабатура" };
                db.Add(student3);
                Student student4 = new Student { Name = "Iлля", Surname = "Заєць" };
                db.Add(student4);
                Student student5 = new Student { Name = "Назар", Surname = "Ягнищак" };
                db.Add(student5);
                Student student6 = new Student { Name = "Вiктор", Surname = "Янiшевський" };
                db.Add(student6);
                db.SaveChanges();
            }
        }
        private void Read()
        {
            using (DataBase db = new DataBase())
            {
                var students = db.Students.ToList();
                foreach (Student student_ in students)
                {
                    Console.WriteLine("{2}:{0} {1}", student_.Name, student_.Surname, student_.Id);
                }
            }
        }
        public Tool(string command_)
        {
            string a_command = "Add", r_command = "Read";
            if (command_ == a_command)
            {
                Add();
            }
            else if (command_ == r_command)
            {
                Read();
            }
            else 
            {
                Console.WriteLine("Команда,яка була введена є невiрна.");
            }
        }
    }
}