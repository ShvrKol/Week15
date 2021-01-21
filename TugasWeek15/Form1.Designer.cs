
namespace TugasWeek15
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxitem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonbev = new System.Windows.Forms.RadioButton();
            this.radioButtonfood = new System.Windows.Forms.RadioButton();
            this.buttoninput = new System.Windows.Forms.Button();
            this.listBoxfirst = new System.Windows.Forms.ListBox();
            this.buttonnext = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.listBoxsecnd = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxfood = new System.Windows.Forms.CheckBox();
            this.checkBoxbev = new System.Windows.Forms.CheckBox();
            this.listBoxfood = new System.Windows.Forms.ListBox();
            this.listBoxbev = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Item:";
            // 
            // textBoxitem
            // 
            this.textBoxitem.Location = new System.Drawing.Point(93, 23);
            this.textBoxitem.Name = "textBoxitem";
            this.textBoxitem.Size = new System.Drawing.Size(152, 20);
            this.textBoxitem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButtonbev);
            this.panel1.Controls.Add(this.radioButtonfood);
            this.panel1.Location = new System.Drawing.Point(93, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 51);
            this.panel1.TabIndex = 3;
            // 
            // radioButtonbev
            // 
            this.radioButtonbev.AutoSize = true;
            this.radioButtonbev.Location = new System.Drawing.Point(77, 17);
            this.radioButtonbev.Name = "radioButtonbev";
            this.radioButtonbev.Size = new System.Drawing.Size(68, 17);
            this.radioButtonbev.TabIndex = 1;
            this.radioButtonbev.TabStop = true;
            this.radioButtonbev.Text = "Minuman";
            this.radioButtonbev.UseVisualStyleBackColor = true;
            this.radioButtonbev.CheckedChanged += new System.EventHandler(this.radioButtonbev_CheckedChanged);
            // 
            // radioButtonfood
            // 
            this.radioButtonfood.AutoSize = true;
            this.radioButtonfood.Location = new System.Drawing.Point(4, 17);
            this.radioButtonfood.Name = "radioButtonfood";
            this.radioButtonfood.Size = new System.Drawing.Size(70, 17);
            this.radioButtonfood.TabIndex = 0;
            this.radioButtonfood.TabStop = true;
            this.radioButtonfood.Text = "Makanan";
            this.radioButtonfood.UseVisualStyleBackColor = true;
            this.radioButtonfood.CheckedChanged += new System.EventHandler(this.radioButtonfood_CheckedChanged);
            // 
            // buttoninput
            // 
            this.buttoninput.Location = new System.Drawing.Point(93, 136);
            this.buttoninput.Name = "buttoninput";
            this.buttoninput.Size = new System.Drawing.Size(75, 23);
            this.buttoninput.TabIndex = 4;
            this.buttoninput.Text = "Input";
            this.buttoninput.UseVisualStyleBackColor = true;
            this.buttoninput.Click += new System.EventHandler(this.buttoninput_Click);
            // 
            // listBoxfirst
            // 
            this.listBoxfirst.FormattingEnabled = true;
            this.listBoxfirst.Items.AddRange(new object[] {
            "Mie Instan",
            "Telor",
            "Susu Sapi",
            "Kopi",
            "Roti",
            "Keju",
            "Daging Giling",
            "Teh",
            "Bir"});
            this.listBoxfirst.Location = new System.Drawing.Point(98, 187);
            this.listBoxfirst.Name = "listBoxfirst";
            this.listBoxfirst.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxfirst.Size = new System.Drawing.Size(151, 225);
            this.listBoxfirst.TabIndex = 5;
            // 
            // buttonnext
            // 
            this.buttonnext.Location = new System.Drawing.Point(278, 187);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(75, 23);
            this.buttonnext.TabIndex = 6;
            this.buttonnext.Text = ">";
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(278, 216);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 7;
            this.buttondelete.Text = "X";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // listBoxsecnd
            // 
            this.listBoxsecnd.FormattingEnabled = true;
            this.listBoxsecnd.Location = new System.Drawing.Point(386, 187);
            this.listBoxsecnd.Name = "listBoxsecnd";
            this.listBoxsecnd.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxsecnd.Size = new System.Drawing.Size(151, 225);
            this.listBoxsecnd.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filter";
            // 
            // checkBoxfood
            // 
            this.checkBoxfood.AutoSize = true;
            this.checkBoxfood.Location = new System.Drawing.Point(278, 285);
            this.checkBoxfood.Name = "checkBoxfood";
            this.checkBoxfood.Size = new System.Drawing.Size(71, 17);
            this.checkBoxfood.TabIndex = 10;
            this.checkBoxfood.Text = "Makanan";
            this.checkBoxfood.UseVisualStyleBackColor = true;
            this.checkBoxfood.CheckedChanged += new System.EventHandler(this.checkBoxfood_CheckedChanged);
            // 
            // checkBoxbev
            // 
            this.checkBoxbev.AutoSize = true;
            this.checkBoxbev.Location = new System.Drawing.Point(278, 308);
            this.checkBoxbev.Name = "checkBoxbev";
            this.checkBoxbev.Size = new System.Drawing.Size(69, 17);
            this.checkBoxbev.TabIndex = 11;
            this.checkBoxbev.Text = "Minuman";
            this.checkBoxbev.UseVisualStyleBackColor = true;
            this.checkBoxbev.CheckedChanged += new System.EventHandler(this.checkBoxbev_CheckedChanged);
            // 
            // listBoxfood
            // 
            this.listBoxfood.FormattingEnabled = true;
            this.listBoxfood.Items.AddRange(new object[] {
            "Mie Instan",
            "Telor",
            "Roti",
            "Keju",
            "Daging Giling"});
            this.listBoxfood.Location = new System.Drawing.Point(98, 187);
            this.listBoxfood.Name = "listBoxfood";
            this.listBoxfood.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxfood.Size = new System.Drawing.Size(151, 225);
            this.listBoxfood.TabIndex = 12;
            this.listBoxfood.Visible = false;
            // 
            // listBoxbev
            // 
            this.listBoxbev.FormattingEnabled = true;
            this.listBoxbev.Items.AddRange(new object[] {
            "Susu Sapi",
            "Kopi",
            "Teh",
            "Bir"});
            this.listBoxbev.Location = new System.Drawing.Point(98, 187);
            this.listBoxbev.Name = "listBoxbev";
            this.listBoxbev.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxbev.Size = new System.Drawing.Size(151, 225);
            this.listBoxbev.TabIndex = 13;
            this.listBoxbev.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.listBoxbev);
            this.Controls.Add(this.listBoxfood);
            this.Controls.Add(this.checkBoxbev);
            this.Controls.Add(this.checkBoxfood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxsecnd);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.listBoxfirst);
            this.Controls.Add(this.buttoninput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxitem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxitem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonbev;
        private System.Windows.Forms.RadioButton radioButtonfood;
        private System.Windows.Forms.Button buttoninput;
        private System.Windows.Forms.ListBox listBoxfirst;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.ListBox listBoxsecnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxfood;
        private System.Windows.Forms.CheckBox checkBoxbev;
        private System.Windows.Forms.ListBox listBoxfood;
        private System.Windows.Forms.ListBox listBoxbev;
    }
}

