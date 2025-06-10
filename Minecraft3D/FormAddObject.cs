using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft3D
{
    public partial class FormAddObject : Form
    {
        public Block Block = new Block("earth", 0, 0);
        FormMain form;
        public FormAddObject(FormMain form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void FormAddObject_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Block.Height = Convert.ToInt32(this.textBoxLength.Text);
            Block.Width = Convert.ToInt32(this.textBoxWidth.Text);
            if (radioButtonEarth.Checked) {
                Block.Name = "Земля";
            }
            else {
                Block.Name = "Вода";
            }
            this.Visible = false;
            
            form.Blocks.Add(Block);
            Close();

        }
    }
}
