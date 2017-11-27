using System;

namespace Locadora.Models
{
    public class VeiculoModel
    {
        public string Placa { get; set; }

        public string Chassi { get; set; }

        public VeiculoModeloModel Modelo { get; set; }

        public string Marca { get; set; }

        //public string Modelo { get; set; }

        public string DataFabricacao { get; set; }

        public VeiculoCor Cor { get; set; }
    }
}