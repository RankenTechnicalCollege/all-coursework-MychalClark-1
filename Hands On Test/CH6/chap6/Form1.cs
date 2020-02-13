using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] books = { "The Great Gatsby", "War and Peace", "Moby-Dick","Hamlet","Pride and Prejudice" };
        string[] descriptions = { "The Story of eccentric millionaire Jay Gatsby and his pursuit of his lost love.", "A fictional story about the 1812 French invasion of Russia.", "The story of a sailor's relentless hunt for a white whale", "A Sshakespearean tragedy about a young man coming home from college after the murder of his father. ", "A comedic story of love and life in Old England." };
         string[] authors = { "F. Scott Fitzgerald", "Leo Tolstoy", "Herman Melville", "William Shakespeare", "Jane Austen" };
        string[] isbns = { "978-1847496140", "978-1400079988", "978-1503280786", "978-1973844402", "978-0141439518" };
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text;
          int index =  SearchByAuthor(author);

            ShowBook(index);

        }
        private int SearchByAuthor(string author) {
            int idx = 0;
            author.ToLower();

            for (int i = 0; i < authors.Length; i++)
            {
                if (authors[i].ToLower().Contains(author)) { idx = i; break; }
                else { idx = 6; }
            }
            return idx;
                }

        private void ShowBook(int index)
        {
            if (index == 6) { lblAuthor.Text = "Item Not Found"; lblDescript.Text = "Item Not Found"; lblName.Text = "Item Not Found"; lblIsbn.Text = "Item Not Found"; }
            else { lblAuthor.Text = $"{authors[index]}"; lblDescript.Text = $"{descriptions[index]}"; lblName.Text = $"{books[index]}"; lblIsbn.Text = $"{isbns[index]}"; }
            return;
            
        }

        private void btnKeyword_Click(object sender, EventArgs e)
        {
            string key = txtKeyword.Text;
            int index = SearchByKeyword(key);

            ShowBook(index);

        }
        private int SearchByKeyword(string key) {
            int idx = 0;
            key.ToLower();

            for (int i = 0; i < descriptions.Length; i++)
            {
                if (descriptions[i].ToLower().Contains(key) || books[i].ToLower().Contains(key)) { idx = i; break; }
                else { idx = 6; }
            }
            return idx;
        }

        private void btnIsbn_Click(object sender, EventArgs e)
        {
            string isbn = txtIsbn.Text;
            int index = SearchByIsbn(isbn);

            ShowBook(index);

        }
        private int SearchByIsbn(string isbn) {
            int idx = 0;
            

            for (int i = 0; i < isbns.Length; i++)
            {
                if (isbns[i].Contains(isbn)) { idx = i; break; }
                else { idx = 6; }
            }
            return idx;
        }
    }
    }
