using System;
using System.Text;

class Percolation
{

            private static int constant = 9;
            private static bool[,] matrix = new bool[constant, constant];
            private static int[] numbers = new int[constant * constant + 1];
            private static int TOP = 0;
            private static int NumberOfOpenSites = 0;
            static bool test_init()
            {
                 Console.WriteLine("test cases");
                 for (int i = 0; i < matrix.GetLength(0); i++)
                 {
                      for (int j = 0; j < matrix.GetLength(1); j++)
                      {
                           if (matrix[i, j] != false)
                           {
                                Console.WriteLine("falled test");
                                return false;
                           }
                      }
                 }
       
                 return true;
            }
       
            static bool test_Open()
            {
                 Console.WriteLine("\n open test cases ");
                 
                 Open(1, 4);
                 Open(1, 1);
                 Open(2, 1);
                 Open(3, 2);
                 Open(2, 3);
                 Open(3, 3);
                 Open(6, 4);
                 Open(3, 5);
                 Open(3, 6);
                 Open(3, 7);
                 Open(3, 8);
                 Open(4, 8);
                 Open(5, 8);
                 Open(5, 7);
                 Open(5, 6);
                 Open(5, 5);
                 Open(6, 5);
                 Open(7, 5);
                 Open(8, 5);
                 Open(9, 5);
                 Open(6, 2);
                 Open(9, 1);
                 Open(8, 1);
                 Open(9, 2);
                 
                 print_input();

                 bool expected1 = true;
                 bool expected2 = true;
                 bool expected3 = true;
                 bool expected4 = false;
                 bool expected5 = false;

                 bool actual1 = isOpen(1, 1);
                 bool actual2 = isOpen(2, 1);
                 bool actual3 = isOpen(3, 3);
                 bool actual4 = isOpen(8, 8);
                 bool actual5 = isOpen(9, 9);

                 if (actual1 != expected1)
                 {
                      Console.WriteLine("Test 1 failed");
                      return false;
                 }
                 if (actual2 != expected2)
                 {
                      Console.WriteLine("Test 2 failed");
                      return false;
                 }
                 if (actual3 != expected3)
                 {
                      Console.WriteLine("Test 3 failed");
                      return false;
                 }
                 if (actual4 != expected4)
                 {
                      Console.WriteLine("Test 4 failed");
                      return false;
                 }
                 if (actual5 != expected5)
                 {
                      Console.WriteLine("Test 5 failed");
                      return false;
                 }

                 return true;
            }

            static bool test_union()
            {
                 bool expected1 = true;
                 bool expected2 = true;
                 bool expected3 = false;

                 bool actual1 = ConnectSites(Index(7, 0), Index(8, 0));
                 bool actual2 = ConnectSites(Index(0, 0), Index(2, 7));
                 bool actual3 = ConnectSites(Index(0, 0), Index(8, 0));

                 if (actual1 != expected1)
                 {
                      Console.WriteLine("test 1 failed ");
                      return false;
                 }
                 if (actual2 != expected2)
                 {
                      Console.WriteLine("test 2 failed ");
                      return false;
                 }
                 if (actual3 != expected3)
                 {
                      Console.WriteLine("test 3 failed ");
                      return false;
                 }

                 return true;
            }

            static bool test_root()
            {
                 Console.WriteLine("\n root test");

                 int expected1 = 0;
                 int expected2 = 64;
                 int expected3 = 0;

                 int actual1 = Root(Index(2, 7));
                 int actual2 = Root(Index(8, 0));
                 int actual3 = Root(Index(8, 4));

                 if (actual1 != expected1)
                 {
                      Console.WriteLine("test 1 failed ");
                      return false;
                 }
                 if (actual2 != expected2)
                 {
                      Console.WriteLine("test 2 failed ");
                      return false;
                 }
                 if (actual3 != expected3)
                 {
                      Console.WriteLine("test 3 failed ");
                      return false;
                 }

                 return true;
            }
            static bool test_isOpen()
            {
                 Console.WriteLine("\n isOpen test");
                 
                 bool expected1 = true;
                 bool expected2 = true;
                 bool expected3 = true;
                 bool expected4 = false;
                 bool expected5 = false;

                 bool actual1 = matrix[4, 6];
                 bool actual2 = matrix[4, 5];
                 bool actual3 = matrix[4, 4];
                 bool actual4 = matrix[7, 7];
                 bool actual5 = matrix[8, 8];
                 
                 if (actual1 != expected1)
                 {
                      Console.WriteLine("Test 1 failed");
                      return false;
                 }
                 if (actual2 != expected2)
                 {
                      Console.WriteLine("Test 2 failed");
                      return false;
                 }
                 if (actual3 != expected3)
                 {
                      Console.WriteLine("Test 3 failed");
                      return false;
                 }
                 if (actual4 != expected4)
                 {
                      Console.WriteLine("Test 4 failed");
                      return false;
                 }
                 if (actual5 != expected5)
                 {
                      Console.WriteLine("Test 5 failed");
                      return false;
                 }

                 return true;
            }

