﻿namespace Latvanyossagok
{
    partial class Latvanyossagok
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
            this.varosGroupBox = new System.Windows.Forms.GroupBox();
            this.varosHozzaadasButton = new System.Windows.Forms.Button();
            this.varosLakossagNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.varosLakossagLabel = new System.Windows.Forms.Label();
            this.varosNeveTextBox = new System.Windows.Forms.TextBox();
            this.varosNeveLabel = new System.Windows.Forms.Label();
            this.varosokLabel = new System.Windows.Forms.Label();
            this.varosokListBox = new System.Windows.Forms.ListBox();
            this.latvanyossagokGroupBox = new System.Windows.Forms.GroupBox();
            this.kivalasztottVarosLabel = new System.Windows.Forms.Label();
            this.kivalasztottlabel = new System.Windows.Forms.Label();
            this.figyelmeztetesLabel = new System.Windows.Forms.Label();
            this.latvanyossagHozzaadasButton = new System.Windows.Forms.Button();
            this.forintLabel = new System.Windows.Forms.Label();
            this.latvanyossagNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.latvanyossagLeirasaTextBox = new System.Windows.Forms.TextBox();
            this.latvanyossagNeveTextBox = new System.Windows.Forms.TextBox();
            this.latvanyossagArLabel = new System.Windows.Forms.Label();
            this.latvanyossagLeirasaLabel = new System.Windows.Forms.Label();
            this.latvanyossagNeveLabel = new System.Windows.Forms.Label();
            this.latvanyossagokListBox = new System.Windows.Forms.ListBox();
            this.latvanyossagokLabel = new System.Windows.Forms.Label();
            this.varosTorlesButton = new System.Windows.Forms.Button();
            this.LatvanyossagTorlesButton = new System.Windows.Forms.Button();
            this.varosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varosLakossagNumericUpDown)).BeginInit();
            this.latvanyossagokGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossagNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // varosGroupBox
            // 
            this.varosGroupBox.Controls.Add(this.varosHozzaadasButton);
            this.varosGroupBox.Controls.Add(this.varosLakossagNumericUpDown);
            this.varosGroupBox.Controls.Add(this.varosLakossagLabel);
            this.varosGroupBox.Controls.Add(this.varosNeveTextBox);
            this.varosGroupBox.Controls.Add(this.varosNeveLabel);
            this.varosGroupBox.Location = new System.Drawing.Point(13, 13);
            this.varosGroupBox.Name = "varosGroupBox";
            this.varosGroupBox.Size = new System.Drawing.Size(253, 182);
            this.varosGroupBox.TabIndex = 0;
            this.varosGroupBox.TabStop = false;
            this.varosGroupBox.Text = "Váos hozzáadás";
            // 
            // varosHozzaadasButton
            // 
            this.varosHozzaadasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varosHozzaadasButton.Location = new System.Drawing.Point(9, 137);
            this.varosHozzaadasButton.Name = "varosHozzaadasButton";
            this.varosHozzaadasButton.Size = new System.Drawing.Size(238, 37);
            this.varosHozzaadasButton.TabIndex = 5;
            this.varosHozzaadasButton.Text = "Hozzáadás";
            this.varosHozzaadasButton.UseVisualStyleBackColor = true;
            this.varosHozzaadasButton.Click += new System.EventHandler(this.VarosHozzaadasButton_Click);
            // 
            // varosLakossagNumericUpDown
            // 
            this.varosLakossagNumericUpDown.Location = new System.Drawing.Point(9, 111);
            this.varosLakossagNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.varosLakossagNumericUpDown.Name = "varosLakossagNumericUpDown";
            this.varosLakossagNumericUpDown.Size = new System.Drawing.Size(238, 20);
            this.varosLakossagNumericUpDown.TabIndex = 4;
            this.varosLakossagNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varosLakossagLabel
            // 
            this.varosLakossagLabel.AutoSize = true;
            this.varosLakossagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varosLakossagLabel.Location = new System.Drawing.Point(6, 89);
            this.varosLakossagLabel.Name = "varosLakossagLabel";
            this.varosLakossagLabel.Size = new System.Drawing.Size(123, 18);
            this.varosLakossagLabel.TabIndex = 3;
            this.varosLakossagLabel.Text = "Város lakossága:";
            // 
            // varosNeveTextBox
            // 
            this.varosNeveTextBox.Location = new System.Drawing.Point(9, 49);
            this.varosNeveTextBox.Name = "varosNeveTextBox";
            this.varosNeveTextBox.Size = new System.Drawing.Size(238, 20);
            this.varosNeveTextBox.TabIndex = 2;
            // 
            // varosNeveLabel
            // 
            this.varosNeveLabel.AutoSize = true;
            this.varosNeveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varosNeveLabel.Location = new System.Drawing.Point(6, 28);
            this.varosNeveLabel.Name = "varosNeveLabel";
            this.varosNeveLabel.Size = new System.Drawing.Size(86, 18);
            this.varosNeveLabel.TabIndex = 1;
            this.varosNeveLabel.Text = "Város neve:";
            // 
            // varosokLabel
            // 
            this.varosokLabel.AutoSize = true;
            this.varosokLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varosokLabel.Location = new System.Drawing.Point(101, 198);
            this.varosokLabel.Name = "varosokLabel";
            this.varosokLabel.Size = new System.Drawing.Size(64, 18);
            this.varosokLabel.TabIndex = 1;
            this.varosokLabel.Text = "Városok";
            // 
            // varosokListBox
            // 
            this.varosokListBox.FormattingEnabled = true;
            this.varosokListBox.Location = new System.Drawing.Point(13, 219);
            this.varosokListBox.Name = "varosokListBox";
            this.varosokListBox.Size = new System.Drawing.Size(253, 173);
            this.varosokListBox.TabIndex = 2;
            this.varosokListBox.SelectedIndexChanged += new System.EventHandler(this.VarosokListBox_SelectedIndexChanged);
            // 
            // latvanyossagokGroupBox
            // 
            this.latvanyossagokGroupBox.Controls.Add(this.kivalasztottVarosLabel);
            this.latvanyossagokGroupBox.Controls.Add(this.kivalasztottlabel);
            this.latvanyossagokGroupBox.Controls.Add(this.figyelmeztetesLabel);
            this.latvanyossagokGroupBox.Controls.Add(this.latvanyossagHozzaadasButton);
            this.latvanyossagokGroupBox.Controls.Add(this.forintLabel);
            this.latvanyossagokGroupBox.Controls.Add(this.latvanyossagNumericUpDown);
            this.latvanyossagokGroupBox.Controls.Add(this.latvanyossagLeirasaTextBox);
            this.latvanyossagokGroupBox.Controls.Add(this.latvanyossagNeveTextBox);
            this.latvanyossagokGroupBox.Controls.Add(this.latvanyossagArLabel);
            this.latvanyossagokGroupBox.Controls.Add(this.latvanyossagLeirasaLabel);
            this.latvanyossagokGroupBox.Controls.Add(this.latvanyossagNeveLabel);
            this.latvanyossagokGroupBox.Location = new System.Drawing.Point(273, 13);
            this.latvanyossagokGroupBox.Name = "latvanyossagokGroupBox";
            this.latvanyossagokGroupBox.Size = new System.Drawing.Size(373, 182);
            this.latvanyossagokGroupBox.TabIndex = 3;
            this.latvanyossagokGroupBox.TabStop = false;
            this.latvanyossagokGroupBox.Text = "Látványosságok hozzáadás";
            // 
            // kivalasztottVarosLabel
            // 
            this.kivalasztottVarosLabel.AutoSize = true;
            this.kivalasztottVarosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kivalasztottVarosLabel.Location = new System.Drawing.Point(136, 150);
            this.kivalasztottVarosLabel.Name = "kivalasztottVarosLabel";
            this.kivalasztottVarosLabel.Size = new System.Drawing.Size(0, 13);
            this.kivalasztottVarosLabel.TabIndex = 15;
            // 
            // kivalasztottlabel
            // 
            this.kivalasztottlabel.AutoSize = true;
            this.kivalasztottlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kivalasztottlabel.Location = new System.Drawing.Point(7, 146);
            this.kivalasztottlabel.Name = "kivalasztottlabel";
            this.kivalasztottlabel.Size = new System.Drawing.Size(129, 18);
            this.kivalasztottlabel.TabIndex = 14;
            this.kivalasztottlabel.Text = "Kiválasztott város:";
            // 
            // figyelmeztetesLabel
            // 
            this.figyelmeztetesLabel.AutoSize = true;
            this.figyelmeztetesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.figyelmeztetesLabel.ForeColor = System.Drawing.Color.Red;
            this.figyelmeztetesLabel.Location = new System.Drawing.Point(7, 129);
            this.figyelmeztetesLabel.Name = "figyelmeztetesLabel";
            this.figyelmeztetesLabel.Size = new System.Drawing.Size(212, 12);
            this.figyelmeztetesLabel.TabIndex = 13;
            this.figyelmeztetesLabel.Text = "*Kérjük válasszon ki a városok listából egy várost!";
            // 
            // latvanyossagHozzaadasButton
            // 
            this.latvanyossagHozzaadasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.latvanyossagHozzaadasButton.Location = new System.Drawing.Point(247, 139);
            this.latvanyossagHozzaadasButton.Name = "latvanyossagHozzaadasButton";
            this.latvanyossagHozzaadasButton.Size = new System.Drawing.Size(120, 37);
            this.latvanyossagHozzaadasButton.TabIndex = 6;
            this.latvanyossagHozzaadasButton.Text = "Hozzáadás";
            this.latvanyossagHozzaadasButton.UseVisualStyleBackColor = true;
            this.latvanyossagHozzaadasButton.Click += new System.EventHandler(this.LatvanyossagHozzaadasButton_Click);
            // 
            // forintLabel
            // 
            this.forintLabel.AutoSize = true;
            this.forintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.forintLabel.Location = new System.Drawing.Point(346, 106);
            this.forintLabel.Name = "forintLabel";
            this.forintLabel.Size = new System.Drawing.Size(21, 18);
            this.forintLabel.TabIndex = 12;
            this.forintLabel.Text = "Ft";
            // 
            // latvanyossagNumericUpDown
            // 
            this.latvanyossagNumericUpDown.Location = new System.Drawing.Point(171, 106);
            this.latvanyossagNumericUpDown.Name = "latvanyossagNumericUpDown";
            this.latvanyossagNumericUpDown.Size = new System.Drawing.Size(171, 20);
            this.latvanyossagNumericUpDown.TabIndex = 11;
            this.latvanyossagNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // latvanyossagLeirasaTextBox
            // 
            this.latvanyossagLeirasaTextBox.Location = new System.Drawing.Point(171, 68);
            this.latvanyossagLeirasaTextBox.Name = "latvanyossagLeirasaTextBox";
            this.latvanyossagLeirasaTextBox.Size = new System.Drawing.Size(196, 20);
            this.latvanyossagLeirasaTextBox.TabIndex = 10;
            // 
            // latvanyossagNeveTextBox
            // 
            this.latvanyossagNeveTextBox.Location = new System.Drawing.Point(171, 29);
            this.latvanyossagNeveTextBox.Name = "latvanyossagNeveTextBox";
            this.latvanyossagNeveTextBox.Size = new System.Drawing.Size(196, 20);
            this.latvanyossagNeveTextBox.TabIndex = 9;
            // 
            // latvanyossagArLabel
            // 
            this.latvanyossagArLabel.AutoSize = true;
            this.latvanyossagArLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latvanyossagArLabel.Location = new System.Drawing.Point(6, 109);
            this.latvanyossagArLabel.Name = "latvanyossagArLabel";
            this.latvanyossagArLabel.Size = new System.Drawing.Size(128, 18);
            this.latvanyossagArLabel.TabIndex = 8;
            this.latvanyossagArLabel.Text = "Látványosság ára:";
            // 
            // latvanyossagLeirasaLabel
            // 
            this.latvanyossagLeirasaLabel.AutoSize = true;
            this.latvanyossagLeirasaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latvanyossagLeirasaLabel.Location = new System.Drawing.Point(6, 67);
            this.latvanyossagLeirasaLabel.Name = "latvanyossagLeirasaLabel";
            this.latvanyossagLeirasaLabel.Size = new System.Drawing.Size(150, 18);
            this.latvanyossagLeirasaLabel.TabIndex = 7;
            this.latvanyossagLeirasaLabel.Text = "Látványosság leírása:";
            // 
            // latvanyossagNeveLabel
            // 
            this.latvanyossagNeveLabel.AutoSize = true;
            this.latvanyossagNeveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latvanyossagNeveLabel.Location = new System.Drawing.Point(6, 28);
            this.latvanyossagNeveLabel.Name = "latvanyossagNeveLabel";
            this.latvanyossagNeveLabel.Size = new System.Drawing.Size(138, 18);
            this.latvanyossagNeveLabel.TabIndex = 6;
            this.latvanyossagNeveLabel.Text = "Látványosság neve:";
            // 
            // latvanyossagokListBox
            // 
            this.latvanyossagokListBox.FormattingEnabled = true;
            this.latvanyossagokListBox.Location = new System.Drawing.Point(342, 219);
            this.latvanyossagokListBox.Name = "latvanyossagokListBox";
            this.latvanyossagokListBox.Size = new System.Drawing.Size(253, 173);
            this.latvanyossagokListBox.TabIndex = 5;
            // 
            // latvanyossagokLabel
            // 
            this.latvanyossagokLabel.AutoSize = true;
            this.latvanyossagokLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.latvanyossagokLabel.Location = new System.Drawing.Point(409, 198);
            this.latvanyossagokLabel.Name = "latvanyossagokLabel";
            this.latvanyossagokLabel.Size = new System.Drawing.Size(116, 18);
            this.latvanyossagokLabel.TabIndex = 4;
            this.latvanyossagokLabel.Text = "Látványosságok";
            // 
            // varosTorlesButton
            // 
            this.varosTorlesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varosTorlesButton.Location = new System.Drawing.Point(191, 398);
            this.varosTorlesButton.Name = "varosTorlesButton";
            this.varosTorlesButton.Size = new System.Drawing.Size(75, 25);
            this.varosTorlesButton.TabIndex = 6;
            this.varosTorlesButton.Text = "Törlés";
            this.varosTorlesButton.UseVisualStyleBackColor = true;
            this.varosTorlesButton.Click += new System.EventHandler(this.VarosTorlesButton_Click);
            // 
            // LatvanyossagTorlesButton
            // 
            this.LatvanyossagTorlesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LatvanyossagTorlesButton.Location = new System.Drawing.Point(520, 398);
            this.LatvanyossagTorlesButton.Name = "LatvanyossagTorlesButton";
            this.LatvanyossagTorlesButton.Size = new System.Drawing.Size(75, 25);
            this.LatvanyossagTorlesButton.TabIndex = 7;
            this.LatvanyossagTorlesButton.Text = "Törlés";
            this.LatvanyossagTorlesButton.UseVisualStyleBackColor = true;
            this.LatvanyossagTorlesButton.Click += new System.EventHandler(this.LatvanyossagTorlesButton_Click);
            // 
            // Latvanyossagok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 435);
            this.Controls.Add(this.LatvanyossagTorlesButton);
            this.Controls.Add(this.varosTorlesButton);
            this.Controls.Add(this.latvanyossagokListBox);
            this.Controls.Add(this.latvanyossagokLabel);
            this.Controls.Add(this.latvanyossagokGroupBox);
            this.Controls.Add(this.varosokListBox);
            this.Controls.Add(this.varosokLabel);
            this.Controls.Add(this.varosGroupBox);
            this.MaximizeBox = false;
            this.Name = "Latvanyossagok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Látványosságok";
            this.varosGroupBox.ResumeLayout(false);
            this.varosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varosLakossagNumericUpDown)).EndInit();
            this.latvanyossagokGroupBox.ResumeLayout(false);
            this.latvanyossagokGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossagNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox varosGroupBox;
        private System.Windows.Forms.TextBox varosNeveTextBox;
        private System.Windows.Forms.Label varosNeveLabel;
        private System.Windows.Forms.Label varosLakossagLabel;
        private System.Windows.Forms.NumericUpDown varosLakossagNumericUpDown;
        private System.Windows.Forms.Label varosokLabel;
        private System.Windows.Forms.ListBox varosokListBox;
        private System.Windows.Forms.Button varosHozzaadasButton;
        private System.Windows.Forms.GroupBox latvanyossagokGroupBox;
        private System.Windows.Forms.Label latvanyossagNeveLabel;
        private System.Windows.Forms.Label latvanyossagLeirasaLabel;
        private System.Windows.Forms.TextBox latvanyossagLeirasaTextBox;
        private System.Windows.Forms.TextBox latvanyossagNeveTextBox;
        private System.Windows.Forms.Label latvanyossagArLabel;
        private System.Windows.Forms.Label forintLabel;
        private System.Windows.Forms.NumericUpDown latvanyossagNumericUpDown;
        private System.Windows.Forms.Button latvanyossagHozzaadasButton;
        private System.Windows.Forms.ListBox latvanyossagokListBox;
        private System.Windows.Forms.Label latvanyossagokLabel;
        private System.Windows.Forms.Label kivalasztottVarosLabel;
        private System.Windows.Forms.Label kivalasztottlabel;
        private System.Windows.Forms.Label figyelmeztetesLabel;
        private System.Windows.Forms.Button varosTorlesButton;
        private System.Windows.Forms.Button LatvanyossagTorlesButton;
    }
}

