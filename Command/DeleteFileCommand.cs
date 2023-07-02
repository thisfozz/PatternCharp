namespace PatternCS.Command;
public class DeleteFileCommand : ICommand
{
    private _File file;

    public DeleteFileCommand(_File file)
    {
        this.file = file;
    }

    public void Execute()
    {
        file.DeleteFile();
    }

    public void Undo()
    {
        file.Create();
    }
}

