using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double result = 0;
        string operate = "";
        bool press_key = false;

        private void bt_num1_Click(object sender, EventArgs e)
        {
            if (press_key == true || Double.Parse(tb_Output.Text) == 0)
            {
                tb_Output.Text = ((Button)sender).Text;
                press_key = false;
            }
            else
            {
                tb_Output.Text += ((Button)sender).Text;
            }
            
        }

        private void bt_num2_Click(object sender, EventArgs e)
        {
            if (press_key == true || Double.Parse(tb_Output.Text) == 0)
            {
                tb_Output.Text = "2";
                press_key = false;
            }
            else
            {
                tb_Output.Text += "2";
            }
        }

        private void bt_num3_Click(object sender, EventArgs e)
        {
            if (press_key == true || Double.Parse(tb_Output.Text) == 0)
            {
                tb_Output.Text = "3";
                press_key = false;
            }
            else
            {
                tb_Output.Text += "3";
            }
        }

        private void bt_num4_Click(object sender, EventArgs e)
        {
            if (press_key == true || Double.Parse(tb_Output.Text) == 0)
            {
                tb_Output.Text = "4";
                press_key = false;
            }
            else
            {
                tb_Output.Text += "4";
            }
        }

        private void bt_num5_Click(object sender, EventArgs e)
        {
            if (press_key == true || Double.Parse(tb_Output.Text) == 0)
            {
                tb_Output.Text = "5";
                press_key = false;
            }
            else
            {
                tb_Output.Text += "5";
            }
        }

        private void bt_num6_Click(object sender, EventArgs e)
        {
            if (press_key == true || Double.Parse(tb_Output.Text) == 0)
            {
                tb_Output.Text = "6";
                press_key = false;
            }
            else
            {
                tb_Output.Text += "6";
            }
        }

        private void bt_num7_Click(object sender, EventArgs e)
        {
            if (press_key == true || Double.Parse(tb_Output.Text) == 0)
            {
                tb_Output.Text = "7";
                press_key = false;
            }
            else
            {
                tb_Output.Text += "7";
            }
        }

        private void bt_num8_Click(object sender, EventArgs e)
        {
            if (press_key == true || Double.Parse(tb_Output.Text) == 0)
            {
                tb_Output.Text = "8";
                press_key = false;
            }
            else
            {
                tb_Output.Text += "8";
            }
        }

        private void bt_num9_Click(object sender, EventArgs e)
        {
            if (press_key == true || Double.Parse(tb_Output.Text) == 0)
            {
                tb_Output.Text = "9";
                press_key = false;
            }
            else
            {
                tb_Output.Text += "9";
            }
        }

        private void bt_num0_Click(object sender, EventArgs e)
        {
            if (press_key == true || Double.Parse(tb_Output.Text) == 0)
            {
                tb_Output.Text = "0";
                press_key = false;
            }
            else
            {
                tb_Output.Text += "0";
            }
        }

        private void bt_plus_Click(object sender, EventArgs e)
        {
            press_key = true;
            result = Double.Parse(tb_Output.Text);
            operate = bt_plus.Text;
            tb_Input.Text = result + " " + operate;
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            press_key = true;
            result = Double.Parse(tb_Output.Text);
            operate = bt_minus.Text;
            tb_Input.Text = result + " " + operate;
        }

        private void bt_multiply_Click(object sender, EventArgs e)
        {
            press_key = true;
            result = Double.Parse(tb_Output.Text);
            operate = bt_multiply.Text;
            tb_Input.Text = result + " " + operate;
        }

        private void bt_division_Click(object sender, EventArgs e)
        {
            press_key = true;
            result = Double.Parse(tb_Output.Text);
            operate = bt_division.Text;
            tb_Input.Text = result + " " + operate;
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_Input.Text = null;
            tb_Output.Text = "0";
            this.result = 0;
            this.operate = "";
            press_key = false;
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            press_key = true;
            tb_Input.Text += " " + tb_Output.Text + " =";
            switch (operate)
            {
                case "+":
                    tb_Output.Text = (this.result + Double.Parse(tb_Output.Text)).ToString();
                    break;
                case "-":
                    tb_Output.Text = (this.result - Double.Parse(tb_Output.Text)).ToString();
                    break;
                case "x":
                    tb_Output.Text = (this.result * Double.Parse(tb_Output.Text)).ToString();
                    break;
                case "/":
                    tb_Output.Text = (this.result / Double.Parse(tb_Output.Text)).ToString();
                    break;
            }    

        }

        private void changeColorMenu_Click(object sender, EventArgs e)
        {
            
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var button in tableLayoutPanel1.Controls.OfType<Button>())
                {
                    button.BackColor = colorDialog.Color;
                }
            }
        }

        private void changeFontMenu_Click(object sender, EventArgs e)
        {
            
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var button in tableLayoutPanel1.Controls.OfType<Button>())
                {
                    button.Font = fontDialog.Font;
                }

                tb_Input.Font = fontDialog.Font;
                tb_Output.Font = fontDialog.Font;


            }
        }
    }
}
