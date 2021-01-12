using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Effettivo_Avaliacao
{
    public class Conexao
    {
        public static string StringConexao { get; set; }
        static Conexao()
        {
            Conexao.StringConexao = "Data Source=APOLO;Initial Catalog=Avaliacao;Persist Security Info=True;User ID=avaliacao;Password=white_02";
        }
    }
}