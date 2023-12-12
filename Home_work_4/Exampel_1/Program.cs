void writeRangeNumber(int m, int n){
    if(m == n)
        Console.Write($"{n}");
    else{
        Console.Write($"{m} ,");
        writeRangeNumber(m + 1,n);
    }
}
Console.WriteLine("Задайте диапазон: ");
int[] number = (Console.ReadLine().Split(" ").Select(x => int.Parse(x))).ToArray();
writeRangeNumber(number[0],number[1]);
