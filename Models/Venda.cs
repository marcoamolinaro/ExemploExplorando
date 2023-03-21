using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public Venda(int id, string produto, Decimal preco, DateTime dataVenda, Decimal? desconto)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
            Desconto = desconto;
        }
        public int Id { get; set; }
        
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public Decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public Decimal? Desconto { get; set; }
    }
}