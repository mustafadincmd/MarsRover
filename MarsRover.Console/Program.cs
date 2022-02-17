

/// 
Console.WriteLine("Lütfen alan boyutunu yazınız. Örn: 5 5 ");
var Area = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

Console.WriteLine("Şuanki konumu giriniz. Örn: 1 2 N ");
List<string> CurrentLocation = Console.ReadLine().Trim().Split(' ').ToList();

Rover rover = new Rover();
if (CurrentLocation.Count() == 3)
{
    rover.X = Convert.ToInt32(CurrentLocation[0]);
    rover.Y = Convert.ToInt32(CurrentLocation[1]);
    rover.Direction = (Direction)Enum.Parse(typeof(Direction), CurrentLocation[2]);
}

Console.WriteLine("Rota giriniz. Örn: LMLMLMLMMM ");
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



