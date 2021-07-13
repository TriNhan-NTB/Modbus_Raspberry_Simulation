
namespace COM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Receive = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Holding_Registers_values = new System.Windows.Forms.TextBox();
            this.textBox_Registers_Inputs_values = new System.Windows.Forms.TextBox();
            this.textBox_Digital_Inputs_values = new System.Windows.Forms.TextBox();
            this.textBox_Coil_values = new System.Windows.Forms.TextBox();
            this.Values = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_holding_values_write = new System.Windows.Forms.TextBox();
            this.textBox_Hoding_address_Write = new System.Windows.Forms.TextBox();
            this.textBox_Coil_value_write = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Coil_address_write = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Open
            // 
            this.button_Open.ForeColor = System.Drawing.Color.DarkGray;
            this.button_Open.Location = new System.Drawing.Point(250, 20);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(88, 32);
            this.button_Open.TabIndex = 1;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Close
            // 
            this.button_Close.ForeColor = System.Drawing.Color.DarkGray;
            this.button_Close.Location = new System.Drawing.Point(371, 20);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(88, 32);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(43, 187);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(88, 32);
            this.button_Send.TabIndex = 5;
            this.button_Send.Text = "Write";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Receive
            // 
            this.button_Receive.Location = new System.Drawing.Point(182, 281);
            this.button_Receive.Name = "button_Receive";
            this.button_Receive.Size = new System.Drawing.Size(144, 32);
            this.button_Receive.TabIndex = 7;
            this.button_Receive.Text = "Read";
            this.button_Receive.UseVisualStyleBackColor = true;
            this.button_Receive.Click += new System.EventHandler(this.button_Receive_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox_Holding_Registers_values);
            this.groupBox1.Controls.Add(this.button_Receive);
            this.groupBox1.Controls.Add(this.textBox_Registers_Inputs_values);
            this.groupBox1.Controls.Add(this.textBox_Digital_Inputs_values);
            this.groupBox1.Controls.Add(this.textBox_Coil_values);
            this.groupBox1.Controls.Add(this.Values);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 334);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_Holding_Registers_values
            // 
            this.textBox_Holding_Registers_values.Location = new System.Drawing.Point(401, 221);
            this.textBox_Holding_Registers_values.Multiline = true;
            this.textBox_Holding_Registers_values.Name = "textBox_Holding_Registers_values";
            this.textBox_Holding_Registers_values.Size = new System.Drawing.Size(419, 49);
            this.textBox_Holding_Registers_values.TabIndex = 19;
            // 
            // textBox_Registers_Inputs_values
            // 
            this.textBox_Registers_Inputs_values.Location = new System.Drawing.Point(401, 166);
            this.textBox_Registers_Inputs_values.Multiline = true;
            this.textBox_Registers_Inputs_values.Name = "textBox_Registers_Inputs_values";
            this.textBox_Registers_Inputs_values.Size = new System.Drawing.Size(419, 49);
            this.textBox_Registers_Inputs_values.TabIndex = 18;
            // 
            // textBox_Digital_Inputs_values
            // 
            this.textBox_Digital_Inputs_values.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Digital_Inputs_values.Location = new System.Drawing.Point(401, 111);
            this.textBox_Digital_Inputs_values.Multiline = true;
            this.textBox_Digital_Inputs_values.Name = "textBox_Digital_Inputs_values";
            this.textBox_Digital_Inputs_values.Size = new System.Drawing.Size(419, 49);
            this.textBox_Digital_Inputs_values.TabIndex = 17;
            // 
            // textBox_Coil_values
            // 
            this.textBox_Coil_values.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Coil_values.Location = new System.Drawing.Point(401, 56);
            this.textBox_Coil_values.Multiline = true;
            this.textBox_Coil_values.Name = "textBox_Coil_values";
            this.textBox_Coil_values.Size = new System.Drawing.Size(419, 49);
            this.textBox_Coil_values.TabIndex = 16;
            // 
            // Values
            // 
            this.Values.AutoSize = true;
            this.Values.Location = new System.Drawing.Point(575, 23);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(66, 20);
            this.Values.TabIndex = 15;
            this.Values.Text = "Values";
            this.Values.Click += new System.EventHandler(this.Values_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(292, 238);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(89, 27);
            this.textBox8.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(146, 238);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(89, 27);
            this.textBox7.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(292, 178);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(89, 27);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(146, 178);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(89, 27);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(292, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 27);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 27);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 27);
            this.textBox2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Start_address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Holding Registers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Registers Inputs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Digital Inputs";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Coil Outputs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button_Send);
            this.groupBox2.Controls.Add(this.textBox_holding_values_write);
            this.groupBox2.Controls.Add(this.textBox_Hoding_address_Write);
            this.groupBox2.Controls.Add(this.textBox_Coil_value_write);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_Coil_address_write);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(859, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 319);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Write";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox_holding_values_write
            // 
            this.textBox_holding_values_write.Location = new System.Drawing.Point(292, 128);
            this.textBox_holding_values_write.Name = "textBox_holding_values_write";
            this.textBox_holding_values_write.Size = new System.Drawing.Size(89, 27);
            this.textBox_holding_values_write.TabIndex = 13;
            // 
            // textBox_Hoding_address_Write
            // 
            this.textBox_Hoding_address_Write.Location = new System.Drawing.Point(137, 128);
            this.textBox_Hoding_address_Write.Name = "textBox_Hoding_address_Write";
            this.textBox_Hoding_address_Write.Size = new System.Drawing.Size(98, 27);
            this.textBox_Hoding_address_Write.TabIndex = 12;
            // 
            // textBox_Coil_value_write
            // 
            this.textBox_Coil_value_write.Location = new System.Drawing.Point(292, 68);
            this.textBox_Coil_value_write.Name = "textBox_Coil_value_write";
            this.textBox_Coil_value_write.Size = new System.Drawing.Size(89, 27);
            this.textBox_Coil_value_write.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Address";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox_Coil_address_write
            // 
            this.textBox_Coil_address_write.Location = new System.Drawing.Point(137, 68);
            this.textBox_Coil_address_write.Name = "textBox_Coil_address_write";
            this.textBox_Coil_address_write.Size = new System.Drawing.Size(98, 27);
            this.textBox_Coil_address_write.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Holding Registers";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Coil Outputs";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(509, 281);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 28);
            this.comboBox2.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Type";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(274, 183);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(132, 28);
            this.comboBox3.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Receive;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Values;
        private System.Windows.Forms.TextBox textBox_Holding_Registers_values;
        private System.Windows.Forms.TextBox textBox_Registers_Inputs_values;
        private System.Windows.Forms.TextBox textBox_Digital_Inputs_values;
        private System.Windows.Forms.TextBox textBox_Coil_values;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_holding_values_write;
        private System.Windows.Forms.TextBox textBox_Hoding_address_Write;
        private System.Windows.Forms.TextBox textBox_Coil_value_write;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Coil_address_write;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label12;
    }
}

