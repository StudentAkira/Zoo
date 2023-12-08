using ClassLibrary1;
using NLog;
using System.Net.Sockets;
using System.Text.Json;
using System.Text;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Zoo zoo = new Zoo();

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(zoo.lmanager.LionName);
            listBox1.Items.Add(zoo.lmanager.ZebraName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoo.buy_aviary(((int)numericUpDown1.Value), label1, listBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zoo.get_status(label1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) zoo.buy_food(((int)numericUpDown2.Value), 1, listBox4, label1);
            if (radioButton2.Checked) zoo.buy_food(((int)numericUpDown2.Value), 2, listBox4, label1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zoo.buy_animal(listBox1.SelectedIndex, listBox2.SelectedIndex, listBox3, label1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zoo.let_visitors_in(label1, listBox3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            zoo.feed(listBox3, listBox4, label1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zoo.kill_animal(listBox3, listBox4, label1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Label tmp_label = new Label();
            zoo.get_status(tmp_label);

            IDecorator decorator = new Decorator();
            Shell ndd = new UppercaseDecorator(decorator);
            Shell upd = new NoDigitDecorator(ndd);

            upd.Write_data(tmp_label.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ZooBinaryWriter zbw = new ZooBinaryWriter(zoo);
            zbw.write_zoo();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            ZooBinaryReader zbr = new ZooBinaryReader();
            zoo = zbr.read_zoo(listBox2, listBox3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ZooTextWriter ztw = new ZooTextWriter(zoo);
            ztw.write_zoo();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ZooTextReader ztr = new ZooTextReader();
            zoo = ztr.read_zoo(listBox2, listBox3);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            zoo.serialize();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            zoo.deserialize(listBox4);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                LocalizationManager.path = @".\data\langs\en.json";

            }
            else if (radioButton4.Checked)
            {
                LocalizationManager.path = @".\data\langs\ru.json";

            }
            zoo.init_managers();
            listBox1.Items.Clear();
            listBox1.Items.Add(zoo.lmanager.LionName);
            listBox1.Items.Add(zoo.lmanager.ZebraName);

        }
    }
}