string inputString = "Hello World!";
int sum = 0; 
foreach (char c in inputString)
{
    sum += (int)c;
}
Console.WriteLine($"Cумма кодов символов строки: {sum}");