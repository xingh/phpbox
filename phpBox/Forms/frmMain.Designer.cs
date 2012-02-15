﻿namespace phpBox
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblSelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTools = new System.Windows.Forms.ToolStrip();
            this.btnFile = new System.Windows.Forms.ToolStripSplitButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTopMost = new System.Windows.Forms.ToolStripButton();
            this.btnExecute = new System.Windows.Forms.ToolStripButton();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.tpScriptFile = new System.Windows.Forms.TabPage();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.tpParameter = new System.Windows.Forms.TabPage();
            this.txtGetParameter = new System.Windows.Forms.TextBox();
            this.tpStartParameter = new System.Windows.Forms.TabPage();
            this.txtStartParameter = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.viewUpdater = new System.Windows.Forms.Timer(this.components);
            this.lblExecTime = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.mainConMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatus.SuspendLayout();
            this.mainTools.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.tpScriptFile.SuspendLayout();
            this.tpParameter.SuspendLayout();
            this.tpStartParameter.SuspendLayout();
            this.mainConMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatus
            // 
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.ToolStripStatusSeparator1,
            this.lblSelCount});
            this.mainStatus.Location = new System.Drawing.Point(0, 556);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(502, 22);
            this.mainStatus.TabIndex = 0;
            this.mainStatus.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 17);
            this.lblStatus.Text = "phpBox - welcome";
            // 
            // ToolStripStatusSeparator1
            // 
            this.ToolStripStatusSeparator1.Name = "ToolStripStatusSeparator1";
            this.ToolStripStatusSeparator1.Size = new System.Drawing.Size(6, 23);
            this.ToolStripStatusSeparator1.Visible = false;
            // 
            // lblSelCount
            // 
            this.lblSelCount.Name = "lblSelCount";
            this.lblSelCount.Size = new System.Drawing.Size(34, 17);
            this.lblSelCount.Text = "Sel: 0";
            this.lblSelCount.Visible = false;
            this.lblSelCount.TextChanged += new System.EventHandler(this.lblSelCount_TextChanged);
            // 
            // mainTools
            // 
            this.mainTools.AllowItemReorder = true;
            this.mainTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTools.AutoSize = false;
            this.mainTools.Dock = System.Windows.Forms.DockStyle.None;
            this.mainTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.toolStripSeparator3,
            this.btnTopMost,
            this.btnExecute});
            this.mainTools.Location = new System.Drawing.Point(0, 57);
            this.mainTools.Name = "mainTools";
            this.mainTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainTools.Size = new System.Drawing.Size(502, 31);
            this.mainTools.Stretch = true;
            this.mainTools.TabIndex = 1;
            this.mainTools.Text = "Tools";
            // 
            // btnFile
            // 
            this.btnFile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.btnFile.Image = global::phpBox.Icons.File;
            this.btnFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(55, 28);
            this.btnFile.Text = "File";
            this.btnFile.ToolTipText = "Additional control functions";
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::phpBox.Icons.About;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "About phpBox";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::phpBox.Icons.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Close phpBox";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // btnTopMost
            // 
            this.btnTopMost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnTopMost.Image = global::phpBox.Icons.TopMost;
            this.btnTopMost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTopMost.Name = "btnTopMost";
            this.btnTopMost.Size = new System.Drawing.Size(71, 28);
            this.btnTopMost.Text = "Top most";
            this.btnTopMost.ToolTipText = "Set phpBox to top most window";
            this.btnTopMost.Click += new System.EventHandler(this.btnTopMost_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Image = global::phpBox.Icons.Start;
            this.btnExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(51, 28);
            this.btnExecute.Text = "Start";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTabs.Controls.Add(this.tpScriptFile);
            this.mainTabs.Controls.Add(this.tpParameter);
            this.mainTabs.Controls.Add(this.tpStartParameter);
            this.mainTabs.Location = new System.Drawing.Point(-5, 2);
            this.mainTabs.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(514, 56);
            this.mainTabs.TabIndex = 2;
            // 
            // tpScriptFile
            // 
            this.tpScriptFile.Controls.Add(this.btnGetFile);
            this.tpScriptFile.Controls.Add(this.txtFilePath);
            this.tpScriptFile.Location = new System.Drawing.Point(4, 25);
            this.tpScriptFile.Name = "tpScriptFile";
            this.tpScriptFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpScriptFile.Size = new System.Drawing.Size(506, 27);
            this.tpScriptFile.TabIndex = 1;
            this.tpScriptFile.Text = "Script File";
            this.tpScriptFile.UseVisualStyleBackColor = true;
            // 
            // btnGetFile
            // 
            this.btnGetFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFile.BackgroundImage = global::phpBox.Icons.Browse;
            this.btnGetFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetFile.Location = new System.Drawing.Point(478, 3);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(25, 23);
            this.btnGetFile.TabIndex = 3;
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.getFile);
            // 
            // txtFilePath
            // 
            this.txtFilePath.AllowDrop = true;
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilePath.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(2, 3);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(475, 23);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFilePath_DragDrop);
            this.txtFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFilePath_DragEnter);
            this.txtFilePath.DoubleClick += new System.EventHandler(this.getFile);
            this.txtFilePath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilePath_KeyDown);
            // 
            // tpParameter
            // 
            this.tpParameter.Controls.Add(this.txtGetParameter);
            this.tpParameter.Location = new System.Drawing.Point(4, 25);
            this.tpParameter.Name = "tpParameter";
            this.tpParameter.Padding = new System.Windows.Forms.Padding(3);
            this.tpParameter.Size = new System.Drawing.Size(506, 27);
            this.tpParameter.TabIndex = 0;
            this.tpParameter.Text = "Parameter String";
            this.tpParameter.UseVisualStyleBackColor = true;
            // 
            // txtGetParameter
            // 
            this.txtGetParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGetParameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetParameter.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetParameter.Location = new System.Drawing.Point(2, 3);
            this.txtGetParameter.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtGetParameter.Name = "txtGetParameter";
            this.txtGetParameter.Size = new System.Drawing.Size(500, 23);
            this.txtGetParameter.TabIndex = 1;
            // 
            // tpStartParameter
            // 
            this.tpStartParameter.Controls.Add(this.txtStartParameter);
            this.tpStartParameter.Location = new System.Drawing.Point(4, 25);
            this.tpStartParameter.Name = "tpStartParameter";
            this.tpStartParameter.Padding = new System.Windows.Forms.Padding(3);
            this.tpStartParameter.Size = new System.Drawing.Size(506, 27);
            this.tpStartParameter.TabIndex = 2;
            this.tpStartParameter.Text = "Start Parameter";
            this.tpStartParameter.UseVisualStyleBackColor = true;
            // 
            // txtStartParameter
            // 
            this.txtStartParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartParameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartParameter.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartParameter.Location = new System.Drawing.Point(2, 3);
            this.txtStartParameter.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtStartParameter.Name = "txtStartParameter";
            this.txtStartParameter.Size = new System.Drawing.Size(500, 23);
            this.txtStartParameter.TabIndex = 2;
            this.txtStartParameter.Text = "-f \"%s\" -- \"%p\"";
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsTab = true;
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.AutoWordSelection = true;
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.ContextMenuStrip = this.mainConMenu;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 86);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ShowSelectionMargin = true;
            this.txtOutput.Size = new System.Drawing.Size(502, 447);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.Text = "";
            this.txtOutput.SelectionChanged += new System.EventHandler(this.txtOutput_SelectionChanged);
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // viewUpdater
            // 
            this.viewUpdater.Enabled = true;
            this.viewUpdater.Tick += new System.EventHandler(this.viewUpdater_Tick);
            // 
            // lblExecTime
            // 
            this.lblExecTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExecTime.Location = new System.Drawing.Point(-2, 534);
            this.lblExecTime.Name = "lblExecTime";
            this.lblExecTime.Size = new System.Drawing.Size(70, 21);
            this.lblExecTime.TabIndex = 4;
            this.lblExecTime.Text = "00:00:00:000";
            this.lblExecTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbProgress.Location = new System.Drawing.Point(69, 534);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(399, 18);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgress.TabIndex = 5;
            // 
            // lblPercent
            // 
            this.lblPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercent.Location = new System.Drawing.Point(468, 534);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(34, 18);
            this.lblPercent.TabIndex = 6;
            this.lblPercent.Text = "0%";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainConMenu
            // 
            this.mainConMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.mainConMenu.Name = "mainConMenu";
            this.mainConMenu.Size = new System.Drawing.Size(113, 70);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 578);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblExecTime);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.mainTabs);
            this.Controls.Add(this.mainTools);
            this.Controls.Add(this.mainStatus);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(275, 305);
            this.Name = "frmMain";
            this.Text = "phpBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_CreateJumpList);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFilePath_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFilePath_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            this.mainTools.ResumeLayout(false);
            this.mainTools.PerformLayout();
            this.mainTabs.ResumeLayout(false);
            this.tpScriptFile.ResumeLayout(false);
            this.tpScriptFile.PerformLayout();
            this.tpParameter.ResumeLayout(false);
            this.tpParameter.PerformLayout();
            this.tpStartParameter.ResumeLayout(false);
            this.tpStartParameter.PerformLayout();
            this.mainConMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStrip mainTools;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage tpParameter;
        private System.Windows.Forms.TabPage tpScriptFile;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtGetParameter;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.ToolStripSplitButton btnFile;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer viewUpdater;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripSeparator ToolStripStatusSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel lblSelCount;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblExecTime;
        private System.Windows.Forms.ToolStripButton btnTopMost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExecute;
        private System.Windows.Forms.TabPage tpStartParameter;
        private System.Windows.Forms.TextBox txtStartParameter;
        private System.Windows.Forms.ContextMenuStrip mainConMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;

    }
}
