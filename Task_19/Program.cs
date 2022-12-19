// Task 19
Console.WriteLine("Введите пятизначное число");
string? a = (Console.ReadLine());
while(a.Length != 5){
    Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число");
    a = (Console.ReadLine());
}
if(a[0] == a[4] && a[1] == a[3]){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}