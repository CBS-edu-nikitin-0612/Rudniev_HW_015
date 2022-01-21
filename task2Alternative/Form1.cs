using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2Alternative
{
    public partial class Form1 : Form
    {
        private OpenFileDialog ofd;
        string fileName, fileExt;
        AbstractHandler handler;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
        }

        private void openBut_Click(object sender, EventArgs e)
        {
            methShow.Text = handler.Open();
        }

        private void createBut_Click(object sender, EventArgs e)
        {
            methShow.Text = handler.Create();
        }

        private void chengeBut_Click(object sender, EventArgs e)
        {
            methShow.Text = handler.Chenge();
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            methShow.Text = handler.Save();
        }

        private void showFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\')+1);
                fileExt = fileName.Substring(fileName.LastIndexOf('.')+1);
                resultOFD.Text = "Вы выбрали файл: " + fileName;
                if (fileExt != "txt" & fileExt != "doc" & fileExt != "xml")
                    resultOFD.Text += "; Это расширение не поддерживается";
                else 
                    switch (fileExt)
                    {
                        case "txt":
                            handler = new TXTHandler() as AbstractHandler;
                            break;
                        case "xml":
                            handler = new XMLHandler() as AbstractHandler;
                            break;
                        case "doc":
                            handler = new DOCHandler() as AbstractHandler;
                            break;
                    }
            }
        }
    }
}
