// y = k1 * x + b1,
// y = k2 * x + b2;
decimal k1 = 5m;
decimal b1 = 2m;
decimal k2 = 9m;
decimal b2 = 4m;

decimal x12 = -10.0m;
decimal step = 0.1m;
decimal y1 = k1 * x12 + b1;
decimal y2 = k2 * x12 + b2;
decimal count = 0.0m;

while (count != -1)
{   
    if(x12 > 10)
    {
        Console.WriteLine("Stop");
        break;
    }
    {
    y1 = k1 * x12 + b1;
    y2 = k2 * x12 + b2;      
    if (y1 == y2)
    {
        Console.WriteLine(x12 + " " + y2);
        break;
    }
    x12 = x12 + step;
    count++;
    }
}



// decimal a = 1m;
// decimal b = 0.9m;
// Console.WriteLine(a - b);

// Math.Round