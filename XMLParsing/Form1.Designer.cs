namespace XMLParsing
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
            this.btnFindingChildren = new System.Windows.Forms.Button();
            this.btnGetElementByTagName = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindingChildren
            // 
            this.btnFindingChildren.Location = new System.Drawing.Point(109, 21);
            this.btnFindingChildren.Name = "btnFindingChildren";
            this.btnFindingChildren.Size = new System.Drawing.Size(100, 59);
            this.btnFindingChildren.TabIndex = 7;
            this.btnFindingChildren.Text = "Get Stock Names";
            this.btnFindingChildren.UseVisualStyleBackColor = true;
            this.btnFindingChildren.Click += new System.EventHandler(this.btnFindingChildren_Click);
            // 
            // btnGetElementByTagName
            // 
            this.btnGetElementByTagName.Location = new System.Drawing.Point(425, 21);
            this.btnGetElementByTagName.Name = "btnGetElementByTagName";
            this.btnGetElementByTagName.Size = new System.Drawing.Size(99, 59);
            this.btnGetElementByTagName.TabIndex = 8;
            this.btnGetElementByTagName.Text = "Get Revision Date";
            this.btnGetElementByTagName.UseVisualStyleBackColor = true;
            this.btnGetElementByTagName.Click += new System.EventHandler(this.btnGetElementByTagName_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(109, 123);
            this.txtResults.Margin = new System.Windows.Forms.Padding(2);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(415, 271);
            this.txtResults.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "Get all nodes and text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReadXMLValues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnGetElementByTagName);
            this.Controls.Add(this.btnFindingChildren);
            this.Name = "Form1";
            this.Text = "Set output as a console application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFindingChildren;
        private System.Windows.Forms.Button btnGetElementByTagName;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button button1;
    }
}

