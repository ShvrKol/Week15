using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] food = new string[15];
        public string[] bev = new string[15];
        public int temp = 5;
        public int temp1 = 4;

        private void buttoninput_Click(object sender, EventArgs e)
        {
            food[0] = "Mie Instan";
            food[1] = "Telor";
            food[2] = "Roti";
            food[3] = "Keju";
            food[4] = "Daging Giling";
            bev[0] = "Susu Sapi";
            bev[1] = "Kopi";
            bev[2] = "Teh";
            bev[3] = "Bir";

            if (radioButtonfood.Checked == true)
            {
                if (textBoxitem.Text == food[0] || textBoxitem.Text == food[1] || textBoxitem.Text == food[2] || textBoxitem.Text == food[3] || textBoxitem.Text == food[4] || textBoxitem.Text == food[5] || textBoxitem.Text == food[6] || textBoxitem.Text == food[7] || textBoxitem.Text == food[8] || textBoxitem.Text == food[9] || textBoxitem.Text == food[10] || textBoxitem.Text == food[11] || textBoxitem.Text == food[12] || textBoxitem.Text == food[13] || textBoxitem.Text == food[14])
                {
                    MessageBox.Show("Input First");
                }
                else
                {
                    listBoxfirst.Items.Add(textBoxitem.Text);
                    food[temp] = textBoxitem.Text;
                    temp++;
                    listBoxfood.Items.Add(textBoxitem.Text);
                }
            }

            if (radioButtonbev.Checked == true)
            {
                if (textBoxitem.Text == bev[0] || textBoxitem.Text == bev[1] || textBoxitem.Text == food[2] || textBoxitem.Text == bev[3] || textBoxitem.Text == bev[4] || textBoxitem.Text == bev[5] || textBoxitem.Text == bev[6] || textBoxitem.Text == bev[7] || textBoxitem.Text == bev[8] || textBoxitem.Text == bev[9] || textBoxitem.Text == bev[10] || textBoxitem.Text == bev[11] || textBoxitem.Text == bev[12] || textBoxitem.Text == bev[13] || textBoxitem.Text == bev[14])
                {
                    MessageBox.Show("Input First");
                }
                else
                {
                    listBoxfirst.Items.Add(textBoxitem.Text);
                    bev[temp1] = textBoxitem.Text;
                    temp1++;
                    listBoxbev.Items.Add(textBoxitem.Text);
                }
            }
            radioButtonfood.Checked = false;
            radioButtonbev.Checked = false;
            textBoxitem.Text = "";
        }

        private void radioButtonfood_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButtonfood.Checked == true)
            //{
            //    if (textBoxitem.Text == food[0] || textBoxitem.Text == food[1] || textBoxitem.Text == food[2] || textBoxitem.Text == food[3] || textBoxitem.Text == food[4] || textBoxitem.Text == food[5] || textBoxitem.Text == food[6] || textBoxitem.Text == food[7] || textBoxitem.Text == food[8] || textBoxitem.Text == food[9] || textBoxitem.Text == food[10] || textBoxitem.Text == food[11] || textBoxitem.Text == food[12] || textBoxitem.Text == food[13] || textBoxitem.Text == food[14])
            //    {
            //        MessageBox.Show("Input First");
            //    }
            //}
        }

        private void radioButtonbev_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButtonbev.Checked == true)
            //{
            //    if (textBoxitem.Text == bev[0] || textBoxitem.Text == bev[1] || textBoxitem.Text == food[2] || textBoxitem.Text == bev[3] || textBoxitem.Text == bev[4] || textBoxitem.Text == bev[5] || textBoxitem.Text == bev[6] || textBoxitem.Text == bev[7] || textBoxitem.Text == bev[8] || textBoxitem.Text == bev[9] || textBoxitem.Text == bev[10] || textBoxitem.Text == bev[11] || textBoxitem.Text == bev[12] || textBoxitem.Text == bev[13] || textBoxitem.Text == bev[14])
            //    {
            //        MessageBox.Show("Input First");
            //    }
            //}
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            foreach (object drink in listBoxfirst.SelectedItems)
            {
                int choose = listBoxsecnd.FindString(listBoxfirst.SelectedItem.ToString());
                listBoxsecnd.SelectedIndex = choose;
                if (choose == listBoxfirst.SelectedIndex)
                {
                    MessageBox.Show("Already Exist");
                }
                else
                {
                    listBoxsecnd.Items.Add(drink);
                }
            }

            if (checkBoxfood.Checked == false && checkBoxbev.Checked == true)
            {
                foreach (object drink1 in listBoxfood.SelectedItems)
                {
                    listBoxsecnd.Items.Add(drink1);
                }
            }

            if (checkBoxfood.Checked == true && checkBoxbev.Checked == false)
            {
                foreach (object drink2 in listBoxbev.SelectedItems)
                {
                    listBoxsecnd.Items.Add(drink2);
                }
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (listBoxsecnd.SelectedIndex > -1)
            {
                for (int i = listBoxsecnd.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int old = listBoxsecnd.SelectedIndices[i];
                    listBoxsecnd.Items.RemoveAt(old);
                }
            }
            else
            {
                listBoxsecnd.Items.Clear();
            }

        }

        private void checkBoxfood_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxfood.Checked == true && checkBoxbev.Checked == false)
            {
                listBoxfirst.Hide();
                listBoxfood.Visible = listBoxfood.Enabled;
                for (int i = 0; i < listBoxfood.Items.Count; i++)
                {
                    listBoxfood.SelectedIndex = i;
                }
            }
            else if (checkBoxfood.Checked == true && checkBoxbev.Checked == true)
            {
                listBoxbev.Hide();
                listBoxfood.Hide();
                listBoxfirst.Visible = listBoxfirst.Enabled;
                for (int i = 0; i < listBoxbev.Items.Count; i++)
                {
                    listBoxbev.SelectedIndex = i;
                }
            }
            else if (checkBoxfood.Checked == false && checkBoxbev.Checked == false)
            {
                listBoxbev.Hide();
                listBoxfood.Hide();
                listBoxfirst.Visible = listBoxfirst.Enabled;
            }
        }

        private void checkBoxbev_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxbev.Checked == true && checkBoxfood.Checked == false)
            {
                listBoxfirst.Hide();
                listBoxbev.Visible = listBoxbev.Enabled;
                for (int i = 0; i < listBoxbev.Items.Count; i++)
                {
                    listBoxbev.SelectedIndex = i;
                }
            }
            else if (checkBoxfood.Checked == true && checkBoxbev.Checked == true)
            {
                listBoxbev.Hide();
                listBoxfood.Hide();
                listBoxfirst.Visible = listBoxfirst.Enabled;
            }
            else if (checkBoxfood.Checked == false && checkBoxbev.Checked == false)
            {
                listBoxbev.Hide();
                listBoxfood.Hide();
                listBoxfirst.Visible = listBoxfirst.Enabled;
            }
        }
    }
}
