﻿namespace Elucidate.Controls
{
    partial class ProtectedDrivesDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.driveGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colPath = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colDriveSpace = new Elucidate.Controls.DataGridViewTripleValueBarColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driveGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AllowDrop = true;
            this.kryptonPanel1.Controls.Add(this.driveGrid);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(403, 290);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // driveGrid
            // 
            this.driveGrid.AllowDrop = true;
            this.driveGrid.AllowUserToResizeColumns = false;
            this.driveGrid.AllowUserToResizeRows = false;
            this.driveGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.driveGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPath,
            this.colName,
            this.colDriveSpace,
            this.colDetails});
            this.driveGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.driveGrid.Location = new System.Drawing.Point(0, 0);
            this.driveGrid.MultiSelect = false;
            this.driveGrid.Name = "driveGrid";
            this.driveGrid.RowHeadersVisible = false;
            this.driveGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driveGrid.ShowEditingIcon = false;
            this.driveGrid.Size = new System.Drawing.Size(403, 290);
            this.driveGrid.TabIndex = 0;
            this.driveGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.driveGrid_RowsAdded);
            // 
            // colPath
            // 
            this.colPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPath.Frozen = true;
            this.colPath.HeaderText = "Path";
            this.colPath.Name = "colPath";
            this.colPath.ReadOnly = true;
            this.colPath.Width = 60;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 68;
            // 
            // colDriveSpace
            // 
            this.colDriveSpace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDriveSpace.HeaderText = "Drive Space Protected : Used : Max Available";
            this.colDriveSpace.Name = "colDriveSpace";
            // 
            // colDetails
            // 
            this.colDetails.HeaderText = "Prot : Used : Max";
            this.colDetails.Name = "colDetails";
            this.colDetails.Width = 124;
            // 
            // ProtectedDrivesDisplay
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ProtectedDrivesDisplay";
            this.Size = new System.Drawing.Size(403, 290);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driveGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView driveGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colPath;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colName;
        private DataGridViewTripleValueBarColumn colDriveSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetails;
    }
}
