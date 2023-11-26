int[] array = new int[10];
int count = 0;
for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(0,1000);
    if(array[i] % 2 == 0)
        count++; 
}
Console.WriteLine(string.Join(", ",array));
Console.WriteLine(count);
