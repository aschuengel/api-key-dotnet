using System.Collections.Generic;

namespace api_key
{
    public class ApiKey
    {
        public string Owner { get; set; }
        public IList<string> Roles { get; set; }
    }
}