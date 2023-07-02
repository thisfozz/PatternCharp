using PatternCS.Command;

public class RenameFileCommand : ICommand
{
    private _File file;
    private string newName;
    private string previousName;

    public RenameFileCommand(_File file, string newName)
    {
        this.file = file;
        this.newName = newName;
    }

    public void Execute()
    {
        previousName = file._fileName;
        file.Rename(newName);
    }

    public void Undo()
    {
        file.Rename(previousName);
    }
}

