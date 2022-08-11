using PoupaDevAPI.Controllers;
using PoupaDevAPI.Entities;

namespace PoupaDevAPI.Persistence
{
    public class PoupaDevContext
    {
        public List<ObjetivoFinanceiro> Objetivos { get; set; }

        public PoupaDevContext()
        {
            Objetivos = new List<ObjetivoFinanceiro>();
        }
    }
}
