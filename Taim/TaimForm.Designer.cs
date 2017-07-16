namespace Taim
{
    partial class TaimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaimForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.taskTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.titleTxt = new Taim.TaimTextBox();
            this.descriptionTxt = new Taim.TaimTextBox();
            this.estimationTxt = new Taim.TaimTextBox();
            this.prevTaskBtn = new System.Windows.Forms.Button();
            this.nextTaskBtn = new System.Windows.Forms.Button();
            this.taimFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTimer = new System.Windows.Forms.Timer(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.topTableLayoutPanel.SuspendLayout();
            this.taskTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taimFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.newToolStripMenuItem,
            this.completeToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(400, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.ColumnCount = 3;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.topTableLayoutPanel.Controls.Add(this.taskTableLayoutPanel1, 1, 0);
            this.topTableLayoutPanel.Controls.Add(this.prevTaskBtn, 0, 0);
            this.topTableLayoutPanel.Controls.Add(this.nextTaskBtn, 2, 0);
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 1;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(400, 237);
            this.topTableLayoutPanel.TabIndex = 1;
            // 
            // taskTableLayoutPanel1
            // 
            this.taskTableLayoutPanel1.ColumnCount = 1;
            this.taskTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.taskTableLayoutPanel1.Controls.Add(this.elapsedTimeLabel, 0, 3);
            this.taskTableLayoutPanel1.Controls.Add(this.titleTxt, 0, 0);
            this.taskTableLayoutPanel1.Controls.Add(this.descriptionTxt, 0, 1);
            this.taskTableLayoutPanel1.Controls.Add(this.estimationTxt, 0, 2);
            this.taskTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskTableLayoutPanel1.Location = new System.Drawing.Point(43, 3);
            this.taskTableLayoutPanel1.Name = "taskTableLayoutPanel1";
            this.taskTableLayoutPanel1.RowCount = 4;
            this.taskTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.taskTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.taskTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.taskTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.taskTableLayoutPanel1.Size = new System.Drawing.Size(314, 231);
            this.taskTableLayoutPanel1.TabIndex = 2;
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elapsedTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elapsedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTimeLabel.Location = new System.Drawing.Point(3, 200);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(308, 31);
            this.elapsedTimeLabel.TabIndex = 0;
            this.elapsedTimeLabel.Text = "00:00:00";
            this.elapsedTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTxt
            // 
            this.titleTxt.BackColor = System.Drawing.SystemColors.Control;
            this.titleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.titleTxt.Location = new System.Drawing.Point(3, 3);
            this.titleTxt.Multiline = true;
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.ReadOnly = true;
            this.titleTxt.Size = new System.Drawing.Size(308, 36);
            this.titleTxt.TabIndex = 1;
            this.titleTxt.Text = "Title";
            this.titleTxt.TextChanged += new System.EventHandler(this.task_DetailChanged);
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxt.Location = new System.Drawing.Point(3, 45);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.ReadOnly = true;
            this.descriptionTxt.Size = new System.Drawing.Size(308, 122);
            this.descriptionTxt.TabIndex = 2;
            this.descriptionTxt.Text = "Description";
            this.descriptionTxt.TextChanged += new System.EventHandler(this.task_DetailChanged);
            // 
            // estimationTxt
            // 
            this.estimationTxt.BackColor = System.Drawing.SystemColors.Control;
            this.estimationTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estimationTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.estimationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimationTxt.Location = new System.Drawing.Point(3, 173);
            this.estimationTxt.Name = "estimationTxt";
            this.estimationTxt.ReadOnly = true;
            this.estimationTxt.Size = new System.Drawing.Size(308, 26);
            this.estimationTxt.TabIndex = 3;
            this.estimationTxt.Text = "1h 30m";
            this.estimationTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.estimationTxt.TextChanged += new System.EventHandler(this.task_DetailChanged);
            // 
            // prevTaskBtn
            // 
            this.prevTaskBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevTaskBtn.FlatAppearance.BorderSize = 0;
            this.prevTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevTaskBtn.Location = new System.Drawing.Point(3, 3);
            this.prevTaskBtn.Name = "prevTaskBtn";
            this.prevTaskBtn.Size = new System.Drawing.Size(34, 231);
            this.prevTaskBtn.TabIndex = 3;
            this.prevTaskBtn.Text = "<";
            this.prevTaskBtn.UseVisualStyleBackColor = false;
            this.prevTaskBtn.Click += new System.EventHandler(this.prevTaskBtn_Click);
            // 
            // nextTaskBtn
            // 
            this.nextTaskBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextTaskBtn.FlatAppearance.BorderSize = 0;
            this.nextTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextTaskBtn.Location = new System.Drawing.Point(363, 3);
            this.nextTaskBtn.Name = "nextTaskBtn";
            this.nextTaskBtn.Size = new System.Drawing.Size(34, 231);
            this.nextTaskBtn.TabIndex = 4;
            this.nextTaskBtn.Text = ">";
            this.nextTaskBtn.UseVisualStyleBackColor = true;
            this.nextTaskBtn.Click += new System.EventHandler(this.nextTaskBtn_Click);
            // 
            // taimFormBindingSource
            // 
            this.taimFormBindingSource.DataSource = typeof(Taim.TaimForm);
            // 
            // taskTimer
            // 
            this.taskTimer.Interval = 1000;
            this.taskTimer.Tick += new System.EventHandler(this.taskTimer_Tick);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // completeToolStripMenuItem
            // 
            this.completeToolStripMenuItem.Name = "completeToolStripMenuItem";
            this.completeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.completeToolStripMenuItem.Text = "Complete";
            this.completeToolStripMenuItem.Click += new System.EventHandler(this.completeToolStripMenuItem_Click);
            // 
            // TaimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.topTableLayoutPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "TaimForm";
            this.Text = "Taim";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.TaimForm_Activated);
            this.Deactivate += new System.EventHandler(this.TaimForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaimForm_FormClosing);
            this.Shown += new System.EventHandler(this.TaimForm_Shown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.topTableLayoutPanel.ResumeLayout(false);
            this.taskTableLayoutPanel1.ResumeLayout(false);
            this.taskTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taimFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel taskTableLayoutPanel1;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private TaimTextBox titleTxt;
        private TaimTextBox descriptionTxt;
        private TaimTextBox estimationTxt;
        private System.Windows.Forms.Button prevTaskBtn;
        private System.Windows.Forms.Button nextTaskBtn;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.BindingSource taimFormBindingSource;
        private System.Windows.Forms.Timer taskTimer;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeToolStripMenuItem;
    }
}

