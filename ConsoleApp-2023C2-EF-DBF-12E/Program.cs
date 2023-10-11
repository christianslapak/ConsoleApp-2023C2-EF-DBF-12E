using ConsoleApp_2023C2_EF_DBF_12E.Modelo;
using System;
using System.Linq;

namespace ConsoleApp_2023C2_EF_DBF_12E
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PruebaEF2023C2Context())
            {
                var consulta = context.Student.Where(s => s.StudentId == 2);
                var estudiante = consulta.FirstOrDefault<Student>();
                Console.WriteLine("Encontré al estudiante 2 y se llama " + estudiante.StudentName);
                Console.ReadKey();

                var std = new Student()
                {
                    StudentName = "Alejandro"
                };
                context.Student.Add(std);
                context.SaveChanges();
            }
        }
    }
}
