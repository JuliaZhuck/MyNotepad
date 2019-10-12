namespace MyNotepad
{
    partial class NotepadMainForm
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
            System.Windows.Forms.ToolStripMenuItem menuItemFileOpen;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadMainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormatColor = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonColor = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            menuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItemFileOpen
            // 
            menuItemFileOpen.Image = global::MyNotepad.Properties.Resources.openHS;
            menuItemFileOpen.Name = "menuItemFileOpen";
            menuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            menuItemFileOpen.Size = new System.Drawing.Size(148, 22);
            menuItemFileOpen.Text = "&Open...";
            menuItemFileOpen.Click += new System.EventHandler(this.menuItemFileOpen_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(492, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileNew,
            menuItemFileOpen,
            this.menuItemSave,
            this.menuItemFileSaveAs,
            this.fToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuItemFileNew
            // 
            this.menuItemFileNew.Image = global::MyNotepad.Properties.Resources.NewDocumentHS;
            this.menuItemFileNew.Name = "menuItemFileNew";
            this.menuItemFileNew.ShortcutKeyDisplayString = "Ctrl+N";
            this.menuItemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemFileNew.Size = new System.Drawing.Size(148, 22);
            this.menuItemFileNew.Text = "&New";
            this.menuItemFileNew.Click += new System.EventHandler(this.menuItemFileNew_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Enabled = false;
            this.menuItemSave.Image = global::MyNotepad.Properties.Resources.saveHS;
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSave.Size = new System.Drawing.Size(148, 22);
            this.menuItemSave.Text = "&Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemFileSaveAs
            // 
            this.menuItemFileSaveAs.Enabled = false;
            this.menuItemFileSaveAs.Name = "menuItemFileSaveAs";
            this.menuItemFileSaveAs.Size = new System.Drawing.Size(148, 22);
            this.menuItemFileSaveAs.Text = "SaveAs...";
            this.menuItemFileSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEditUndo,
            this.menuItemEditRedo,
            this.dToolStripMenuItem,
            this.menuItemEditCut,
            this.menuItemEditCopy,
            this.menuItemEditPaste,
            this.menuItemEditDelete,
            this.fToolStripMenuItem1,
            this.menuItemEditSelectAll});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
            // 
            // menuItemEditUndo
            // 
            this.menuItemEditUndo.Image = global::MyNotepad.Properties.Resources.Edit_UndoHS;
            this.menuItemEditUndo.Name = "menuItemEditUndo";
            this.menuItemEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuItemEditUndo.Size = new System.Drawing.Size(156, 22);
            this.menuItemEditUndo.Text = "&Undo";
            this.menuItemEditUndo.Click += new System.EventHandler(this.menuItemEditUndo_Click);
            // 
            // menuItemEditRedo
            // 
            this.menuItemEditRedo.Image = global::MyNotepad.Properties.Resources.Edit_RedoHS;
            this.menuItemEditRedo.Name = "menuItemEditRedo";
            this.menuItemEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuItemEditRedo.Size = new System.Drawing.Size(156, 22);
            this.menuItemEditRedo.Text = "&Redo";
            this.menuItemEditRedo.Click += new System.EventHandler(this.menuItemEditRedo_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(153, 6);
            // 
            // menuItemEditCut
            // 
            this.menuItemEditCut.Image = global::MyNotepad.Properties.Resources.CutHS;
            this.menuItemEditCut.Name = "menuItemEditCut";
            this.menuItemEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuItemEditCut.Size = new System.Drawing.Size(156, 22);
            this.menuItemEditCut.Text = "C&ut";
            this.menuItemEditCut.Click += new System.EventHandler(this.menuItemEditCut_Click);
            // 
            // menuItemEditCopy
            // 
            this.menuItemEditCopy.Image = global::MyNotepad.Properties.Resources.CopyHS;
            this.menuItemEditCopy.Name = "menuItemEditCopy";
            this.menuItemEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuItemEditCopy.Size = new System.Drawing.Size(156, 22);
            this.menuItemEditCopy.Text = "&Copy";
            this.menuItemEditCopy.Click += new System.EventHandler(this.menuItemEditCopy_Click);
            // 
            // menuItemEditPaste
            // 
            this.menuItemEditPaste.Image = global::MyNotepad.Properties.Resources.PasteHS;
            this.menuItemEditPaste.Name = "menuItemEditPaste";
            this.menuItemEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuItemEditPaste.Size = new System.Drawing.Size(156, 22);
            this.menuItemEditPaste.Text = "&Paste";
            this.menuItemEditPaste.Click += new System.EventHandler(this.menuItemEditPaste_Click);
            // 
            // menuItemEditDelete
            // 
            this.menuItemEditDelete.Image = global::MyNotepad.Properties.Resources.DeleteHS;
            this.menuItemEditDelete.Name = "menuItemEditDelete";
            this.menuItemEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuItemEditDelete.Size = new System.Drawing.Size(156, 22);
            this.menuItemEditDelete.Text = "&Delete";
            this.menuItemEditDelete.Click += new System.EventHandler(this.menuItemEditDelete_Click);
            // 
            // fToolStripMenuItem1
            // 
            this.fToolStripMenuItem1.Name = "fToolStripMenuItem1";
            this.fToolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // menuItemEditSelectAll
            // 
            this.menuItemEditSelectAll.Name = "menuItemEditSelectAll";
            this.menuItemEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuItemEditSelectAll.Size = new System.Drawing.Size(156, 22);
            this.menuItemEditSelectAll.Text = "&Select All";
            this.menuItemEditSelectAll.Click += new System.EventHandler(this.menuItemEditSelectAll_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFormatFont,
            this.menuItemFormatColor,
            this.dToolStripMenuItem1});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.formatToolStripMenuItem.Text = "&Format";
            // 
            // menuItemFormatFont
            // 
            this.menuItemFormatFont.Enabled = false;
            this.menuItemFormatFont.Image = global::MyNotepad.Properties.Resources.FontDialogHS;
            this.menuItemFormatFont.Name = "menuItemFormatFont";
            this.menuItemFormatFont.Size = new System.Drawing.Size(110, 22);
            this.menuItemFormatFont.Text = "&Font...";
            this.menuItemFormatFont.Click += new System.EventHandler(this.menuItemFormatFont_Click);
            // 
            // menuItemFormatColor
            // 
            this.menuItemFormatColor.Enabled = false;
            this.menuItemFormatColor.Image = global::MyNotepad.Properties.Resources.Color_fontHS;
            this.menuItemFormatColor.Name = "menuItemFormatColor";
            this.menuItemFormatColor.Size = new System.Drawing.Size(110, 22);
            this.menuItemFormatColor.Text = "C&olor...";
            this.menuItemFormatColor.Click += new System.EventHandler(this.menuItemFormatColor_Click);
            // 
            // dToolStripMenuItem1
            // 
            this.dToolStripMenuItem1.Name = "dToolStripMenuItem1";
            this.dToolStripMenuItem1.Size = new System.Drawing.Size(107, 6);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViewCascade,
            this.menuItemTileHorizontal,
            this.menuItemTileVertical,
            this.menuItemViewArrangeIcons});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // menuItemViewCascade
            // 
            this.menuItemViewCascade.Enabled = false;
            this.menuItemViewCascade.Name = "menuItemViewCascade";
            this.menuItemViewCascade.Size = new System.Drawing.Size(141, 22);
            this.menuItemViewCascade.Text = "&Cascade";
            this.menuItemViewCascade.Click += new System.EventHandler(this.menuItemViewCascade_Click);
            // 
            // menuItemTileHorizontal
            // 
            this.menuItemTileHorizontal.Enabled = false;
            this.menuItemTileHorizontal.Name = "menuItemTileHorizontal";
            this.menuItemTileHorizontal.Size = new System.Drawing.Size(141, 22);
            this.menuItemTileHorizontal.Text = "Tile&Horizontal";
            this.menuItemTileHorizontal.Click += new System.EventHandler(this.menuItemTileHorizontal_Click);
            // 
            // menuItemTileVertical
            // 
            this.menuItemTileVertical.Enabled = false;
            this.menuItemTileVertical.Name = "menuItemTileVertical";
            this.menuItemTileVertical.Size = new System.Drawing.Size(141, 22);
            this.menuItemTileVertical.Text = "Tile&Vertical";
            this.menuItemTileVertical.Click += new System.EventHandler(this.menuItemTileVertical_Click);
            // 
            // menuItemViewArrangeIcons
            // 
            this.menuItemViewArrangeIcons.Enabled = false;
            this.menuItemViewArrangeIcons.Name = "menuItemViewArrangeIcons";
            this.menuItemViewArrangeIcons.Size = new System.Drawing.Size(141, 22);
            this.menuItemViewArrangeIcons.Text = "A&rrangeIcons";
            this.menuItemViewArrangeIcons.Click += new System.EventHandler(this.menuItemViewArrangeIcons_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo,
            this.toolStripButtonCut,
            this.toolStripButtonCopy,
            this.toolStripButtonPaste,
            this.toolStripSeparator2,
            this.toolStripButtonFont,
            this.toolStripButtonColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStripMain";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = global::MyNotepad.Properties.Resources.NewDocumentHS;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "New";
            this.toolStripButtonNew.Click += new System.EventHandler(this.menuItemFileNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::MyNotepad.Properties.Resources.openHS;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "Open";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.menuItemFileOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = global::MyNotepad.Properties.Resources.saveHS;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Enabled = false;
            this.toolStripButtonUndo.Image = global::MyNotepad.Properties.Resources.Edit_UndoHS;
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUndo.Text = "Undo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.menuItemEditUndo_Click);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Enabled = false;
            this.toolStripButtonRedo.Image = global::MyNotepad.Properties.Resources.Edit_RedoHS;
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRedo.Text = "Redo";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.menuItemEditRedo_Click);
            // 
            // toolStripButtonCut
            // 
            this.toolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCut.Enabled = false;
            this.toolStripButtonCut.Image = global::MyNotepad.Properties.Resources.CutHS;
            this.toolStripButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCut.Name = "toolStripButtonCut";
            this.toolStripButtonCut.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCut.Text = "Cut";
            this.toolStripButtonCut.Click += new System.EventHandler(this.menuItemEditCut_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Enabled = false;
            this.toolStripButtonCopy.Image = global::MyNotepad.Properties.Resources.CopyHS;
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCopy.Text = "Copy";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.menuItemEditCopy_Click);
            // 
            // toolStripButtonPaste
            // 
            this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPaste.Enabled = false;
            this.toolStripButtonPaste.Image = global::MyNotepad.Properties.Resources.PasteHS;
            this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPaste.Text = "Paste";
            this.toolStripButtonPaste.Click += new System.EventHandler(this.menuItemEditPaste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonFont
            // 
            this.toolStripButtonFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFont.Enabled = false;
            this.toolStripButtonFont.Image = global::MyNotepad.Properties.Resources.FontDialogHS;
            this.toolStripButtonFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFont.Name = "toolStripButtonFont";
            this.toolStripButtonFont.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFont.Text = "Font";
            this.toolStripButtonFont.Click += new System.EventHandler(this.menuItemFormatFont_Click);
            // 
            // toolStripButtonColor
            // 
            this.toolStripButtonColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColor.Enabled = false;
            this.toolStripButtonColor.Image = global::MyNotepad.Properties.Resources.Color_fontHS;
            this.toolStripButtonColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColor.Name = "toolStripButtonColor";
            this.toolStripButtonColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonColor.Text = "Color";
            this.toolStripButtonColor.Click += new System.EventHandler(this.menuItemFormatColor_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "New Document1.rtf";
            this.saveFileDialog1.Filter = "RTF files|*.rtf";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowDrop = true;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemCut});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 26);
            // 
            // contextMenuItemCut
            // 
            this.contextMenuItemCut.Image = global::MyNotepad.Properties.Resources.CutHS;
            this.contextMenuItemCut.Name = "contextMenuItemCut";
            this.contextMenuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.contextMenuItemCut.Size = new System.Drawing.Size(128, 22);
            this.contextMenuItemCut.Text = "C&ut";
            // 
            // NotepadMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "NotepadMainForm";
            this.Text = "MyNotepad";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileNew;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripSeparator fToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditUndo;
        private System.Windows.Forms.ToolStripSeparator dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditDelete;
        private System.Windows.Forms.ToolStripSeparator fToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditRedo;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.ToolStripButton toolStripButtonCut;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaste;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewCascade;
        private System.Windows.Forms.ToolStripMenuItem menuItemTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuItemTileVertical;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormatFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonColor;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormatColor;
        private System.Windows.Forms.ToolStripSeparator dToolStripMenuItem1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemCut;
    }
}

