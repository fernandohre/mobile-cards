using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bancoApi.Models.Negocio
{
    public class Opcoes
    {
        public List<Opcoes> _listaDeOpcoes { get; set; }
        private string _id { get; set; }
        private string _descricao { get; set; }
    }
}