namespace PatternCS.Command;
public class OpenFileCommand : ICommand
{
    private _File file;

    public OpenFileCommand(_File file)
    {
        this.file = file;
    }

    public void Execute()
    {
        file.OpenFile();
    }

    public void Undo()
    {
        file.CloseFile();
    }
}
