namespace Taschenrechner_WF
{
    partial class TaschenrechnerForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnzeigeRechnung = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonErgebnis = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMal = new System.Windows.Forms.Button();
            this.buttonGeteilt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnzeigeRechnung
            // 
            this.AnzeigeRechnung.AutoSize = true;
            this.AnzeigeRechnung.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AnzeigeRechnung.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AnzeigeRechnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnzeigeRechnung.Location = new System.Drawing.Point(30, 22);
            this.AnzeigeRechnung.MaximumSize = new System.Drawing.Size(285, 35);
            this.AnzeigeRechnung.MinimumSize = new System.Drawing.Size(285, 35);
            this.AnzeigeRechnung.Name = "AnzeigeRechnung";
            this.AnzeigeRechnung.Size = new System.Drawing.Size(285, 35);
            this.AnzeigeRechnung.TabIndex = 0;
            this.AnzeigeRechnung.Click += new System.EventHandler(this.AnzeigeRechnung_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonGeteilt, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonMal, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonMinus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonErgebnis, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(289, 256);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(76, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(147, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(5, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(76, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(147, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 55);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(5, 131);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 55);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(76, 131);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 55);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.FlatAppearance.BorderSize = 3;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(147, 131);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 55);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button0.FlatAppearance.BorderSize = 3;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(76, 194);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(63, 55);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonC.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonC.FlatAppearance.BorderSize = 3;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(5, 194);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(63, 55);
            this.buttonC.TabIndex = 10;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            // 
            // buttonErgebnis
            // 
            this.buttonErgebnis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonErgebnis.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonErgebnis.FlatAppearance.BorderSize = 3;
            this.buttonErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErgebnis.Location = new System.Drawing.Point(147, 194);
            this.buttonErgebnis.Name = "buttonErgebnis";
            this.buttonErgebnis.Size = new System.Drawing.Size(63, 55);
            this.buttonErgebnis.TabIndex = 11;
            this.buttonErgebnis.Text = "=";
            this.buttonErgebnis.UseVisualStyleBackColor = false;
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlus.FlatAppearance.BorderSize = 3;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(218, 5);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(63, 55);
            this.buttonPlus.TabIndex = 12;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMinus.FlatAppearance.BorderSize = 3;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(218, 68);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(63, 55);
            this.buttonMinus.TabIndex = 13;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            // 
            // buttonMal
            // 
            this.buttonMal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMal.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMal.FlatAppearance.BorderSize = 3;
            this.buttonMal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMal.Location = new System.Drawing.Point(218, 131);
            this.buttonMal.Name = "buttonMal";
            this.buttonMal.Size = new System.Drawing.Size(63, 55);
            this.buttonMal.TabIndex = 14;
            this.buttonMal.Text = "*";
            this.buttonMal.UseVisualStyleBackColor = false;
            // 
            // buttonGeteilt
            // 
            this.buttonGeteilt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGeteilt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGeteilt.FlatAppearance.BorderSize = 3;
            this.buttonGeteilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeteilt.Location = new System.Drawing.Point(218, 194);
            this.buttonGeteilt.Name = "buttonGeteilt";
            this.buttonGeteilt.Size = new System.Drawing.Size(63, 55);
            this.buttonGeteilt.TabIndex = 15;
            this.buttonGeteilt.Text = "/";
            this.buttonGeteilt.UseVisualStyleBackColor = false;
            // 
            // TaschenrechnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(352, 374);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AnzeigeRechnung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaschenrechnerForm";
            this.Text = "Taschenrechner";
            this.Load += new System.EventHandler(this.TaschenrechnerForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnzeigeRechnung;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonGeteilt;
        private System.Windows.Forms.Button buttonMal;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonErgebnis;
    }
}

