//Строка кватратной матрицы с наименшим суммой  элементов или Сумма 
int min_sum(int[,] matrix){
    int min = int.MaxValue;
    int sum;
    int min_s = 0;
    for(int i = 0; i < matrix.GetLength(0); i++){
        sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
            sum += matrix[i,j];
        if(sum < min){
            min = sum;
            min_s = i;
        }
    }
    return min_s; // return min;

}
void ReadMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 100);
    }
}

void InputMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine("");
    }
}

Console.WriteLine("Введите размеры массива");
int[] size = (Console.ReadLine().Split(" ").Select(x => int.Parse(x))).ToArray();
int[,] matrix = new int[size[0], size[1]];
ReadMatrix(matrix);
InputMatrix(matrix);
Console.WriteLine($"строка с наименшим суммой элементов : {min_sum(matrix)}");

