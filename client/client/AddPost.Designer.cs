namespace client
{
    partial class AddPost
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
            this.lblposttitle = new System.Windows.Forms.Label();
            this.lblpostcategory = new System.Windows.Forms.Label();
            this.lblpostdescription = new System.Windows.Forms.Label();
            this.txtposttitle = new System.Windows.Forms.TextBox();
            this.txtpostdescription = new System.Windows.Forms.TextBox();
            this.cmdaddpost = new System.Windows.Forms.Button();
            this.txtpostcategory = new System.Windows.Forms.TextBox();
            this.lblapprovelrequest = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblposttitle
            // 
            this.lblposttitle.AutoSize = true;
            this.lblposttitle.Location = new System.Drawing.Point(77, 33);
            this.lblposttitle.Name = "lblposttitle";
            this.lblposttitle.Size = new System.Drawing.Size(51, 13);
            this.lblposttitle.TabIndex = 0;
            this.lblposttitle.Text = "Post Title";
            // 
            // lblpostcategory
            // 
            this.lblpostcategory.AutoSize = true;
            this.lblpostcategory.Location = new System.Drawing.Point(77, 118);
            this.lblpostcategory.Name = "lblpostcategory";
            this.lblpostcategory.Size = new System.Drawing.Size(73, 13);
            this.lblpostcategory.TabIndex = 1;
            this.lblpostcategory.Text = "Post Category";
            // 
            // lblpostdescription
            // 
            this.lblpostdescription.AutoSize = true;
            this.lblpostdescription.Location = new System.Drawing.Point(77, 215);
            this.lblpostdescription.Name = "lblpostdescription";
            this.lblpostdescription.Size = new System.Drawing.Size(84, 13);
            this.lblpostdescription.TabIndex = 2;
            this.lblpostdescription.Text = "Post Description";
            // 
            // txtposttitle
            // 
            this.txtposttitle.Location = new System.Drawing.Point(206, 33);
            this.txtposttitle.Name = "txtposttitle";
            this.txtposttitle.Size = new System.Drawing.Size(100, 20);
            this.txtposttitle.TabIndex = 3;
            this.txtposttitle.TextChanged += new System.EventHandler(this.txtposttitle_TextChanged);
            // 
            // txtpostdescription
            // 
            this.txtpostdescription.Location = new System.Drawing.Point(206, 212);
            this.txtpostdescription.Multiline = true;
            this.txtpostdescription.Name = "txtpostdescription";
            this.txtpostdescription.Size = new System.Drawing.Size(190, 124);
            this.txtpostdescription.TabIndex = 4;
            // 
            // cmdaddpost
            // 
            this.cmdaddpost.Location = new System.Drawing.Point(321, 342);
            this.cmdaddpost.Name = "cmdaddpost";
            this.cmdaddpost.Size = new System.Drawing.Size(75, 23);
            this.cmdaddpost.TabIndex = 6;
            this.cmdaddpost.Text = "Add Post";
            this.cmdaddpost.UseVisualStyleBackColor = true;
            this.cmdaddpost.Click += new System.EventHandler(this.cmdaddpost_Click);
            // 
            // txtpostcategory
            // 
            this.txtpostcategory.Location = new System.Drawing.Point(206, 118);
            this.txtpostcategory.Name = "txtpostcategory";
            this.txtpostcategory.Size = new System.Drawing.Size(100, 20);
            this.txtpostcategory.TabIndex = 7;
            // 
            // lblapprovelrequest
            // 
            this.lblapprovelrequest.AutoSize = true;
            this.lblapprovelrequest.Location = new System.Drawing.Point(77, 342);
            this.lblapprovelrequest.Name = "lblapprovelrequest";
            this.lblapprovelrequest.Size = new System.Drawing.Size(92, 13);
            this.lblapprovelrequest.TabIndex = 8;
            this.lblapprovelrequest.TabStop = true;
            this.lblapprovelrequest.Text = "Approvel Request";
            this.lblapprovelrequest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblapprovelrequest_LinkClicked);
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 376);
            this.Controls.Add(this.lblapprovelrequest);
            this.Controls.Add(this.txtpostcategory);
            this.Controls.Add(this.cmdaddpost);
            this.Controls.Add(this.txtpostdescription);
            this.Controls.Add(this.txtposttitle);
            this.Controls.Add(this.lblpostdescription);
            this.Controls.Add(this.lblpostcategory);
            this.Controls.Add(this.lblposttitle);
            this.Name = "AddPost";
            this.Text = "AddPost";
            this.Load += new System.EventHandler(this.AddPost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblposttitle;
        private System.Windows.Forms.Label lblpostcategory;
        private System.Windows.Forms.Label lblpostdescription;
        private System.Windows.Forms.TextBox txtposttitle;
        private System.Windows.Forms.TextBox txtpostdescription;
        private System.Windows.Forms.Button cmdaddpost;
        private System.Windows.Forms.TextBox txtpostcategory;
        private System.Windows.Forms.LinkLabel lblapprovelrequest;
    }
}