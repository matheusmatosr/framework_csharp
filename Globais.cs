using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novo_projeto_anker
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0; // 0 = basico,  1= gerente, 2 = master
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco_projeto.db";
        public static string caminhoBanco = caminhoBanco+@"\banco\";

        /*
        tb_usuarios
        N_IDUSUARIO
        T_NOMEUSUARIO
        T_SENHAUSUARIO
        T_STATUSUSUARIO
        N_NIVELUSUARIO
         */
    }
}
