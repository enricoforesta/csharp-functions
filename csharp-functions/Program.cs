namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stampa array
            void StampaVirgolaESpazio()
            {
                Console.Write(", ");
            }
            void StampaArray(int[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                        StampaVirgolaESpazio();
                }
                Console.Write("]");
                Console.WriteLine("");
            }

            // Stampa numero al quadrato 
            int Quadrato(int numero)
            {
                int result = numero * numero;
                return result;
            }

            // Stampa Array al quadrato
            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] resultArray = (int[])array.Clone();
                for (int i = 0;i < resultArray.Length; i++)
                {
                    resultArray[i] = Quadrato(resultArray[i]);
                }
                return resultArray;
            }
            // Stampa Somma Array
            int SommaElementiArray(int[] array)
            {
                int somma = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    somma += array[i];
                }
                return somma;
            }

            // Creazione Array 
            int[] CreazioneArray()
            {
                Console.WriteLine("indica la lunghezza dell array");
                int nInput = Convert.ToInt32(Console.ReadLine());
                int[] arrayNum = new int[nInput];
                Console.WriteLine("indica i numeri da inserire nell  array");
                for (int i = 0; i < arrayNum.Length; i++)
                {
                    arrayNum[i] = Convert.ToInt32(Console.ReadLine());
                }
                return arrayNum;
            }


            // Creazione Array 
            int[] arrayNum=  CreazioneArray();

            // Stampa array
            //int[] arrayNum = [2, 6, 7, 5, 3, 9];
            Console.WriteLine($"Array originale");
            StampaArray(arrayNum);


            // Stampa Array al quadrato
            Console.WriteLine("Array copia");
            StampaArray((ElevaArrayAlQuadrato(arrayNum)));
            Console.WriteLine("Array originale");
            StampaArray(arrayNum);

            // Stampa Somma numeri Array
            Console.WriteLine($"La somma dei numeri è {SommaElementiArray(arrayNum)}");

            //Stampa Somma numeri al quadrato Array
            Console.WriteLine($"La somma dei numeri è { SommaElementiArray(ElevaArrayAlQuadrato(arrayNum))}");
        }
    }
}
