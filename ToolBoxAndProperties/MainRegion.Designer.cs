namespace ToolBoxAndProperties
{
    partial class MainRegion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRegion));
            this.btn_toolBox = new System.Windows.Forms.Button();
            this.btn_properties = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_toolBox
            // 
            this.btn_toolBox.Location = new System.Drawing.Point(233, 229);
            this.btn_toolBox.Name = "btn_toolBox";
            this.btn_toolBox.Size = new System.Drawing.Size(122, 55);
            this.btn_toolBox.TabIndex = 2;
            this.btn_toolBox.Text = "ToolBox";
            this.btn_toolBox.UseVisualStyleBackColor = true;
            this.btn_toolBox.Click += new System.EventHandler(this.btn_toolBox_Click);
            // 
            // btn_properties
            // 
            this.btn_properties.Location = new System.Drawing.Point(361, 229);
            this.btn_properties.Name = "btn_properties";
            this.btn_properties.Size = new System.Drawing.Size(122, 55);
            this.btn_properties.TabIndex = 3;
            this.btn_properties.Text = "Properties";
            this.btn_properties.UseVisualStyleBackColor = true;
            this.btn_properties.Click += new System.EventHandler(this.btn_properties_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_description.Location = new System.Drawing.Point(12, 48);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(735, 60);
            this.lbl_description.TabIndex = 0;
            this.lbl_description.Text = resources.GetString("lbl_description.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(93, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şimdi ise hatırlayamadığın veya öğrenmek istediğin sekmenin butonuna tıklayabilir" +
    "sin";
            // 
            // MainRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.btn_properties);
            this.Controls.Add(this.btn_toolBox);
            this.Name = "MainRegion";
            this.Text = "MainRegion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_toolBox;
        private System.Windows.Forms.Button btn_properties;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label label1;
    }
}