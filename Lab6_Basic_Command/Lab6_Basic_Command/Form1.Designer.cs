namespace Lab6_Basic_Command
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
            components = new System.ComponentModel.Container();
            btnLoad = new Button();
            lvCategory = new ListView();
            chID = new ColumnHeader();
            chName = new ColumnHeader();
            chType = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmDelete = new ToolStripMenuItem();
            tsmViewFood = new ToolStripMenuItem();
            txtID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtType = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(57, 191);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Lấy danh sách";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lvCategory
            // 
            lvCategory.Columns.AddRange(new ColumnHeader[] { chID, chName, chType });
            lvCategory.ContextMenuStrip = contextMenuStrip1;
            lvCategory.FullRowSelect = true;
            lvCategory.Location = new Point(32, 259);
            lvCategory.MultiSelect = false;
            lvCategory.Name = "lvCategory";
            lvCategory.Size = new Size(655, 305);
            lvCategory.TabIndex = 1;
            lvCategory.UseCompatibleStateImageBehavior = false;
            lvCategory.View = View.Details;
            lvCategory.SelectedIndexChanged += lvCategory_SelectedIndexChanged;
            lvCategory.Click += lvCategory_Click;
            // 
            // chID
            // 
            chID.Text = "Mã Loại";
            chID.Width = 150;
            // 
            // chName
            // 
            chName.Text = "Tên loại món ăn";
            chName.Width = 150;
            // 
            // chType
            // 
            chType.Text = "Loại";
            chType.Width = 150;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmDelete, tsmViewFood });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(200, 70);
            // 
            // tsmDelete
            // 
            tsmDelete.Name = "tsmDelete";
            tsmDelete.Size = new Size(199, 22);
            tsmDelete.Text = "Xóa nhóm sản phẩm";
            tsmDelete.Click += tsmDelete_Click_1;
            // 
            // tsmViewFood
            // 
            tsmViewFood.Name = "tsmViewFood";
            tsmViewFood.Size = new Size(199, 22);
            tsmViewFood.Text = "Xem danh sách món ăn";
            tsmViewFood.Click += tsmViewFood_Click_1;
            // 
            // txtID
            // 
            txtID.Location = new Point(190, 24);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(240, 23);
            txtID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Mã nhóm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 59);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên nhóm thức ăn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 93);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Loại:";
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 23);
            txtName.TabIndex = 2;
            // 
            // txtType
            // 
            txtType.Location = new Point(190, 90);
            txtType.Name = "txtType";
            txtType.Size = new Size(240, 23);
            txtType.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(343, 191);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(470, 191);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(603, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 619);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtType);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lvCategory);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private ListView lvCategory;
        private ColumnHeader chID;
        private ColumnHeader chName;
        private ColumnHeader chType;
        private TextBox txtID;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtType;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmDelete;
        private ToolStripMenuItem tsmViewFood;
    }
}
