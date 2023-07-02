using PatternCS.Command;
CommandExample();

void CommandExample()
{
    _File file = new _File("example.txt");
    FileManager fileManager = new FileManager();

    ICommand createFileCommand = new CreateFileCommand(file);
    ICommand openFileCommand = new OpenFileCommand(file);
    ICommand saveFileCommand = new SaveFileCommand(file);
    ICommand deleteFileCommand = new DeleteFileCommand(file);
    ICommand renameFileCommand = new RenameFileCommand(file, "new_example.txt");

    //createFileCommand.Execute();

    Console.WriteLine("\nСоздаем файл");
    fileManager.SetCommand(createFileCommand);
    fileManager.ExecuteCommand();

    Console.WriteLine("\nОткрываем файл");
    fileManager.SetCommand(openFileCommand);
    fileManager.ExecuteCommand();

    Console.WriteLine("\nСохраняем файл");
    fileManager.SetCommand(saveFileCommand);
    fileManager.ExecuteCommand();

    Console.WriteLine("\nПереименовываем файл");
    fileManager.SetCommand(renameFileCommand);
    fileManager.ExecuteCommand();

    Console.WriteLine("\nУдаляем файл");
    fileManager.SetCommand(deleteFileCommand);
    fileManager.ExecuteCommand();

    Console.WriteLine("\nПопытка открыть файл после удаления");
    fileManager.SetCommand(openFileCommand);
    fileManager.ExecuteCommand();

    Console.WriteLine("\nПопытка сохранить файл после удаления");
    fileManager.SetCommand(saveFileCommand);
    fileManager.ExecuteCommand();
}