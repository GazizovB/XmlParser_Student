using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Запись
            List<Student> students = new List<Student>
            {
                new Student
                {
                    FirstName = "Josh",
                    LastName = "Jon",
                    Speciality = "Math",
                    Age = 21
                },

                new Student
                {
                    FirstName = "Christopher",
                    LastName = "Simon",
                    Speciality = "Physics",
                    Age = 22
                },

                new Student
                {
                    FirstName = "Angelina",
                    LastName = "Rose",
                    Speciality = "Art",
                    Age = 20
                },
            };

            XmlDocument xmlDocument = new XmlDocument();
            XmlElement rootElement = xmlDocument.CreateElement("students");
            foreach (Student student in students)
            {
                XmlElement carElement = xmlDocument.CreateElement("student");
                carElement.SetAttribute("firstName", student.FirstName);
                carElement.SetAttribute("lastName", student.LastName);
                carElement.SetAttribute("speciality", student.Speciality);
                carElement.SetAttribute("age", student.Age.ToString());


                rootElement.AppendChild(carElement);
            }

            xmlDocument.AppendChild(rootElement);
            xmlDocument.Save("students.xml");

            #endregion

            #region Чтение
            //List<Car> cars = new List<Car>();

            //XmlDocument xmlDocument = new XmlDocument();
            //xmlDocument.Load("cars.xml");

            //XmlElement rootElement = xmlDocument.DocumentElement;
            //foreach (/*var*/XmlElement element in rootElement.ChildNodes)
            //{
            //    string mark = element.Attributes["mark"].Value;
            //    string model = element.Attributes["model"].Value;
            //    string color = element.Attributes["color"].Value;
            //    double price = double.Parse(element.Attributes["price"].Value);


            //    cars.Add(new Car
            //    {
            //        Mark = mark,
            //        Model = model,
            //        Color = color,
            //        Price = price
            //    });
            //}

            #endregion
        }
    }
}
