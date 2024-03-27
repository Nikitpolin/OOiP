namespace _IMovable;
using _Vector;

public interface IMovable
{
    public Vector Location { get; set; }
    public Vector Velosity { get; }
}
