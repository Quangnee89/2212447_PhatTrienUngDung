namespace Lab09_Entity_Framework
{
    partial class MainForm
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
            TreeNode treeNode1 = new TreeNode("Canh");
            TreeNode treeNode2 = new TreeNode("Cơm");
            TreeNode treeNode3 = new TreeNode("Gà");
            TreeNode treeNode4 = new TreeNode("Hải sản");
            TreeNode treeNode5 = new TreeNode("Khai vị");
            TreeNode treeNode6 = new TreeNode("Lẩu ");
            TreeNode treeNode7 = new TreeNode("Rau");
            TreeNode treeNode8 = new TreeNode("Thịt");
            TreeNode treeNode9 = new TreeNode("Đồ ăn", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7, treeNode8 });
            TreeNode treeNode10 = new TreeNode("Bia");
            TreeNode treeNode11 = new TreeNode("Cà phê");
            TreeNode treeNode12 = new TreeNode("Nước khoáng");
            TreeNode treeNode13 = new TreeNode("Nước ngọt");
            TreeNode treeNode14 = new TreeNode("Trà đá");
            TreeNode treeNode15 = new TreeNode("Thức uống", new TreeNode[] { treeNode10, treeNode11, treeNode12, treeNode13, treeNode14 });
            TreeNode treeNode16 = new TreeNode("Tất cả", new TreeNode[] { treeNode9, treeNode15 });
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            ListViewItem listViewItem4 = new ListViewItem("");
            ListViewItem listViewItem5 = new ListViewItem("");
            ListViewItem listViewItem6 = new ListViewItem("");
            label1 = new Label();
            tvwCategory = new TreeView();
            lvwFood = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label2 = new Label();
            btnReloadCategory = new Button();
            btnAddCategory = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            btnReloadFood = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Danh mục";
            // 
            // tvwCategory
            // 
            tvwCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tvwCategory.Location = new Point(23, 52);
            tvwCategory.Name = "tvwCategory";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Canh";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Cơm";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Gà";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Hải sản";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Khai vị";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Lẩu ";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Rau";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Thịt";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Đồ ăn";
            treeNode10.Name = "Node17";
            treeNode10.Text = "Bia";
            treeNode11.Name = "Node18";
            treeNode11.Text = "Cà phê";
            treeNode12.Name = "Node19";
            treeNode12.Text = "Nước khoáng";
            treeNode13.Name = "Node20";
            treeNode13.Text = "Nước ngọt";
            treeNode14.Name = "Node21";
            treeNode14.Text = "Trà đá";
            treeNode15.Name = "Node10";
            treeNode15.Text = "Thức uống";
            treeNode16.Name = "Node0";
            treeNode16.Text = "Tất cả";
            tvwCategory.Nodes.AddRange(new TreeNode[] { treeNode16 });
            tvwCategory.Size = new Size(222, 529);
            tvwCategory.TabIndex = 1;
            tvwCategory.AfterSelect += tvwCategory_AfterSelect;
            // 
            // lvwFood
            // 
            lvwFood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwFood.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvwFood.FullRowSelect = true;
            lvwFood.GridLines = true;
            lvwFood.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 });
            lvwFood.Location = new Point(265, 52);
            lvwFood.MultiSelect = false;
            lvwFood.Name = "lvwFood";
            lvwFood.Size = new Size(679, 529);
            lvwFood.TabIndex = 2;
            lvwFood.UseCompatibleStateImageBehavior = false;
            lvwFood.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã số";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên đồ ăn/Thức uống";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ĐV Tính";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giá bán";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nhóm mặt hàng";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ghi chú";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 20);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Thực đơn";
            // 
            // btnReloadCategory
            // 
            btnReloadCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReloadCategory.Location = new Point(140, 16);
            btnReloadCategory.Name = "btnReloadCategory";
            btnReloadCategory.Size = new Size(45, 23);
            btnReloadCategory.TabIndex = 3;
            btnReloadCategory.Text = "R";
            toolTip1.SetToolTip(btnReloadCategory, "Thêm danh mục mới");
            btnReloadCategory.UseVisualStyleBackColor = true;
            btnReloadCategory.Click += btnReloadCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(200, 16);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(45, 23);
            btnAddCategory.TabIndex = 3;
            btnAddCategory.Text = "+";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(835, 16);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(45, 23);
            btnDeleteFood.TabIndex = 3;
            btnDeleteFood.Text = "-";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(886, 16);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(45, 23);
            btnAddFood.TabIndex = 3;
            btnAddFood.Text = "+";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // btnReloadFood
            // 
            btnReloadFood.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReloadFood.Location = new Point(753, 16);
            btnReloadFood.Name = "btnReloadFood";
            btnReloadFood.Size = new Size(43, 23);
            btnReloadFood.TabIndex = 4;
            btnReloadFood.Text = "R";
            toolTip1.SetToolTip(btnReloadFood, "Thêm món ăn mới");
            btnReloadFood.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 616);
            Controls.Add(btnReloadFood);
            Controls.Add(btnDeleteFood);
            Controls.Add(btnAddFood);
            Controls.Add(btnAddCategory);
            Controls.Add(btnReloadCategory);
            Controls.Add(lvwFood);
            Controls.Add(tvwCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Quản lý nhà hàng";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TreeView tvwCategory;
        private ListView lvwFood;
        private Label label2;
        private Button btnReloadCategory;
        private Button btnAddCategory;
        private Button btnDeleteFood;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnAddFood;
        private Button btnReloadFood;
        private ToolTip toolTip1;
    }
}
