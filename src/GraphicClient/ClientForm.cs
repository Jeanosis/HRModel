using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicClient
{
    public partial class ClientForm : Form
    {
        /// <summary>
        /// The event is raised when the "Request" is clicked.
        /// It takes delegates which take the requested name string as an argument.
        /// </summary>
        public event Action<string> RequestButtonClick;

        public string QueryResult
        {
            get { return textBoxResult.Text; }
            set { textBoxResult.Text = value; }
        }

        public ClientForm()
        {
            InitializeComponent();
            buttonRequest.Click += (sender, e) => RequestButtonClick(textBoxRequestedName.Text);
        }
    }
}
