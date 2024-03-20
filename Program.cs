using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemoClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a dictionary with string key (student name) and int for grades (Values)
            //Dictionary<TKey, TValue>
            Dictionary<string,int> studentGrades = new Dictionary<string, int>();

            // Add some student names and grades to the dictionary 
            studentGrades.Add("David", 98);
            studentGrades.Add("Sarah", 79);
            studentGrades.Add("Eve", 56);
            studentGrades["Rose"] = 100;
            studentGrades["Bob"] = 87;
            studentGrades["Helen"] = 67;


            // Display the contents of the dictionary 
            Console.WriteLine("Student Grade :");

            foreach(var student in studentGrades)
            {
                Console.WriteLine(student.Key + " "+ student.Value);
            }

            //TO DO 
            // Course iformation with string string courseCode courseTitle


            var cities = new Dictionary<string, string>()
            {
                {"Canada","ottawa,Montreal, Vancouver" },
                {"USA", "Chicago, New york, Washington" },
                {"India", "Mumbai, New Dehli, Pune" },
                {"France", "Paris, Leon, Nice" }
            };


            //cities["USA"] = "Los Angles";
            // the key is always unique 
            Console.WriteLine("=====================================");
            // I can show the list of cities based on the key value
            Console.WriteLine(cities["Canada"]);
            Console.WriteLine(cities["USA"]);
            Console.WriteLine(cities["India"]);


            // I want to check and see the key France is exist or not 

            if(cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }
            else
            {
                Console.WriteLine("Key does not exist");
            }

            // I want to get the value for  key 
            string result;

            if(cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("value does not exist");
            }

            // use ElemetAt to retrive (key-Value) pair 

            for(int i= 0; i< cities.Count; i++)
            {
                Console.WriteLine("key: {0}, Value: {1}", cities.ElementAt(i).Key, cities.ElementAt(i).Value);
            }

            foreach(KeyValuePair<string,string> pair in cities)
            {
                Console.WriteLine("key: {0}, Value: {1}", pair.Key, pair.Value);
            }


            // TO DO 
            // Country and provinces or states 
            // canada , USA , your own country 

            Console.WriteLine("List of provinces for all countries ");

            Console.WriteLine("Check the key Japon");

            Console.WriteLine("user tryGetValue for Japon");

            Console.WriteLine("ElementAt key-value pair");

            Console.WriteLine("KeyValuePair key-value pair");

            Console.ReadKey();

        }
    }
}
