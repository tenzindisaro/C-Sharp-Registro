using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.RegistrosPac;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 
        private static string configuracaoArquivo = "config.txt"; // Nome do arquivo de configuração

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (PrimeiraExecucao())
            {
                //Application.Run(new FormCadastroUser());
                //Application.Run(new Form5_Registro_Pac());
                AtualizarConfiguracao();
            }
            else
            {
                Application.Run(new FrmLogin());
                //Application.Run(new Form5_Registro_Pac()); 
                //Application.Run(new FormCadastroUser());
            }
        }

        static bool PrimeiraExecucao()
        {
            // Verifica se o arquivo de configuração existe
            //return !File.Exists(configuracaoArquivo);     
            return false;   //função desativada para avaliação de novas interfaces.
        }

        static void AtualizarConfiguracao()
        {
            // Cria o arquivo de configuração vazio para indicar que o programa já foi configurado.
            File.Create(configuracaoArquivo).Close();
        }
    }
}
