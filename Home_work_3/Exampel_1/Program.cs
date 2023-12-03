
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


void get(int[,] matrix,int row,int col){
    if(row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        Console.WriteLine("Позисия неопределена");
    else
        Console.WriteLine($"matrix[{row},{col}] = {matrix[row,col]}");
}

Console.WriteLine("Введите размеры массива");
int[] size = (Console.ReadLine().Split(" ").Select(x => int.Parse(x))).ToArray();
int[,] matrix = new int[size[0],size[1]];
ReadMatrix(matrix);
InputMatrix(matrix);
get(matrix,1,3);
