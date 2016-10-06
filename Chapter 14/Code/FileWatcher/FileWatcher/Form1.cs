using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace FileWatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            changesList.Items.Add(e.Name + " changed.");
        }

        private void watcher_Created(object sender, FileSystemEventArgs e)
        {
            changesList.Items.Add(e.Name + " was created.");
        }

        private void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            changesList.Items.Add(e.Name + " was deleted.");
        }

        private void watcher_Renamed(object sender, RenamedEventArgs e)
        {
            changesList.Items.Add(e.Name + " was renamed.");
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                folderLabel.Text = folderDialog.SelectedPath;
                watcher.Path = folderDialog.SelectedPath;
                watcher.IncludeSubdirectories = true;
                watcher.Filter = "*.*";
                watcher.EnableRaisingEvents = true;
            }
        }
    }
}