            static bool test_percoletes()
            {
                 Console.WriteLine("\n percolates test");
                 
                 bool expected1 = true;

                 bool actual1 = percolates();

                 if (actual1 != expected1)
                 {
                      Console.WriteLine("TEST 1 failed");
                      return false;
                 }

                 return true;
            }

            static bool test_isFull()
            {
                 Console.WriteLine("\n issFull test");
                 
                 bool expected1 = true;
                 bool expected2 = true;
                 bool expected3 = true;
                 bool expected4 = false;
                 bool expected5 = false;

                 bool actual1 = isFull(5,5);
                 bool actual2 = isFull(5,6);
                 bool actual3 = isFull(5,7);
                 bool actual4 = isFull(6,2);
                 bool actual5 = isFull(9,1);

                 if (actual1 != expected1)
                 {
                      Console.WriteLine("TEST 1 failed ");
                      return false;
                 }
                 if (actual2 != expected2)
                 {
                      Console.WriteLine("TEST 2 failed ");
                      return false;
                 } 
                 if (actual3 != expected3)
                 {
                      Console.WriteLine("TEST 3 failed ");
                      return false;
                 }
                 if (actual4 != expected4)
                 {
                      Console.WriteLine("TEST 4 failed ");
                      return false;
                 } 
                 if (actual5 != expected5)
                 {
                      Console.WriteLine("TEST 5 failed ");
                      return false;
                 }

                 return true;
            }

            static bool test_numberOfOpenSites()
            {
                 Console.WriteLine("\nnumberOfOpenSites test");
                 
                 int expected1 = 23;
                 int actual1 = numberOfOpenSites();

                 if (actual1 != expected1)
                 {
                      Console.WriteLine("Test 1 failed ");
                      return false;
                 }

                 return true;
            }

            static void Main()
            {

                 Console.WriteLine("Percolation\n");


                 init(constant);
                 Console.ForegroundColor = ConsoleColor.Cyan;
                 Console.WriteLine("Work: {0}" , test_init());
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine("Work: {0}" , test_Open());
                 Console.ForegroundColor = ConsoleColor.Yellow;
                 Console.WriteLine("Work:: {0}" , test_root());
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("Work:: {0}" , test_union());
                 Console.ForegroundColor = ConsoleColor.Blue;
                 Console.WriteLine("Work:: {0}" , test_isOpen());
                 Console.ForegroundColor = ConsoleColor.DarkYellow;
                 Console.WriteLine("Work:: {0}" , test_percoletes());
                 Console.ForegroundColor = ConsoleColor.Magenta;
                 Console.WriteLine("Work:: {0}" , test_isFull());
                 Console.ForegroundColor = ConsoleColor.White;
                 Console.WriteLine("Work:: {0}" , test_numberOfOpenSites());

                 input();
                 init(constant);

                 
                 while (percolates() != true)
                 {
                      Console.Clear();
                      
                      print_input();
                      Console.ForegroundColor = ConsoleColor.Cyan;
                      Console.WriteLine("\nChoose the site to be opened ");

                      string siteOpener = Convert.ToString(Console.ReadLine());

                      string[] split = siteOpener.Split(' ');
                      bool tryX, tryY;
                      int x, y;

                      try
                      {
                           tryX = int.TryParse(split[0], out x);
                           tryY = int.TryParse(split[1], out y);
                      }
                      catch
                      {
                           Console.WriteLine("Invalid");
                           
                           continue;
                      }

                      if (tryX == false || tryY == false || x! <0||y!<0 ||x!>constant||y!>constant)
                      {
                           Console.WriteLine("Exit y/n \t");
                           string exit = Console.ReadLine();
                           switch (exit)
                           {
                                case "y":
                                case "x":
                                default:
                                     Console.WriteLine("Number of Open sites {0}",numberOfOpenSites());
                                     Console.WriteLine("Does the system percolate : {0}", percolates());
                                     return;
                                case "n":
                                     continue;
                           }
                      }
                      
                      Open(x, y);
                      
                      print_input();
                      
                      Console.WriteLine("Number of open sites {0}", numberOfOpenSites());
                      Console.WriteLine("System percolates {0}", percolates());
                      
                 }



            }

