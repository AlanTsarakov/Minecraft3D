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
    public partial class FormMain : Form
    {
        List<Block> blocks = new List<Block>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCreateObject_Click(object sender, EventArgs e)
        {

            FormAddObject formAddObject = new FormAddObject();
            formAddObject.ShowDialog();
            blocks.Add(formAddObject.Block);
            formAddObject.Close();
            ShowBlocks();
        }

        private void ShowBlocks()
        {
            dataGridViewMain.Rows.Clear();
            dataGridViewMain.ColumnCount = 6;
            dataGridViewMain.RowCount = blocks.Count;
            for (int i = 0; i < blocks.Count; i++)
            {
                dataGridViewMain[0, i].Value = blocks[i].Name;
                dataGridViewMain[1, i].Value = blocks[i].Height;
                dataGridViewMain[2, i].Value = blocks[i].Width;
                dataGridViewMain[3, i].Value = blocks[i].X;
                dataGridViewMain[4, i].Value = blocks[i].Y;
                CheckRight();

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckRight();
        }

        public void CheckRight()
        {
            
        }
    }
}
