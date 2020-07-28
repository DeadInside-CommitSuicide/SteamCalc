namespace SteamCalc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox9 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Location = new System.Drawing.Point(21, 82);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(95, 23);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Text = "0";
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.metroTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(21, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Sell Item Price";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(21, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "AutoBuy Price";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(20, 146);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(95, 23);
            this.metroTextBox2.TabIndex = 3;
            this.metroTextBox2.Text = "0";
            this.metroTextBox2.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            this.metroTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Enabled = false;
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox3.Location = new System.Drawing.Point(178, 82);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(95, 23);
            this.metroTextBox3.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(187, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Proffit Price";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Enabled = false;
            this.metroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox4.Location = new System.Drawing.Point(178, 146);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.Size = new System.Drawing.Size(95, 23);
            this.metroTextBox4.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(187, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Proffit Price";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Enabled = false;
            this.metroTextBox5.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox5.Location = new System.Drawing.Point(178, 273);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.Size = new System.Drawing.Size(95, 23);
            this.metroTextBox5.TabIndex = 11;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(187, 251);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Price RUB";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.Location = new System.Drawing.Point(20, 273);
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.Size = new System.Drawing.Size(95, 23);
            this.metroTextBox6.TabIndex = 9;
            this.metroTextBox6.Text = "0";
            this.metroTextBox6.TextChanged += new System.EventHandler(this.metroTextBox6_TextChanged);
            this.metroTextBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox6_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(21, 251);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Price COIN";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroTextBox7
            // 
            this.metroTextBox7.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox7.Location = new System.Drawing.Point(20, 354);
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.Size = new System.Drawing.Size(95, 23);
            this.metroTextBox7.TabIndex = 13;
            this.metroTextBox7.TextChanged += new System.EventHandler(this.metroTextBox7_TextChanged);
            this.metroTextBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox7_KeyPress);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(3, 332);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(127, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Price DMarket USD";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroTextBox8
            // 
            this.metroTextBox8.Enabled = false;
            this.metroTextBox8.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox8.Location = new System.Drawing.Point(178, 354);
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.Size = new System.Drawing.Size(95, 23);
            this.metroTextBox8.TabIndex = 15;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(187, 332);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "PROFFIT";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroTextBox9
            // 
            this.metroTextBox9.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox9.Location = new System.Drawing.Point(20, 217);
            this.metroTextBox9.Name = "metroTextBox9";
            this.metroTextBox9.Size = new System.Drawing.Size(95, 23);
            this.metroTextBox9.TabIndex = 17;
            this.metroTextBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox9_KeyPress);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(20, 195);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(88, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "USD TO RUB";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(198, 217);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "2 PAGE";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 399);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox9);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroTextBox8);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroTextBox7);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroTextBox5);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTextBox6);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "SteamCalcProffit";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox metroTextBox9;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

