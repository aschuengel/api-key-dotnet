using System;
using System.Collections.Generic;

namespace api_key
{
    public class GetApiKeyQuery : IGetApiKeyQuery
    {
        private static readonly Guid ApiKeyGuid = Guid.Parse("{14739a8a-b3f2-4f6e-8af4-0b8933586239}");
        public ApiKey Execute(string providedApiKey)
        {
            if (providedApiKey == null || providedApiKey.Length < 2 || !Guid.TryParse(providedApiKey, out var guid))
                return null;
            if (!guid.Equals(ApiKeyGuid))
                return null;
            return new ApiKey
            {
                Owner = "HDM", // TODO: Not really needed?
                Roles = new List<string> { "Reader", "Writer" } // TODO: Not really needed?
            };
        }
    }
}