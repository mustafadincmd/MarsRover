


/// İlk input  AreaSize Örn: 5 5 
/// S-E-W-N yönleri için bir değişken tut
/// hareket özellikler LMR 
/// Maksimum alanı geçer ise hata mesajı gönder. 
/// 
/// 1. Plato Size 5,5 
/// 2. Current Location 
/// 3. LMLMLMLMLMMM
/// 4. Verilen son yönden sonra son konumu 
///     
///Test için olması gerekenler 
///1. sola ve sağa dönmeli 
///ileri gidebilmeli 
///area içerisinde kalmalı 
/// 
Console.WriteLine("Lütfen alan boyutunu yazınız. Örn: 5 5 ");
var Area = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
var CurrentLocation = Console.ReadLine().Trim().Split(' ');
Rover rover = new Rover();

if (CurrentLocation.Count() == 3)
{
    rover.X = Convert.ToInt32(CurrentLocation[0]);
    rover.Y = Convert.ToInt32(CurrentLocation[1]);
    rover.Direction = (Direction)Enum.Parse(typeof(Direction), CurrentLocation[2]);
}

var Rotation = Console.ReadLine().ToUpper();

try
{
    rover.Execute(Area, Rotation);
    Console.WriteLine($"{rover.X} {rover.Y} {rover.Direction.ToString()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();



