using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_DataManipulation_x02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataManager me = new DataManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataManagement_x01DataSet.Kirat' table. You can move, or remove it, as needed.
            this.kiratTableAdapter.Fill(this.dataManagement_x01DataSet.Kirat);

        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            //me.checkConn();
            kiratTableAdapter.InsertQuery();
            me.addValue(fname.Text);
            this.kiratTableAdapter.Fill(this.dataManagement_x01DataSet.Kirat);
        }
    }
}
