namespace furi_imageProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbA = new System.Windows.Forms.PictureBox();
            this.btnA = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbB = new System.Windows.Forms.PictureBox();
            this.btnB = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnMirror = new System.Windows.Forms.Button();
            this.btnColV = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnNOT = new System.Windows.Forms.Button();
            this.btnOR = new System.Windows.Forms.Button();
            this.btnXOR = new System.Windows.Forms.Button();
            this.btnAND = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtBld = new System.Windows.Forms.TextBox();
            this.txtMult = new System.Windows.Forms.TextBox();
            this.txtDiv = new System.Windows.Forms.TextBox();
            this.btnBld = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.bntDiv = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbA);
            this.groupBox1.Controls.Add(this.btnA);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(225, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image A";
            // 
            // pbA
            // 
            this.pbA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbA.Location = new System.Drawing.Point(15, 17);
            this.pbA.Margin = new System.Windows.Forms.Padding(2);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(195, 195);
            this.pbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbA.TabIndex = 0;
            this.pbA.TabStop = false;
            this.pbA.Click += new System.EventHandler(this.pbA_Click);
            // 
            // btnA
            // 
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.Location = new System.Drawing.Point(116, 218);
            this.btnA.Margin = new System.Windows.Forms.Padding(2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(94, 24);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "Load Image A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbB);
            this.groupBox2.Controls.Add(this.btnB);
            this.groupBox2.Location = new System.Drawing.Point(238, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(225, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image B";
            // 
            // pbB
            // 
            this.pbB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbB.Location = new System.Drawing.Point(15, 17);
            this.pbB.Margin = new System.Windows.Forms.Padding(2);
            this.pbB.Name = "pbB";
            this.pbB.Size = new System.Drawing.Size(195, 195);
            this.pbB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbB.TabIndex = 0;
            this.pbB.TabStop = false;
            this.pbB.Click += new System.EventHandler(this.pbB_Click);
            // 
            // btnB
            // 
            this.btnB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.Location = new System.Drawing.Point(116, 218);
            this.btnB.Margin = new System.Windows.Forms.Padding(2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(94, 24);
            this.btnB.TabIndex = 4;
            this.btnB.Text = "Load Image B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.pbResult);
            this.groupBox3.Location = new System.Drawing.Point(467, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(225, 250);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(15, 17);
            this.pbResult.Margin = new System.Windows.Forms.Padding(2);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(195, 195);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 0;
            this.pbResult.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(21, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(634, 166);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tools";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnMirror);
            this.groupBox7.Controls.Add(this.btnColV);
            this.groupBox7.Location = new System.Drawing.Point(501, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(118, 141);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "More";
            // 
            // btnMirror
            // 
            this.btnMirror.Location = new System.Drawing.Point(20, 78);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(75, 35);
            this.btnMirror.TabIndex = 1;
            this.btnMirror.Text = "Mirror";
            this.btnMirror.UseVisualStyleBackColor = true;
            // 
            // btnColV
            // 
            this.btnColV.Location = new System.Drawing.Point(20, 28);
            this.btnColV.Name = "btnColV";
            this.btnColV.Size = new System.Drawing.Size(75, 35);
            this.btnColV.TabIndex = 0;
            this.btnColV.Text = "Vertical Collage";
            this.btnColV.UseVisualStyleBackColor = true;
            this.btnColV.Click += new System.EventHandler(this.btnColV_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnNOT);
            this.groupBox6.Controls.Add(this.btnOR);
            this.groupBox6.Controls.Add(this.btnXOR);
            this.groupBox6.Controls.Add(this.btnAND);
            this.groupBox6.Location = new System.Drawing.Point(284, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 98);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Logic Operations";
            // 
            // btnNOT
            // 
            this.btnNOT.Location = new System.Drawing.Point(110, 66);
            this.btnNOT.Name = "btnNOT";
            this.btnNOT.Size = new System.Drawing.Size(85, 23);
            this.btnNOT.TabIndex = 5;
            this.btnNOT.Text = "NOT";
            this.btnNOT.UseVisualStyleBackColor = true;
            // 
            // btnOR
            // 
            this.btnOR.Location = new System.Drawing.Point(110, 28);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(85, 23);
            this.btnOR.TabIndex = 4;
            this.btnOR.Text = "OR";
            this.btnOR.UseVisualStyleBackColor = true;
            // 
            // btnXOR
            // 
            this.btnXOR.Location = new System.Drawing.Point(6, 66);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.Size = new System.Drawing.Size(85, 23);
            this.btnXOR.TabIndex = 2;
            this.btnXOR.Text = "XOR";
            this.btnXOR.UseVisualStyleBackColor = true;
            // 
            // btnAND
            // 
            this.btnAND.Location = new System.Drawing.Point(6, 28);
            this.btnAND.Name = "btnAND";
            this.btnAND.Size = new System.Drawing.Size(85, 23);
            this.btnAND.TabIndex = 1;
            this.btnAND.Text = "AND";
            this.btnAND.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtBld);
            this.groupBox5.Controls.Add(this.txtMult);
            this.groupBox5.Controls.Add(this.txtDiv);
            this.groupBox5.Controls.Add(this.btnBld);
            this.groupBox5.Controls.Add(this.btnAvg);
            this.groupBox5.Controls.Add(this.btnMult);
            this.groupBox5.Controls.Add(this.bntDiv);
            this.groupBox5.Controls.Add(this.btnSub);
            this.groupBox5.Controls.Add(this.btnAdd);
            this.groupBox5.Location = new System.Drawing.Point(13, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 141);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Arithmetic Operations";
            // 
            // txtBld
            // 
            this.txtBld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBld.Location = new System.Drawing.Point(201, 106);
            this.txtBld.Name = "txtBld";
            this.txtBld.Size = new System.Drawing.Size(48, 20);
            this.txtBld.TabIndex = 9;
            // 
            // txtMult
            // 
            this.txtMult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMult.Location = new System.Drawing.Point(201, 69);
            this.txtMult.Name = "txtMult";
            this.txtMult.Size = new System.Drawing.Size(48, 20);
            this.txtMult.TabIndex = 8;
            // 
            // txtDiv
            // 
            this.txtDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiv.Location = new System.Drawing.Point(201, 31);
            this.txtDiv.Name = "txtDiv";
            this.txtDiv.Size = new System.Drawing.Size(48, 20);
            this.txtDiv.TabIndex = 7;
            this.txtDiv.TextChanged += new System.EventHandler(this.txtDiv_TextChanged);
            // 
            // btnBld
            // 
            this.btnBld.Location = new System.Drawing.Point(110, 106);
            this.btnBld.Name = "btnBld";
            this.btnBld.Size = new System.Drawing.Size(85, 23);
            this.btnBld.TabIndex = 6;
            this.btnBld.Text = "Blending";
            this.btnBld.UseVisualStyleBackColor = true;
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(6, 106);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(85, 23);
            this.btnAvg.TabIndex = 5;
            this.btnAvg.Text = "Average";
            this.btnAvg.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(110, 66);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(85, 23);
            this.btnMult.TabIndex = 3;
            this.btnMult.Text = "Multiplication";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // bntDiv
            // 
            this.bntDiv.Location = new System.Drawing.Point(110, 28);
            this.bntDiv.Name = "bntDiv";
            this.bntDiv.Size = new System.Drawing.Size(85, 23);
            this.bntDiv.TabIndex = 4;
            this.bntDiv.Text = "Division";
            this.bntDiv.UseVisualStyleBackColor = true;
            this.bntDiv.Click += new System.EventHandler(this.bntDiv_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(6, 66);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(85, 23);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "Subtraction";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Addition";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(116, 216);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Export Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 469);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Image Processor";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnColV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBld;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button bntDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnNOT;
        private System.Windows.Forms.Button btnOR;
        private System.Windows.Forms.Button btnXOR;
        private System.Windows.Forms.Button btnAND;
        private System.Windows.Forms.TextBox txtBld;
        private System.Windows.Forms.TextBox txtMult;
        private System.Windows.Forms.TextBox txtDiv;
        private System.Windows.Forms.Button btnMirror;
        private System.Windows.Forms.Button button1;
    }
}

