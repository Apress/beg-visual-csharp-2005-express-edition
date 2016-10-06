using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalcFactorials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                resultsBox.Items.Clear();
                startingNum = long.Parse(startingNumber.Text);
                backgroundWorker1.RunWorkerAsync();
                calcButton.Text = "Cancel";
            }
        }
        private long startingNum;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // This method will run on a thread other than the UI thread.
            // Be sure not to manipulate any Windows Forms controls created
            // on the UI thread from this method.

            for (long currentNum = startingNum;
                currentNum < startingNum + 1000;
                currentNum++)
            {
                lock (backgroundWorker1)
                {
                    if (backgroundWorker1.CancellationPending)
                        return;
                }
                long factorial = 0;
                for (long i = 1; i < currentNum; i++)
                {
                    factorial += i;
                }

                backgroundWorker1.ReportProgress(0,
                    string.Format("The factorial of {0} is {1}",
                    currentNum, factorial));
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultsBox.Items.Add(e.UserState);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            calcButton.Text = "Calculate";
        }
    }
}