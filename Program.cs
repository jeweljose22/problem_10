
Queue<int> b1 = new Queue<int>();
Queue<int> b2 = new Queue<int>();
Queue<int> b3 = new Queue<int>(); Console.WriteLine("enter the values");
int[] valuee = new int[10];
for (int i = 0; i < 10; i++)
{
    valuee[i] = Convert.ToInt32(Console.ReadLine());
    if (b1.Count < 3)
        b1.Enqueue(valuee[i]);
    else if (b2.Count < 3)
        b2.Enqueue(valuee[i]);
    else
        b3.Enqueue(valuee[i]);
}
Console.WriteLine("-----------------------------------------");
Random rnd = new Random();
int randNum = rnd.Next(0, 3);
Console.WriteLine("Randomn value" + randNum);
if (randNum == 0)
{
    b1.Dequeue();
    b1.Enqueue(valuee[9]);
    Console.WriteLine("first");
}
if (randNum == 1)
{
    b2.Dequeue();
    b2.Enqueue(valuee[9]);
    Console.WriteLine("second");
}
if (randNum == 2)
{
    b3.Dequeue();
    b3.Enqueue(valuee[9]);
    Console.WriteLine("third");
}
foreach (var i in b1)
{
    Console.Write(i);
    Console.WriteLine(" 1st ");
}
foreach (var i in b2)
{
    Console.Write(i);
    Console.WriteLine(" 2nd ");
}
foreach (var i in b3)
{
    Console.Write(i);
    Console.WriteLine(" 3rd ");
}


