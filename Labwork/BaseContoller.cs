using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork
{
    //Base Controller
    interface BaseContoller
    {
        string SelectFile(); // Return path to file
        void ClearInterface(); // Clear user interface
        void EditFile(string path);
        void Synchronization(string path); // sync data from file with user interface
        List<Item> DataFromFileToListItem(string path);
        void ErrorMessage(string error);
    }
}
