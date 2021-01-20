namespace BSK_Grzegorz_Krzyzanski
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1_Key_Encrypt = new System.Windows.Forms.TextBox();
            this.richTextBox1_Decrpt_input = new System.Windows.Forms.RichTextBox();
            this.textBox2_key_decrypt = new System.Windows.Forms.TextBox();
            this.richTextBox2_Encrypt_Input = new System.Windows.Forms.RichTextBox();
            this.richTextBox3_Encrypt_Output = new System.Windows.Forms.RichTextBox();
            this.richTextBox4_decrypt_output = new System.Windows.Forms.RichTextBox();
            this.button1_encrypt = new System.Windows.Forms.Button();
            this.button1_decrypt = new System.Windows.Forms.Button();
            this.button1_openFile = new System.Windows.Forms.Button();
            this.button1_save_file = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1_save_file);
            this.panel1.Controls.Add(this.button1_openFile);
            this.panel1.Controls.Add(this.button1_encrypt);
            this.panel1.Controls.Add(this.richTextBox3_Encrypt_Output);
            this.panel1.Controls.Add(this.richTextBox2_Encrypt_Input);
            this.panel1.Controls.Add(this.textBox1_Key_Encrypt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.button1_decrypt);
            this.panel2.Controls.Add(this.richTextBox4_decrypt_output);
            this.panel2.Controls.Add(this.textBox2_key_decrypt);
            this.panel2.Controls.Add(this.richTextBox1_Decrpt_input);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(434, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 426);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(116, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szyfrowanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(120, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Odszyfrowanie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(99, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Wprowadz text do zakodowania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Klucz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(118, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Text po zaszyfrowaniu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(87, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Wprowadz text do odkodowania";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(28, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Klucz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(109, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Text po odkodowaniu";
            // 
            // textBox1_Key_Encrypt
            // 
            this.textBox1_Key_Encrypt.Location = new System.Drawing.Point(77, 189);
            this.textBox1_Key_Encrypt.Name = "textBox1_Key_Encrypt";
            this.textBox1_Key_Encrypt.Size = new System.Drawing.Size(266, 20);
            this.textBox1_Key_Encrypt.TabIndex = 4;
            // 
            // richTextBox1_Decrpt_input
            // 
            this.richTextBox1_Decrpt_input.Location = new System.Drawing.Point(31, 63);
            this.richTextBox1_Decrpt_input.Name = "richTextBox1_Decrpt_input";
            this.richTextBox1_Decrpt_input.Size = new System.Drawing.Size(307, 116);
            this.richTextBox1_Decrpt_input.TabIndex = 5;
            this.richTextBox1_Decrpt_input.Text = "";
            // 
            // textBox2_key_decrypt
            // 
            this.textBox2_key_decrypt.Location = new System.Drawing.Point(73, 186);
            this.textBox2_key_decrypt.Name = "textBox2_key_decrypt";
            this.textBox2_key_decrypt.Size = new System.Drawing.Size(248, 20);
            this.textBox2_key_decrypt.TabIndex = 6;
            // 
            // richTextBox2_Encrypt_Input
            // 
            this.richTextBox2_Encrypt_Input.Location = new System.Drawing.Point(59, 63);
            this.richTextBox2_Encrypt_Input.Name = "richTextBox2_Encrypt_Input";
            this.richTextBox2_Encrypt_Input.Size = new System.Drawing.Size(307, 116);
            this.richTextBox2_Encrypt_Input.TabIndex = 7;
            this.richTextBox2_Encrypt_Input.Text = "";
            this.richTextBox2_Encrypt_Input.TextChanged += new System.EventHandler(this.richTextBox2_Encrypt_Input_TextChanged);
            // 
            // richTextBox3_Encrypt_Output
            // 
            this.richTextBox3_Encrypt_Output.Location = new System.Drawing.Point(59, 239);
            this.richTextBox3_Encrypt_Output.Name = "richTextBox3_Encrypt_Output";
            this.richTextBox3_Encrypt_Output.Size = new System.Drawing.Size(307, 116);
            this.richTextBox3_Encrypt_Output.TabIndex = 8;
            this.richTextBox3_Encrypt_Output.Text = "";
            // 
            // richTextBox4_decrypt_output
            // 
            this.richTextBox4_decrypt_output.Location = new System.Drawing.Point(31, 239);
            this.richTextBox4_decrypt_output.Name = "richTextBox4_decrypt_output";
            this.richTextBox4_decrypt_output.Size = new System.Drawing.Size(307, 116);
            this.richTextBox4_decrypt_output.TabIndex = 7;
            this.richTextBox4_decrypt_output.Text = "";
            // 
            // button1_encrypt
            // 
            this.button1_encrypt.Location = new System.Drawing.Point(3, 393);
            this.button1_encrypt.Name = "button1_encrypt";
            this.button1_encrypt.Size = new System.Drawing.Size(95, 23);
            this.button1_encrypt.TabIndex = 9;
            this.button1_encrypt.Text = "Zaszyfruj";
            this.button1_encrypt.UseVisualStyleBackColor = true;
            this.button1_encrypt.Click += new System.EventHandler(this.button1_encrypt_Click);
            // 
            // button1_decrypt
            // 
            this.button1_decrypt.Location = new System.Drawing.Point(256, 393);
            this.button1_decrypt.Name = "button1_decrypt";
            this.button1_decrypt.Size = new System.Drawing.Size(95, 23);
            this.button1_decrypt.TabIndex = 10;
            this.button1_decrypt.Text = "Odszyfruj";
            this.button1_decrypt.UseVisualStyleBackColor = true;
            this.button1_decrypt.Click += new System.EventHandler(this.button1_decrypt_Click);
            // 
            // button1_openFile
            // 
            this.button1_openFile.Location = new System.Drawing.Point(104, 393);
            this.button1_openFile.Name = "button1_openFile";
            this.button1_openFile.Size = new System.Drawing.Size(91, 23);
            this.button1_openFile.TabIndex = 10;
            this.button1_openFile.Text = "Otwórz plik";
            this.button1_openFile.UseVisualStyleBackColor = true;
            this.button1_openFile.Click += new System.EventHandler(this.button1_openFile_Click);
            // 
            // button1_save_file
            // 
            this.button1_save_file.Location = new System.Drawing.Point(197, 393);
            this.button1_save_file.Name = "button1_save_file";
            this.button1_save_file.Size = new System.Drawing.Size(208, 23);
            this.button1_save_file.TabIndex = 11;
            this.button1_save_file.Text = "Zapisz zaszyfrowany tekst w pliku";
            this.button1_save_file.UseVisualStyleBackColor = true;
            this.button1_save_file.Click += new System.EventHandler(this.button1_save_file_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(73, 398);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Kodowanie Steganograficznie";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(803, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 403);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(984, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Szyfrowanie w obrazie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 441);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1_Key_Encrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2_key_decrypt;
        private System.Windows.Forms.RichTextBox richTextBox1_Decrpt_input;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox3_Encrypt_Output;
        private System.Windows.Forms.RichTextBox richTextBox2_Encrypt_Input;
        private System.Windows.Forms.RichTextBox richTextBox4_decrypt_output;
        private System.Windows.Forms.Button button1_encrypt;
        private System.Windows.Forms.Button button1_decrypt;
        private System.Windows.Forms.Button button1_openFile;
        private System.Windows.Forms.Button button1_save_file;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}

