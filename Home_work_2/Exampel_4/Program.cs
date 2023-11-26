int number = new Random().Next(0,100001);
Console.WriteLine(number);
int len = (Convert.ToString(number)).Length;
int[] array = new int[len];
for(int i = 0; i < len; i++){
    array[len - i - 1] = number % 10;
    number /= 10; 
}

Console.WriteLine(string.Join(", ",array));
