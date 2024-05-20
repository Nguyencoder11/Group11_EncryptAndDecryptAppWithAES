using System.Windows;
using System.IO;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using Xceed.Words.NET;
using Xceed.Document.NET;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using GemBox.Document;
using System.Security.Cryptography;

namespace Group11_EncryptAndDecryptAppWithAES
{
    public partial class Form1 : Form
    {
        private byte[] key;

        public Form1()
        {
            InitializeComponent();
        }

        // ham chon file txt hoac Word cho richTextBox ban ro
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
                        richTextBoxFirst.Text = fileContent;
                    }
                    //richTextBoxFirst.Text = fileContent;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }

        // ham luu du lieu ma hoa vao file txt hoac Word 
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|Word documents (*.doc;*.docx)|*.doc;*.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                if (filePath.EndsWith(".txt"))
                {
                    File.WriteAllText(filePath, richTextBoxSecond.Text);
                }
                else if (filePath.EndsWith(".doc") || filePath.EndsWith(".docx"))
                {
                    ComponentInfo.SetLicense("FREE-LIMITED-KEY");
                    try
                    {
                        DocumentModel document = new DocumentModel();

                        document.Content.LoadText(richTextBoxSecond.Text);

                        GemBox.Document.SaveOptions options = GemBox.Document.SaveOptions.DocxDefault;
                        if (filePath.EndsWith(".doc"))
                        {
                            options = GemBox.Document.SaveOptions.DocxDefault;
                        }
                        else if (filePath.EndsWith(".docx"))
                        {
                            options = GemBox.Document.SaveOptions.DocxDefault;
                        }

                        document.Save(filePath, options);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error saving Word file: " + ex.Message);
                    }
                }

