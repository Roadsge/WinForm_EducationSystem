namespace MaAnShanTeachersCollege
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
            this.tlPanelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.flPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.tlPanelContainer.SuspendLayout();
            this.tlPanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPanelContainer
            // 
            this.tlPanelContainer.BackColor = System.Drawing.SystemColors.Highlight;
            this.tlPanelContainer.ColumnCount = 1;
            this.tlPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelContainer.Controls.Add(this.tlPanelContent, 0, 1);
            this.tlPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.tlPanelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tlPanelContainer.Name = "tlPanelContainer";
            this.tlPanelContainer.RowCount = 3;
            this.tlPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlPanelContainer.Size = new System.Drawing.Size(1067, 547);
            this.tlPanelContainer.TabIndex = 0;
            // 
            // tlPanelContent
            // 
            this.tlPanelContent.BackColor = System.Drawing.SystemColors.Control;
            this.tlPanelContent.ColumnCount = 2;
            this.tlPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tlPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelContent.Controls.Add(this.flPanelMenu, 0, 0);
            this.tlPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelContent.Location = new System.Drawing.Point(3, 83);
            this.tlPanelContent.Name = "tlPanelContent";
            this.tlPanelContent.RowCount = 1;
            this.tlPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelContent.Size = new System.Drawing.Size(1061, 411);
            this.tlPanelContent.TabIndex = 0;
            // 
            // flPanelMenu
            // 
            this.flPanelMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPanelMenu.Location = new System.Drawing.Point(3, 3);
            this.flPanelMenu.Name = "flPanelMenu";
            this.flPanelMenu.Size = new System.Drawing.Size(234, 405);
            this.flPanelMenu.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 547);
            this.Controls.Add(this.tlPanelContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tlPanelContainer.ResumeLayout(false);
            this.tlPanelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanelContainer;
        private System.Windows.Forms.TableLayoutPanel tlPanelContent;
        private System.Windows.Forms.FlowLayoutPanel flPanelMenu;
    }
}

