using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;

namespace Dictionary
{
    public partial class fVieToEng : Form
    {
        string FileName;
        public fVieToEng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                Image image = Image.FromFile(FileName);
                pictureBox1.Image = image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var obj = OcrApi.Create())
            {
                obj.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = obj.GetTextFromImage(FileName);
                textBox1.Text = plainText;
                obj.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strTransText = null;
            TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
            strTransText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", textBox1.Text, "", "en");
            textBox2.Text = strTransText;
            client.Close();
        }
    }
}
