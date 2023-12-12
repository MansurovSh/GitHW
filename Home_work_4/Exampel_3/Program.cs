void InputMatrix(int[] matrix, int len){
    if(len == 0)
        Console.Write($" {matrix[len]}");
    if(len > 0){
        Console.Write($" {matrix[len]} ,");
        InputMatrix(matrix,--len);
    }
            
}
Console.WriteLine("Введите массив: ");
int[] matrix = (Console.ReadLine().Split(" ").Select(x => int.Parse(x))).ToArray();
InputMatrix(matrix, matrix.Length - 1);
