int len = new Random().Next(4,11);
double[] array = new double[len];

for(int i = 0; i < array.Length; i++){
    array[i] = new Random().NextDouble();
}

Console.WriteLine(string.Join(",     ",array));
double min = array[0];
double max = array[0];
for(int i = 0; i < array.Length; i++){
    if(min > array[i] )
        min = array[i];
    if(max < array[i])
        max = array[i];
}

Console.WriteLine(max - min);
