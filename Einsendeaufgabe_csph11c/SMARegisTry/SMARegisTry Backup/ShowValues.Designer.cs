namespace SMARegisTry_Backup
{
    partial class ShowValues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowValues));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.registryTreeSubView = new System.Windows.Forms.TreeView();
            this.addSubKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BulletIndent = 1;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(17, 249);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(517, 125);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Additional Keys:";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(17, 395);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 35);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&Close";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // registryTreeSubView
            // 
            this.registryTreeSubView.Location = new System.Drawing.Point(17, 40);
            this.registryTreeSubView.Name = "registryTreeSubView";
            this.registryTreeSubView.Size = new System.Drawing.Size(517, 124);
            this.registryTreeSubView.TabIndex = 3;
            this.registryTreeSubView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.registryTreeSubView_AfterSelect);
            // 
            // addSubKey
            // 
            this.addSubKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubKey.Location = new System.Drawing.Point(17, 175);
            this.addSubKey.Name = "addSubKey";
            this.addSubKey.Size = new System.Drawing.Size(182, 35);
            this.addSubKey.TabIndex = 4;
            this.addSubKey.Text = "&Add Key To Main List";
            this.addSubKey.UseVisualStyleBackColor = true;
            this.addSubKey.Click += new System.EventHandler(this.addSubKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Keys in Key / Values:";
            // 
            // ShowValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addSubKey);
            this.Controls.Add(this.registryTreeSubView);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowValues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Contents";
            this.Load += new System.EventHandler(this.ShowValues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TreeView registryTreeSubView;
        private System.Windows.Forms.Button addSubKey;
        private System.Windows.Forms.Label label2;
    }
}