            static void input()
            {
                 Console.ForegroundColor = ConsoleColor.White;
                 Console.Write("\n Generate the matrix , input size\t");
                 try
                 {
                      constant = int.Parse(Console.ReadLine());
                      
                 }
                 catch 
                 {
                      Console.WriteLine("Invalid ");
                      Environment.Exit(0);
                 }

                 if (constant<=0)
                 {
                      Console.WriteLine("Invalid");
                      Environment.Exit(0);
                 }
            }

            static void init(int n) //
            {
                 matrix = new bool[n, n];
                 numbers = new int[n * n + 1];
                 
                 NumberOfOpenSites = 0;
                 
                 for (int i = 0; i < n; i++)
                 {
                      for (int j = 0; j < n; j++)
                      {
                           matrix[i, j] = false;
                      }
                 }

                 for (int i = 0; i < n*n+1 ; i++)
                 {
                      numbers[i] = i;

                 }
            }

            static void Open(int row, int col)
            {
                 if (!isOpen(row,col))
                 {
                      NumberOfOpenSites++;
                 }

                 row = row - 1;
                 col = col - 1;
                 
                 matrix[row, col] = true;

                 if (row == 0 && matrix[row,col])
                 {
                      Union(Index(0, col), TOP);
                 }

                 if (row>0 && matrix[row-1 , col])
                 {
                      Union(Index(row, col), Index(row - 1, col));
                 }

                 if (col>0 && matrix[row,col -1])
                 {
                      Union(Index(row, col), Index(row, col - 1));
                      
                 }

                 if (row<matrix.GetLength(0) - 1 && matrix[row+1 , col])
                 {
                      Union(Index(row, col), Index(row + 1, col));
                 }

                 if (col<matrix.GetLength(0)-1 && matrix[row,col+1])
                 {
                      Union(Index(row, col), Index(row, col + 1));
                 }

                 
            }

            static bool isOpen(int row, int col)
            {
                 return matrix[row - 1, col - 1];
            }

            static bool isFull(int row, int col)
            {
                 return ConnectSites(Index(row - 1, col - 1), TOP);
            }

            static int numberOfOpenSites()
            {
                 return NumberOfOpenSites;
            }

            static void print_input()
            {
                 Console.WriteLine("\n"+ "0-block\n"+" 1-open\n"+"2-full\n");

                 for (int i = 0; i < matrix.GetLength(0); i++)
                 {
                      for (int j = 0; j < matrix.GetLength(1); j++)
                      {
                           switch (matrix[i,j])
                           {
                                case false:
                                     Console.ForegroundColor = ConsoleColor.Red;
                                     Console.Write(" 0   ");
                                     break;
                                    
                                case true when ! isFull(i+1 , j+1):
                                     Console.ForegroundColor = ConsoleColor.DarkGreen;
                                     Console.Write("1   ");
                                     break;
                                case true when isFull(i+1,j+1):
                                     Console.ForegroundColor = ConsoleColor.Blue;
                                     Console.Write("2   ");
                                     break;
                           }
                      }
                      Console.WriteLine("\n");
                 }
            }

            static void Union(int x, int y) // алгоритм юніон файн , перевірка коренів для кожної множини
            {                
                 int rootX = Root(x);
                 int rootY = Root(y);
 
                 
                 if (rootX>rootY)
                 {
                      numbers[rootX] = rootY;
                 }
                 else
                 {
                      numbers[rootY] = rootX;
                 }
                 
            }

            static int Index(int row, int col) // двовимірн. в одновим.
            {

                 return row * matrix.GetLength(0) + col + 1;
            }

            static int Root(int x)
            {
                 int final = numbers[x];
                 
                 while (final != numbers[final])
                 {
                      numbers[final] = numbers[numbers[final]];
                      final = numbers[final];
                 }

                 return final;
            }

            static bool ConnectSites(int x, int y) // порівняння коренів
            {
                 return Root(x) == Root(y);
            }

            static bool percolates()
            {
                 for (int i = 0; i < constant; i++)
                 {
                      if (isFull(matrix.GetLength(0),i))
                      {
                           return true;
                      } 
                 }

                 return false;
            }

   
     }
