void tr_matrix(int[,] matrix){
    int m = 0;
    int row = matrix.GetLength(0) - 1; 
    for(int i = 0; i < matrix.GetLength(1); i++){
        m = matrix[0,i];
        matrix[0,i] = matrix[row, i];
        matrix[row, i] = m;
    }
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
int[,] matrix = new int[size[0],size[1]];
ReadMatrix(matrix);
InputMatrix(matrix);
Console.WriteLine("Трансформированная матрица :");
tr_matrix(matrix);
InputMatrix(matrix);

