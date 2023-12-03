int[,] Minor(int[,] matrix, int row, int col){
    int[,] minor = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for(int i = 0, r = 0; i < matrix.GetLength(0); i++, r++){
        if(i == row)
            i++;
        for(int j = 0, c = 0; j < matrix.GetLength(1); j++, c++){
            if(j == col)
                j++;
            minor[r,c] = matrix[i,j];
        }
    }
    return minor;
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
Console.WriteLine("Введите позиции по котором надо вазять минор :");
int row = Convert.ToInt32(Console.ReadLine());
int col = Convert.ToInt32(Console.ReadLine());
ReadMatrix(matrix);
InputMatrix(matrix);
Console.WriteLine("Минор матрици по позиции :");
InputMatrix(Minor(matrix,row,col));

