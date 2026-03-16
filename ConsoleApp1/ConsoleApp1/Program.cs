using System.Text;

var rand = new Random();
const string charPool = 
    "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz23456789!@#$%𓆣";
Console.WriteLine("Password generator. Type q to quit");
while (true)
{
    Console.Write("\nEnter number of chars: ");
    var input = Console.ReadLine();
    if (input == "q") break;
    if (int.TryParse(input, out int passLength))
    {
        var sb = new StringBuilder();
        for (var i = 0; i < passLength; i++)
        {
            var index = rand.Next(charPool.Length);
            sb.Append(charPool[index]);
        }
        Console.WriteLine(sb.ToString());
    }
    else
    {
        Console.WriteLine("Invalid input. Try again");
    }
}