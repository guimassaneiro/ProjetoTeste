using Newtonsoft.Json;
using ProjetoTeste.Guilherme.UI.Models;
using System.Collections.Generic;
using System.IO;
using System.Web.Hosting;

namespace ProjetoTeste.Guilherme.UI.Services
{
    public class ProdutoService
    {
        // C = CREATE
        // R = READ
        // U = UPDATE
        // D = DELETE

        public static IEnumerable<ProdutoViewModel> ObterProdutos()
        {
            // Obtem caminho do arquivo
            var arquivoJson = HostingEnvironment.MapPath(@"~/App_Data/produtos.json");

            // Lê o arquivo no caminho informado e guarda os dados na variável
            var json = File.ReadAllText(arquivoJson);

            // Deserializa o conteudo da variável para o objeto Produto, formando uma lista
            var result = JsonConvert.DeserializeObject<List<ProdutoViewModel>>(json);

            // Retorna o objeto para que chamou o método
            return result;
        }

        public void ObterProdutoPorId(int id) { }

        public void AdicionarProdutos(List<ProdutoViewModel> produtos) { }

        public void AdicionarProduto(ProdutoViewModel produto) { }

        public void AlterarProdutos(List<ProdutoViewModel> produtos) { }

        public void AlterarProduto(ProdutoViewModel produto) { }

        public void ExcluirProduto(int id) { }
    }
}