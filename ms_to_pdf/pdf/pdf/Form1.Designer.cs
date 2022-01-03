
namespace pdf
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.listBox_work_files = new System.Windows.Forms.ListBox();
            this.label_work_file = new System.Windows.Forms.Label();
            this.label_save_file = new System.Windows.Forms.Label();
            this.textBox_save_folder = new System.Windows.Forms.TextBox();
            this.button_set_save_folder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "PDF変換";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_work_files
            // 
            this.listBox_work_files.AllowDrop = true;
            this.listBox_work_files.FormattingEnabled = true;
            this.listBox_work_files.ItemHeight = 12;
            this.listBox_work_files.Location = new System.Drawing.Point(149, 37);
            this.listBox_work_files.Name = "listBox_work_files";
            this.listBox_work_files.Size = new System.Drawing.Size(450, 100);
            this.listBox_work_files.TabIndex = 2;
            this.listBox_work_files.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox_work_files.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox_work_files.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox_work_files.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // label_work_file
            // 
            this.label_work_file.AutoSize = true;
            this.label_work_file.Location = new System.Drawing.Point(147, 16);
            this.label_work_file.Name = "label_work_file";
            this.label_work_file.Size = new System.Drawing.Size(201, 12);
            this.label_work_file.TabIndex = 3;
            this.label_work_file.Text = "作業ファイル（docx,doc,xlsx.xls,pptx,ppt）";
            // 
            // label_save_file
            // 
            this.label_save_file.AutoSize = true;
            this.label_save_file.Location = new System.Drawing.Point(147, 140);
            this.label_save_file.Name = "label_save_file";
            this.label_save_file.Size = new System.Drawing.Size(64, 12);
            this.label_save_file.TabIndex = 4;
            this.label_save_file.Text = "保存フォルダ";
            this.label_save_file.Click += new System.EventHandler(this.label_save_file_Click);
            // 
            // textBox_save_folder
            // 
            this.textBox_save_folder.AllowDrop = true;
            this.textBox_save_folder.Location = new System.Drawing.Point(149, 157);
            this.textBox_save_folder.Name = "textBox_save_folder";
            this.textBox_save_folder.Size = new System.Drawing.Size(370, 19);
            this.textBox_save_folder.TabIndex = 5;
            this.textBox_save_folder.Text = "Default";
            this.textBox_save_folder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_save_folder.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox_save_folder.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // button_set_save_folder
            // 
            this.button_set_save_folder.Location = new System.Drawing.Point(525, 155);
            this.button_set_save_folder.Name = "button_set_save_folder";
            this.button_set_save_folder.Size = new System.Drawing.Size(74, 23);
            this.button_set_save_folder.TabIndex = 6;
            this.button_set_save_folder.Text = "参照";
            this.button_set_save_folder.UseVisualStyleBackColor = true;
            this.button_set_save_folder.Click += new System.EventHandler(this.button_set_save_folder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "label_test";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(13, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 37);
            this.panel1.TabIndex = 9;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "表示用画質";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "印刷用画質";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 188);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_set_save_folder);
            this.Controls.Add(this.textBox_save_folder);
            this.Controls.Add(this.label_save_file);
            this.Controls.Add(this.label_work_file);
            this.Controls.Add(this.listBox_work_files);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox_work_files;
        private System.Windows.Forms.Label label_work_file;
        private System.Windows.Forms.Label label_save_file;
        private System.Windows.Forms.TextBox textBox_save_folder;
        private System.Windows.Forms.Button button_set_save_folder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

