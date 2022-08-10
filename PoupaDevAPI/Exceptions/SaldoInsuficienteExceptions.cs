using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoupaDevAPI.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() : base("Saldo insuficiente!")
        {
        }
    }
}