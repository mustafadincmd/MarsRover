

public class Rover : IRover
{
    public int X { get; set; }
    public int Y { get; set; }
    public Direction Direction { get; set; }

    public Rover()
    {
        X = Y = 0;
        Direction = Direction.N;
    }

    private void TurnLeft()
    {
        switch (this.Direction)
        {
            case Direction.N:
                this.Direction = Direction.W;
                break;
            case Direction.S:
                this.Direction = Direction.E;
                break;
            case Direction.E:
                this.Direction = Direction.N;
                break;
            case Direction.W:
                this.Direction = Direction.S;
                break;
            default:
                break;
        }
    }

    private void TurnRight()
    {
        switch (this.Direction)
        {
            case Direction.N:
                this.Direction = Direction.E;
                break;
            case Direction.S:
                this.Direction = Direction.W;
                break;
            case Direction.E:
                this.Direction = Direction.S;
                break;
            case Direction.W:
                this.Direction = Direction.N;
                break;
            default:
                break;
        }
    }

    private void Forward()
    {
        switch (this.Direction)
        {
            case Direction.N:
                this.Y += 1;
                break;
            case Direction.S:
                this.Y -= 1;
                break;
            case Direction.E:
                this.X += 1;
                break;
            case Direction.W:
                this.X -= 1;
                break;
            default:
                break;
        }
    }


    public void Execute(List<int> Area, string Char)
    {
        foreach (var item in Char)
        {
            switch (item)
            {
                case 'M':
                    this.Forward();
                    break;
                case 'L':
                    this.TurnLeft();
                    break;
                case 'R':
                    this.TurnRight();
                    break;
                default:
                    Console.WriteLine($"Geçersiz Karakter => {item}");
                    break;
            }

            if (this.Y > Area[1] || this.X < 0 || this.Y < 0 || this.X > Area[0] )
            {
                throw new Exception($"Lütfen alan sınırları içerisinde bir değer giriniz :  ({Area[0]} , {Area[1]})");
            }

        }
    }
}