                System.Windows.Forms.MessageBox.Show("File da duoc luu thanh cong.");
            }
        }

        // ham chon file txt hoac Word cho richTextBox ban ma
        private void chooseFileBtn2_Click(object sender, EventArgs e)
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
                        richTextBoxThird.Text = fileContent;
                    }
                    else if (openFileDialog.FileName.EndsWith(".doc") || openFileDialog.FileName.EndsWith(".docx"))
                    {
                        fileContent = ReadWordFile(openFileDialog.FileName);
                        richTextBoxThird.Text = fileContent;
                    }
                    //richTextBoxFirst.Text = fileContent;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|Word documents (*.doc;*.docx)|*.doc;*.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                if (filePath.EndsWith(".txt"))
                {
                    File.WriteAllText(filePath, richTextBoxFourth.Text);
                }
                else if (filePath.EndsWith(".doc") || filePath.EndsWith(".docx"))
                {
                    ComponentInfo.SetLicense("FREE-LIMITED-KEY");
                    try
                    {
                        DocumentModel document = new DocumentModel();

                        document.Content.LoadText(richTextBoxFourth.Text);

                        GemBox.Document.SaveOptions options = GemBox.Document.SaveOptions.DocxDefault;
                        if (filePath.EndsWith(".doc"))
                        {
                            options = GemBox.Document.SaveOptions.DocxDefault;
                        }
                        else if (filePath.EndsWith(".docx"))
                        {
                            options = GemBox.Document.SaveOptions.DocxDefault;
                        }

                        document.Save(filePath, options);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error saving Word file: " + ex.Message);
                    }
                }

                System.Windows.Forms.MessageBox.Show("File da duoc luu thanh cong.");
            }
        }

        // ham doc du lieu tu file word
        private string ReadWordFile(string fileName)
        {
            // license for GemBox.Document
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            string fileContent = string.Empty;
            try
            {
                var document = DocumentModel.Load(fileName);

                fileContent = document.Content.ToString();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error reading Word file: " + ex.Message);
            }

            return fileContent;
        }

        // ham chuyen doi 
        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            richTextBoxThird.Text = richTextBoxSecond.Text;
        }

        // S-Box
        private readonly byte[] SBox = new byte[256]
        {
            0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76,
            0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0,
            0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15,
            0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75,
            0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84,
            0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf,
            0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8,
            0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2,
            0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73,
            0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb,
            0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79,
            0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08,
            0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a,
            0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e,
            0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf,
            0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16
        };

        // S-Box dao
        private readonly byte[] InvSBox = new byte[256]
        {
            0x52, 0x09, 0x6a, 0xd5, 0x30, 0x36, 0xa5, 0x38, 0xbf, 0x40, 0xa3, 0x9e, 0x81, 0xf3, 0xd7, 0xfb,
            0x7c, 0xe3, 0x39, 0x82, 0x9b, 0x2f, 0xff, 0x87, 0x34, 0x8e, 0x43, 0x44, 0xc4, 0xde, 0xe9, 0xcb,
            0x54, 0x7b, 0x94, 0x32, 0xa6, 0xc2, 0x23, 0x3d, 0xee, 0x4c, 0x95, 0x0b, 0x42, 0xfa, 0xc3, 0x4e,
            0x08, 0x2e, 0xa1, 0x66, 0x28, 0xd9, 0x24, 0xb2, 0x76, 0x5b, 0xa2, 0x49, 0x6d, 0x8b, 0xd1, 0x25, 
            0x72, 0xf8, 0xf6, 0x64, 0x86, 0x68, 0x98, 0x16, 0xd4, 0xa4, 0x5c, 0xcc, 0x5d, 0x65, 0xb6, 0x92,
            0x6c, 0x70, 0x48, 0x50, 0xfd, 0xed, 0xb9, 0xda, 0x5e, 0x15, 0x46, 0x57, 0xa7, 0x8d, 0x9d, 0x84,
            0x90, 0xd8, 0xab, 0x00, 0x8c, 0xbc, 0xd3, 0x0a, 0xf7, 0xe4, 0x58, 0x05, 0xb8, 0xb3, 0x45, 0x06,
            0xd0, 0x2c, 0x1e, 0x8f, 0xca, 0x3f, 0x0f, 0x02, 0xc1, 0xaf, 0xbd, 0x03, 0x01, 0x13, 0x8a, 0x6b,
            0x3a, 0x91, 0x11, 0x41, 0x4f, 0x67, 0xdc, 0xea, 0x97, 0xf2, 0xcf, 0xce, 0xf0, 0xb4, 0xe6, 0x73,
            0x96, 0xac, 0x74, 0x22, 0xe7, 0xad, 0x35, 0x85, 0xe2, 0xf9, 0x37, 0xe8, 0x1c, 0x75, 0xdf, 0x6e,
            0x47, 0xf1, 0x1a, 0x71, 0x1d, 0x29, 0xc5, 0x89, 0x6f, 0xb7, 0x62, 0x0e, 0xaa, 0x18, 0xbe, 0x1b,
            0xfc, 0x56, 0x3e, 0x4b, 0xc6, 0xd2, 0x79, 0x20, 0x9a, 0xdb, 0xc0, 0xfe, 0x78, 0xcd, 0x5a, 0xf4,
            0x1f, 0xdd, 0xa8, 0x33, 0x88, 0x07, 0xc7, 0x31, 0xb1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xec, 0x5f,
            0x60, 0x51, 0x7f, 0xa9, 0x19, 0xb5, 0x4a, 0x0d, 0x2d, 0xe5, 0x7a, 0x9f, 0x93, 0xc9, 0x9c, 0xef,
            0xa0, 0xe0, 0x3b, 0x4d, 0xae, 0x2a, 0xf5, 0xb0, 0xc8, 0xeb, 0xbb, 0x3c, 0x83, 0x53, 0x99, 0x61,
            0x17, 0x2b, 0x04, 0x7e, 0xba, 0x77, 0xd6, 0x26, 0xe1, 0x69, 0x14, 0x63, 0x55, 0x21, 0x0c, 0x7d,
        };

        private readonly byte[] Rcon = new byte[]
        {
            0x00, 0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x80, 0x1b, 0x36, 0x6c, 0xd8, 0xab, 0x4d, 0x9a,
            0x2f, 0x5e, 0xbc, 0x63, 0xc6, 0x97, 0x35, 0x6a, 0xd4, 0xb3, 0x7d, 0xfa, 0xef, 0xc5, 0x91, 0x39,
            0x72, 0xe4, 0xd3, 0xbd, 0x61, 0xc2, 0x9f, 0x25, 0x4a, 0x94, 0x33, 0x66, 0xcc, 0x83, 0x1d, 0x3a,
            0x74, 0xe8, 0xcb, 0x8d
        };


        // ham tao va sinh khoa tu dong voi khoa co the la 128, 192 hoac 256bit
        private void autoGenerateKey()
        {
            using (var ase = Aes.Create())
            {
                ase.GenerateKey();
                key = ase.Key;
            }
        }

        /* ham mo rong khoa KeyExpandsion thuc hien viec sinh khoa cho cac vong */
        // cong thuc tinh w[j]: w[j] = w[j-1] + w[j-4] if j%4!=0
        //               w[j] = trans(w[j-1]) + w[j-4] if j%4==0
        private byte[] KeyExpansion(byte[] key)
        {
            int keySize = key.Length;
            int expandedKeySize = 176; // For AES-128
            byte[] expandedKey = new byte[expandedKeySize];

            Array.Copy(key, expandedKey, keySize);

            int bytesGenerated = keySize;
            int rconIndex = 1;
            byte[] temp = new byte[4];

            while (bytesGenerated < expandedKeySize)
            {
                for (int i = 0; i < 4; i++)
                {
                    temp[i] = expandedKey[(bytesGenerated - 4) + i];
                }

                if (bytesGenerated % keySize == 0)
                {
                    temp = SubWord(RotWord(temp));
                    temp[0] ^= Rcon[rconIndex++];
                }

                for (int i = 0; i < 4; i++)
                {
                    expandedKey[bytesGenerated] = (byte)(expandedKey[bytesGenerated - keySize] ^ temp[i]);
                    bytesGenerated++;
                }
            }

            return expandedKey;
        }

        // function for RotWord
        private byte[] RotWord(byte[] word)
        {
            return new byte[] { word[1], word[2], word[3], word[0] };
        }

        // function for SubWord with S-Box
        private byte[] SubWord(byte[] word)
        {
            for (int i = 0; i < 4; i++)
            {
                word[i] = SBox[word[i]];
            }
            return word;
        }

        // function for XOR with Rcon[j/4]


        /* Cac ham su dung cho qua trinh ma hoa */
        // ham SubBytes
        private void SubBytes(byte[,] state)
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    state[i, j] = SBox[state[i, j]];
                }
            }
        }

        // ham ShiftRows
        private void ShiftRows(byte[,] state)
        {
            for(int i = 1; i < 4; i++)
            {
                byte[] tempRow = new byte[4];
                for(int j = 0; j < 4; j++)
                {
                    tempRow[j] = state[i, (j + i) % 4];
                }
                for(int j = 0; j < 4; j++)
                {
                    state[i, j] = tempRow[j];
                }
            }
        }

        // ham MixColumns
        private void MixColumns(byte[,] state)
        {
            for(int i = 0; i < 4; i++)
            {
                byte a = state[0, i];
                byte b = state[1, i];
                byte c = state[2, i];
                byte d = state[3, i];

                state[0, i] = (byte)(Gmul(a, 0x02) ^ Gmul(b, 0x03) ^ c ^ d);
                state[1, i] = (byte)(a ^ Gmul(b, 0x02) ^ Gmul(c, 0x03) ^ d);
                state[2, i] = (byte)(a ^ b ^ Gmul(c, 0x02) ^ Gmul(d, 0x03));
                state[3, i] = (byte)(Gmul(a, 0x03) ^ b ^ c ^ Gmul(d, 0x02));
            }
        }

        private byte Gmul(byte a, byte b)
        {
            byte p = 0;
            byte counter;
            byte hi_bit_set;
            for (counter = 0; counter < 8; counter++)
            {
                if ((b & 1) != 0)
                {
                    p ^= a;
                }
                hi_bit_set = (byte)(a & 0x80);
                a <<= 1;
                if (hi_bit_set != 0)
                {
                    a ^= 0x1b; // x^8 + x^4 + x^3 + x + 1
                }
                b >>= 1;
            }
            return p;
        }

        // ham AddRoundKey
        private void AddRoundKey(byte[,] state, byte[] roundKey)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[j, i] ^= roundKey[(i * 4) + j];
                }
            }
        }


        /* Cac ham su dung cho qua trinh giai ma */
        // ham InvSubBytes
        private void InvSubBytes(byte[,] state)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[i, j] = InvSBox[state[i, j]];
                }
            }
        }

        // ham InvShiftRows
        private void InvShiftRows(byte[,] state)
        {
            for (int i = 1; i < 4; i++)
            {
                byte[] tempRow = new byte[4];
                for (int j = 0; j < 4; j++)
                {
                    tempRow[j] = state[i, (j - i + 4) % 4];
                }
                for (int j = 0; j < 4; j++)
                {
                    state[i, j] = tempRow[j];
                }
            }
        }

        // ham InvMixColumns
        private void InvMixColumns(byte[,] state)
        {
            for (int i = 0; i < 4; i++)
            {
                byte a = state[0, i];
                byte b = state[1, i];
                byte c = state[2, i];
                byte d = state[3, i];

                state[0, i] = (byte)(Gmul(a, 0x0e) ^ Gmul(b, 0x0b) ^ Gmul(c, 0x0d) ^ Gmul(d, 0x09));
                state[1, i] = (byte)(Gmul(a, 0x09) ^ Gmul(b, 0x0e) ^ Gmul(c, 0x0b) ^ Gmul(d, 0x0d));
                state[2, i] = (byte)(Gmul(a, 0x0d) ^ Gmul(b, 0x09) ^ Gmul(c, 0x0e) ^ Gmul(d, 0x0b));
                state[3, i] = (byte)(Gmul(a, 0x0b) ^ Gmul(b, 0x0d) ^ Gmul(c, 0x09) ^ Gmul(d, 0x0e));
            }
        }


        /*
        // ham EncryptAES de thuc hien qua trinh ma hoa
        private byte[] EncryptAES(byte[] plaintext, byte[] key)
        {
            byte[,] state = new byte[4, 4];
            byte[] expandedKey = KeyExpansion(key);

            for (int i = 0; i < 16; i++)
            {
                state[i % 4, i / 4] = plaintext[i];
            }

            AddRoundKey(state, expandedKey);

            for (int round = 1; round <= 10; round++)
            {
                SubBytes(state);
                ShiftRows(state);
                if (round != 10)
                {
                    MixColumns(state);
                }
                AddRoundKey(state, expandedKey.Skip(round * 16).Take(16).ToArray());
            }

            byte[] encrypted = new byte[16];
            for (int i = 0; i < 16; i++)
            {
                encrypted[i] = state[i % 4, i / 4];
            }

            return encrypted;
        }

        // ham DecryptAES de thuc hien qua trinh giai ma
        private byte[] DecryptAES(byte[] ciphertext, byte[] key)
        {
            byte[,] state = new byte[4, 4];
            byte[] expandedKey = KeyExpansion(key);

            for (int i = 0; i < 16; i++)
            {
                state[i % 4, i / 4] = ciphertext[i];
            }

            AddRoundKey(state, expandedKey.Skip(10 * 16).Take(16).ToArray());

            for (int round = 9; round >= 0; round--)
            {
                InvShiftRows(state);
                InvSubBytes(state);
                AddRoundKey(state, expandedKey.Skip(round * 16).Take(16).ToArray());
                if (round != 0)
                {
                    InvMixColumns(state);
                }
            }

            byte[] decrypted = new byte[16];
            for (int i = 0; i < 16; i++)
            {
                decrypted[i] = state[i % 4, i / 4];
            }

            return decrypted;
        }
        */

        /*
        // goi toi ham EncryptAES
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // lay du lieu text tu richTextBoxFirst de ma hoa
            string plainText = richTextBoxFirst.Text;

            // thuc hien ma hoa theo giai thuat AES
            // Convert the plaintext to bytes
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText.PadRight(16, '\0').Substring(0, 16));

            // Auto-generate a key
            autoGenerateKey();

            // Encrypt the plaintext
            byte[] encryptedBytes = EncryptAES(plainBytes, key);

            // hien thi du lieu da ma hoa len richTextBoxSecond
            richTextBoxSecond.Text = BitConverter.ToString(encryptedBytes).Replace("-", "");
        }

        // goi toi ham DecryptAES
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // lay du lieu text tu richTextBoxThird de giai ma
            string cipherText = richTextBoxThird.Text;

            // thuc hien giai max theo giai thuat AES
            // Convert the ciphertext from hex string to bytes
            byte[] cipherBytes = new byte[cipherText.Length / 2];
            for (int i = 0; i < cipherBytes.Length; i++)
            {
                cipherBytes[i] = Convert.ToByte(cipherText.Substring(i * 2, 2), 16);
            }

            // Decrypt the ciphertext
            byte[] decryptedBytes = DecryptAES(cipherBytes, key);

            // hien thi du lieu da giai ma len richTextBoxFourth
            richTextBoxFourth.Text = Encoding.UTF8.GetString(decryptedBytes).TrimEnd('\0');
        }
        */


        private byte[] EncryptAES(byte[] plaintext, byte[] key)
        {
            byte[] paddedPlaintext = PadPlaintext(plaintext);
            byte[] encrypted = new byte[paddedPlaintext.Length];

            for (int block = 0; block < paddedPlaintext.Length; block += 16)
            {
                byte[] blockData = new byte[16];
                Array.Copy(paddedPlaintext, block, blockData, 0, 16);
                byte[] encryptedBlock = EncryptAESBlock(blockData, key);
                Array.Copy(encryptedBlock, 0, encrypted, block, 16);
            }

            return encrypted;
        }

        private byte[] EncryptAESBlock(byte[] plaintextBlock, byte[] key)
        {
            byte[,] state = new byte[4, 4];
            byte[] expandedKey = KeyExpansion(key);

            for (int i = 0; i < 16; i++)
            {
                state[i % 4, i / 4] = plaintextBlock[i];
            }

            AddRoundKey(state, expandedKey);

            for (int round = 1; round <= 10; round++)
            {
                SubBytes(state);
                ShiftRows(state);
                if (round != 10)
                {
                    MixColumns(state);
                }
                AddRoundKey(state, expandedKey.Skip(round * 16).Take(16).ToArray());
            }

            byte[] encryptedBlock = new byte[16];
            for (int i = 0; i < 16; i++)
            {
                encryptedBlock[i] = state[i % 4, i / 4];
            }

            return encryptedBlock;
        }

        private byte[] DecryptAES(byte[] ciphertext, byte[] key)
        {
            byte[] decrypted = new byte[ciphertext.Length];

            for (int block = 0; block < ciphertext.Length; block += 16)
            {
                byte[] blockData = new byte[16];
                Array.Copy(ciphertext, block, blockData, 0, 16);
                byte[] decryptedBlock = DecryptAESBlock(blockData, key);
                Array.Copy(decryptedBlock, 0, decrypted, block, 16);
            }

            return RemovePadding(decrypted);
        }

        private byte[] DecryptAESBlock(byte[] ciphertextBlock, byte[] key)
        {
            byte[,] state = new byte[4, 4];
            byte[] expandedKey = KeyExpansion(key);

            for (int i = 0; i < 16; i++)
            {
                state[i % 4, i / 4] = ciphertextBlock[i];
            }

            AddRoundKey(state, expandedKey.Skip(10 * 16).Take(16).ToArray());

            for (int round = 9; round >= 0; round--)
            {
                InvShiftRows(state);
                InvSubBytes(state);
                AddRoundKey(state, expandedKey.Skip(round * 16).Take(16).ToArray());
                if (round != 0)
                {
                    InvMixColumns(state);
                }
            }

            byte[] decryptedBlock = new byte[16];
            for (int i = 0; i < 16; i++)
            {
                decryptedBlock[i] = state[i % 4, i / 4];
            }

            return decryptedBlock;
        }

        private byte[] PadPlaintext(byte[] plaintext)
        {
            int paddingLength = 16 - (plaintext.Length % 16);
            byte[] paddedPlaintext = new byte[plaintext.Length + paddingLength];
            Array.Copy(plaintext, paddedPlaintext, plaintext.Length);
            for (int i = plaintext.Length; i < paddedPlaintext.Length; i++)
            {
                paddedPlaintext[i] = (byte)paddingLength;
            }
            return paddedPlaintext;
        }

        private byte[] RemovePadding(byte[] plaintext)
        {
            int paddingLength = plaintext[plaintext.Length - 1];
            byte[] unpaddedPlaintext = new byte[plaintext.Length - paddingLength];
            Array.Copy(plaintext, unpaddedPlaintext, unpaddedPlaintext.Length);
            return unpaddedPlaintext;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = richTextBoxFirst.Text;
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            autoGenerateKey();
            byte[] encryptedBytes = EncryptAES(plainBytes, key);
            richTextBoxSecond.Text = BitConverter.ToString(encryptedBytes).Replace("-", "");
            //richTextBoxThird.Text = BitConverter.ToString(encryptedBytes).Replace("-", "");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = richTextBoxThird.Text;
            byte[] cipherBytes = new byte[cipherText.Length / 2];
            for (int i = 0; i < cipherBytes.Length; i++)
            {
                cipherBytes[i] = Convert.ToByte(cipherText.Substring(i * 2, 2), 16);
            }
            byte[] decryptedBytes = DecryptAES(cipherBytes, key);
            richTextBoxFourth.Text = Encoding.UTF8.GetString(decryptedBytes);
        }
    }
}
