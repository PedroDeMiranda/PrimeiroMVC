using AplicacaoWeb.Models.Pranchas;

namespace AplicacaoWeb.Models.Pranchas
{
    public class PranchasModel
    {
        public List<PranchaModel> Pranchas { get; set; }

        public PranchasModel()
        {
            Pranchas = new List<PranchaModel>();
        }
    }
}
