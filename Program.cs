namespace WhileLooop
{
    class Whileloop
    {
        static void Main(string[] args)
        {
            //SIMPLE WHILE LOOP
            //int x = 1;

            //while(x <= 10)
            //{
            //Console.WriteLine("Number " + x);
            //x++;
            //}

            //LOOP FOR ENTERING NUMBER BTWN 0 AND 10
            //int playerNumber = -1;

            //while (playerNumber < 0 || playerNumber > 10)
            //{
            //Console.WriteLine("Enter a number between 0 and 10");
            //string playerResponse = Console.ReadLine();
            //playerNumber = Convert.ToInt32(playerResponse);
            //}

            //DO WHILE LOOP
            //int playerNumber;
            //do
            //{
            //Console.WriteLine("Enter a number between 0 and 10 ");
            //string playerResponse = Console.ReadLine();
            //playerNumber = Convert.ToInt32(playerResponse);
            //}
            //while (playerNumber < 0 || playerNumber > 10);

            //THE FOR LOOP
            //for (int x = 2; x <= 10; x++)
            //{
            //Console.WriteLine(x);
            //}

            //BREAKING OUT OF LOOPS
            //int numberThatCausesProblems = 54;

            //for (int x = 1; x <=100; x++)
            //{
            //Console.WriteLine(x);

            //if (x == numberThatCausesProblems)
            //break;
            //}

            //FOREVER LOOP WORTH BREAKING
            //while (true)
            //{
            //Console.WriteLine("What is thy bidding, my maste?");
            //string input = Console.ReadLine();

            //if (input == "quit" || input == "exit")
            //break;
            //}

            //CONTINUING TO THE NEXT ITERATION OF THE LOOP
            //for (int x = 1; x <= 10; x++)
            //{
            //if (x == 3)
            //continue;
            //break;

            //Console.WriteLine(x);
            //}

            //NESTING LOOPS
            //for (int row = 0; row < 5; row++)
            //{
            //for (int column = 0; column < 10; column++)
            //Console.WriteLine("*");

            //Console.WriteLine();               
            //}

            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < row + 1; column++)
                    Console.WriteLine("*");

                Console.WriteLine();
               
            }
        }
    }
}