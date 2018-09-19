using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace Week04Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AttractionsEntities db = new AttractionsEntities())
            {

                var countries = from c in db.Countries select c;
                foreach(Country country in countries)
                {
                    Console.WriteLine(country.CountryName);
                }
                
                Country myNewCountry = new Country()
                {
                    CountryID = 12,
                    CountryName = "Brazil2"
                };

                db.Countries.Add(myNewCountry);
                db.SaveChanges();
            }
            //LinqOne();
            //classDemo();
            //DBShowAttractions();

        }

        static SqlConnection DBConn()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Jeremy Porier\\Attractions.mdf\";Integrated Security=True;Connect Timeout=30";

            cn.Open();

            return cn;
        }

        static void DBAddIceland()
        {
            SqlConnection cn = DBConn();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Countries (CountryID, CountryName) " +
                                "VALUES (5, 'Iceland')";
            cmd.ExecuteNonQuery();

            cn.Close();

        }

        static void DBShowAttractions()
        {
            SqlConnection conn = DBConn();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT countryName, AttractionName FROM Countries AS c INNER JOIN Attractions AS a ON c.CountryID = a.CountryID ORDER BY c.CountryName";
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["countryName"] + " " + sdr["attractionName"]);
                }
                
            }

        }




        static void LinqOne()
        {
            List<Student> students = new List<Student>
            {
                new Student("Claire", "Standish", 2, 4),
                new Student("Andrew", "Clark", 3, 3),
                new Student("John", "Bender", 1, 4),
                new Student("Brian", "Bender", 4, 1),
                new Student("Allison", "Reynolds", 5, 3)
            };

            //string[] yearLabels = { "Freshman", "Sophomore", "Junior", "Senior" };

            students.Sort();

            Console.WriteLine(students.First().LastName + " " + students.First().FirstName);

            //var upperclassmen = from s in students where s.Year > 2 select s;

            /*var upperclassmen = students.Where(s => s.Year > 2 == true);

            foreach (Student s in upperclassmen)
            {
                Console.WriteLine(s.LastName);
            }*/

        }

        static void classDemo()
        {
            Person jeremy = new Person("Jeremy","Porier");

            Student rachel = new Student("Rachel", "Porier", 15, 4);
            Person r = (Person)rachel;
            rachel = null;
            Student rsp = (Student)r;
            Console.WriteLine(rsp.Year);

            WorkStudy jmp = new WorkStudy();



        }
    }
}
