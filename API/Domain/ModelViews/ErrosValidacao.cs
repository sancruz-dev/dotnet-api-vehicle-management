using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Domain.ModelViews
{
    public class ErrosValidacao
    {
        public List<string> Mensagens { get; set; } = new();
    }
}