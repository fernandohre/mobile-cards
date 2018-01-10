using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bancoApi.Models.Persistencia
{
    public class Conexao
    {
        private string _servidor { get; set; }
        private string _banco { get; set; }
        private string _usuario { get; set; }
        private string _senha { get; set; }

        private MySqlConnection _conexao;
        private MySqlCommand _comando;

        public Conexao(string servidor, string banco, string usuario, string senha)
        {
            _servidor = servidor;
            _banco    = banco;
            _usuario  = usuario;
            _senha    = senha;
        }

        private string ObtenhaStringConexao()
        {
            return string.Format("Server=", _servidor, ";", "Database=", _banco, ";", "Uid=", _usuario, ";", "Pwd=", _senha,";");
        }

        public void ExecuteComando(string sql)
        {
            if (_conexao == null)
            {
                _conexao = new MySqlConnection(ObtenhaStringConexao());
                _comando = _conexao.CreateCommand();
            }
            try
            {
                _conexao.Open();
                _comando.CommandText = sql;
                _comando.ExecuteNonQuery();
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void Dispose()
        {
            _conexao.Close();
        }
    }
}