//DiasEntreAnos
internal class Program
{
    private static void Main(string[] args)
    {
        int ano_inicial, ano_final;
        int aux, soma_dias;

        soma_dias = 0;

        Console.WriteLine("Digite o primeiro ano");
        ano_inicial = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo ano");
        ano_final = int.Parse(Console.ReadLine());

        if(ano_inicial == ano_final)
        {
            Console.WriteLine("Total de dias entre os anos: ZERO");
        }
        else
        {
            if(ano_inicial > ano_final)
            {
                aux = ano_final;
                ano_final = ano_inicial;
                ano_inicial = aux;
            }
            for(int i = ano_inicial; i <= ano_final; i++) 
            {
                if(i % 4 == 0) 
                {
                    if(i % 100 == 0)
                    {
                        if(i % 400 == 0)
                        {
                            soma_dias += 1;
                        }
                    }
                    else
                    {
                        soma_dias += 1;
                    }
                }
                soma_dias += 365;
            }

            Console.WriteLine("Total de dias entre os anos: " + soma_dias);
        }


    }
}