using OOADPROV2.Models;
using OOADPROV2.Utilities.Commands.Category;
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

public partial class CategoryForm : Form
{
    Categories? effectedCategory = null;
    public CategoryForm()
    {
        InitializeComponent();
        btnAddCategory.Click += DoClickAddCategory;
        btnClickDelete.Click += DoClickDeleteCategory;
        btnClickUpdate.Click += DoClickUpdateCategory;
        dgvCategory.CellClick += Select_Handling_Category;
    }

    private void Select_Handling_Category(object? sender, EventArgs e)
    {
        if (dgvCategory.CurrentRow == null) return;
        int no = (int)dgvCategory.CurrentRow.Cells["CategoryID"].Value;
        try
        {
            effectedCategory = CategoryCommands.GetOneCategory(no);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Here: {ex.Message}");
        }
    }

    private void DoClickUpdateCategory(object? sender, EventArgs e)
    {
        AddCategoryForm categoryAddForm = new ();
        categoryAddForm.LoadCategoryToUpdate(effectedCategory);
        categoryAddForm.CategoryHanlder += (sender, result) =>
        {
            if (result)
                LoadingDataCategory();
        };
        categoryAddForm.Show();
    }

    private void DoClickDeleteCategory(object? sender, EventArgs e)
    {
        int.TryParse(effectedCategory.CategoryID.ToString(), out int id);
        bool isDeleted = CategoryCommands.DeleteCategory(id);
        if (isDeleted)
        {
            MessageBox.Show("Staff deleted successfully!");
            LoadingDataCategory();
        }
        else
        {
            MessageBox.Show("Failed to delete the staff member.");
        }
    }

    private void DoClickAddCategory(object? sender, EventArgs e)
    {
        AddCategoryForm categoryAddForm = new();
        categoryAddForm.CategoryHanlder += (sender, result) =>
        {
            if (result)
                LoadingDataCategory();
        };
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
            var result = CategoryCommands.GetAllCategories();

            dgvCategory.Rows.Clear();
            foreach (var category in result)
            {
                dgvCategory.Rows.Add(category.CategoryID, category.CategoryName, category.CategoryDescription);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
