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
        public List<Block> Blocks = new List<Block>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCreateObject_Click(object sender, EventArgs e)
        {

            FormAddObject formAddObject = new FormAddObject(this);
            formAddObject.ShowDialog();
            ShowBlocks();
        }

        private void ShowBlocks()
        {
            dataGridViewMain.Rows.Clear();
            dataGridViewMain.ColumnCount = 6;
            dataGridViewMain.RowCount = Blocks.Count;
            for (int i = 0; i < Blocks.Count; i++)
            {
                dataGridViewMain[0, i].Value = Blocks[i].Name;
                dataGridViewMain[1, i].Value = Blocks[i].Height;
                dataGridViewMain[2, i].Value = Blocks[i].Width;
                dataGridViewMain[3, i].Value = Blocks[i].X;
                dataGridViewMain[4, i].Value = Blocks[i].Y;
                dataGridViewMain[5, i].Value = "☑";
            }
            CheckRight();
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
            for (int i = 0; i < Blocks.Count; i++)
            {
                if (Blocks[i].Name == "Земля")
                {
                    for (int j = 0; j < Blocks.Count; j++)
                    {
                        if (Blocks[j].Name == "Вода")
                        {
                            
                            if (Blocks[i].Height > Blocks[j].Height)
                            {
                                dataGridViewMain[5, i].Value = "X";
                            }
                            else if (Blocks[i].Width > Blocks[j].Width)
                            {
                                dataGridViewMain[5, i].Value = "X";
                            }
                            else if ((Blocks[i].Height * Blocks[i].Height + Blocks[i].Width * Blocks[i].Width) > (Blocks[j].Height * Blocks[j].Height + Blocks[j].Width * Blocks[j].Width))
                            {
                                dataGridViewMain[5, i].Value = "X";
                            }
                        }    
                    }
                }    
            }
        }
    }
}
