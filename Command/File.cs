namespace PatternCS.Command;
public class _File
{
    public string _fileName { get; private set; }
    private bool isDeleted;
    private bool isCreated;

    public _File(string FileName)
    {
        _fileName = FileName;
        isDeleted = false;
        isCreated = false;
    }

    public void Create()
    {
        Console.WriteLine($"Создан файл: {_fileName}");
        isDeleted = false;
        isCreated = true;
    }
    public void DeleteFile()
    {
        if (!isCreated)
        {
            Console.WriteLine($"Невозможно удалить файл. Файл не создан.");
        }
        if (!isDeleted)
        {
            Console.WriteLine($"Удален файл: {_fileName}");
            isDeleted = true;
        } 
        else
        {
            Console.WriteLine($"Невозможно удалить файл: <{_fileName}> Файл уже удален.");
        }
    }

    public void OpenFile()
    {
        if (!isCreated)
        {
            Console.WriteLine($"Невозможно открыть файл. Файл не создан.");
        }
        else if (!isDeleted)
        {
            Console.WriteLine($"Открыт файл: <{_fileName}>");
        }
        else
        {
            Console.WriteLine($"Невозможно открыть файл: <{_fileName}> Файл удален.");
        }
    }
    public void CloseFile()
    {
        if (!isCreated)
        {
            Console.WriteLine($"Невозможно закрыть файл. Файл не создан.");
        }
        else if (!isDeleted)
        {
            Console.WriteLine($"Файл <{_fileName}> закрыт");
        }
        else
        {
            Console.WriteLine($"Невозможно закрыть файл: <{_fileName}> Файл удален.");
        }
    }

    public void SaveFile()
    {
        if (!isCreated)
        {
            Console.WriteLine($"Невозможно сохранить файл. Файл не создан.");
        }
        else if (!isDeleted)
        {
            Console.WriteLine($"Файл <{_fileName}> сохранен");
        }
        else
        {
            Console.WriteLine($"Невозможно сохранить файл: <{_fileName}> Файл удален.");
        }
    }
    public void Rename(string newName)
    {
        if (!isCreated)
        {
            Console.WriteLine($"Невозможно переименовать файл. Файл не создан.");
        }
        else if (!isDeleted)
        {
            Console.WriteLine($"Переименован файл: <{_fileName}> -> {newName}");
            _fileName = newName;
        }
        else
        {
            Console.WriteLine($"Невозможно переимновать файл: <{_fileName}> Файл удален.");
        }
    }
}


