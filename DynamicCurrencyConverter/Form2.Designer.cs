using System.Drawing;

namespace DynamicCurrencyConverter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.amount = new MetroFramework.Controls.MetroTextBox();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.Finalvalue = new System.Windows.Forms.Button();
            this.DestinationCombo = new System.Windows.Forms.ComboBox();
            this.SourceCombo = new System.Windows.Forms.ComboBox();
            this.mainframetext = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.FinalAmount = new System.Windows.Forms.TextBox();
            this.MostPrefferedCheckList = new System.Windows.Forms.CheckedListBox();
            this.MostPrefferedList = new System.Windows.Forms.Button();
            this.PrefferedListOkayButton = new System.Windows.Forms.Button();
            this.PrefferedListCancelButton = new System.Windows.Forms.Button();
            this.MostPrefferedClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // amount
            // 
            this.amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amount.BackColor = System.Drawing.Color.Beige;
            // 
            // 
            // 
            this.amount.CustomButton.Image = null;
            this.amount.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.amount.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.amount.CustomButton.Name = "";
            this.amount.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amount.CustomButton.TabIndex = 1;
            this.amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amount.CustomButton.UseSelectable = true;
            this.amount.CustomButton.Visible = false;
            this.amount.Lines = new string[0];
            this.amount.Location = new System.Drawing.Point(251, 170);
            this.amount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.amount.MaxLength = 32767;
            this.amount.Name = "amount";
            this.amount.PasswordChar = '\0';
            this.amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amount.SelectedText = "";
            this.amount.SelectionLength = 0;
            this.amount.SelectionStart = 0;
            this.amount.ShortcutsEnabled = true;
            this.amount.Size = new System.Drawing.Size(172, 29);
            this.amount.TabIndex = 6;
            this.amount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.amount.UseCustomForeColor = true;
            this.amount.UseSelectable = true;
            this.amount.UseStyleColors = true;
            this.amount.WaterMarkColor = System.Drawing.Color.White;
            this.amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SourceLabel
            // 
            this.SourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceLabel.BackColor = System.Drawing.Color.Black;
            this.SourceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SourceLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceLabel.ForeColor = System.Drawing.Color.White;
            this.SourceLabel.Location = new System.Drawing.Point(41, 88);
            this.SourceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SourceLabel.Size = new System.Drawing.Size(213, 29);
            this.SourceLabel.TabIndex = 12;
            this.SourceLabel.Text = "Choose Source Currency";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DestinationLabel.BackColor = System.Drawing.Color.Black;
            this.DestinationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DestinationLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.ForeColor = System.Drawing.Color.White;
            this.DestinationLabel.Location = new System.Drawing.Point(41, 130);
            this.DestinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DestinationLabel.Size = new System.Drawing.Size(213, 29);
            this.DestinationLabel.TabIndex = 13;
            this.DestinationLabel.Text = "Choose Destination Currency";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.Black;
            this.AmountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AmountLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.ForeColor = System.Drawing.Color.White;
            this.AmountLabel.Location = new System.Drawing.Point(41, 170);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AmountLabel.Size = new System.Drawing.Size(196, 26);
            this.AmountLabel.TabIndex = 14;
            this.AmountLabel.Text = "Enter the Amount";
            // 
            // Finalvalue
            // 
            this.Finalvalue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Finalvalue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Finalvalue.BackColor = System.Drawing.Color.Black;
            this.Finalvalue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Finalvalue.BackgroundImage")));
            this.Finalvalue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Finalvalue.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finalvalue.ForeColor = System.Drawing.Color.Tomato;
            this.Finalvalue.Location = new System.Drawing.Point(46, 220);
            this.Finalvalue.Margin = new System.Windows.Forms.Padding(1);
            this.Finalvalue.Name = "Finalvalue";
            this.Finalvalue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Finalvalue.Size = new System.Drawing.Size(111, 29);
            this.Finalvalue.TabIndex = 15;
            this.Finalvalue.Text = "Convert";
            this.Finalvalue.UseVisualStyleBackColor = false;
            this.Finalvalue.Click += new System.EventHandler(this.Finalvalue_Click);
            // 
            // DestinationCombo
            // 
            this.DestinationCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationCombo.BackColor = System.Drawing.SystemColors.MenuText;
            this.DestinationCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DestinationCombo.ForeColor = System.Drawing.Color.DarkKhaki;
            this.DestinationCombo.FormattingEnabled = true;
            this.DestinationCombo.Location = new System.Drawing.Point(251, 130);
            this.DestinationCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DestinationCombo.Name = "DestinationCombo";
            this.DestinationCombo.Size = new System.Drawing.Size(172, 24);
            this.DestinationCombo.TabIndex = 17;
            // 
            // SourceCombo
            // 
            this.SourceCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceCombo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SourceCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SourceCombo.ForeColor = System.Drawing.Color.DarkKhaki;
            this.SourceCombo.FormattingEnabled = true;
            this.SourceCombo.Location = new System.Drawing.Point(251, 88);
            this.SourceCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SourceCombo.Name = "SourceCombo";
            this.SourceCombo.Size = new System.Drawing.Size(172, 24);
            this.SourceCombo.TabIndex = 18;
            // 
            // mainframetext
            // 
            this.mainframetext.BackColor = System.Drawing.Color.DarkGray;
            this.mainframetext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainframetext.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainframetext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mainframetext.Location = new System.Drawing.Point(26, 29);
            this.mainframetext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainframetext.Name = "mainframetext";
            this.mainframetext.Size = new System.Drawing.Size(685, 30);
            this.mainframetext.TabIndex = 19;
            this.mainframetext.Text = "X-perience Currency on the Go..........";
            this.mainframetext.UseCompatibleTextRendering = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDark;
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(470, 6);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(594, 6);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // FinalAmount
            // 
            this.FinalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FinalAmount.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.FinalAmount.Location = new System.Drawing.Point(251, 227);
            this.FinalAmount.Name = "FinalAmount";
            this.FinalAmount.Size = new System.Drawing.Size(172, 22);
            this.FinalAmount.TabIndex = 22;
            this.FinalAmount.Text = "Result.....";
            // 
            // MostPrefferedCheckList
            // 
            this.MostPrefferedCheckList.BackColor = System.Drawing.SystemColors.Desktop;
            this.MostPrefferedCheckList.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostPrefferedCheckList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MostPrefferedCheckList.FormattingEnabled = true;
            this.MostPrefferedCheckList.Location = new System.Drawing.Point(513, 88);
            this.MostPrefferedCheckList.Name = "MostPrefferedCheckList";
            this.MostPrefferedCheckList.Size = new System.Drawing.Size(163, 89);
            this.MostPrefferedCheckList.TabIndex = 23;
            // 
            // MostPrefferedList
            // 
            this.MostPrefferedList.Location = new System.Drawing.Point(46, 287);
            this.MostPrefferedList.Name = "MostPrefferedList";
            this.MostPrefferedList.Size = new System.Drawing.Size(208, 23);
            this.MostPrefferedList.TabIndex = 24;
            this.MostPrefferedList.Text = "Save Most Used Currencies";
            this.MostPrefferedList.UseVisualStyleBackColor = true;
            this.MostPrefferedList.Click += new System.EventHandler(this.MostPrefferedList_Click);
            // 
            // PrefferedListOkayButton
            // 
            this.PrefferedListOkayButton.BackColor = System.Drawing.Color.Black;
            this.PrefferedListOkayButton.ForeColor = System.Drawing.Color.Green;
            this.PrefferedListOkayButton.Location = new System.Drawing.Point(513, 173);
            this.PrefferedListOkayButton.Name = "PrefferedListOkayButton";
            this.PrefferedListOkayButton.Size = new System.Drawing.Size(55, 23);
            this.PrefferedListOkayButton.TabIndex = 25;
            this.PrefferedListOkayButton.Text = "Okay";
            this.PrefferedListOkayButton.UseVisualStyleBackColor = false;
            this.PrefferedListOkayButton.Click += new System.EventHandler(this.PrefferedListOkayButton_Click);
            // 
            // PrefferedListCancelButton
            // 
            this.PrefferedListCancelButton.BackColor = System.Drawing.Color.Black;
            this.PrefferedListCancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PrefferedListCancelButton.Location = new System.Drawing.Point(616, 173);
            this.PrefferedListCancelButton.Name = "PrefferedListCancelButton";
            this.PrefferedListCancelButton.Size = new System.Drawing.Size(60, 23);
            this.PrefferedListCancelButton.TabIndex = 26;
            this.PrefferedListCancelButton.Text = "Cancel";
            this.PrefferedListCancelButton.UseVisualStyleBackColor = false;
            this.PrefferedListCancelButton.Click += new System.EventHandler(this.PrefferedListCancelButton_Click);
            // 
            // MostPrefferedClearButton
            // 
            this.MostPrefferedClearButton.BackColor = System.Drawing.Color.Black;
            this.MostPrefferedClearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MostPrefferedClearButton.Location = new System.Drawing.Point(566, 173);
            this.MostPrefferedClearButton.Name = "MostPrefferedClearButton";
            this.MostPrefferedClearButton.Size = new System.Drawing.Size(59, 23);
            this.MostPrefferedClearButton.TabIndex = 27;
            this.MostPrefferedClearButton.Text = "Clear";
            this.MostPrefferedClearButton.UseVisualStyleBackColor = false;
            this.MostPrefferedClearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 448);
            this.Controls.Add(this.MostPrefferedClearButton);
            this.Controls.Add(this.PrefferedListCancelButton);
            this.Controls.Add(this.PrefferedListOkayButton);
            this.Controls.Add(this.MostPrefferedList);
            this.Controls.Add(this.MostPrefferedCheckList);
            this.Controls.Add(this.FinalAmount);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.mainframetext);
            this.Controls.Add(this.SourceCombo);
            this.Controls.Add(this.DestinationCombo);
            this.Controls.Add(this.Finalvalue);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(24, 75, 24, 25);
            this.Text = "Hot Convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox amount;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button Finalvalue;
        private System.Windows.Forms.ComboBox DestinationCombo;
        private System.Windows.Forms.ComboBox SourceCombo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label mainframetext;
        private System.Windows.Forms.TextBox FinalAmount;
        private System.Windows.Forms.CheckedListBox MostPrefferedCheckList;
        private System.Windows.Forms.Button MostPrefferedList;
        private System.Windows.Forms.Button PrefferedListOkayButton;
        private System.Windows.Forms.Button PrefferedListCancelButton;
        private System.Windows.Forms.Button MostPrefferedClearButton;
    }
}