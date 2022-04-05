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
            int playerNumber = -1;

            while (playerNumber < 0 || playerNumber > 10)
            {
                Console.WriteLine("Enter a number between 0 and 10");
                string playerResponse = Console.ReadLine();
                playerNumber = Convert.ToInt32(playerResponse);
            }
        }
    }
}