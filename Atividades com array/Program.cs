namespace Atividades_com_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listadevalores = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };

            int[] copyvalues = new int[listadevalores.Length];
            Array.Copy(listadevalores, copyvalues, listadevalores.Length);

            foreach (int i in listadevalores)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            maxvalue(listadevalores);
            Console.WriteLine();

            minvalues(listadevalores);
            Console.WriteLine();    

            medianvalues(listadevalores);
            Console.WriteLine();

            maxtreevalues(copyvalues);
            Console.WriteLine();

            negativevalues(listadevalores);
            Console.WriteLine();

            removeitem(listadevalores);
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void removeitem(int[] listadevalores)
        {
            int indexNovoArray = 0;

            Console.Write("Digite o valor que deseja remover: ");
            int valorremovido = Convert.ToInt32(Console.ReadLine());
            int[] removevalue = new int[listadevalores.Length - 1];
            foreach (int i in listadevalores)
            {
                if (i != valorremovido)
                {
                    removevalue[indexNovoArray] = i;
                    indexNovoArray++;
                }

            }
            Console.WriteLine("A lista com o valor removido fica assim: ");
            foreach (int i in removevalue)
            {
                Console.Write(i + ", ");
            }
        }

        private static void maxtreevalues(int[] copyvalues)
        {
            Array.Sort(copyvalues);
            Array.Reverse(copyvalues);
            int[] treebigies = new int[3];
            Array.Copy(copyvalues, treebigies, 3);
            Console.WriteLine("Os três maiores valores são: ");
            foreach (int i in treebigies)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }

        private static void negativevalues(int[] listadevalores)
        {
            //int[] negativos = new int[listadevalores.Length];
            Console.WriteLine("Os valores negativos da lista são: ");
            foreach (int i in listadevalores)
            {
                if (i < 0)
                {
                    //negativos[i] = listadevalores[i];
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private static void minvalues(int[] listadevalores)
        {
            Console.WriteLine("O maenor valor da sequência é: " + listadevalores.Min());
        }

        private static void medianvalues(int[] listadevalores)
        {
            int soma = 0;
            Console.WriteLine("A média dos valores é: ");
            foreach (int i in listadevalores)
            {
                soma += i;
            }
            double media = (double)soma / listadevalores.Length;
            Console.WriteLine(media.ToString());
        }

        private static void maxvalue(int[] listadevalores)
        {
            Console.WriteLine("O maior valor da sequência é: " + listadevalores.Max());
        }
    }
}
