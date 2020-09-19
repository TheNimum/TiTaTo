using System;

namespace TiTaTo
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            char Player = 'X';
            char[,] Board = new char[3,3]; // detta är kärnan av indexeringen av spel rutorna
           
            
            intro();
           bool Wincondition = true;
            while (Wincondition == true)
            {
           
            print(Board);
            System.Console.Write("print a row  number: ");
            int row = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("print a colum  number: ");
            int colums = Convert.ToInt32(Console.ReadLine());
            
             Board[row,colums] = Player;
           
            Player = whosturn(Player);
           
           
           
            }

            
        }
        public static char whosturn(char currentplayer)
        {
             if (currentplayer == 'X')
           {
               return 'O'; 
           }else 
                {
                    return 'X'; 
                }

        }
         public static void intro()
            {
            Console.WriteLine("---------------------");
            Console.WriteLine("welcome to tic-tac-toe");
            Console.WriteLine("--------------------");
            }
            
            static void print(char[,]Board)
            {
                System.Console.WriteLine("   0   1   2   ");
                for (int row = 0; row < 3; row++) // denna 4loopen skriver ut all resultat 
                {
                    Console.Write(row + "| ");
                        for (int colums = 0; colums < 3; colums++)
                        {
                            Console.Write(Board[row, colums]);
                            Console.Write(  " | ");
                        }
                        Console.WriteLine();
                }
                
            }
    }
        
           
    
}
