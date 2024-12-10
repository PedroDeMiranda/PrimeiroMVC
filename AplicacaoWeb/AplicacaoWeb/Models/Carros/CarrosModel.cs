using AplicacaoWeb.Models.Carros;

namespace AplicacaoWeb.Models.Carros
{
    public class CarrosModel
    {
        public List<CarroModel> Carros { get; set; }

        public CarrosModel()
        {
            Carros = new List<CarroModel>();
        }
    }
}
