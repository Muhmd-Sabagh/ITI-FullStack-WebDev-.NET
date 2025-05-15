using EF_CodeFirstModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CodeFirstModel
{
    public partial class FormHome : Form
    {
        private string _username;
        private int _userID;

        NewspaperContext NewspaperDb;
        public FormHome(string username, int id)
        {
            InitializeComponent();
            _username = username;
            _userID = id;
            NewspaperDb = new NewspaperContext();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome {_username}";

            var News = NewspaperDb.News
                .Select(n => new
                {
                    n.Id,
                    n.Title,
                    n.Brief,
                    n.Description,
                    n.PublishDate,
                    Category = n.Category.Name,
                    Author = n.Author.Name,
                    n.Cat_Id,
                    n.Auth_Id
                });

            ResetBtns();
            LoadCategoryCbsData();


            if (_userID == 1)
            {
                DgvNews.DataSource = News.ToList();
                DgvNews.Columns["Cat_Id"].Visible = false;
                DgvNews.Columns["Auth_Id"].Visible = false;

                BtnAccDel.Visible = false;

                LoadAuthorCbsData();
            }
            else
            {
                DgvNews.DataSource = News.Where(n => n.Auth_Id == _userID).ToList();
                DgvNews.Columns["Cat_Id"].Visible = false;
                DgvNews.Columns["Auth_Id"].Visible = false;
                cbNewsAuthor.SelectedValue = _userID;

                cbAuthor.Visible = cbCategory.Visible = cbNewsAuthor.Visible = txtCatName.Visible = rtbCatDesc.Visible = false;
                lblAuthor.Visible = lblCategories.Visible = lblAuthors.Visible = lblCatName.Visible = lblCatDesc.Visible = lblCatName1.Visible = lblAuthName.Visible = false;
                BtnAuthDel.Visible = BtnCatDel.Visible = BtnCatAdd.Visible = false;
            }
        }

        private void LoadCategoryCbsData()
        {
            cbNewsCategory.DataSource = cbCategory.DataSource = NewspaperDb.Categories.ToList();
            cbNewsCategory.ValueMember = cbCategory.ValueMember = "Id";
            cbNewsCategory.DisplayMember = cbCategory.DisplayMember = "Name";
        }

        private void LoadAuthorCbsData()
        {
            cbNewsAuthor.DataSource = cbAuthor.DataSource = NewspaperDb.Authors.Skip(1).ToList();
            cbNewsAuthor.ValueMember = cbAuthor.ValueMember = "Id";
            cbNewsAuthor.DisplayMember = cbAuthor.DisplayMember = "Name";
        }

        private void ResetFields()
        {
            txtTitle.Text = txtBrief.Text = rtbDesc.Text = txtCatName.Text = rtbCatDesc.Text = "";
            cbNewsCategory.SelectedIndex = cbNewsAuthor.SelectedIndex = cbCategory.SelectedIndex = cbAuthor.SelectedIndex = -1;
        }

        private void ResetBtns()
        {
            BtnAdd.Enabled = true;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            BtnCancel.Enabled = false;
        }

        private void BtnCatAdd_Click(object sender, EventArgs e)
        {
            NewspaperDb.Categories
                .Add(new Category
                {
                    Name = txtCatName.Text,
                    Description = rtbCatDesc.Text
                });

            NewspaperDb.SaveChanges();
            LoadCategoryCbsData();
            ResetFields();

            MessageBox.Show("Category Added Successfully.");
        }

        private void BtnCatDel_Click(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex != -1)
            {
                int catId = (int)cbCategory.SelectedValue;
                Category delCat = NewspaperDb.Categories.Where(c => c.Id == catId).FirstOrDefault();
                NewspaperDb.Categories.Remove(delCat);

                NewspaperDb.SaveChanges();
                LoadCategoryCbsData();
                ResetFields();

                MessageBox.Show("Category Deleted Successfully.");
            }
            else
            {
                MessageBox.Show("Choose a Category To Delete.");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            NewspaperDb.News
                .Add(new News
                {
                    Title = txtTitle.Text,
                    Brief = txtBrief.Text,
                    Description = rtbDesc.Text,
                    PublishDate = dtpPublishDate.Value,
                    Cat_Id = (int)cbNewsCategory.SelectedValue,
                    Auth_Id = (int)cbNewsAuthor.SelectedValue
                });

            NewspaperDb.SaveChanges();
            DgvNews.DataSource = NewspaperDb.News.ToList();
            ResetFields();

            MessageBox.Show("News Added Successfully.");
        }

        News selectedNews;
        private void DgvNews_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int newsId = (int)DgvNews.SelectedRows[0].Cells[0].Value;

            selectedNews = NewspaperDb.News.Where(n => n.Id == newsId).FirstOrDefault();

            txtTitle.Text = selectedNews.Title;
            txtBrief.Text = selectedNews.Brief;
            rtbDesc.Text = selectedNews.Description;
            dtpPublishDate.Value = selectedNews.PublishDate;
            cbNewsCategory.SelectedValue = selectedNews.Cat_Id;
            cbNewsAuthor.SelectedValue = selectedNews.Auth_Id;

            BtnAdd.Enabled = false;
            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            BtnCancel.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetFields();
            ResetBtns();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            selectedNews.Title = txtTitle.Text;
            selectedNews.Brief = txtBrief.Text;
            selectedNews.Description = rtbDesc.Text;
            selectedNews.PublishDate = dtpPublishDate.Value;
            selectedNews.Cat_Id = (int)cbNewsCategory.SelectedValue;
            selectedNews.Auth_Id = (int)cbNewsAuthor.SelectedValue;

            NewspaperDb.SaveChanges();
            DgvNews.DataSource = NewspaperDb.News.ToList();
            ResetFields();
            ResetBtns();

            MessageBox.Show("News Information Updated");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            NewspaperDb.News.Remove(selectedNews);
            NewspaperDb.SaveChanges();

        }
    }
}
