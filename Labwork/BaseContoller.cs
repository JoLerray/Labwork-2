using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork
{
    //Base Controller

    interface BaseContoller<T, R> : BaseParsing<T, R>
    {

        void AddFile(); // Add file in list Pathes
        void CreateFile(string path, string FileName); // Create new file need get name and path
        void DeleteFile(string path); // delete file in pathes
        void ChangeFile(int index = 0); // select file return path to file and clear path to current file if !null
        void ClearInterface(Action action); // Clear user interface
        void EditFile(string path); // open file in editor
        void Synchronization(string path); // sync data from file with user interface
        void ErrorMessage(string error);  // simple view with Error
        
    }
    interface FormDepensiveAction
    {
        void ClearInterface(Action action); // Clear user interface
    }
}
