namespace SpaceBattle.Lib;

public interface IReceiver
{
    _ICommand.ICommand Receive();
    bool isEmpty();
}