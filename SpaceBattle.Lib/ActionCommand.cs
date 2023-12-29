namespace SpaceBattle.Lib;

public class ActionCommand : ICommand
{
    public readonly Action<object[]> _function;
    public readonly object[] _args;

    public ActionCommand(Action<object[]> function, object[] args)
    {
        _function = function;
        _args = args;
    }

    public void Execute()
    {
        _function(_args);
    }
}
