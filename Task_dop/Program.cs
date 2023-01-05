Console.Clear();
Console.Write("Введите размер грядки: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for(int i = 0; i < n; i++){
Console.Write($"Введите урожайность куста {i + 1}: ");
array [i] = Convert.ToInt32(Console.ReadLine());
}
Console.Clear();
Console.WriteLine($"Урожайность грядки: [{String.Join(", ", array)}]");
int max = 0;
for(int i = 1; i < n - 1; i++){
    if(array[i - 1] + array[i] + array[i + 1] > max)
      max = array[i - 1] + array[i] + array[i + 1];
    
    if(array[0] + array[1] + array[n - 1] > max)
    max = array[0] + array[1] + array[n - 1];

    if(array[n - 1] + array[n - 2] + array[0] > max)
    max = array[n - 1] + array[n - 2] + array[0];
}
Console.WriteLine($"Максимальный урожай трёх кустов составит: {max} ягод");