namespace Kontaktandmed
{
    partial class Form2
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
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_address = new System.Windows.Forms.Button();
            this.btn_addfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.Coral;
            this.btn_all.FlatAppearance.BorderSize = 0;
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_all.Location = new System.Drawing.Point(12, 12);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(232, 59);
            this.btn_all.TabIndex = 2;
            this.btn_all.Text = "Kirjutage kõigile";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_address
            // 
            this.btn_address.BackColor = System.Drawing.Color.Coral;
            this.btn_address.FlatAppearance.BorderSize = 0;
            this.btn_address.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_address.Location = new System.Drawing.Point(268, 12);
            this.btn_address.Name = "btn_address";
            this.btn_address.Size = new System.Drawing.Size(232, 59);
            this.btn_address.TabIndex = 3;
            this.btn_address.Text = "Valige addressat";
            this.btn_address.UseVisualStyleBackColor = false;
            this.btn_address.Click += new System.EventHandler(this.btn_address_Click);
            // 
            // btn_addfile
            // 
            this.btn_addfile.BackColor = System.Drawing.Color.Coral;
            this.btn_addfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_addfile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_addfile.FlatAppearance.BorderSize = 0;
            this.btn_addfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_addfile.Location = new System.Drawing.Point(543, 12);
            this.btn_addfile.Name = "btn_addfile";
            this.btn_addfile.Size = new System.Drawing.Size(232, 59);
            this.btn_addfile.TabIndex = 4;
            this.btn_addfile.Text = "Manusta fail";
            this.btn_addfile.UseVisualStyleBackColor = false;
            this.btn_addfile.Click += new System.EventHandler(this.btn_addfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kellele: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(660, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Teema:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(661, 20);
            this.textBox2.TabIndex = 9;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Coral;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_send.Location = new System.Drawing.Point(678, 189);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(82, 38);
            this.btn_send.TabIndex = 10;
            this.btn_send.Text = "Saada";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 233);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(743, 203);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(17, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addfile);
            this.Controls.Add(this.btn_address);
            this.Controls.Add(this.btn_all);
            this.Name = "Form2";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_address;
        private System.Windows.Forms.Button btn_addfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}