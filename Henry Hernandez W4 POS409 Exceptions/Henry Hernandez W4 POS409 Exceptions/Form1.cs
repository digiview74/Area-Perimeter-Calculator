//Henry Hernandez 
//W4 POS409 Exceptions Program
//Calculates area and perimeter of a rectangle
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Henry_Hernandez_W4_POS409_Exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) // Calculates area and perimeter
        {           
            try
            {
                // checks input to be numeric
                int len = int.Parse(textBox1.Text);
                int wid = int.Parse(textBox2.Text);
                if (len < 0) // checks input to be positive integer
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    label1.Text = "";
                    label2.Text = "";
                    len = 0;
                    wid = 0;
                    MessageBox.Show("No Negative Numbers");
                    label1.Text = String.Empty;
                    label2.Text = String.Empty;
                }              
                else
                {
                    textBox1.Text = textBox1.Text;
                   
                    AreaConverter getPerimeter1;
                    getPerimeter1 = new AreaConverter();
                    label2.Text = getPerimeter1.getPerimeter(len, wid).ToString();
               
                }
                if (wid < 0)// checks input to be positive integer
                {
                    len = 0;
                    wid = 0;
                    label1.Text = "";
                    label2.Text = "";
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("No Negative Numbers");               
                }
                else
                {
                    // calculates area
                    textBox2.Text = textBox2.Text;
                    int b = int.Parse(label2.Text);
                    AreaConverter getArea1;
                    getArea1 = new AreaConverter();
                    label1.Text = getArea1.getArea(len, wid).ToString();             
                }
            }
            catch //catches error
            {
                label1.Text = "";
                label2.Text = "";
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Must enter numbers");
            }
            try
            {
                // checks input to be numeric
                int a = int.Parse(label1.Text);
                int b = int.Parse(label2.Text);
                {    
                    //converts area units
                    double num1 = 12;
                    double num2 = 39.3701;
                    double num3 = 2.54;
                    double ans1 = (num3 * a);
                    double ans2 = (a / num1);
                    double ans3 = (a / num2);
                    listBox1.Items.Add("Area");
                    listBox1.Items.Add(ans1 + " " + "sq cm");
                    listBox1.Items.Add(a + " " + "in");
                    listBox1.Items.Add(ans2 + " " + "sq ft");
                    listBox1.Items.Add(ans3 + " " + "sq m");
                    //converts perimeter units  
                    double num4 = 12;
                    double num5 = 39.3701;
                    double num6 = 2.54;
                    double ans4 = (num6 * b);
                    double ans5 = (b / num4);
                    double ans6 = (b / num5);
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Perimeter");
                    listBox1.Items.Add(ans4 + " " + "sq cm");
                    listBox1.Items.Add(b + " " + "in");
                    listBox1.Items.Add(ans5 + " " + "sq ft");
                    listBox1.Items.Add(ans6 + " " + "sq m");
                }
            }
            catch
            {
                MessageBox.Show("Format not correct");
            }
        }
        private void button3_Click(object sender, EventArgs e) // resets fields
        {
            clearAreas();
        }
      void clearAreas() //reset method
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = String.Empty;
            label2.Text = String.Empty;
            listBox1.Items.Clear();          
        }
        public void label1_Click(object sender, EventArgs e)
        {
    
        }
        public void textBox_Validating(object sender, CancelEventArgs e)
        {
            //checks for empty text box
            TextBox currenttb = (TextBox)sender;
            if (currenttb.Text == "")
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show(string.Format("Empty field {0 }", currenttb.Name.Substring(3)));
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)   //checks for empty text box
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>().Where(x => x.CausesValidation == true))
            {
                tb.Validating += textBox_Validating;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)   //checks for empty text box
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>().Where(x => x.CausesValidation == true))
            {
                tb.Validating += textBox_Validating;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)   //checks for empty text box
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>().Where(x => x.CausesValidation == true))
            {
                tb.Validating += textBox_Validating;
            }
        }
    }
    }
    
    

