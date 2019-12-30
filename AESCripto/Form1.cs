using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace AESCripto
{
    public partial class aescripto : Form
    {
        private static void AES_Encrypt(string inputFile, string outputFile, byte[] passwordBytes)
        {
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            string cryptFile = outputFile;
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged AES = new RijndaelManaged();

            AES.KeySize = 256;
            AES.BlockSize = 128;


            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.Zeros;

            AES.Mode = CipherMode.CBC;

            CryptoStream cs = new CryptoStream(fsCrypt,
                 AES.CreateEncryptor(),
                CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            int data;
            while ((data = fsIn.ReadByte()) != -1)
                cs.WriteByte((byte)data);


            fsIn.Close();
            cs.Close();
            fsCrypt.Close();

        }

        private static void AES_Decrypt(string inputFile, string outputFile, byte[] passwordBytes)
        {



            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

            RijndaelManaged AES = new RijndaelManaged();

            AES.KeySize = 256;
            AES.BlockSize = 128;


            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.Zeros;

            AES.Mode = CipherMode.CBC;

            CryptoStream cs = new CryptoStream(fsCrypt,
                AES.CreateDecryptor(),
                CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int data;
            while ((data = cs.ReadByte()) != -1)
                fsOut.WriteByte((byte)data);

            fsOut.Close();
            cs.Close();
            fsCrypt.Close();

        }

        public aescripto()
        {
            InitializeComponent();
        }

        private void btnAes_Click(object sender, EventArgs e)
        {
            procLoading.Value = 0;
            if (chkFolderList.Items.Count > 0 && txtPass.Text != "")
            {
                for (int i = 0; i < chkFolderList.Items.Count; i++)
                {
                    string str = (string)chkFolderList.Items[i];
                    string srcFile = (string)chkFolderList.Items[i];
                    string encryptedFile = (string)chkFolderList.Items[i] + ".encrypt";
                    byte[] aespass = Encoding.ASCII.GetBytes(txtPass.Text);

                    try
                    {
                        AES_Encrypt(srcFile, encryptedFile, aespass);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("IO Exception Error", "No Permission");
                    }

                    if (checkRemove.Checked == true)
                    {
                        File.Delete(srcFile);
                    }
                    chkFolderList.Items[i] = encryptedFile;
                    //procLoading.Value += procentage;

                    if (chkFolderList.Items.Count / 10 == i)
                    {
                        procLoading.Value = 10;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 2 == i)
                    {
                        procLoading.Value = 20;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 3 == i)
                    {
                        procLoading.Value = 30;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 4 == i)
                    {
                        procLoading.Value = 40;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 5 == i)
                    {
                        procLoading.Value = 50;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 6 == i)
                    {
                        procLoading.Value = 60;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 7 == i)
                    {
                        procLoading.Value = 70;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 8 == i)
                    {
                        procLoading.Value = 80;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 9 == i)
                    {
                        procLoading.Value = 90;
                    }
                    procLoading.Value = 100;
                }
            }
            else
            {
                MessageBox.Show("File not found or password not informed");
            }
            checkRemove.Checked = false;
        }

        private void btnUnAes_Click(object sender, EventArgs e)
        {
            procLoading.Value = 0;
            if (chkFolderList.Items.Count > 0 && txtPass.Text != "")
            {
                for (int i = 0; i < chkFolderList.Items.Count; i++)
                {
                    byte[] aespass = Encoding.ASCII.GetBytes(txtPass.Text);
                    string encryptedFile = (string)chkFolderList.Items[i];
                    string decryptedFile = encryptedFile.Replace(".encrypt", "");
                    AES_Decrypt(encryptedFile, decryptedFile, aespass);

                    if (checkRemove.Checked == true)
                    {
                        File.Delete(encryptedFile);
                    }
                    if (chkFolderList.Items.Count / 10 == i)
                    {
                        procLoading.Value = 10;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 2 == i)
                    {
                        procLoading.Value = 20;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 3 == i)
                    {
                        procLoading.Value = 30;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 4 == i)
                    {
                        procLoading.Value = 40;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 5 == i)
                    {
                        procLoading.Value = 50;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 6 == i)
                    {
                        procLoading.Value = 60;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 7 == i)
                    {
                        procLoading.Value = 70;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 8 == i)
                    {
                        procLoading.Value = 80;
                    }
                    else if ((chkFolderList.Items.Count / 10) * 9 == i)
                    {
                        procLoading.Value = 90;
                    }
                    procLoading.Value = 100;
                }
            }
            else
            {
                MessageBox.Show("File not found or password not informed");
            }
            chkFolderList.Items.Clear();
        }

        static void ApplyAllFiles(string folders, Action<string> fileAction)
        {
            List<string> permissoes = new List<string>();
            FolderBrowserDialog folder = new FolderBrowserDialog();
            foreach (string file in Directory.GetFiles(folders))
            {
                fileAction(file);

            }
            foreach (string subDir in Directory.GetDirectories(folders))
            {
                try
                {
                    ApplyAllFiles(subDir, fileAction);
                }
                catch (UnauthorizedAccessException)
                {

                }
            }


        }
        private void ProcessFile(string path)
        {
            chkFolderList.Items.Add(path, true);
            CheckedListBox novo = new CheckedListBox();
            novo.Items.Add(path, true);

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        bool validacao = false;
        private void btnChooseFile_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Choose file to be encrypted";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Any file|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (chkFolderList.Items.Count > 0)
                {
                    for (int i = 0; i < chkFolderList.Items.Count; i++)
                    {
                        if ((string)chkFolderList.Items[i] == openFileDialog1.FileName)
                        {
                            validacao = true;
                            break;
                        }
                        else
                        {
                            validacao = false;
                        }
                    }
                    if (validacao == false)
                    {
                        chkFolderList.Items.Add(openFileDialog1.FileName, true);
                        validacao = true;
                    }
                }
                if (validacao == false)
                {
                    chkFolderList.Items.Add(openFileDialog1.FileName, true);
                    validacao = true;
                }
            }
            else
            {
                MessageBox.Show("Operation canceled");
            }

        }
        FolderBrowserDialog folder = new FolderBrowserDialog();
        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            //DialogResult result = folder.ShowDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                ApplyAllFiles(folderBrowserDialog1.SelectedPath, ProcessFile);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            chkFolderList.Items.Clear();
            btnChooseFolder.Visible = true;
            validacao = false;
            checkRemove.Checked = false;
            procLoading.Value = 0;
            txtPass.Text = "";
        }

        private void checkRemove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRemove.Checked == true)
            {

                MessageBox.Show("With big power comes big responsibility... \r\nIf you forgot your password your files will be gone forever!!!", "BE CAREFUL!!!");
            }
        }

    }
}
