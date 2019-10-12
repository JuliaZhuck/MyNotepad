using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class NotepadMainForm : Form
    {
        public NotepadMainForm()
        {
            InitializeComponent();
            this.toolStrip1.Invalidated += new InvalidateEventHandler(toolStrip1_Invalidated);
            this.LayoutMdi(MdiLayout.ArrangeIcons);
            this.menuItemViewArrangeIcons.Checked = true;
        }

      
    
        #region newFile

        private void menuItemFileNew_Click(object sender, EventArgs e)
        {
            MenuNewFile();
        }

        private void MenuNewFile()
        {
            ChildForm mdiChild = new ChildForm();
            mdiChild.SavingHandler += new EventHandler(MustSaveCHildWindows);
            OpenNewChildForm(mdiChild);
            mdiChild.Text = "New document";
            this.toolStrip1.Invalidate();
        }


        private void OpenNewChildForm(Form mdiChild)
        {
            mdiChild.MdiParent = this;
            mdiChild.Show();
        }
        #endregion



        
        #region OpenFile

        private void menuItemFileOpen_Click(object sender, EventArgs e)
        {
            MenuOpenFile();
        }

        private void MenuOpenFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK &&
                    openFileDialog1.FileName.Length > 0)
            {
                OpenFile(openFileDialog1.FileName);
            }
        }

        public void OpenFileWithPath(string path)
        {
            OpenFile(path);
        }

        private void OpenFile (string pathFile)
        {
            if (pathFile.Length > 0)
            {
                ChildForm mdiChild = new ChildForm();
                OpenNewChildForm(mdiChild);
                RichTextBox childRtb = (RichTextBox)mdiChild.ActiveControl;
                try
                {
                    if (childRtb != null)
                        childRtb.LoadFile(mdiChild.PathFile = pathFile,
                            RichTextBoxStreamType.RichText);
                }
                catch (Exception)
                {
                    try
                    {
                        if (childRtb != null)
                            childRtb.LoadFile(pathFile,
                                RichTextBoxStreamType.PlainText);
                    }
                    catch (Exception)
                    {
                        if (childRtb != null)
                            childRtb.LoadFile(pathFile, RichTextBoxStreamType.UnicodePlainText);

                    }
                }
                mdiChild.Text = pathFile;
                this.toolStrip1.Invalidate();
            }
        }

        #endregion



        #region SaveFile

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            MenuFileSave(mdiChild);
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            MenuFileSaveAs(mdiChild);
        }


        private void MenuFileSaveAs(Form mdiChild)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK &&
                   saveFileDialog1.FileName.Length > 0
                   && mdiChild != null)
            {
                try
                {
                    RichTextBox childRtb = (RichTextBox)mdiChild.ActiveControl;
                    string newPathFile = saveFileDialog1.FileName;
                    if (String.IsNullOrEmpty(newPathFile) == false)
                    {
                        childRtb.SaveFile(newPathFile);
                        ((ChildForm)mdiChild).PathFile = newPathFile;
                        mdiChild.Text = newPathFile;
                        ((ChildForm)mdiChild).IsHaveChanged = false;
                        this.toolStrip1.Invalidate();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении в файл: \n" + ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void MenuFileSave(Form mdiChild)
        {
            try
            {
                RichTextBox childRtb = (RichTextBox)mdiChild.ActiveControl;
                string path = ((ChildForm)mdiChild).PathFile;
                if (String.IsNullOrEmpty(path) == false)
                {
                    childRtb.SaveFile(path);
                    ((ChildForm)mdiChild).IsHaveChanged = false;
                    this.toolStrip1.Invalidate();
                }
                else
                    MenuFileSaveAs(mdiChild);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении в файл: \n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void MustSaveCHildWindows(object sender, EventArgs ev)
        {
            ChildForm mdiChild = (ChildForm)sender;
            MenuFileSaveAs(mdiChild);
            if (this.MdiChildren.Length == 0)
                this.toolStrip1.Invalidate(true);
        }

        #endregion



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        #region EditFunctions

        private void menuItemEditUndo_Click(object sender, EventArgs e)
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            if (mdiChild != null)
            {
                    RichTextBox editBox = (RichTextBox)mdiChild.ActiveControl;
                    if (editBox != null)
                    {
                        editBox.Undo();
                    }
            }
        }

        private void menuItemEditRedo_Click(object sender, EventArgs e)
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            if (mdiChild != null)
            {
                RichTextBox editBox = (RichTextBox)mdiChild.ActiveControl;
                if (editBox != null)
                {
                    editBox.Redo();
                }
            }
        }

        private void menuItemEditCut_Click(object sender, EventArgs e)
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            if (mdiChild != null)
            {
                RichTextBox editBox = (RichTextBox)mdiChild.ActiveControl;
                if (editBox != null)
                {
                    try
                    {
                        Clipboard.Clear();
                        Clipboard.SetDataObject(editBox.SelectedText);
                        editBox.Cut();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при работе с буфером обмена: \n" + ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }


        private void menuItemEditCopy_Click(object sender, EventArgs e)
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            if (mdiChild != null)
            {
                RichTextBox editBox = (RichTextBox)mdiChild.ActiveControl;
                if (editBox != null)
                {
                    try
                    {
                        Clipboard.Clear();
                        Clipboard.SetDataObject(editBox.SelectedText);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при работе с буфером обмена: \n" + ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void menuItemEditPaste_Click(object sender, EventArgs e)
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            if (mdiChild != null)
            {
                RichTextBox editBox = (RichTextBox)mdiChild.ActiveControl;
                if (editBox != null)
                {
                    try
                    {
                        IDataObject data = Clipboard.GetDataObject();
                        if (data.GetDataPresent(DataFormats.Text))
                        {
                            editBox.SelectedText = data.GetData(DataFormats.Text).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при работе с буфером обмена: \n" + ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void menuItemEditDelete_Click(object sender, EventArgs e)
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            if (mdiChild != null)
            {
                RichTextBox editBox = (RichTextBox)mdiChild.ActiveControl;
                if (editBox != null)
                {
                    Clipboard.SetDataObject(editBox.SelectedText);
                    editBox.Cut();
                }
            }
        }

        private void menuItemEditSelectAll_Click(object sender, EventArgs e)
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            if (mdiChild != null)
            {
                RichTextBox editBox = (RichTextBox)mdiChild.ActiveControl;
                if (editBox != null)
                {
                    Clipboard.SetDataObject(editBox.SelectedText);
                    editBox.SelectAll();
                }
            }
        }

        #endregion


        #region Menu&ToolBar

        private void CheckMenuAndTollbarItems()
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            if (mdiChild == null)
            {
                foreach (ToolStripItem item in this.editToolStripMenuItem.DropDownItems)
                    item.Enabled = false;
                foreach (ToolStripItem item in this.viewToolStripMenuItem.DropDownItems)
                    item.Enabled = false;
                foreach (ToolStripItem item in this.formatToolStripMenuItem.DropDownItems)
                    item.Enabled = false;
                this.toolStripButtonUndo.Enabled = false;
                this.toolStripButtonRedo.Enabled = false;
                this.menuItemEditSelectAll.Enabled = false;
                this.toolStripButtonPaste.Enabled = false;
                this.toolStripButtonCut.Enabled = false;
                this.toolStripButtonCopy.Enabled = false;
                this.toolStripButtonSave.Enabled = false;
                this.toolStripButtonColor.Enabled = false;
                this.toolStripButtonFont.Enabled = false;
            }
            else
            {
                RichTextBox editBox = (RichTextBox)mdiChild.ActiveControl;
                foreach (ToolStripItem item in this.viewToolStripMenuItem.DropDownItems)
                    item.Enabled = true;
                foreach (ToolStripItem item in this.formatToolStripMenuItem.DropDownItems)
                    item.Enabled = true;
                this.toolStripButtonColor.Enabled = true;
                this.toolStripButtonFont.Enabled = true;
                if (editBox != null)
                {
                    if (editBox.CanUndo)
                    {
                        this.menuItemEditUndo.Enabled = true;
                        this.toolStripButtonUndo.Enabled = true;
                    }
                    else
                    {
                        this.menuItemEditUndo.Enabled = false;
                        this.toolStripButtonUndo.Enabled = false;
                    }
                    if (editBox.CanRedo)
                    {
                        this.menuItemEditRedo.Enabled = true;
                        this.toolStripButtonRedo.Enabled = true;
                    }
                    else
                    {
                        this.menuItemEditRedo.Enabled = false;
                        this.toolStripButtonRedo.Enabled = false;
                    }
                    if (editBox.CanSelect)
                        this.menuItemEditSelectAll.Enabled = true;
                    else
                        this.menuItemEditSelectAll.Enabled = false;
                     if (Clipboard.ContainsText() == true)
                     {
                        this.menuItemEditPaste.Enabled = true;
                        this.toolStripButtonPaste.Enabled = true;
                    }
                    else
                    {
                        this.menuItemEditPaste.Enabled = false;
                        this.toolStripButtonPaste.Enabled = false;
                    }
                    if (String.IsNullOrEmpty(editBox.SelectedText) != true)
                    {
                        this.menuItemEditCut.Enabled = true;
                        this.menuItemEditCopy.Enabled = true;
                        this.toolStripButtonCut.Enabled = true;
                        this.toolStripButtonCopy.Enabled = true;
                    }
                    else
                    {
                        this.menuItemEditCut.Enabled = false;
                        this.menuItemEditCopy.Enabled = false;
                        this.toolStripButtonCut.Enabled = false;
                        this.toolStripButtonCopy.Enabled = false;
                    }
                    if (mdiChild.IsHaveChanged == true)
                    {
                        this.menuItemSave.Enabled = true;
                        this.toolStripButtonSave.Enabled = true;
                    }
                    else
                    {
                        this.menuItemSave.Enabled = false;
                        this.toolStripButtonSave.Enabled = false;
                    }
                }
            }
        }

        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            CheckMenuAndTollbarItems();
        }

        private void toolStrip1_Invalidated(object sender, InvalidateEventArgs e)
        {
            CheckMenuAndTollbarItems();
        }

        public void CheckItemsForChildWindow()
        {
            this.toolStrip1.Invalidate();
        }

        #endregion



        #region MeniItemView

        private void menuItemViewCascade_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in this.viewToolStripMenuItem.DropDownItems)
                if (item.Checked == true)
                    item.Checked = false;
            this.LayoutMdi(MdiLayout.Cascade);
            this.menuItemViewCascade.Checked = true;
        }

        private void menuItemTileHorizontal_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in this.viewToolStripMenuItem.DropDownItems)
                if (item.Checked == true)
                    item.Checked = false;
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.menuItemTileHorizontal.Checked = true;

        }


        private void menuItemTileVertical_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in this.viewToolStripMenuItem.DropDownItems)
                if (item.Checked == true)
                    item.Checked = false;
            this.LayoutMdi(MdiLayout.TileVertical);
            this.menuItemTileVertical.Checked = true;
        }


        private void menuItemViewArrangeIcons_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in this.viewToolStripMenuItem.DropDownItems)
                if (item.Checked == true)
                    item.Checked = false;
            this.LayoutMdi(MdiLayout.ArrangeIcons);
            this.menuItemViewArrangeIcons.Checked = true;
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
        }


        #endregion


     

        #region Format

        private void menuItemFormatFont_Click(object sender, EventArgs e)
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            if (mdiChild != null)
            {
                RichTextBox editBox = (RichTextBox)mdiChild.ActiveControl;
                if (editBox != null)
                    if (fontDialog1.ShowDialog() == DialogResult.OK)
                        editBox.SelectionFont = fontDialog1.Font;
            }
        }


        #endregion

        private void menuItemFormatColor_Click(object sender, EventArgs e)
        {
            ChildForm mdiChild = (ChildForm)this.ActiveMdiChild;
            if (mdiChild != null)
            {
                RichTextBox editBox = (RichTextBox)mdiChild.ActiveControl;
                if (editBox != null)
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                        editBox.SelectionColor = colorDialog1.Color;
            }
        }




    }
}