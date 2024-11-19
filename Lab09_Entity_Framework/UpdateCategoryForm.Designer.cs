namespace Lab09_Entity_Framework
{
    partial class UpdateCategoryForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCategoryId = new TextBox();
            txtCategoryName = new TextBox();
            cbbCategoryTy = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 50);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 98);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên nhóm thức ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 151);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 0;
            label3.Text = "Loại";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(205, 47);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(82, 23);
            txtCategoryId.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(205, 95);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(219, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // cbbCategoryTy
            // 
            cbbCategoryTy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoryTy.FormattingEnabled = true;
            cbbCategoryTy.Items.AddRange(new object[] { "Đồ uống ", "Thức ăn" });
            cbbCategoryTy.Location = new Point(205, 148);
            cbbCategoryTy.Name = "cbbCategoryTy";
            cbbCategoryTy.Size = new Size(219, 23);
            cbbCategoryTy.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(268, 201);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(349, 201);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // UpdateCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 247);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbbCategoryTy);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateCategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm/cập nhật nhóm thức ăn ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryId;
        private TextBox txtCategoryName;
        private ComboBox cbbCategoryTy;
        private Button btnSave;
        private Button btnCancel;
    }
}