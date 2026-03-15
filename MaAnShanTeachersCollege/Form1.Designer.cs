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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogoMain = new System.Windows.Forms.PictureBox();
            this.picLogoSecondary = new System.Windows.Forms.PictureBox();
            this.tlPanelContainer.SuspendLayout();
            this.tlPanelContent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSecondary)).BeginInit();
            this.SuspendLayout();
            // 
            // tlPanelContainer
            // 
            this.tlPanelContainer.BackColor = System.Drawing.SystemColors.Highlight;
            this.tlPanelContainer.ColumnCount = 1;
            this.tlPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelContainer.Controls.Add(this.tlPanelContent, 0, 1);
            this.tlPanelContainer.Controls.Add(this.panel1, 0, 0);
            this.tlPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.tlPanelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tlPanelContainer.Name = "tlPanelContainer";
            this.tlPanelContainer.RowCount = 3;
            this.tlPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlPanelContainer.Size = new System.Drawing.Size(1348, 721);
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
            this.tlPanelContent.Location = new System.Drawing.Point(0, 80);
            this.tlPanelContent.Margin = new System.Windows.Forms.Padding(0);
            this.tlPanelContent.Name = "tlPanelContent";
            this.tlPanelContent.RowCount = 1;
            this.tlPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelContent.Size = new System.Drawing.Size(1348, 591);
            this.tlPanelContent.TabIndex = 0;
            // 
            // flPanelMenu
            // 
            this.flPanelMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPanelMenu.Location = new System.Drawing.Point(3, 3);
            this.flPanelMenu.Name = "flPanelMenu";
            this.flPanelMenu.Size = new System.Drawing.Size(234, 585);
            this.flPanelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.picLogoSecondary);
            this.panel1.Controls.Add(this.picLogoMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 80);
            this.panel1.TabIndex = 1;
            // 
            // picLogoMain
            // 
            this.picLogoMain.Image = global::MaAnShanTeachersCollege.Properties.Resources.LogoMain;
            this.picLogoMain.Location = new System.Drawing.Point(3, 3);
            this.picLogoMain.Name = "picLogoMain";
            this.picLogoMain.Size = new System.Drawing.Size(555, 71);
            this.picLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoMain.TabIndex = 0;
            this.picLogoMain.TabStop = false;
            // 
            // picLogoSecondary
            // 
            this.picLogoSecondary.Image = global::MaAnShanTeachersCollege.Properties.Resources.LogoSecondary;
            this.picLogoSecondary.Location = new System.Drawing.Point(564, 24);
            this.picLogoSecondary.Name = "picLogoSecondary";
            this.picLogoSecondary.Size = new System.Drawing.Size(555, 50);
            this.picLogoSecondary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoSecondary.TabIndex = 1;
            this.picLogoSecondary.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.tlPanelContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tlPanelContainer.ResumeLayout(false);
            this.tlPanelContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSecondary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanelContainer;
        private System.Windows.Forms.TableLayoutPanel tlPanelContent;
        private System.Windows.Forms.FlowLayoutPanel flPanelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogoMain;
        private System.Windows.Forms.PictureBox picLogoSecondary;
    }
}

