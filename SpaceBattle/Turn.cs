namespace SpaceBattle;

 public interface IRotate
{
    int RotationRate { get; }
}

public class RotationCommand : ICommand
{
    private readonly IRotate _rotatable;
    private readonly Angle _angle;

    public RotationCommand(IRotate rotatable, Angle angle)
    {
        _rotatable = rotatable;
        _angle = angle;
    }

    public void Execute()
    {
        _ = _angle.StartAngle;
        _angle.Rotate(_rotatable.RotationRate);
        _angle.StartAngle = _angle.CurrentAngle;
    }
}