namespace Rew_Zaksieguj
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.txtSerwer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSqlUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSqlPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtIdRoku = new System.Windows.Forms.Label();
            this.numIdRoku = new System.Windows.Forms.NumericUpDown();
            this.numRokRoku = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.richPerSecond = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numIdRoku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRokRoku)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Księguj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richText
            // 
            this.richText.Dock = System.Windows.Forms.DockStyle.Right;
            this.richText.Location = new System.Drawing.Point(437, 0);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(267, 450);
            this.richText.TabIndex = 1;
            this.richText.Text = "";
            
            // 
            // txtSerwer
            // 
            this.txtSerwer.Location = new System.Drawing.Point(12, 19);
            this.txtSerwer.Name = "txtSerwer";
            this.txtSerwer.Size = new System.Drawing.Size(191, 20);
            this.txtSerwer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serwer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baza:";
            // 
            // txtBaza
            // 
            this.txtBaza.Location = new System.Drawing.Point(12, 67);
            this.txtBaza.Name = "txtBaza";
            this.txtBaza.Size = new System.Drawing.Size(191, 20);
            this.txtBaza.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SqlUser";
            // 
            // txtSqlUser
            // 
            this.txtSqlUser.Location = new System.Drawing.Point(15, 117);
            this.txtSqlUser.Name = "txtSqlUser";
            this.txtSqlUser.Size = new System.Drawing.Size(191, 20);
            this.txtSqlUser.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SqlPassword";
            // 
            // txtSqlPassword
            // 
            this.txtSqlPassword.Location = new System.Drawing.Point(12, 166);
            this.txtSqlPassword.Name = "txtSqlPassword";
            this.txtSqlPassword.PasswordChar = '*';
            this.txtSqlPassword.Size = new System.Drawing.Size(191, 20);
            this.txtSqlPassword.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Użytkownik";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(15, 221);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(191, 20);
            this.txtUser.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Użytkownik hasło";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(15, 272);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(191, 20);
            this.txtUserPassword.TabIndex = 12;
            // 
            // txtIdRoku
            // 
            this.txtIdRoku.AutoSize = true;
            this.txtIdRoku.Location = new System.Drawing.Point(12, 306);
            this.txtIdRoku.Name = "txtIdRoku";
            this.txtIdRoku.Size = new System.Drawing.Size(40, 13);
            this.txtIdRoku.TabIndex = 15;
            this.txtIdRoku.Text = "Id roku";
            // 
            // numIdRoku
            // 
            this.numIdRoku.Location = new System.Drawing.Point(15, 322);
            this.numIdRoku.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIdRoku.Name = "numIdRoku";
            this.numIdRoku.Size = new System.Drawing.Size(120, 20);
            this.numIdRoku.TabIndex = 16;
            this.numIdRoku.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRokRoku
            // 
            this.numRokRoku.Location = new System.Drawing.Point(158, 322);
            this.numRokRoku.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numRokRoku.Minimum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.numRokRoku.Name = "numRokRoku";
            this.numRokRoku.Size = new System.Drawing.Size(120, 20);
            this.numRokRoku.TabIndex = 17;
            this.numRokRoku.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rok roku";
            // 
            // richPerSecond
            // 
            this.richPerSecond.Dock = System.Windows.Forms.DockStyle.Right;
            this.richPerSecond.Location = new System.Drawing.Point(320, 0);
            this.richPerSecond.Name = "richPerSecond";
            this.richPerSecond.Size = new System.Drawing.Size(117, 450);
            this.richPerSecond.TabIndex = 20;
            this.richPerSecond.Text = "";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.richPerSecond);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numRokRoku);
            this.Controls.Add(this.numIdRoku);
            this.Controls.Add(this.txtIdRoku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSqlPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSqlUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBaza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerwer);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numIdRoku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRokRoku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.TextBox txtSerwer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSqlUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSqlPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label txtIdRoku;
        private System.Windows.Forms.NumericUpDown numIdRoku;
        private System.Windows.Forms.NumericUpDown numRokRoku;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richPerSecond;
    }
}

