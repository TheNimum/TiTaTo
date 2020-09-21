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
           bool Wincondition = false;
            while (Wincondition == false)
            {
           
            print(Board);
            System.Console.Write("print a row  number: ");
            int row = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("print a colum  number: ");
            int colums = Convert.ToInt32(Console.ReadLine());
            
             Board[row,colums] = Player;
           
            


                
                
                    if(Player == Board[0,0] && Player == Board[0,1] && Player == Board[0,2])
                        {
                            System.Console.WriteLine($"{Player} has won the game!. ");
                            
                            Console.ReadKey();
                            Wincondition = true;
                        }
                    
                    
                        if(Player == Board[0,0] && Player == Board[1,0] && Player == Board[2,0])
                        {
                            System.Console.WriteLine($"{Player} has won the game!. ");
                            
                            Console.ReadKey();
                            Wincondition = true;
                        }
                    
                    
                   
                    
                        if(Player == Board[0,2] && Player == Board[1,1] && Player == Board[2,0])
                        {
                            System.Console.WriteLine($"{Player} has won the game!. ");
                            
                            Console.ReadKey();
                            Wincondition = true;
                        }
                        
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
