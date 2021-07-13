using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
namespace COM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(port);
            comboBox1.SelectedItem = 0;

            comboBox2.Items.Add("Int");
            comboBox2.Items.Add("Float");
            comboBox2.SelectedItem = "Int";
            comboBox3.Items.Add("Int");
            comboBox3.Items.Add("Float");
            comboBox3.SelectedItem = "Int";
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            button_Open.Enabled = true;
            button_Open.ForeColor = Color.Coral;
            button_Close.ForeColor = Color.DarkGray;
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
            }
            catch (Exception)
            {

            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            button_Close.Enabled = true;
            button_Close.ForeColor = Color.Coral;
            button_Open.ForeColor = Color.DarkGray;
            try
            {
                serialPort1.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            int i;
            double j;
            if (comboBox3.Text == "Float")
                if (!(double.TryParse(textBox_holding_values_write.Text, out j) && int.TryParse(textBox_Hoding_address_Write.Text, out i)
                    && int.TryParse(textBox_Coil_value_write.Text, out i) && int.TryParse(textBox_Coil_address_write.Text, out i )))
                {
                    MessageBox.Show("Invalid input");
                    return;
                }
            if (comboBox3.Text == "Int")
                if (!(int.TryParse(textBox_holding_values_write.Text, out i) && int.TryParse(textBox_Hoding_address_Write.Text, out i)
                    && int.TryParse(textBox_Coil_value_write.Text, out i) && int.TryParse(textBox_Coil_address_write.Text, out i)))
                {
                    MessageBox.Show("Invalid input");
                    return;
                }


            string type = comboBox3.Text;

            try
            {
                if(serialPort1.IsOpen)
                {
                    //serialPort1.WriteLine(textBox_Message.Text + Environment.NewLine);
                    string coil_address = textBox_Coil_address_write.Text;
                    string coil_values = textBox_Coil_value_write.Text;
                    string holding_address = textBox_Hoding_address_Write.Text;
                    string holding_values = textBox_holding_values_write.Text;
                    string data_send = "write-" + coil_address + "-" + coil_values + "-" + holding_address + "-" + holding_values + "-" + type;
                    serialPort1.WriteLine(data_send);
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void button_Receive_Click(object sender, EventArgs e)
        {
            int i;
            if (!(int.TryParse(textBox1.Text, out i) && int.TryParse(textBox2.Text, out i)
                && int.TryParse(textBox3.Text, out i) && int.TryParse(textBox4.Text, out i)
                && int.TryParse(textBox5.Text, out i) && int.TryParse(textBox6.Text, out i)
                && int.TryParse(textBox7.Text, out i) && int.TryParse(textBox8.Text, out i)
                ))
            {
                MessageBox.Show("Invalid input: Make sure is number");
                return;
            }
            string type = comboBox2.Text;

            if (type == "Float" && ((int.Parse(textBox6.Text)%2 != 0) || (int.Parse(textBox8.Text) % 2 != 0)))
            {
                MessageBox.Show("Make sure count holding registers is even number!!");
            }

            try
            {
                if (serialPort1.IsOpen)
                {
                    string coil_outputs_address = textBox1.Text;
                    string coil_outputs_count = textBox2.Text;
                    string digital_inputs_address = textBox3.Text;
                    string digital_inputs_count = textBox4.Text;
                    string registers_inputs_address = textBox5.Text;
                    string registers_input_count = textBox6.Text;
                    string holding_registers_address = textBox7.Text;
                    string holding_registers_count = textBox8.Text;
                    string data_send = "read-"+coil_outputs_address + '-' + coil_outputs_count + '-' + 
                                        digital_inputs_address + '-' + digital_inputs_count + '-' +
                                        registers_inputs_address + '-' + registers_input_count + '-' +
                                        holding_registers_address + '-' + holding_registers_count + '-' + type;
                    serialPort1.WriteLine(data_send);
                    
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string[] data = serialPort1.ReadLine().Split('-');
            this.Invoke((MethodInvoker) delegate
            {
                textBox_Coil_values.Text = data[0];
                textBox_Digital_Inputs_values.Text = data[1];
                textBox_Registers_Inputs_values.Text = data[2];
                textBox_Holding_Registers_values.Text = data[3];
            });
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void Values_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
