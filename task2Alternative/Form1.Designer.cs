
namespace task2Alternative
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showFile = new System.Windows.Forms.Button();
            this.resultOFD = new System.Windows.Forms.Label();
            this.openBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createBut = new System.Windows.Forms.Button();
            this.chengeBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.methShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showFile
            // 
            this.showFile.Location = new System.Drawing.Point(12, 12);
            this.showFile.Name = "showFile";
            this.showFile.Size = new System.Drawing.Size(140, 31);
            this.showFile.TabIndex = 0;
            this.showFile.Text = "Выбрать файл";
            this.showFile.UseVisualStyleBackColor = true;
            this.showFile.Click += new System.EventHandler(this.showFile_Click);
            // 
            // resultOFD
            // 
            this.resultOFD.AutoSize = true;
            this.resultOFD.Location = new System.Drawing.Point(158, 20);
            this.resultOFD.Name = "resultOFD";
            this.resultOFD.Size = new System.Drawing.Size(0, 15);
            this.resultOFD.TabIndex = 1;
            // 
            // openBut
            // 
            this.openBut.Location = new System.Drawing.Point(134, 53);
            this.openBut.Name = "openBut";
            this.openBut.Size = new System.Drawing.Size(75, 23);
            this.openBut.TabIndex = 2;
            this.openBut.Text = "open";
            this.openBut.UseVisualStyleBackColor = true;
            this.openBut.Click += new System.EventHandler(this.openBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите действие:";
            // 
            // createBut
            // 
            this.createBut.Location = new System.Drawing.Point(215, 53);
            this.createBut.Name = "createBut";
            this.createBut.Size = new System.Drawing.Size(75, 23);
            this.createBut.TabIndex = 4;
            this.createBut.Text = "create";
            this.createBut.UseVisualStyleBackColor = true;
            this.createBut.Click += new System.EventHandler(this.createBut_Click);
            // 
            // chengeBut
            // 
            this.chengeBut.Location = new System.Drawing.Point(296, 53);
            this.chengeBut.Name = "chengeBut";
            this.chengeBut.Size = new System.Drawing.Size(75, 23);
            this.chengeBut.TabIndex = 5;
            this.chengeBut.Text = "chenge";
            this.chengeBut.UseVisualStyleBackColor = true;
            this.chengeBut.Click += new System.EventHandler(this.chengeBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(377, 53);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(75, 23);
            this.saveBut.TabIndex = 6;
            this.saveBut.Text = "save";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // methShow
            // 
            this.methShow.AutoSize = true;
            this.methShow.Location = new System.Drawing.Point(12, 84);
            this.methShow.Name = "methShow";
            this.methShow.Size = new System.Drawing.Size(10, 15);
            this.methShow.TabIndex = 7;
            this.methShow.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 161);
            this.Controls.Add(this.methShow);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.chengeBut);
            this.Controls.Add(this.createBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openBut);
            this.Controls.Add(this.resultOFD);
            this.Controls.Add(this.showFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showFile;
        private System.Windows.Forms.Label resultOFD;
        private System.Windows.Forms.Button openBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createBut;
        private System.Windows.Forms.Button chengeBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Label methShow;
    }
}

