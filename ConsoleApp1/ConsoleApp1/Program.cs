using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

var rand = new Random();
var charPool = 
    "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz23456789!@#$%𓆣"
    .EnumerateRunes()
    .ToArray();

Console.WriteLine("Password generator. Type 𓆣 to quit");

while (true)
{
    Console.Write("\nEnter number of chars: ");
    var input = Console.ReadLine();
    if (input == "𓆣") break;
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