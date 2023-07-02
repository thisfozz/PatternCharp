using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCS.Command
{
    public class SaveFileCommand : ICommand
    {
        private _File file;

        public SaveFileCommand(_File file)
        {
            this.file = file;
        }

        public void Execute()
        {
            file.SaveFile();
        }

        public void Undo()
        {
            file.DeleteFile();
        }
    }
}
