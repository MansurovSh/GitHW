int[] array = new int[10];
int count = 0;
for(int i = 0;i < array.Length; i++){
    array[i] = new Random().Next(1,100);
    if( array[i] >= 20 && array[i] <= 90)
        count++;
}
Console.WriteLine(string.Join(", ",array));
Console.WriteLine(count);
