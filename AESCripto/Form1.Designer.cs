namespace AESCripto
{
    partial class aescripto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aescripto));
            this.btnAes = new System.Windows.Forms.Button();
            this.btnUnAes = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkFolderList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkRemove = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.procLoading = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAes
            // 
            this.btnAes.Location = new System.Drawing.Point(113, 482);
            this.btnAes.Name = "btnAes";
            this.btnAes.Size = new System.Drawing.Size(110, 23);
            this.btnAes.TabIndex = 0;
            this.btnAes.Text = "AES ME!";
            this.btnAes.UseVisualStyleBackColor = true;
            this.btnAes.Click += new System.EventHandler(this.btnAes_Click);
            // 
            // btnUnAes
            // 
            this.btnUnAes.Location = new System.Drawing.Point(10, 482);
            this.btnUnAes.Name = "btnUnAes";
            this.btnUnAes.Size = new System.Drawing.Size(97, 23);
            this.btnUnAes.TabIndex = 1;
            this.btnUnAes.Text = "UN AES ME!";
            this.btnUnAes.UseVisualStyleBackColor = true;
            this.btnUnAes.Click += new System.EventHandler(this.btnUnAes_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(10, 125);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(213, 23);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Choose file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(78, 456);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(145, 20);
            this.txtPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(10, 154);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(213, 23);
            this.btnChooseFolder.TabIndex = 7;
            this.btnChooseFolder.Text = "Choose folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(148, 424);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkFolderList
            // 
            this.chkFolderList.FormattingEnabled = true;
            this.chkFolderList.Location = new System.Drawing.Point(10, 189);
            this.chkFolderList.Name = "chkFolderList";
            this.chkFolderList.Size = new System.Drawing.Size(213, 229);
            this.chkFolderList.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(24, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "People Always Make the Best Exploits";
            // 
            // checkRemove
            // 
            this.checkRemove.AutoSize = true;
            this.checkRemove.Location = new System.Drawing.Point(10, 424);
            this.checkRemove.Name = "checkRemove";
            this.checkRemove.Size = new System.Drawing.Size(123, 17);
            this.checkRemove.TabIndex = 11;
            this.checkRemove.Text = "Remove Original File";
            this.checkRemove.UseVisualStyleBackColor = true;
            this.checkRemove.CheckedChanged += new System.EventHandler(this.checkRemove_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AESCripto.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 107);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // procLoading
            // 
            this.procLoading.Location = new System.Drawing.Point(10, 518);
            this.procLoading.Name = "procLoading";
            this.procLoading.Size = new System.Drawing.Size(210, 23);
            this.procLoading.TabIndex = 13;
            // 
            // aescripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 569);
            this.Controls.Add(this.procLoading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkFolderList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnUnAes);
            this.Controls.Add(this.btnAes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "aescripto";
            this.Text = "AES-Encrypt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAes;
        private System.Windows.Forms.Button btnUnAes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckedListBox chkFolderList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkRemove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar procLoading;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

