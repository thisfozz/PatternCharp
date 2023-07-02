namespace PatternCS.Command;
public class FileManager
{
    private _File file;
    private ICommand command;

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public void ExecuteCommand()
    {
        if (command != null)
        {
            command.Execute();
        }
    }

    public void UndoCommand()
    {
        if (command != null)
        {
            command.Undo();
        }
    }
}

