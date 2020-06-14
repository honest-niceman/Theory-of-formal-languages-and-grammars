using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Globalization;

namespace Analizator8
{
    public partial class ananlyzer_19 : Form
    {
        public ananlyzer_19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckingResult result = Controller.CheckString(textBox1.Text);
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            if (result.Error == null)
            {
                textBox2.Text = "Список идентификаторов:\r\n\r\n";
                for (int i = 0; i < result.Vars.Count; ++i)
                {
                    textBox2.Text += result.Vars.ElementAt(i) + "\r\n";
                }
                textBox3.Text += "Список констант:\r\n\r\n";
                for (int i = 0; i < result.Consts.Count; ++i)
                {
                    textBox3.Text += result.Consts.ElementAt(i) + "\r\n";
                }
            }
            else
            {
                textBox4.Text = result.Error.Description;
                textBox1.Focus();
                textBox1.SelectionStart = result.Error.Pos;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ananlyzer_19_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CultureInfo ci = new CultureInfo("ru-RU");
                Assembly a = Assembly.Load("Analizator8");
                ResourceManager rm = new ResourceManager("Analizator8.Lang-Ru", a);
                label1.Text = rm.GetString("String1", ci);
                label2.Text = rm.GetString("String2", ci);               
                button1.Text = rm.GetString("String3", ci);              
            }
            if (comboBox1.SelectedIndex == 1)
            {
                CultureInfo ci = new CultureInfo("en-US");
                Assembly a = Assembly.Load("Analizator8");
                ResourceManager rm = new ResourceManager("Analizator8.Lang-En", a);
                label1.Text = rm.GetString("String1", ci);
                label2.Text = rm.GetString("String2", ci);
                button1.Text = rm.GetString("String3", ci);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                CultureInfo ci = new CultureInfo("fr-FR");
                Assembly a = Assembly.Load("Analizator8");
                ResourceManager rm = new ResourceManager("Analizator8.Lang-Fr", a);
                label1.Text = rm.GetString("String1", ci);
                label2.Text = rm.GetString("String2", ci);
                button1.Text = rm.GetString("String3", ci);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                CultureInfo ci = new CultureInfo("de-DE");
                Assembly a = Assembly.Load("Analizator8");
                ResourceManager rm = new ResourceManager("Analizator8.Lang-De", a);
                label1.Text = rm.GetString("String1", ci);
                label2.Text = rm.GetString("String2", ci);
                button1.Text = rm.GetString("String3", ci);
            }
        }
    }
}
