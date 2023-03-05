internal class Program
{
    private static void Main(string[] args)
    {
        int anoInicial = 0, anoFinal = 1, ano_corrente = 0, dias_entre_anos = 0;

        void EntradaDados()
        {
            bool flag = false;
            do
            {
                if (flag)
                {
                    Console.WriteLine("ATENÇÃO !!!");
                    Console.WriteLine("ANO INICIAL TEM QUE SER MENOR QUE O FINAL");
                }
                Console.WriteLine("DIGITE O ANO INICIAL: ");
                anoInicial = int.Parse(Console.ReadLine());

                Console.WriteLine("DIGITE O ANO FINAL: ");
                anoFinal = int.Parse(Console.ReadLine());

                flag = true;

            } while (anoInicial > anoFinal);
        }

        bool VerficarAnoBissexto()
        {
            bool flag = false;

            if (ano_corrente % 4 == 0)
            {
                if (ano_corrente % 100 == 0)
                {
                    if (ano_corrente % 400 == 0)
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = true;
                }
            }

            return flag;
        }

        void SomaEntreNumeros()
        {

            for (ano_corrente = anoInicial; ano_corrente <= anoFinal; ano_corrente++)
            {

                if (VerficarAnoBissexto())
                {
                    dias_entre_anos++;
                }
                dias_entre_anos += 365;
            }
        }
        void ExibirDados()
        {
            Console.WriteLine("A quantidade de dias entre o ano " + anoInicial + " e " + anoFinal + " é " + dias_entre_anos);
        }

        EntradaDados();
        SomaEntreNumeros();
        ExibirDados();

    }
}