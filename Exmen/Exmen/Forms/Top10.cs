using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exmen
{
    public partial class Top10 : Form
    {

        public Top10()
        {
            InitializeComponent();
            listView1.Visible = true;
            listView1.Items.Clear();
            ListViewItem item = new ListViewItem();
            foreach (Usuario u in Lista.u21)
            {
                item = listView1.Items.Add(u.Nombre);
                item.SubItems.Add(u.Ptje.ToString());
            }
        }
    }
}
