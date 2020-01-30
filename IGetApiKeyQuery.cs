using System.Threading.Tasks;

namespace api_key
{
    public interface IGetApiKeyQuery
    {
        ApiKey Execute(string providedApiKey);
    }
}