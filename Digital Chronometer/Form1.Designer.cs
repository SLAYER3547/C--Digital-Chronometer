
namespace Digitale_Chronometer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yuvarlakButon4 = new Digitale_Chronometer.YuvarlakButon();
            this.yuvarlakButon3 = new Digitale_Chronometer.YuvarlakButon();
            this.yuvarlakButon2 = new Digitale_Chronometer.YuvarlakButon();
            this.yuvarlakButon1 = new Digitale_Chronometer.YuvarlakButon();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "00:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "00 ,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sec";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 277);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 216);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tours";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hour";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Minute";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Second";
            this.columnHeader4.Width = 113;
            // 
            // yuvarlakButon4
            // 
            this.yuvarlakButon4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yuvarlakButon4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yuvarlakButon4.BackgroundImage")));
            this.yuvarlakButon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yuvarlakButon4.FlatAppearance.BorderSize = 0;
            this.yuvarlakButon4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakButon4.Location = new System.Drawing.Point(303, 187);
            this.yuvarlakButon4.Name = "yuvarlakButon4";
            this.yuvarlakButon4.Size = new System.Drawing.Size(56, 55);
            this.yuvarlakButon4.TabIndex = 10;
            this.yuvarlakButon4.Text = "\r\n";
            this.yuvarlakButon4.UseVisualStyleBackColor = false;
            this.yuvarlakButon4.Click += new System.EventHandler(this.yuvarlakButon4_Click);
            // 
            // yuvarlakButon3
            // 
            this.yuvarlakButon3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yuvarlakButon3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yuvarlakButon3.BackgroundImage")));
            this.yuvarlakButon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yuvarlakButon3.FlatAppearance.BorderSize = 0;
            this.yuvarlakButon3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakButon3.Location = new System.Drawing.Point(228, 187);
            this.yuvarlakButon3.Name = "yuvarlakButon3";
            this.yuvarlakButon3.Size = new System.Drawing.Size(56, 55);
            this.yuvarlakButon3.TabIndex = 9;
            this.yuvarlakButon3.Text = "\r\n";
            this.yuvarlakButon3.UseVisualStyleBackColor = false;
            this.yuvarlakButon3.Click += new System.EventHandler(this.yuvarlakButon3_Click);
            // 
            // yuvarlakButon2
            // 
            this.yuvarlakButon2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yuvarlakButon2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yuvarlakButon2.BackgroundImage")));
            this.yuvarlakButon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yuvarlakButon2.FlatAppearance.BorderSize = 0;
            this.yuvarlakButon2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakButon2.Location = new System.Drawing.Point(149, 187);
            this.yuvarlakButon2.Name = "yuvarlakButon2";
            this.yuvarlakButon2.Size = new System.Drawing.Size(56, 55);
            this.yuvarlakButon2.TabIndex = 8;
            this.yuvarlakButon2.Text = "\r\n";
            this.yuvarlakButon2.UseVisualStyleBackColor = false;
            this.yuvarlakButon2.Click += new System.EventHandler(this.yuvarlakButon2_Click);
            // 
            // yuvarlakButon1
            // 
            this.yuvarlakButon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yuvarlakButon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yuvarlakButon1.BackgroundImage")));
            this.yuvarlakButon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yuvarlakButon1.FlatAppearance.BorderSize = 0;
            this.yuvarlakButon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakButon1.Location = new System.Drawing.Point(74, 187);
            this.yuvarlakButon1.Name = "yuvarlakButon1";
            this.yuvarlakButon1.Size = new System.Drawing.Size(56, 55);
            this.yuvarlakButon1.TabIndex = 4;
            this.yuvarlakButon1.Text = "\r\n";
            this.yuvarlakButon1.UseVisualStyleBackColor = false;
            this.yuvarlakButon1.Click += new System.EventHandler(this.yuvarlakButon1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 505);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.yuvarlakButon4);
            this.Controls.Add(this.yuvarlakButon3);
            this.Controls.Add(this.yuvarlakButon2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yuvarlakButon1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Digital Chronometer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private YuvarlakButon yuvarlakButon1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private YuvarlakButon yuvarlakButon2;
        private YuvarlakButon yuvarlakButon3;
        private YuvarlakButon yuvarlakButon4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

