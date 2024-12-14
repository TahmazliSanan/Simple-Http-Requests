using Newtonsoft.Json;
using SimpleHttpRequests.Models;

namespace SimpleHttpRequests
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            await DeserializeJson();
            // SerializeObject();
            Console.ReadLine();
        }

        public static async Task DeserializeJson()
        {
            string continueStatus;
            const string apiUrl = "https://catfact.ninja/fact";

            HttpClient httpClient = new HttpClient();

            do
            {
                var response = await httpClient.GetStringAsync(apiUrl);

                // Convert JSON to class
                var catFact = JsonConvert.DeserializeObject<CatFact>(response);
                Console.WriteLine($"Fact: {catFact.Fact}");

                Console.WriteLine("----------------------------------------------------------------");

                Console.Write("Do you want to continue (Yes or No)? ");
                continueStatus = Console.ReadLine().ToLower();

            } while (continueStatus.Equals("yes"));

            Console.WriteLine("You exit!");
        }

        public static void SerializeObject()
        {
            User user = new User
            {
                Name = "John",
                IsStudent = false,
                Age = 35,
                MonthlySalary = 5500.00,
                SuccessSymbols = new[] { 'S', 'N', 'T' },
                Parent = new Person
                {
                    Name = "Garry",
                    DateOfBirth = new DateTime(1969, 01, 25)
                },
                Children = new[]
                {
                    new Person
                    {
                        Name = "Iohan",
                        DateOfBirth = new DateTime(2005, 12, 01)
                    },
                    new Person
                    {
                        Name = "Andrea",
                        DateOfBirth = new DateTime(2008, 05, 05)
                    },
                    new Person
                    {
                        Name = "Caruana",
                        DateOfBirth = new DateTime(1995, 01, 01)
                    },
                }
            };

            var json = JsonConvert.SerializeObject(user, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
