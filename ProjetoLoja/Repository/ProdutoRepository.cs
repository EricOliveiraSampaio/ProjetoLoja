namespace ProjetoLoja.Repository;
using ProjetoLoja.Models;
using Dapper;
using MySql.Data.MySqlClient;


namespace ProjetoLoja.Repository
{
    public class ProdutoRepository
    {
        private readonly string _connectionString;

        public ProdutoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<Produto>> TodosProdutos()
        {
            using var connection = new MySqlConnection(_connectionString);
            var sql = "SELECT Id, Nome, Descricao, Preco, ImageUrl, Estoque FROM Produtos";
            return await connection.QueryAsync<Produto>(sql);
        }
    }
}