using System.Text;

var rand = new Random();
const string charPool = 
    "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz23456789!@#$%";
Console.WriteLine("Password generator. Enter number of chars: ");
if (int.TryParse(Console.ReadLine(), out int passLength))
{
    var sb = new StringBuilder();
    for (var i = 0; i < passLength; i++)
    {
        var index = rand.Next(charPool.Length);
        sb.Append(charPool[index]);
    }
    Console.WriteLine(sb.ToString());
}