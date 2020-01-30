using Microsoft.AspNetCore.Authentication;

namespace api_key
{
    public class ApiKeyAuthenticationOptions : AuthenticationSchemeOptions
    {
        public static string DefaultScheme => "API Key";
        public static string AuthenticationType => DefaultScheme;
        public static string Scheme => DefaultScheme;
    }
}