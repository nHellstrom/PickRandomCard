using PickRandomCard;

bool wroteNumber = false;

do
{
    Console.Write("How many cards shall be drawn? ");
    string drawAmount = Console.ReadLine();

    Console.WriteLine();

    if (int.TryParse(drawAmount, out int numberOfCards))
    {
        wroteNumber = true;
        int draw = 1;
        string[] drawnCards = CardPicker.PickSomeCards(numberOfCards);

        foreach (var card in drawnCards)
        {
            if (draw % 2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }

            Console.WriteLine(format: "Card #{0,2}: {1,18}",draw++, card);
        }

        Console.BackgroundColor = ConsoleColor.Black;

    }
    else
    {
        // Infinite write, fix this
        Console.WriteLine("Please repeat your number.");
    }
}
while (!wroteNumber);


