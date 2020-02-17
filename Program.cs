using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace corrida_kart
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time;
            int numpiloto;
            string nome;
            int volta;
            double velocidade;

            private string arquivo;
            private string mensagem;
        private void MetodoParaLerLinhaArquivo()
        {
            List<string> mensagemLinha = new List<string>();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "xxxxxxxxxo";
                openFileDialog.InitialDirectory = @"c:\";
                 openFileDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    arquivo = openFileDialog.FileName;
            }
            if (String.IsNullOrEmpty(arquivo))
            {
                MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK);
            }
            else
            {
                using (StreamReader texto = new StreamReader(arquivo))
                {
                    while ((mensagem = texto.ReadLine()) != null)
                    {
                        mensagemLinha.Add(mensagem);
                    }
                }
                int registro = mensagemLinha.Count; //total de linhas do arquivo.
                for (int i = 0; i < mensagemLinha.Count; i++)
                {
                    TextBox textbox1 = new TextBox();
                    textbox1.Text += mensagemLinha[i];
                    File.WriteAllText(arquivo, mensagemLinha[i] + "1");
                }
            }
        }


            Console.Write("Digite a Hora: ");
            time = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite o Número do Piloto: ");
            numpiloto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do piloto: ");
            nome = Console.ReadLine();

            Console.Write("Digite a volta do piloto: ");
            volta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a velocidade do piloto: ");
            velocidade = Convert.ToDouble(Console.ReadLine());


            //declarando a variavel do tipo StreamWriter para 
            //abrir ou criar um arquivo para escrita 
            StreamWriter x;

            //Colocando o caminho fisico e o nome do arquivo a ser criado
            //finalizando com .txt
            string CaminhoNome = "C:\\corrida.txt";

            //utilizando o método para criar um arquivo texto
            //e associando o caminho e nome ao metodo
            x = File.CreateText(CaminhoNome);

            //Console.ReadKey();

            x.WriteLine("CORRIDA");
            //pulando linha sem escrita
            x.WriteLine();
            x.WriteLine();
            //escrevendo conteúdo do recibo
            x.WriteLine("******************GRANDE PRÊMIO DE FÓRMULA 1*********************");
            x.WriteLine("_________________________________________________________________");
            x.WriteLine("HORA: ", time); x.WriteLine(time);
            x.WriteLine("NUMERO: ", numpiloto); x.WriteLine(numpiloto);
            x.WriteLine("PILOTO: "); x.WriteLine(nome);
            x.WriteLine("VOLTA: "); x.WriteLine(volta);
            x.WriteLine("VELOCIDADE: "); x.WriteLine(velocidade);
            x.WriteLine("_________________________________________________________________");

            /*x.WriteLine("23:49:10.858 033 – R.BARRICHELLO 1 1:04.352 43,243");
            x.WriteLine("23:49:11.075 002 – K.RAIKKONEN 1 1:04.108 43,408");
            x.WriteLine("23:49:12.667 023 – M.WEBBER 1 1:04.414 43,202");
            x.WriteLine("23:49:30.976 015 – F.ALONSO 1 1:18.456 35,47");
            x.WriteLine("23:50:11.447 038 – F.MASSA 2 1:03.170 44,053");
            x.WriteLine("23:50:14.860 033 – R.BARRICHELLO 2 1:04.002 43,48");
            x.WriteLine("23:50:15.057 002 – K.RAIKKONEN 2 1:03.982 43,493");
            x.WriteLine("23:50:17.472 023 – M.WEBBER 2 1:04.805 42,941");
            x.WriteLine("23:50:37.987 015 – F.ALONSO 2 1:07.011 41,528");
            x.WriteLine("23:51:14.216 038 – F.MASSA 3 1:02.769 44,334");
            x.WriteLine("23:51:18.576 033 – R.BARRICHELLO 3 1:03.716 43,675");
            x.WriteLine("23:51:19.044 002 – K.RAIKKONEN 3 1:03.987 43,49");
            x.WriteLine("23:51:21.759 023 – M.WEBBER 3 1:04.287 43,287");
            x.WriteLine("23:51:46.691 015 – F.ALONSO 3 1:08.704 40,504");
            x.WriteLine("23:52:01.796 011 – S.VETTEL 1 3:31.315 13,169");
            x.WriteLine("23:52:17.003 038 – F.MASS 4 1:02.787 44,321");
            x.WriteLine("23:52:22.586 033 – R.BARRICHELLO 4 1:04.010 43,474");
            x.WriteLine("23:52:22.120 002 – K.RAIKKONEN 4 1:03.076 44,118");
            x.WriteLine("23:52:25.975 023 – M.WEBBER 4 1:04.216 43,335");
            x.WriteLine("23:53:06.741 015 – F.ALONSO 4 1:20.050 34,763");
            x.WriteLine("23:53:39.660 011 – S.VETTEL 2 1:37.864 28,435");
            x.WriteLine("23:54:57.757 011 – S.VETTEL 3 1:18.097 35,633");
            */


            //fechando o arquivo texto com o método .Close()
            x.Close();

        }
    }
}
