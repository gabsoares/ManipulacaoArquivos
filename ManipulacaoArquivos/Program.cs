using System.Threading.Channels;

namespace ManipulacaoArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pega o caminho da pasta especial do usuario
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+"\\Dados\\";
            string path = @"C:\DadosEx\";
            string file = "arquivo.txt";

            //Se o caminho não existe, ele cria o caminho
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (File.Exists(path + file))
            {
                StreamReader sr = new(path + file);
                string s = sr.ReadToEnd();
                Console.Clear();
                Console.WriteLine(s);
                sr.Close();

                s += Console.ReadLine();

                StreamWriter sw = new(path + file);
                sw.WriteLine(s);
                sw.Close();

                Console.Clear();
                sr = new(path + file);
                Console.WriteLine(sr.ReadToEnd());

                sr.Close();

                var retorno = File.ReadLines(path + file).ElementAt(2);
                Console.WriteLine(retorno);
            }
        }
    }
}
