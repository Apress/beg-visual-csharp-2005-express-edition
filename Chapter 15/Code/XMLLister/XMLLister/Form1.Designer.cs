namespace XMLLister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getXML = new System.Windows.Forms.Button();
            this.xmlList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // getXML
            // 
            this.getXML.Location = new System.Drawing.Point(12, 12);
            this.getXML.Name = "getXML";
            this.getXML.Size = new System.Drawing.Size(194, 30);
            this.getXML.TabIndex = 0;
            this.getXML.Text = "Get the XML";
            this.getXML.UseVisualStyleBackColor = true;
            this.getXML.Click += new System.EventHandler(this.getXML_Click);
            // 
            // xmlList
            // 
            this.xmlList.FormattingEnabled = true;
            this.xmlList.ItemHeight = 16;
            this.xmlList.Location = new System.Drawing.Point(12, 48);
            this.xmlList.Name = "xmlList";
            this.xmlList.Size = new System.Drawing.Size(471, 340);
            this.xmlList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 401);
            this.Controls.Add(this.xmlList);
            this.Controls.Add(this.getXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getXML;
        private System.Windows.Forms.ListBox xmlList;
    }
}

