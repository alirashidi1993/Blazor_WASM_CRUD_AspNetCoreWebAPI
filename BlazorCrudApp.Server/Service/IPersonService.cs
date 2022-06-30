using BlazorCrudApp.Server.Models;

namespace BlazorCrudApp.Server.Service
{
    public interface IPersonService
    {
        Task<Person> AddPerson(Person person);
        Task<bool> UpdatePerson(int id, Person person);
        Task<bool> DeletePerson(int id);
        Task<List<Person>> GetAllPersons();
        Task<Person> GetPerson(int id);
    }
}
