using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Labwork
{
    class Controller : BaseContoller, BaseParsing<string, Item>
    {
        private OpenFileDialog file = new OpenFileDialog();
        // all pathes files in App
        private List<string> _pathes = new List<string>();

        public void AddFile()
        {
            
            if(file.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    _pathes.Add(file.FileName);
                    
                }
                catch(Exception e)
                {
                    ErrorMessage(e.Message);
                    return;
                }
            }
        }

        public void ChangeFile(int index = 0)
        {
            if (file.ShowDialog() == DialogResult.OK)
            {
                try {
                    _pathes[index] = file.FileName;
                }
                catch(Exception e) {
                    ErrorMessage(e.Message);
                    return;
                }
            }
        }

        public void ClearInterface(Action action) { 
            action.Invoke(); 
        }

        public void CreateFile(string path, string FileName)
        {
            throw new NotImplementedException();
        }

        public void DeleteFile(string path)
        {
            throw new NotImplementedException();
        }

        public void DeletePath(string path)
        {
            throw new NotImplementedException();
        }

        public void EditFile(string path)
        {
            throw new NotImplementedException();
        }

        public void ErrorMessage(string error)
        {
            throw new NotImplementedException();
        }

        // get pathes files in App
        public Array getPathes()
        {
            return _pathes.ToArray();
        }

        public List<Item> Parsing(string data)
        {
            throw new NotImplementedException();
        }

        public void Synchronization(string path)
        {
            throw new NotImplementedException();
        }
    }
}
