namespace WhatsAppMaster
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelMainPage = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFile = new System.Windows.Forms.Panel();
            this.labelFileMB = new System.Windows.Forms.Label();
            this.buttonFileReset = new System.Windows.Forms.Button();
            this.buttonAddName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFilePicker = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textboxMessage = new System.Windows.Forms.TextBox();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.panelReport = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUnSent = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.labelProgress = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.labelNameLength = new System.Windows.Forms.Label();
            this.labelNumberLength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNames = new System.Windows.Forms.TextBox();
            this.textBoxNumbers = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabMainPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.labelDaysLeft = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabWhatsApp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabContact = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabMessageScheme = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tabReports = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelMainPage.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.panelReport.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panelMessages.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBarStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.progressBarStatus.Location = new System.Drawing.Point(37, 661);
            this.progressBarStatus.Margin = new System.Windows.Forms.Padding(0);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(650, 40);
            this.progressBarStatus.Step = 1;
            this.progressBarStatus.TabIndex = 6;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.labelStatus.Location = new System.Drawing.Point(371, 25);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(500, 20);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "Waiting for WhatsApp link";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.textBoxFileName.Location = new System.Drawing.Point(13, 35);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(651, 26);
            this.textBoxFileName.TabIndex = 18;
            this.textBoxFileName.TabStop = false;
            this.textBoxFileName.WordWrap = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Title = "Dosya Seçiniz";
            // 
            // panelMainPage
            // 
            this.panelMainPage.Controls.Add(this.label6);
            this.panelMainPage.Location = new System.Drawing.Point(23, 163);
            this.panelMainPage.Name = "panelMainPage";
            this.panelMainPage.Size = new System.Drawing.Size(667, 50);
            this.panelMainPage.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(492, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Welcome. You can start sending by linking WhatsApp first";
            // 
            // panelFile
            // 
            this.panelFile.Controls.Add(this.labelFileMB);
            this.panelFile.Controls.Add(this.buttonFileReset);
            this.panelFile.Controls.Add(this.buttonAddName);
            this.panelFile.Controls.Add(this.label2);
            this.panelFile.Controls.Add(this.buttonFilePicker);
            this.panelFile.Controls.Add(this.label10);
            this.panelFile.Controls.Add(this.textboxMessage);
            this.panelFile.Controls.Add(this.textBoxFileName);
            this.panelFile.Location = new System.Drawing.Point(23, 163);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(667, 476);
            this.panelFile.TabIndex = 26;
            this.panelFile.Visible = false;
            // 
            // labelFileMB
            // 
            this.labelFileMB.BackColor = System.Drawing.Color.Transparent;
            this.labelFileMB.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFileMB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.labelFileMB.Location = new System.Drawing.Point(544, 64);
            this.labelFileMB.Name = "labelFileMB";
            this.labelFileMB.Size = new System.Drawing.Size(120, 21);
            this.labelFileMB.TabIndex = 37;
            this.labelFileMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonFileReset
            // 
            this.buttonFileReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonFileReset.FlatAppearance.BorderSize = 0;
            this.buttonFileReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonFileReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonFileReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileReset.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFileReset.ForeColor = System.Drawing.Color.White;
            this.buttonFileReset.Location = new System.Drawing.Point(115, 69);
            this.buttonFileReset.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFileReset.Name = "buttonFileReset";
            this.buttonFileReset.Size = new System.Drawing.Size(117, 29);
            this.buttonFileReset.TabIndex = 36;
            this.buttonFileReset.TabStop = false;
            this.buttonFileReset.Text = "Remove File path";
            this.buttonFileReset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFileReset.UseVisualStyleBackColor = false;
            this.buttonFileReset.Click += new System.EventHandler(this.buttonFileReset_Click);
            // 
            // buttonAddName
            // 
            this.buttonAddName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonAddName.FlatAppearance.BorderSize = 0;
            this.buttonAddName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonAddName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonAddName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddName.ForeColor = System.Drawing.Color.White;
            this.buttonAddName.Location = new System.Drawing.Point(564, 94);
            this.buttonAddName.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddName.Name = "buttonAddName";
            this.buttonAddName.Size = new System.Drawing.Size(91, 29);
            this.buttonAddName.TabIndex = 35;
            this.buttonAddName.TabStop = false;
            this.buttonAddName.Text = "{Name}";
            this.buttonAddName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddName.UseVisualStyleBackColor = false;
            this.buttonAddName.Click += new System.EventHandler(this.buttonAddName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Message:";
            // 
            // buttonFilePicker
            // 
            this.buttonFilePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonFilePicker.FlatAppearance.BorderSize = 0;
            this.buttonFilePicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonFilePicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonFilePicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilePicker.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFilePicker.ForeColor = System.Drawing.Color.White;
            this.buttonFilePicker.Location = new System.Drawing.Point(12, 69);
            this.buttonFilePicker.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFilePicker.Name = "buttonFilePicker";
            this.buttonFilePicker.Size = new System.Drawing.Size(91, 29);
            this.buttonFilePicker.TabIndex = 33;
            this.buttonFilePicker.TabStop = false;
            this.buttonFilePicker.Text = "Pick a File";
            this.buttonFilePicker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFilePicker.UseVisualStyleBackColor = false;
            this.buttonFilePicker.Click += new System.EventHandler(this.buttonFilePicker_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.label10.Location = new System.Drawing.Point(6, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "File Path:";
            // 
            // textboxMessage
            // 
            this.textboxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxMessage.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F);
            this.textboxMessage.Location = new System.Drawing.Point(5, 136);
            this.textboxMessage.Multiline = true;
            this.textboxMessage.Name = "textboxMessage";
            this.textboxMessage.Size = new System.Drawing.Size(652, 337);
            this.textboxMessage.TabIndex = 12;
            this.textboxMessage.TabStop = false;
            this.textboxMessage.Text = "Hi {Name}";
            this.textboxMessage.WordWrap = false;
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.AutoSize = true;
            this.labelPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelPageTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.labelPageTitle.Location = new System.Drawing.Point(17, 117);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(73, 34);
            this.labelPageTitle.TabIndex = 30;
            this.labelPageTitle.Text = "Home";
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.label1);
            this.panelReport.Controls.Add(this.textBoxUnSent);
            this.panelReport.Location = new System.Drawing.Point(23, 163);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(239, 476);
            this.panelReport.TabIndex = 26;
            this.panelReport.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Failed Messages:";
            // 
            // textBoxUnSent
            // 
            this.textBoxUnSent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnSent.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxUnSent.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F);
            this.textBoxUnSent.Location = new System.Drawing.Point(12, 34);
            this.textBoxUnSent.Multiline = true;
            this.textBoxUnSent.Name = "textBoxUnSent";
            this.textBoxUnSent.ReadOnly = true;
            this.textBoxUnSent.Size = new System.Drawing.Size(220, 436);
            this.textBoxUnSent.TabIndex = 2;
            this.textBoxUnSent.WordWrap = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel14.Controls.Add(this.labelProgress);
            this.panel14.Controls.Add(this.panel7);
            this.panel14.Controls.Add(this.buttonSend);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.progressBarStatus);
            this.panel14.Controls.Add(this.labelPageTitle);
            this.panel14.Controls.Add(this.panelReport);
            this.panel14.Controls.Add(this.panelMessages);
            this.panel14.Controls.Add(this.panelMainPage);
            this.panel14.Controls.Add(this.panelFile);
            this.panel14.Location = new System.Drawing.Point(300, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(902, 715);
            this.panel14.TabIndex = 34;
            this.panel14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel14_MouseDown);
            this.panel14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel14_MouseMove);
            this.panel14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel14_MouseUp);
            // 
            // labelProgress
            // 
            this.labelProgress.BackColor = System.Drawing.Color.Transparent;
            this.labelProgress.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.labelProgress.Location = new System.Drawing.Point(37, 642);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(75, 19);
            this.labelProgress.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Location = new System.Drawing.Point(817, 672);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(21, 19);
            this.panel7.TabIndex = 31;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(89)))));
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F);
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(709, 661);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(150, 40);
            this.buttonSend.TabIndex = 32;
            this.buttonSend.TabStop = false;
            this.buttonSend.Text = "Send";
            this.buttonSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(900, 67);
            this.panel15.TabIndex = 0;
            // 
            // panelMessages
            // 
            this.panelMessages.Controls.Add(this.labelNameLength);
            this.panelMessages.Controls.Add(this.labelNumberLength);
            this.panelMessages.Controls.Add(this.label4);
            this.panelMessages.Controls.Add(this.label3);
            this.panelMessages.Controls.Add(this.textBoxNames);
            this.panelMessages.Controls.Add(this.textBoxNumbers);
            this.panelMessages.Location = new System.Drawing.Point(23, 163);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(579, 476);
            this.panelMessages.TabIndex = 25;
            this.panelMessages.Visible = false;
            // 
            // labelNameLength
            // 
            this.labelNameLength.BackColor = System.Drawing.Color.Transparent;
            this.labelNameLength.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNameLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.labelNameLength.Location = new System.Drawing.Point(463, 9);
            this.labelNameLength.Name = "labelNameLength";
            this.labelNameLength.Size = new System.Drawing.Size(101, 21);
            this.labelNameLength.TabIndex = 14;
            this.labelNameLength.Text = "1";
            this.labelNameLength.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelNumberLength
            // 
            this.labelNumberLength.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberLength.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNumberLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.labelNumberLength.Location = new System.Drawing.Point(178, 9);
            this.labelNumberLength.Name = "labelNumberLength";
            this.labelNumberLength.Size = new System.Drawing.Size(101, 21);
            this.labelNumberLength.TabIndex = 13;
            this.labelNumberLength.Text = "1";
            this.labelNumberLength.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(298, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Add Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Add Number";
            // 
            // textBoxNames
            // 
            this.textBoxNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNames.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxNames.Location = new System.Drawing.Point(302, 36);
            this.textBoxNames.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNames.Multiline = true;
            this.textBoxNames.Name = "textBoxNames";
            this.textBoxNames.Size = new System.Drawing.Size(262, 436);
            this.textBoxNames.TabIndex = 10;
            this.textBoxNames.Text = "Eşref";
            this.textBoxNames.WordWrap = false;
            this.textBoxNames.TextChanged += new System.EventHandler(this.textBoxNames_TextChanged);
            // 
            // textBoxNumbers
            // 
            this.textBoxNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumbers.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxNumbers.Location = new System.Drawing.Point(17, 34);
            this.textBoxNumbers.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNumbers.Multiline = true;
            this.textBoxNumbers.Name = "textBoxNumbers";
            this.textBoxNumbers.Size = new System.Drawing.Size(262, 436);
            this.textBoxNumbers.TabIndex = 2;
            this.textBoxNumbers.Text = "5555555555";
            this.textBoxNumbers.WordWrap = false;
            this.textBoxNumbers.TextChanged += new System.EventHandler(this.textBoxNumbers_TextChanged);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_status;
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel13.Location = new System.Drawing.Point(340, 23);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(25, 25);
            this.panel13.TabIndex = 25;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_button_minimize;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(1117, 28);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(15, 15);
            this.buttonMinimize.TabIndex = 31;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_button_close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(1144, 28);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(15, 15);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabMainPage
            // 
            this.tabMainPage.BackColor = System.Drawing.Color.Transparent;
            this.tabMainPage.FlatAppearance.BorderSize = 0;
            this.tabMainPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tabMainPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tabMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabMainPage.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabMainPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabMainPage.Location = new System.Drawing.Point(92, 322);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.Size = new System.Drawing.Size(172, 31);
            this.tabMainPage.TabIndex = 22;
            this.tabMainPage.TabStop = false;
            this.tabMainPage.Text = "Home";
            this.tabMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabMainPage.UseVisualStyleBackColor = false;
            this.tabMainPage.Click += new System.EventHandler(this.tabMainPage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_tab_mainmenu;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(56, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 30);
            this.panel2.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_profile;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Location = new System.Drawing.Point(92, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(85, 108);
            this.panel6.TabIndex = 32;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_person;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(25, 39);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(36, 36);
            this.panel11.TabIndex = 34;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel12.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_dot;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(67, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(15, 15);
            this.panel12.TabIndex = 33;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_dot;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Location = new System.Drawing.Point(67, 75);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(15, 15);
            this.panel10.TabIndex = 33;
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoEllipsis = true;
            this.labelProfileName.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProfileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.labelProfileName.Location = new System.Drawing.Point(69, 198);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(130, 20);
            this.labelProfileName.TabIndex = 33;
            this.labelProfileName.Text = "Name Surname";
            this.labelProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDaysLeft
            // 
            this.labelDaysLeft.AutoEllipsis = true;
            this.labelDaysLeft.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDaysLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelDaysLeft.Location = new System.Drawing.Point(82, 218);
            this.labelDaysLeft.Name = "labelDaysLeft";
            this.labelDaysLeft.Size = new System.Drawing.Size(107, 20);
            this.labelDaysLeft.TabIndex = 34;
            this.labelDaysLeft.Text = "45 Days Left";
            this.labelDaysLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_logo;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel9.Location = new System.Drawing.Point(44, 18);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(133, 33);
            this.panel9.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_button_menu;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(250, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 16);
            this.button1.TabIndex = 39;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabWhatsApp
            // 
            this.tabWhatsApp.BackColor = System.Drawing.Color.Transparent;
            this.tabWhatsApp.FlatAppearance.BorderSize = 0;
            this.tabWhatsApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tabWhatsApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tabWhatsApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabWhatsApp.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabWhatsApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabWhatsApp.Location = new System.Drawing.Point(91, 374);
            this.tabWhatsApp.Name = "tabWhatsApp";
            this.tabWhatsApp.Size = new System.Drawing.Size(172, 31);
            this.tabWhatsApp.TabIndex = 40;
            this.tabWhatsApp.TabStop = false;
            this.tabWhatsApp.Text = "WhatsApp";
            this.tabWhatsApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabWhatsApp.UseVisualStyleBackColor = false;
            this.tabWhatsApp.Click += new System.EventHandler(this.tabWhatsApp_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_tab_qr;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(56, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 30);
            this.panel3.TabIndex = 41;
            // 
            // tabContact
            // 
            this.tabContact.BackColor = System.Drawing.Color.Transparent;
            this.tabContact.FlatAppearance.BorderSize = 0;
            this.tabContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tabContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tabContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabContact.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabContact.Location = new System.Drawing.Point(91, 421);
            this.tabContact.Name = "tabContact";
            this.tabContact.Size = new System.Drawing.Size(172, 31);
            this.tabContact.TabIndex = 42;
            this.tabContact.TabStop = false;
            this.tabContact.Text = "Add Contact";
            this.tabContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabContact.UseVisualStyleBackColor = false;
            this.tabContact.Click += new System.EventHandler(this.tabContact_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_tab_contact;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(56, 421);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 30);
            this.panel5.TabIndex = 43;
            // 
            // tabMessageScheme
            // 
            this.tabMessageScheme.BackColor = System.Drawing.Color.Transparent;
            this.tabMessageScheme.FlatAppearance.BorderSize = 0;
            this.tabMessageScheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tabMessageScheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tabMessageScheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabMessageScheme.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabMessageScheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabMessageScheme.Location = new System.Drawing.Point(91, 467);
            this.tabMessageScheme.Name = "tabMessageScheme";
            this.tabMessageScheme.Size = new System.Drawing.Size(172, 31);
            this.tabMessageScheme.TabIndex = 44;
            this.tabMessageScheme.TabStop = false;
            this.tabMessageScheme.Text = "Add Message";
            this.tabMessageScheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabMessageScheme.UseVisualStyleBackColor = false;
            this.tabMessageScheme.Click += new System.EventHandler(this.tabMessageScheme_Click_1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_tab_scheme;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(56, 467);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(30, 30);
            this.panel8.TabIndex = 45;
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.Color.Transparent;
            this.tabReports.FlatAppearance.BorderSize = 0;
            this.tabReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tabReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tabReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabReports.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabReports.Location = new System.Drawing.Point(91, 519);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(172, 31);
            this.tabReports.TabIndex = 46;
            this.tabReports.TabStop = false;
            this.tabReports.Text = "Reports";
            this.tabReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabReports.UseVisualStyleBackColor = false;
            this.tabReports.Click += new System.EventHandler(this.tabReports_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::WhatsAppMaster.Properties.Resources.new_icon_tab_file;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(56, 520);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 30);
            this.panel4.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.tabReports);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.tabMessageScheme);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.tabContact);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tabWhatsApp);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.labelDaysLeft);
            this.panel1.Controls.Add(this.labelProfileName);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tabMainPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 715);
            this.panel1.TabIndex = 20;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelVersion.Location = new System.Drawing.Point(3, 693);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(69, 13);
            this.labelVersion.TabIndex = 35;
            this.labelVersion.Text = "Version 1.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 715);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatsApp Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelMainPage.ResumeLayout(false);
            this.panelMainPage.PerformLayout();
            this.panelFile.ResumeLayout(false);
            this.panelFile.PerformLayout();
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panelMessages.ResumeLayout(false);
            this.panelMessages.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelMainPage;
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelFile;
        private System.Windows.Forms.TextBox textboxMessage;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUnSent;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.TextBox textBoxNames;
        private System.Windows.Forms.TextBox textBoxNumbers;
        private System.Windows.Forms.Button buttonFilePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tabMainPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.Label labelDaysLeft;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tabWhatsApp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button tabContact;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button tabMessageScheme;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button tabReports;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddName;
        private System.Windows.Forms.Button buttonFileReset;
        private System.Windows.Forms.Label labelFileMB;
        private System.Windows.Forms.Label labelNameLength;
        private System.Windows.Forms.Label labelNumberLength;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelVersion;
    }
}

