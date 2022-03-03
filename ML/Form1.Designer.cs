
namespace ML
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fixedacidity_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.volatileacidity_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.citricacid_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.residualsugar_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chlorides_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.freesulfur_textBox = new System.Windows.Forms.TextBox();
            this.totalsulfur_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.density_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.phvalue_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sulphates_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.alcohol_textBox = new System.Windows.Forms.TextBox();
            this.quality_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Learning Model";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 282);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Train Model";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 342);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Test Model";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "The data currently being used is about wine quality got from the public dataset r" +
    "eposity on Kaggle.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Learn more about the dataset here at https://www.kaggle.com/yasserh/wine-quality-" +
    "dataset";
            // 
            // fixedacidity_textBox
            // 
            this.fixedacidity_textBox.Location = new System.Drawing.Point(236, 114);
            this.fixedacidity_textBox.Name = "fixedacidity_textBox";
            this.fixedacidity_textBox.Size = new System.Drawing.Size(100, 20);
            this.fixedacidity_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fixed Acidity";
            // 
            // volatileacidity_textBox
            // 
            this.volatileacidity_textBox.Location = new System.Drawing.Point(236, 140);
            this.volatileacidity_textBox.Name = "volatileacidity_textBox";
            this.volatileacidity_textBox.Size = new System.Drawing.Size(100, 20);
            this.volatileacidity_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Volatile Acidity";
            // 
            // citricacid_textBox
            // 
            this.citricacid_textBox.Location = new System.Drawing.Point(236, 166);
            this.citricacid_textBox.Name = "citricacid_textBox";
            this.citricacid_textBox.Size = new System.Drawing.Size(100, 20);
            this.citricacid_textBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Citric Acid";
            // 
            // residualsugar_textBox
            // 
            this.residualsugar_textBox.Location = new System.Drawing.Point(236, 192);
            this.residualsugar_textBox.Name = "residualsugar_textBox";
            this.residualsugar_textBox.Size = new System.Drawing.Size(100, 20);
            this.residualsugar_textBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Residual Sugar";
            // 
            // chlorides_textBox
            // 
            this.chlorides_textBox.Location = new System.Drawing.Point(236, 218);
            this.chlorides_textBox.Name = "chlorides_textBox";
            this.chlorides_textBox.Size = new System.Drawing.Size(100, 20);
            this.chlorides_textBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chlorides";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Free Sulfur Dioxide";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total Sulfur Dioxide";
            // 
            // freesulfur_textBox
            // 
            this.freesulfur_textBox.Location = new System.Drawing.Point(571, 114);
            this.freesulfur_textBox.Name = "freesulfur_textBox";
            this.freesulfur_textBox.Size = new System.Drawing.Size(100, 20);
            this.freesulfur_textBox.TabIndex = 17;
            // 
            // totalsulfur_textBox
            // 
            this.totalsulfur_textBox.Location = new System.Drawing.Point(571, 140);
            this.totalsulfur_textBox.Name = "totalsulfur_textBox";
            this.totalsulfur_textBox.Size = new System.Drawing.Size(100, 20);
            this.totalsulfur_textBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Density";
            // 
            // density_textBox
            // 
            this.density_textBox.Location = new System.Drawing.Point(571, 166);
            this.density_textBox.Name = "density_textBox";
            this.density_textBox.Size = new System.Drawing.Size(100, 20);
            this.density_textBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(460, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "pH Value";
            // 
            // phvalue_textBox
            // 
            this.phvalue_textBox.Location = new System.Drawing.Point(571, 192);
            this.phvalue_textBox.Name = "phvalue_textBox";
            this.phvalue_textBox.Size = new System.Drawing.Size(100, 20);
            this.phvalue_textBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Sulphates";
            // 
            // sulphates_textBox
            // 
            this.sulphates_textBox.Location = new System.Drawing.Point(571, 218);
            this.sulphates_textBox.Name = "sulphates_textBox";
            this.sulphates_textBox.Size = new System.Drawing.Size(100, 20);
            this.sulphates_textBox.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(332, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Alcohol";
            // 
            // alcohol_textBox
            // 
            this.alcohol_textBox.Location = new System.Drawing.Point(389, 249);
            this.alcohol_textBox.Name = "alcohol_textBox";
            this.alcohol_textBox.Size = new System.Drawing.Size(100, 20);
            this.alcohol_textBox.TabIndex = 26;
            // 
            // quality_textBox
            // 
            this.quality_textBox.Location = new System.Drawing.Point(571, 361);
            this.quality_textBox.Name = "quality_textBox";
            this.quality_textBox.Size = new System.Drawing.Size(100, 20);
            this.quality_textBox.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(503, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Quality";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 55);
            this.button4.TabIndex = 29;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 409);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.quality_textBox);
            this.Controls.Add(this.alcohol_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sulphates_textBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.phvalue_textBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.density_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalsulfur_textBox);
            this.Controls.Add(this.freesulfur_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chlorides_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.residualsugar_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.citricacid_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.volatileacidity_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fixedacidity_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fixedacidity_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox volatileacidity_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox citricacid_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox residualsugar_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox chlorides_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox freesulfur_textBox;
        private System.Windows.Forms.TextBox totalsulfur_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox density_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox phvalue_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox sulphates_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox alcohol_textBox;
        private System.Windows.Forms.TextBox quality_textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
    }
}

