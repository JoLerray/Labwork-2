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
    public partial class Form1 : Form, UserActions
    {
        public Form1()
        {
            InitializeComponent();
            ErrorMessage("SUCK DICK");
        }

        public void ErrorMessage(string error)
        {
            MessageBox.Show(error);
        }

        void UserActions.ClearInterface()
        {
            throw new NotImplementedException();
        }

        List<Item> UserActions.DataFromFileToListItem(string path)
        {
            throw new NotImplementedException();
        }

        void UserActions.EditFile(string path)
        {
            throw new NotImplementedException();
        }

        string UserActions.SelectFile()
        {
            throw new NotImplementedException();
        }

        void UserActions.Synchronization(string path)
        {
            throw new NotImplementedException();
        }
    }
    interface  UserActions {
        
        string SelectFile(); // Return path to file
        void ClearInterface(); // Clear user interface
        void EditFile(string path);
        void Synchronization(string path); // sync data from file with user interface
        List<Item> DataFromFileToListItem(string path);
        void ErrorMessage(string error);
     
        
    }
}
