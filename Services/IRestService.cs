using AppFutebol.Models;

namespace AppFutebol.Services;

public interface IRestService
{
    Task<Matchs[]> GetMatchData(string entity);
}
