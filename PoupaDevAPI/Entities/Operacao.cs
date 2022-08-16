using PoupaDevAPI.Enums;

namespace PoupaDevAPI.Entities
{
    public class Operacao
    {
        public Operacao(decimal valor, TipoOperacao tipo, int idObjetivo)
        {
            Valor = valor;
            Tipo = tipo;

            DataOperacao = DateTime.Now;
            IdObjetivo = idObjetivo;
        }

        public int Id { get; private set; }
        public decimal Valor { get; private set; }
        public TipoOperacao Tipo { get; private set; }
        public DateTime DataOperacao { get; set; }
        public int IdObjetivo { get; set; }
    }
}
