using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labwork
{
    public partial class Form1 : Form, ApplicationManagement
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void ErrorMessage(string error)
        {
                MessageBox.Show(error);
        }

        void ApplicationManagement.ClearInterface()
        {
            throw new NotImplementedException();
        }

        List<Item> ApplicationManagement.DataFromFileToListItem(string path)
        {
            throw new NotImplementedException();
        }

        void ApplicationManagement.EditFile(string path)
        {
            throw new NotImplementedException();
        }

        string ApplicationManagement.SelectFile()
        {
            throw new NotImplementedException();
        }

        void ApplicationManagement.Synchronization(string path)
        {
            throw new NotImplementedException();
        }
    }
    interface  ApplicationManagement {
        
        string SelectFile(); // Return path to file
        void ClearInterface();
        void EditFile(string path);
        void Synchronization(string path); // sync data from file with user interface
        List<Item> DataFromFileToListItem(string path);
        void ErrorMessage(string error);
     
        
    }
}
