using PoupaDevAPI.Enums;

namespace PoupaDevAPI.Models
{
    public class OperacaoInputModel
    {
        public decimal Valor { get; set; }
        public TipoOperacao TipoOperacao { get; set; }
    }
}
