using System;

namespace letra
{
    class Program
    {
        static void Main(string[] args)
        {
            pintarU();
            pintarX();
        }

        static char[,] pintarU()
        {
            
            char[,] letraU = new char[7,7] { {'*',' ',' ',' ',' ',' ','*'},
                                             {'*',' ',' ',' ',' ',' ','*'},
                                             {'*',' ',' ',' ',' ',' ','*'},
                                             {'*',' ',' ',' ',' ',' ','*'},
                                             {'*',' ',' ',' ',' ',' ','*'},
                                             {'*',' ',' ',' ',' ',' ','*'},
                                             {'*','*','*','*','*','*','*'}};
            
            for (int row = 0; row < 7; row++) 
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write(letraU[row,col]);
                }   
                Console.WriteLine();
            }

            return letraU;    
        }

        static char[,] pintarX()
        {
            char[,] letraX = new char[7,7] { {'*',' ',' ',' ',' ',' ','*'},
                                             {' ','*',' ',' ',' ','*',' '},
                                             {' ',' ','*',' ','*',' ',' '},
                                             {' ',' ',' ','*',' ',' ',' '},
                                             {' ',' ','*',' ','*',' ',' '},
                                             {' ','*',' ',' ',' ','*',' '},
                                             {'*',' ',' ',' ',' ',' ','*'}};
            
            for (int row = 0; row < 7; row++) 
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write(letraX[row,col]);
                }   
                Console.WriteLine();
            }

            return letraX;  

        }
    }
}
