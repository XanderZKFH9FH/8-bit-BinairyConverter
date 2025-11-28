namespace Binairy_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vars

            int BinairyNumber = 0;
            string BinairySolution = "";
            int Length = 0;
            string Num = "";
            int Loops = 0;
            int Max = 1;
            int Pow = 0;
            int Output = 0;
            int UserBreak = 0;
            while (UserBreak != 1)
            {
                //End

                Console.WriteLine("Type 1 to quit converting");
                int.TryParse(Console.ReadLine(), out UserBreak);

                //BreakCheck
                if (UserBreak != 1)
                {

                    //TXT

                    Console.WriteLine("Hey, I am asuming you want to convert a binairy number (up to 8 bits)!");
                    Console.Write("Please insert your binairy number : ");

                    // Conversions

                    int.TryParse(Console.ReadLine(), out BinairyNumber);
                    Console.WriteLine(BinairyNumber);
                    BinairySolution = Convert.ToString(BinairyNumber);
                    Length = BinairySolution.Length;

                    // Calc

                    while (Length != 0)
                    {
                        Num = BinairySolution.Substring(Loops, Max);
                        Length--;
                        if (Num == "1")
                        {
                            Output = (int)(Output + Math.Pow(2, Loops));
                        }
                        else
                        {

                        }
                        Loops++;
                    }
                    Console.WriteLine(Output);
                }
            }
        }
    }
}
