using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Empresa : Base
    {
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public string CEO { get; set; }       
        public DateTime DataDeAbertura { get; set; }
        public DateTime DataDeExtincao { get; set; }
        public Funcionario Funcionario { get; set; }

    }
}
