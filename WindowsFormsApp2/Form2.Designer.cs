namespace WindowsFormsApp2
{
    partial class Form2
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
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.서식OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtNotepad = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.서식OToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.tsmiExit});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(298, 34);
            this.tsmiNew.Text = "새로 만들기 (N)";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(298, 34);
            this.tsmiOpen.Text = "열기 (O)";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(298, 34);
            this.tsmiSave.Text = "저장 (S)";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(298, 34);
            this.tsmiSaveAs.Text = "다른 이름으로 저장 (A)";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(298, 34);
            this.tsmiExit.Text = "끝내기 (X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiDelete,
            this.tsmiSelectAll});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.편집EToolStripMenuItem.Text = "편집(E)";
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.Size = new System.Drawing.Size(221, 34);
            this.tsmiUndo.Text = "실행 취소 (U)";
            this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(221, 34);
            this.tsmiCut.Text = "잘라내기 (T)";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(221, 34);
            this.tsmiCopy.Text = "복사 (C)";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(221, 34);
            this.tsmiPaste.Text = "붙여넣기 (P)";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(221, 34);
            this.tsmiDelete.Text = "삭제 (L)";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(221, 34);
            this.tsmiSelectAll.Text = "모두선택 (A)";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // 서식OToolStripMenuItem
            // 
            this.서식OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWordWrap,
            this.tsmiFont,
            this.tsmiFontColor,
            this.tsmiBackColor});
            this.서식OToolStripMenuItem.Name = "서식OToolStripMenuItem";
            this.서식OToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.서식OToolStripMenuItem.Text = "서식(O)";
            // 
            // tsmiWordWrap
            // 
            this.tsmiWordWrap.Name = "tsmiWordWrap";
            this.tsmiWordWrap.Size = new System.Drawing.Size(255, 34);
            this.tsmiWordWrap.Text = "자동 줄 바꿈 (W)";
            this.tsmiWordWrap.Click += new System.EventHandler(this.tsmiWordWrap_Click);
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(255, 34);
            this.tsmiFont.Text = "글꼴 (F)";
            this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // tsmiFontColor
            // 
            this.tsmiFontColor.Name = "tsmiFontColor";
            this.tsmiFontColor.Size = new System.Drawing.Size(255, 34);
            this.tsmiFontColor.Text = "글자색 바꾸기 (C)";
            this.tsmiFontColor.Click += new System.EventHandler(this.tsmiFontColor_Click);
            // 
            // tsmiBackColor
            // 
            this.tsmiBackColor.Name = "tsmiBackColor";
            this.tsmiBackColor.Size = new System.Drawing.Size(255, 34);
            this.tsmiBackColor.Text = "바탕색 바꾸기 (B)";
            this.tsmiBackColor.Click += new System.EventHandler(this.tsmiBackColor_Click);
            // 
            // txtNotepad
            // 
            this.txtNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotepad.Location = new System.Drawing.Point(0, 33);
            this.txtNotepad.Multiline = true;
            this.txtNotepad.Name = "txtNotepad";
            this.txtNotepad.Size = new System.Drawing.Size(800, 417);
            this.txtNotepad.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNotepad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtNotepad;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiWordWrap;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiFontColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}