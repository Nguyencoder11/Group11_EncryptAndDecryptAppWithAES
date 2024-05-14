using System.Security.Cryptography;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using Aspose.Words;

namespace Group11_EncryptAndDecryptAppWithAES
{
    public partial class Form1 : Form
    {
        private string key;

        public Form1()
        {
            InitializeComponent();
        }

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
                    }
                    else if (openFileDialog.FileName.EndsWith(".doc") || openFileDialog.FileName.EndsWith(".docx"))
                    {
                        fileContent = ReadWordFile(openFileDialog.FileName);
                    }

                    richTextBoxFirst.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }

        // ham doc du lieu tu file word
        private string ReadWordFile(string fileName)
        {
            /* su dung thu vien Microsoft.Office.Interop.Word
            Word.Application wordApp = null;
            Word.Document doc = null;
            string fileContent = string.Empty;

            try
            {
                wordApp = new Word.Application();
                doc = wordApp.Documents.Open(fileName);

                foreach (Word.Paragraph paragraph in doc.Paragraphs)
                {
                    fileContent += paragraph.Range.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading Word file: " + ex.Message);
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
                }
                if (wordApp != null)
                {
                    wordApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                }
            }

            return fileContent;*/

            // su dung thu vien Aspose.Words
            try
            {
                Document doc = new Document(fileName);
                return doc.ToString(SaveFormat.Text);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error reading Word file: " + ex.Message);
                return string.Empty;
            }
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
