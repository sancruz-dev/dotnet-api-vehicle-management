using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.infrastructure.Auth
{
    public class JwtSettings
    {
        public string Key { get; set; } = string.Empty;
    }
}