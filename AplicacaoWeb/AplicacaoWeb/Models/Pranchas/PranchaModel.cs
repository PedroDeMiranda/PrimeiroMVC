using System.ComponentModel.DataAnnotations;

namespace AplicacaoWeb.Models.Pranchas
{
    public class PranchaModel
    {
            public int Id { get; set; }
            public string Modelo { get; set; }
            public double Litragem { get; set; }

        [Range(0, double.MaxValue)]
            public double Altura { get; set; }
    }
}
