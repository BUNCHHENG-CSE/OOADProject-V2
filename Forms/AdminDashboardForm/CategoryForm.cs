using Microsoft.IdentityModel.Tokens;
using OOADPROV2.Models;
using OOADPROV2.Utilities;
using OOADPROV2.Utilities.Commands.Category;
using OOADPROV2.Utilities.Function;
using OOADPROV2.Utilities.Observer;
using OOADPROV2.Utilities.Observer.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPROV2.Forms.AdminDashboardForm;

public partial class CategoryForm : Form, IObservers<Categories> 
{
    Categories? effectedCategory = null;
    private readonly CatgoryNotifier _categoryNotifier = new();
    public CategoryForm()
    {
        InitializeComponent();
        btnAddCategory.Click += DoClickAddCategory;
        btnClickDelete.Click += DoClickDeleteCategory;
        btnClickUpdate.Click += DoClickUpdateCategory;
        dgvCategory.CellClick += Select_Handling_Category;
        _categoryNotifier.Attach(this);
    }

    private void Select_Handling_Category(object? sender, EventArgs e)
    {
        if (dgvCategory.CurrentRow == null) return;
        int no = (int)dgvCategory.CurrentRow.Cells["CategoryID"].Value;
        try
        {
            effectedCategory = CategoryGet.One(no);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Here: {ex.Message}");
        }
    }

    private void DoClickUpdateCategory(object? sender, EventArgs e)
    {
        AddCategoryForm categoryAddForm = new (_categoryNotifier);
        categoryAddForm.LoadCategoryToUpdate(effectedCategory);
        categoryAddForm.Show();
    }

    private void DoClickDeleteCategory(object? sender, EventArgs e)
    {
        _ = int.TryParse(effectedCategory.CategoryID.ToString(), out int id);
        bool isDeleted = CategoryCommands.DeleteCategory(id);
        if (isDeleted)
        {
            MessageBox.Show("Category deleted successfully!");
            LoadingDataCategory();
        }
        else
        {
            MessageBox.Show("Failed to delete the category member.");
        }
    }

    private void DoClickAddCategory(object? sender, EventArgs e)
    {
        AddCategoryForm categoryAddForm = new(_categoryNotifier);
        
        categoryAddForm.Show();
    }

    private void CategoryForm_Load(object sender, EventArgs e)
    {
        LoadingDataCategory();
    }
    private void LoadingDataCategory()
    {
        try
        {
            var result = CategoryGet.All();
            dgvCategory.Rows.Clear();
            foreach (var category in result)
            {
                
                dgvCategory.Rows.Add(category.CategoryID, category.CategoryName, category.CategoryDescription);
            }
            Database.Instance.CloseConnection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void Update(Categories data)
    {
        LoadingDataCategory();
    }
}
