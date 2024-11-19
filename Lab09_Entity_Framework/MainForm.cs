﻿using Lab09_Entity_Framework.Models;

namespace Lab09_Entity_Framework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }
        private List<Category> GetCategories()
        {
            // Khởi tạo đối tượng context
            var dbContext = new RestaurantContext();

            // Lấy danh sách tất cả nhóm thức ăn, sắp xếp theo tên
            return dbContext.Categories.OrderBy(x => x.Name).ToList();
        }
        private void ShowCategories()
        {
            // Xóa tất cả các nút hiện có trên cây
            tvwCategory.Nodes.Clear();

            // Tạo danh sách các loại nhóm thức ăn, đồ uống
            // Tên của các loại này được hiển thị trên các nút mức 2
            var cateMap = new Dictionary<CategoryType, string>()
            {
                    { CategoryType.Food, "Đồ ăn" },
                    { CategoryType.Drink, "Thức uống" }
            };

            // Tạo nút gốc của cây
            var rootNode = tvwCategory.Nodes.Add("Tất cả");

            // Lấy danh sách nhóm đồ ăn, thức uống
            var categories = GetCategories();

            // Duyệt qua các loại nhóm thức ăn
            foreach (var cateType in cateMap)
            {
                // Tạo các nút tương ứng với loại nhóm thức ăn
                var childNode = rootNode.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType.Key;

                // Duyệt qua các nhóm thức ăn
                foreach (var category in categories)
                {
                    // Nếu nhóm đang xét không cùng loại thì bỏ qua
                    if (category.Type != cateType.Key) continue;

                    // Ngược lại, tạo các nút tương ứng trên cây
                    var grandChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                    grandChildNode.Tag = category;
                }
            }

            // Mở rộng các nhánh của cây để thấy hết tất cả các nhóm thức ăn
            tvwCategory.ExpandAll();

            // Đánh dấu nút gốc đang được chọn
            tvwCategory.SelectedNode = rootNode;
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }
        private List<FoodModel> GetFoodByCategory(int categoryId)
        {
            var dbContext = new RestaurantContext();
            var foods = dbContext.Foods.AsQueryable();

            if (categoryId != null && categoryId > 0)
            {
                foods = foods.Where(x => x.FoodCategoryId == categoryId);
            }

            return foods
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }
        private List<FoodModel> GetFoodByCategoryType(CategoryType cateType)
        {
            var dbContext = new RestaurantContext();

            return dbContext.Foods
                .Where(x => x.Category.Type == cateType)
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }
        private void ShowFoodsForNode(TreeNode node)
        {
            // Xóa danh sách thực đơn hiện tại khỏi listview
            lvwFood.Items.Clear();

            // Nếu node = null, không cần xử lý gì thêm
            if (node == null) return;

            // Tạo danh sách để chứa danh sách các món ăn tìm được
            List<FoodModel> foods = null;

            // Nếu nút được chọn trên TreeView tương ứng với 
            // loại nhóm thức ăn (Category Type) (mức thứ 2 trên cây)
            if (node.Level == 1)
            {
                // Thì lấy danh sách món ăn theo loại nhóm
                var categoryType = (CategoryType)node.Tag;
                foods = GetFoodByCategoryType(categoryType);
            }
            else
            {
                // Ngược lại, lấy danh sách món ăn theo thể loại 
                // hoặc lấy hết danh sách món ăn thì lấy hết
                var category = node.Tag as Category;
                foods = GetFoodByCategory(category?.Id);
            }

            // Gọi hàm để hiển thị các món ăn lên ListView
            ShowFoodsOnListView(foods);
        }
        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            foreach (var foodItem in foods)
            {
                // Tạo item tương ứng trên ListView
                var item = lvwFood.Items.Add(foodItem.Id.ToString());

                // Và hiển thị các thông tin của món ăn
                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }
    }
}
