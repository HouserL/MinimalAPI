using APILibrary.Models;

namespace APILibrary.API;

public interface IAPIHelper
{
    HttpClient ApiClient { get; }

    Task DeleteUser(int id);
    Task<User> GetUser(int id);
    Task<List<User>> GetUsers();
    Task InsertUser(User user);
    Task<User> UpdateUser(User user);
}