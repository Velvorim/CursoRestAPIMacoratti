using ApiCatalagoMinimal.Models;

namespace ApiCatalagoMinimal.Services;

public interface ITokenService
{
    string GerarToken(string key, string issuer,string audience, UserModel user);
}
