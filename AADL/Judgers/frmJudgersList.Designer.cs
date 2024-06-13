﻿namespace AADL.Judgers
{
    partial class frmJudgersList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJudgersList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJudgers = new System.Windows.Forms.DataGridView();
            this.lblTotalRecordsCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.cbPage = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cmsJudgers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivateJudgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteJudgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJudgers)).BeginInit();
            this.cmsJudgers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Name = "label1";
            // 
            // dgvJudgers
            // 
            this.dgvJudgers.AllowUserToAddRows = false;
            this.dgvJudgers.AllowUserToDeleteRows = false;
            this.dgvJudgers.AllowUserToOrderColumns = true;
            this.dgvJudgers.AllowUserToResizeRows = false;
            this.dgvJudgers.BackgroundColor = System.Drawing.Color.White;
            this.dgvJudgers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvJudgers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJudgers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvJudgers, "dgvJudgers");
            this.dgvJudgers.GridColor = System.Drawing.Color.DarkGray;
            this.dgvJudgers.Name = "dgvJudgers";
            this.dgvJudgers.ReadOnly = true;
            this.dgvJudgers.RowTemplate.Height = 25;
            this.dgvJudgers.StandardTab = true;
            this.dgvJudgers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJudgers_CellContentDoubleClick);
            this.dgvJudgers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvJudgers_CellMouseDown);
            // 
            // lblTotalRecordsCount
            // 
            resources.ApplyResources(this.lblTotalRecordsCount, "lblTotalRecordsCount");
            this.lblTotalRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRecordsCount.Name = "lblTotalRecordsCount";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbFilterBy, "cbFilterBy");
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            resources.GetString("cbFilterBy.Items"),
            resources.GetString("cbFilterBy.Items1"),
            resources.GetString("cbFilterBy.Items2"),
            resources.GetString("cbFilterBy.Items3"),
            resources.GetString("cbFilterBy.Items4")});
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // cbPage
            // 
            this.cbPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbPage, "cbPage");
            this.cbPage.FormattingEnabled = true;
            this.cbPage.Name = "cbPage";
            this.cbPage.SelectedIndexChanged += new System.EventHandler(this.cbPage_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtFilterValue, "txtFilterValue");
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cmsJudgers
            // 
            resources.ApplyResources(this.cmsJudgers, "cmsJudgers");
            this.cmsJudgers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsJudgers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem,
            this.deactivateJudgerToolStripMenuItem,
            this.deleteJudgerToolStripMenuItem});
            this.cmsJudgers.Name = "cmsJudgers";
            // 
            // showInfoToolStripMenuItem
            // 
            this.showInfoToolStripMenuItem.Image = global::AADL.Properties.Resources.show_info_32;
            resources.ApplyResources(this.showInfoToolStripMenuItem, "showInfoToolStripMenuItem");
            this.showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            this.showInfoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.showInfoToolStripMenuItem.Click += new System.EventHandler(this.showInfoToolStripMenuItem_Click);
            // 
            // deactivateJudgerToolStripMenuItem
            // 
            this.deactivateJudgerToolStripMenuItem.Image = global::AADL.Properties.Resources.deactivate_32;
            resources.ApplyResources(this.deactivateJudgerToolStripMenuItem, "deactivateJudgerToolStripMenuItem");
            this.deactivateJudgerToolStripMenuItem.Name = "deactivateJudgerToolStripMenuItem";
            this.deactivateJudgerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.deactivateJudgerToolStripMenuItem.Click += new System.EventHandler(this.deactivateJudgerToolStripMenuItem_Click);
            // 
            // deleteJudgerToolStripMenuItem
            // 
            this.deleteJudgerToolStripMenuItem.Image = global::AADL.Properties.Resources.delete_judger_32;
            resources.ApplyResources(this.deleteJudgerToolStripMenuItem, "deleteJudgerToolStripMenuItem");
            this.deleteJudgerToolStripMenuItem.Name = "deleteJudgerToolStripMenuItem";
            this.deleteJudgerToolStripMenuItem.Click += new System.EventHandler(this.deleteJudgerToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AADL.Properties.Resources.judge_512;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmJudgersList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbPage);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalRecordsCount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvJudgers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmJudgersList";
            this.Load += new System.EventHandler(this.frmJudgersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJudgers)).EndInit();
            this.cmsJudgers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvJudgers;
        private System.Windows.Forms.Label lblTotalRecordsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.ComboBox cbPage;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ContextMenuStrip cmsJudgers;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivateJudgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteJudgerToolStripMenuItem;
    }
}