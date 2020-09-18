using System;

namespace TiTaTo
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            char[,] Board = new char[3,3]; // detta är kärnan av indexeringen av spel rutorna
            Board[0,0] = 'x';
            Board[2,2] = 'O';
            intro();
            print(Board);
            
            System.Console.Write("print a row  number: ");
            int row = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("print a colum  number: ");
            int colums = Convert.ToInt32(Console.ReadLine());
           Board[row,colums] = 'X';
           print(Board);


            
        }
         public static void intro()
            {
            Console.WriteLine("---------------------");
            Console.WriteLine("welcome to tic-tac-toe");
            Console.WriteLine("--------------------");
            }
            
            static void print(char[,]Board)
            {
                for (int row = 0; row < 3; row++) // denna 4loopen skriver ut all resultat 
                {
                    Console.Write("| ");
                        for (int colums = 0; colums < 3; colums++)
                        {
                            Console.Write(Board[row, colums]);
                            Console.Write(" | ");
                        }
                        Console.WriteLine();
                }
                
            }
    }
        
           
    
}
