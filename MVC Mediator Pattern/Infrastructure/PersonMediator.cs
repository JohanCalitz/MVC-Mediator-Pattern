using MVC_Mediator_Pattern.Models;
using System.Text.Json;

namespace MVC_Mediator_Pattern.Infrastructure
{
    public interface IPersonMediator
    {
        Task CreatePerson(string name, int age);
    }

    public class PersonMediator : IPersonMediator
    {
        public async Task CreatePerson(string name, int age)
        {
            var person = new Person { Name = name, Age = age };

            // Serialize the person object to JSON
            var jsonString = JsonSerializer.Serialize(person);

            // Save the JSON string to a file
            await File.WriteAllTextAsync("person.json", jsonString);
        }
    }
}
