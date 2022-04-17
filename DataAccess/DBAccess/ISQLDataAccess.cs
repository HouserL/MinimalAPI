
namespace DataAccess.DBAccess;

public interface ISQLDataAccess
{
    Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U paramaters, string connectionId = "Default");
    Task SaveData<T>(string storedProcedure, T paramaters, string connectionId = "Default");
}