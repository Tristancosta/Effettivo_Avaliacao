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
            Conexao.StringConexao = "Server=tcp:bdsergio.database.windows.net,1433;Initial Catalog=Effettivo_Avaliacao;Persist Security Info=False;User ID=tristancosta_admin;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
    }
}