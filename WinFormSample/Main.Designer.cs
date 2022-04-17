namespace WinFormSample;

partial class Main
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
            this.btnLoadData = new System.Windows.Forms.Button();
            this.cboxNames = new System.Windows.Forms.ComboBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.GetUser = new System.Windows.Forms.Button();
            this.PutUser = new System.Windows.Forms.Button();
            this.PostUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(12, 287);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(96, 96);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // cboxNames
            // 
            this.cboxNames.FormattingEnabled = true;
            this.cboxNames.Location = new System.Drawing.Point(12, 30);
            this.cboxNames.Name = "cboxNames";
            this.cboxNames.Size = new System.Drawing.Size(151, 28);
            this.cboxNames.TabIndex = 1;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(12, 111);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(137, 27);
            this.TextBoxFirstName.TabIndex = 2;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(12, 166);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(137, 27);
            this.TextBoxLastName.TabIndex = 3;
            // 
            // GetUser
            // 
            this.GetUser.Location = new System.Drawing.Point(114, 287);
            this.GetUser.Name = "GetUser";
            this.GetUser.Size = new System.Drawing.Size(112, 96);
            this.GetUser.TabIndex = 4;
            this.GetUser.Text = "GetUser";
            this.GetUser.UseVisualStyleBackColor = true;
            this.GetUser.Click += new System.EventHandler(this.GetUser_Click);
            // 
            // PutUser
            // 
            this.PutUser.Location = new System.Drawing.Point(232, 287);
            this.PutUser.Name = "PutUser";
            this.PutUser.Size = new System.Drawing.Size(112, 96);
            this.PutUser.TabIndex = 5;
            this.PutUser.Text = "PutUser";
            this.PutUser.UseVisualStyleBackColor = true;
            this.PutUser.Click += new System.EventHandler(this.PutUser_Click);
            // 
            // PostUser
            // 
            this.PostUser.Location = new System.Drawing.Point(350, 287);
            this.PostUser.Name = "PostUser";
            this.PostUser.Size = new System.Drawing.Size(112, 96);
            this.PostUser.TabIndex = 6;
            this.PostUser.Text = "PostUser";
            this.PostUser.UseVisualStyleBackColor = true;
            this.PostUser.Click += new System.EventHandler(this.PostUser_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(473, 287);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(112, 96);
            this.DeleteUser.TabIndex = 7;
            this.DeleteUser.Text = "Delete User";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.PostUser);
            this.Controls.Add(this.PutUser);
            this.Controls.Add(this.GetUser);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.cboxNames);
            this.Controls.Add(this.btnLoadData);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button btnLoadData;
    private ComboBox cboxNames;
    private TextBox TextBoxFirstName;
    private TextBox TextBoxLastName;
    private Button GetUser;
    private Button PutUser;
    private Button PostUser;
    private Button DeleteUser;
}
