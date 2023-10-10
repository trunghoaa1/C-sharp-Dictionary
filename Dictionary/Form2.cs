using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Dictionary
{
    public partial class fDictionary : Form
    {
        DictionaryManager dictionary;
        public fDictionary()
        {
            InitializeComponent();
            cbWord.DisplayMember = "Key";
            dictionary = new DictionaryManager();
            dictionary.LoadDataToCombobox(cbWord);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            dictionary.Serialize();
        }

        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.DataSource == null)
            {
                return;
            }
            DictionaryData data = cb.SelectedItem as DictionaryData;
            txbMeans.Text = data.Meaning;
            txbDefine.Text = data.Explaination;
        }

        private void btnEngToVie_Click(object sender, EventArgs e)
        {
            fEngToVie fTrans = new fEngToVie();
            fTrans.ShowDialog();
        }

        private void btnGGDich_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://translate.google.com/?hl=vi");
        }

        private void btnVieToEng_Click(object sender, EventArgs e)
        {
            fVieToEng fVie = new fVieToEng();
            fVie.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 50;
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync(txbDefine.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 50;
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync((cbWord.SelectedItem as DictionaryData).Key);
        }
    }
}
