using System.IO;
using System.Text;
using System.Security.Cryptography;
using Word = Microsoft.Office.Interop.Word;
using GemBox.Document;
using Xceed.Words.NET;
using Xceed.Document.NET;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Windows;

namespace Group11_EncryptAndDecryptAppWithAES
{
    public partial class Form1 : Form
    {
        private string key;

        public Form1()
        {
            InitializeComponent();
            //ApplyGemBoxLicense();
        }
        
        /*
         * private void ApplyGemBoxLicense()
         * {
         *   ComponentInfo.SetLicense("FREE-LIMITED-KEY");
         * }
         */

        // ham chon file txt hoac Word
        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|Word documents (*.doc;*.docx)|*.doc;*.docx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileContent = string.Empty;
                try
                {
                    if (openFileDialog.FileName.EndsWith(".txt"))
                    {
                        fileContent = File.ReadAllText(openFileDialog.FileName);
                        richTextBoxFirst.Text = fileContent;
                    }
                    else if (openFileDialog.FileName.EndsWith(".doc") || openFileDialog.FileName.EndsWith(".docx"))
                    {
                        fileContent = ReadWordFile(openFileDialog.FileName);
                       richTextBoxFirst.Rtf = fileContent;
                    }
                    //richTextBoxFirst.Text = fileContent;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }

        // ham doc du lieu tu file word
        private string ReadWordFile(string fileName)
        {
            
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (WordDocument document = new WordDocument(fileStream, FormatType.Automatic))
                {
                    // Tao MemoryStream de luu noi dung RTF
                    using (MemoryStream stream = new MemoryStream())
                    {
                        // Luu tai lieu duoi dang RTF
                        document.Save(stream, FormatType.Rtf);
                        stream.Position = 0;

                        // Doc noi dung RTF tu MemoryStream
                        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                        {
                            string content = reader.ReadToEnd();
                            return RemoveTrialWatermark(content);
                        }
                    }
                }
            }
            
        }

        private string RemoveTrialWatermark(string content)
        {
            string[] trialMessages = new string[]
            {
                "Created with a trial version of Syncfusion Word library or registered the wrong key in your application.",
                "Click here to obtain the valid key.",
            };

            foreach (var trialMessage in trialMessages)
            {
                content = content.Replace(trialMessage, string.Empty);
            }

            content = content.Trim();

            return content;
        }



        // ham chuyen doi che do giua Ma hoa va Giai ma
        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            string firstLabelContent = labelFirst.Text.ToString();
            string secondLabelContent = labelSecond.Text.ToString();

            labelFirst.Text = secondLabelContent;
            labelSecond.Text = firstLabelContent;

            string tmpString = richTextBoxFirst.Text;
            richTextBoxFirst.Text = richTextBoxSecond.Text;
            richTextBoxSecond.Text = tmpString;
        }

        // ham luu du lieu ma hoa/giai ma vao file txt hoac Word
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
        }

        // ham tao tao va sinh khoa tu dong
        private void taoKhoaBtn_Click(object sender, EventArgs e)
        {
            using (var ase = Aes.Create())
            {
                ase.GenerateKey();
                key = Convert.ToBase64String(ase.Key);
            }

            txtGenerateKey.Text = key;
        }

        // ham tinh tpan thuc hien ma hoa hoac giai ma theo AES
        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        // function to expand key
        // with formula: w[j] = w[j-1] + w[j-4] if j%4!=0
        //               w[j] = trans(w[j-1]) + w[j-4] if j%4==0

        // function for trans(w[j])

        // function for RotWord

        // function for SubWord with S-Box 

        // function for XOR with Rcon[j/4]

        // ham thuc hien ma hoa AES
        private void encrypt()
        {

        }
        
        // ham thuc hien giai ma AES
        private void decrypt()
        {

        }
    }
}
