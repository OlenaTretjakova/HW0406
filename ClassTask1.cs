using System;

namespace HW0406
{
        public class Task1
        {
            private int width = 3;
            private int height = 3;
            private readonly string[,] arr;
            private Random rnd;

            public Task1()
            {
                arr = new string[width, height];
                rnd = new Random();

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        arr[i, j] = "*";
                    }
                }
            }

            public void ShowField()
            {
                Console.WriteLine();

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write("\t" + arr[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            public int MyChoice()
            {
                int value = int.Parse(Console.ReadLine());
                return value;
            }

            public void MoveUser()
            {
                while (true)
                {
                    Console.WriteLine("Enter value for i from 0 to 2: ");
                    int x = MyChoice();
                    Console.WriteLine("Enter value for j from 0 to 2: ");
                    int y = MyChoice();

                    if (arr[x, y] == "*")
                    {
                        arr[x, y] = "X";
                        break;
                    }
                }
            }

            public void MoveComp()
            {
                while (true)
                {
                    int x = rnd.Next(0, 3);
                    int y = rnd.Next(0, 3);

                    if (arr[x, y] == "*")
                    {
                        arr[x, y] = "O";
                        break;
                    }
                }
            }

            public bool Win(string symbol)
            {
                for (int i = 0; i < height; i++)
                {
                    if (arr[i, 0] == symbol && arr[i, 1] == symbol && arr[i, 2] == symbol)
                        return true;
                }

                for (int j = 0; j < width; j++)
                {
                    if (arr[0, j] == symbol && arr[1, j] == symbol && arr[2, j] == symbol)
                        return true;
                }

                if ((arr[0, 0] == symbol && arr[1, 1] == symbol && arr[2, 2] == symbol) ||
                    (arr[0, 2] == symbol && arr[1, 1] == symbol && arr[2, 0] == symbol))
                {
                    return true;
                }

                return false;
            }

            public void GameMoving()
            {
                Console.WriteLine("Who will you play with: 1.computer; 2.another player.");

                int numPlayers = int.Parse(Console.ReadLine());

                Console.WriteLine("The game starts:");
                ShowField();

                if (numPlayers == 1)
                {
                    int userTurn = rnd.Next(0, 2);

                    while (true)
                    {
                        if (userTurn == 0)
                        {
                            Console.WriteLine("Your turn (X):");
                            MoveUser();

                            Console.WriteLine("Computer's turn (O):");
                            MoveComp();
                        }
                        else
                        {
                            Console.WriteLine("Computer's turn (O):");
                            MoveComp();

                            Console.WriteLine("Your turn (X):");
                            MoveUser();
                        }

                        ShowField();

                        if (Win("X"))
                        {
                            Console.WriteLine("You won!");
                            break;
                        }

                        if (Win("O"))
                        {
                            Console.WriteLine("Computer won!");
                            break;
                        }

                    }
                }
                else if (numPlayers == 2)
                {
                    int userTurn = rnd.Next(0, 2);

                    while (true)
                    {
                        if (userTurn == 0)
                        {
                            Console.WriteLine("Player 1 turn (X):");
                            MoveUser();

                            Console.WriteLine("Player 2 turn (0):");
                            MoveUser();
                        }
                        else
                        {
                            Console.WriteLine("Your turn (X):");
                            MoveUser();

                            Console.WriteLine("Player 2 turn (0):");
                            MoveUser();
                        }

                        ShowField();

                        if (Win("X"))
                        {
                            Console.WriteLine("Player 1 won!");
                            break;
                        }

                        if (Win("O"))
                        {
                            Console.WriteLine("Player 2 won!");
                            break;
                        }

                    }

                }
            }



        }

}
