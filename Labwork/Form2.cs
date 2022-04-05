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
    public partial class Form2 : Form
    {
        Controller controller = new Controller(); // MVC - Model View Contoller

        public Form2()
        {
        
            InitializeComponent();
            //controller.ClearInterface(() => { controller.AddFile(); }); Example lamda function Action
        }
    }
}
