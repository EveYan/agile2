using System;
namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按上传者查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按时间查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.downloadDataSet = new WindowsFormsApplication1.downloadDataSet();
            this.fileTableAdapter = new WindowsFormsApplication1.downloadDataSetTableAdapters.fileTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 246);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(492, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ToolStripMenuItem,
            this.按上传者查看ToolStripMenuItem,
            this.按时间查看ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "所有文件";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.ToolStripMenuItem.Text = "按主题查看";
            // 
            // 按上传者查看ToolStripMenuItem
            // 
            this.按上传者查看ToolStripMenuItem.Name = "按上传者查看ToolStripMenuItem";
            this.按上传者查看ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.按上传者查看ToolStripMenuItem.Text = "按上传者查看";
            // 
            // 按时间查看ToolStripMenuItem
            // 
            this.按时间查看ToolStripMenuItem.Name = "按时间查看ToolStripMenuItem";
            this.按时间查看ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.按时间查看ToolStripMenuItem.Text = "按时间查看";
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 161);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "我想上传";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.upload_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fileBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(344, 149);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "编号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "资料名";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "主题";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "时间";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileBindingSource
            // 
            this.fileBindingSource.DataMember = "file";
            this.fileBindingSource.DataSource = this.downloadDataSet;
            // 
            // downloadDataSet
            // 
            this.downloadDataSet.DataSetName = "downloadDataSet";
            this.downloadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fileTableAdapter
            // 
            this.fileTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "我想下载";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.download_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 268);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按上传者查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按时间查看ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private downloadDataSet downloadDataSet;
        private System.Windows.Forms.BindingSource fileBindingSource;
        private downloadDataSetTableAdapters.fileTableAdapter fileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        
       
    }
}

