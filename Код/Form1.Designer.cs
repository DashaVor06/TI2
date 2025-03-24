namespace Laba2_LFSR
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbInitialState = new System.Windows.Forms.TextBox();
            this.lbInitialState = new System.Windows.Forms.Label();
            this.btnInitialState = new System.Windows.Forms.Button();
            this.lbKey = new System.Windows.Forms.Label();
            this.txtbInputText = new System.Windows.Forms.TextBox();
            this.txtbKey = new System.Windows.Forms.TextBox();
            this.txtbOutputText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbOutput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtbInitialState
            // 
            this.txtbInitialState.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbInitialState.Location = new System.Drawing.Point(19, 107);
            this.txtbInitialState.Margin = new System.Windows.Forms.Padding(6);
            this.txtbInitialState.Name = "txtbInitialState";
            this.txtbInitialState.Size = new System.Drawing.Size(481, 29);
            this.txtbInitialState.TabIndex = 0;
            this.txtbInitialState.TextChanged += new System.EventHandler(this.txtbInitialState_TextChanged);
            // 
            // lbInitialState
            // 
            this.lbInitialState.AutoSize = true;
            this.lbInitialState.Location = new System.Drawing.Point(19, 77);
            this.lbInitialState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbInitialState.Name = "lbInitialState";
            this.lbInitialState.Size = new System.Drawing.Size(519, 24);
            this.lbInitialState.TabIndex = 1;
            this.lbInitialState.Text = "Введите начальное состояние регистра (0/35 разрядов)";
            // 
            // btnInitialState
            // 
            this.btnInitialState.BackColor = System.Drawing.Color.Bisque;
            this.btnInitialState.Location = new System.Drawing.Point(509, 107);
            this.btnInitialState.Name = "btnInitialState";
            this.btnInitialState.Size = new System.Drawing.Size(99, 29);
            this.btnInitialState.TabIndex = 1;
            this.btnInitialState.Text = "OK";
            this.btnInitialState.UseVisualStyleBackColor = false;
            this.btnInitialState.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(19, 142);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(56, 24);
            this.lbKey.TabIndex = 2;
            this.lbKey.Text = "Ключ";
            // 
            // txtbInputText
            // 
            this.txtbInputText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbInputText.Location = new System.Drawing.Point(19, 324);
            this.txtbInputText.Multiline = true;
            this.txtbInputText.Name = "txtbInputText";
            this.txtbInputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbInputText.Size = new System.Drawing.Size(589, 125);
            this.txtbInputText.TabIndex = 3;
            // 
            // txtbKey
            // 
            this.txtbKey.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbKey.Location = new System.Drawing.Point(19, 169);
            this.txtbKey.Multiline = true;
            this.txtbKey.Name = "txtbKey";
            this.txtbKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbKey.Size = new System.Drawing.Size(589, 125);
            this.txtbKey.TabIndex = 4;
            // 
            // txtbOutputText
            // 
            this.txtbOutputText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbOutputText.Location = new System.Drawing.Point(19, 483);
            this.txtbOutputText.Multiline = true;
            this.txtbOutputText.Name = "txtbOutputText";
            this.txtbOutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbOutputText.Size = new System.Drawing.Size(589, 125);
            this.txtbOutputText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Исходый текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Шифро текст";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Location = new System.Drawing.Point(205, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtbInput
            // 
            this.txtbInput.Enabled = false;
            this.txtbInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbInput.Location = new System.Drawing.Point(19, 35);
            this.txtbInput.Name = "txtbInput";
            this.txtbInput.Size = new System.Drawing.Size(180, 29);
            this.txtbInput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Исходный файл";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Зашифрованный файл";
            // 
            // txtbOutput
            // 
            this.txtbOutput.Enabled = false;
            this.txtbOutput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbOutput.Location = new System.Drawing.Point(320, 35);
            this.txtbOutput.Name = "txtbOutput";
            this.txtbOutput.Size = new System.Drawing.Size(180, 29);
            this.txtbOutput.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Location = new System.Drawing.Point(506, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Выбрать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.InitialDirectory = ".";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(626, 621);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbOutputText);
            this.Controls.Add(this.txtbKey);
            this.Controls.Add(this.txtbInputText);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.btnInitialState);
            this.Controls.Add(this.lbInitialState);
            this.Controls.Add(this.txtbInitialState);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потоковое шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbInitialState;
        private System.Windows.Forms.Label lbInitialState;
        private System.Windows.Forms.Button btnInitialState;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.TextBox txtbInputText;
        private System.Windows.Forms.TextBox txtbKey;
        private System.Windows.Forms.TextBox txtbOutputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

