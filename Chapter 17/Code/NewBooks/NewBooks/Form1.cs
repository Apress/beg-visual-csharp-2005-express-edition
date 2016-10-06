using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace NewBooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bookCheckButton_Click(object sender, EventArgs e)
        {
            GetWebPage("http://www.apress.com/book/forthcoming.html");
        }

        private MatchCollection GetBookDetailsFromWebPage(string webPage)
        {
            // Use a regex here to find all the book info
            Regex newBooksRegEx =
                new Regex(
                "<a href=\"(/book/bookDisplay\\.html\\?bID=[0-9]+)\">([^<]+)</a>",
                RegexOptions.Singleline);

            return newBooksRegEx.Matches(webPage);
        }

        private void AddBooksToListBox(MatchCollection books)
        {
            foreach (Match bookMatch in books)
            {
                bookList.Items.Add(
                    new Book(bookMatch.Groups[2].Value, bookMatch.Groups[1].Value)
                );

            }
        }

        
        private void GetWebPage(string url)
        {
            WebClient web = new WebClient();

            web.DownloadStringCompleted += 
                new DownloadStringCompletedEventHandler(DownloadComplete);
            web.DownloadProgressChanged += 
                new DownloadProgressChangedEventHandler(ProgressChanged);

            bookList.Items.Clear();
            web.DownloadStringAsync(new System.Uri(url));
        }


        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            downloadProgress.Value = e.ProgressPercentage;
        }

        private void DownloadComplete(object sender, DownloadStringCompletedEventArgs e)
        {

                downloadProgress.Value = 100;
                if (!e.Cancelled)
                {
                    string newBooksPage = e.Result;

                    AddBooksToListBox(
                        GetBookDetailsFromWebPage(newBooksPage)

                    );
                }
 
        }

        private void bookList_DoubleClick(object sender, EventArgs e)
        {
            if (bookList.SelectedIndex != -1)
            {
                Book selectedBook = (Book)bookList.SelectedItem;
                browser.Navigate("http://www.apress.com/" + selectedBook.BookURL, true);
            }
        }
    }
}