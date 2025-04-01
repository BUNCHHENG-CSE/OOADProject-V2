using OOADPROV2.Models;
using OOADPROV2.Utilities.Builder.Category;
using OOADPROV2.Utilities.Commands.Category;
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


public partial class AddCategoryForm : Form
{
    int categoryCount = 0;
    Categories? effectedCategory = null;
    private readonly CatgoryNotifier _catgoryNotifier;
    public AddCategoryForm(CatgoryNotifier notifier)
    {
        InitializeComponent();
        _catgoryNotifier = notifier;
        btnClear.Click += DoClickClearFormInput;
        btnInsert.Click += DoClickInsertCategory;
        btnUpdate.Click += DoClickUpdateCategory;
    }

    private void DoClickUpdateCategory(object? sender, EventArgs e)
    {
       
        effectedCategory.CategoryName = txtCategoryName.Text.Trim();
        effectedCategory.CategoryDescription = rtxtCategoryDescription.Text.Trim();

        var (isValid, errorMessage) = CategoryValidatorBuilder.Create().Build().Validate(effectedCategory);
        if (!isValid)
        {
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        try
        {
            var result = CategoryCommands.UpdateCategory(effectedCategory);
            if (result == true)
            {
                MessageBox.Show($"Successfully updated category with the id {txtCategoryID.Text}");
               _catgoryNotifier.Notify(effectedCategory);
            }
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void DoClickInsertCategory(object? sender, EventArgs e)
    {
        
        Categories newcategory = CategoryBuilder.Create()
            .WithCategoryName(txtCategoryName.Text)
            .WithCategoryDescription(rtxtCategoryDescription.Text)
            .Build();
        try
        {
            var result = CategoryCommands.AddCategory(newcategory);
            if (result == true)
            {
                MessageBox.Show($"Successfully inserted category with the id {txtCategoryID.Text}");
                _catgoryNotifier.Notify(newcategory);
            }
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        ClearFormInput();
    }

    private void DoClickClearFormInput(object? sender, EventArgs e)
    {
        ClearFormInput();
    }
    private void AddCategoryForm_Load(object sender, EventArgs e)
    {
        LoadCategory();
        if (txtCategoryName.Text == "")
            txtCategoryID.Text = (categoryCount + 1).ToString();
    }
    private void LoadCategory()
    {
        try
        {
            var result = CategoryCommands.GetAllCategories();

            if (result.LastOrDefault() != null) { categoryCount = result.LastOrDefault().CategoryID; }
            else { categoryCount = 0; }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving category", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void ClearFormInput()
    {
        txtCategoryID.Text = (categoryCount + 1).ToString();
        txtCategoryName.Text = "";
        rtxtCategoryDescription.Text = "";
    }
    public void LoadCategoryToUpdate(Categories category)
    {
        if (category == null)
            MessageBox.Show("Category is null");
        txtCategoryID.Clear();
        txtCategoryID.Text = category.CategoryID.ToString();
        txtCategoryName.Text = category.CategoryName;
        rtxtCategoryDescription.Text = category.CategoryDescription;
        effectedCategory = category;
    }
}
