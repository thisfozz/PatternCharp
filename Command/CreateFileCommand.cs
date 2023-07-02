namespace PatternCS.Command;
public class CreateFileCommand : ICommand
{
    private _File file;

    public CreateFileCommand(_File file)
    {
        this.file = file;
    }

    public void Execute()
    {
        file.Create();
    }

    public void Undo()
    {
        file.DeleteFile();
    }
}

