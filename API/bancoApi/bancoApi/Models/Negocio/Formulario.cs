using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bancoApi.Models.Negocio
{
    public class Formulario
    {
        private Pergunta _pergunta { get; set; }
        private Opcoes _respostas { get; set; }
        private int _opcaoCorreta { get; }
    }
}