using System;
using System.Collections.Generic;
using System.IO;
 using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace WebApiFornecedor.Models
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string razaosocial { get; set; }
        public string nomeempresa { get; set; }
        public string ramoatividade { get; set; }


        public List<Fornecedor> ListarFornecedores()
        {
            var dbFornecedores = AppDomain.CurrentDomain.BaseDirectory + @"base.json";
            var json = File.ReadAllText(dbFornecedores);
            var listaFornecedores = JsonConvert.DeserializeObject<List<Fornecedor>>(json);

            return listaFornecedores;

        }

        public bool ReescreverArquivo(List<Fornecedor> listaFornecedores)
        {
            var dbFornecedores = AppDomain.CurrentDomain.BaseDirectory + @"base.json";
            var json = JsonConvert.SerializeObject(listaFornecedores, Formatting.Indented);
            File.WriteAllText(dbFornecedores, json);
            return true;

        }

    }
}
