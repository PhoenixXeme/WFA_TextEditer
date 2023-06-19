namespace WFA_TextEditer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_save = new Button();
            btn_load = new Button();
            tb_load_path = new TextBox();
            tb_edit = new TextBox();
            lbl_fileName = new Label();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_save.ForeColor = Color.DimGray;
            btn_save.Location = new Point(12, 394);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(88, 39);
            btn_save.TabIndex = 0;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_load
            // 
            btn_load.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_load.ForeColor = Color.Black;
            btn_load.Location = new Point(106, 394);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(88, 39);
            btn_load.TabIndex = 0;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // tb_load_path
            // 
            tb_load_path.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_load_path.BackColor = Color.WhiteSmoke;
            tb_load_path.BorderStyle = BorderStyle.None;
            tb_load_path.ForeColor = Color.Black;
            tb_load_path.Location = new Point(200, 403);
            tb_load_path.Name = "tb_load_path";
            tb_load_path.Size = new Size(389, 16);
            tb_load_path.TabIndex = 1;
            // 
            // tb_edit
            // 
            tb_edit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_edit.BackColor = Color.WhiteSmoke;
            tb_edit.BorderStyle = BorderStyle.None;
            tb_edit.ForeColor = Color.Black;
            tb_edit.Location = new Point(12, 39);
            tb_edit.Multiline = true;
            tb_edit.Name = "tb_edit";
            tb_edit.Size = new Size(577, 349);
            tb_edit.TabIndex = 2;
            // 
            // lbl_fileName
            // 
            lbl_fileName.Anchor = AnchorStyles.Top;
            lbl_fileName.AutoSize = true;
            lbl_fileName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_fileName.ForeColor = Color.Black;
            lbl_fileName.Location = new Point(236, 9);
            lbl_fileName.Name = "lbl_fileName";
            lbl_fileName.Size = new Size(99, 25);
            lbl_fileName.TabIndex = 3;
            lbl_fileName.Text = "File Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(601, 445);
            Controls.Add(lbl_fileName);
            Controls.Add(tb_edit);
            Controls.Add(tb_load_path);
            Controls.Add(btn_load);
            Controls.Add(btn_save);
            ForeColor = SystemColors.ControlText;
            MinimumSize = new Size(617, 484);
            Name = "Form1";
            Text = "Text Editer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_save;
        private Button btn_load;
        private TextBox tb_load_path;
        private TextBox tb_edit;
        private Label lbl_fileName;
    }
}