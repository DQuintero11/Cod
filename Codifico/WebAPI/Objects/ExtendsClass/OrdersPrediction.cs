using Codifico.WebAPI.Objects.BaseClass;

namespace Codifico.WebAPI.Objects.Extends
{
    public class OrdersPrediction
    {
        public int custid  { get; set; }
        public string companyname { get; set; }

        public DateTime FechaUltimaOrden { get; set; }
        public int PromedioDias { get; set; }
        public DateTime FechaPosibleSiguienteOrden { get; set; }


    }

}
