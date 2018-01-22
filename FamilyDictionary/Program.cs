using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Krista"},
                {"age", "42"}
            });

            foreach (var person in myFamily)
                // goes over each family member, in this dictionary there is only 1 family member...
                // here, person is the dictionary of Key: "sister" and value: new Dictionary
            {
                var relation = person.Key; // here, "sister"

                var personName = myFamily[relation]["name"];
                //              ^ opens up the myFamily dictionary with the key of "sister"...
                //                  in "sister" dictionary the key of "name" is used to reach the value: "Krista"

                var personAge = myFamily[relation]["age"];
                //              ^ opens up the myFamily dictionary with the key of "sister"...
                //                  in "sister" dictionary the key of "age" is used to reach the value: "42"

                Console.WriteLine($"{personName} is my {relation} and is {personAge} years old.");
            }

            Console.ReadKey();
        }
    }
}
