var s = Console.ReadLine();
var n = int.Parse(s?.Split(' ')[0]);
var m = int.Parse(s.Split(' ')[1]);

var result = 0;
while (n % 2 == 0 || m % 2 == 0)
{
    if (n % 2 == 0 && n >= m)
    {
        n /= 2;
        result++;
    }
    else if (m % 2 == 0 && n <= m)
    {
        m /= 2;
        result++;
    }
    else if (m % 2 == 0 && n > m)
    {
        m /= 2;
        result++;
    }
    else if (n % 2 == 0 && n < m)
    {
        n /= 2;
        result++;
    }
}
Console.WriteLine(result);