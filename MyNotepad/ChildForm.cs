using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class ChildForm : Form
    {
        public event EventHandler SavingHandler;

        bool isHaveChanged = false;

        public bool IsHaveChanged
        {
            get { return isHaveChanged; }
            set { isHaveChanged = value; }
        }

        string pathFile = "";

        public string PathFile
        {
            get { return pathFile; }
            set { pathFile = value; }
        }

        public ChildForm()
        {
            InitializeComponent();
            this.richTextBox1.SelectionIndent = 3;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isHaveChanged = true;
            NotepadMainForm main = (NotepadMainForm)this.MdiParent;
            if (main != null)
                main.CheckItemsForChildWindow();
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isHaveChanged && SavingHandler != null)
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(
                        System.String.Format("Документ {0} был изменен.\nСохранить изменения?",
                        this.Text),
                        "Сохранение документа", System.Windows.Forms.MessageBoxButtons.YesNoCancel,
                        System.Windows.Forms.MessageBoxIcon.Warning, System.Windows.Forms.MessageBoxDefaultButton.Button1);
                switch (result)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        SavingHandler(this, new System.EventArgs());
                        break;
                    case System.Windows.Forms.DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            isHaveChanged = true;
            NotepadMainForm main = (NotepadMainForm)this.MdiParent;
            if (main != null)
                main.CheckItemsForChildWindow();
        }

        //private void contextMenuItemCut_Click(object sender, EventArgs e)
        //{
        //    Clipboard.Clear();
        //    Clipboard.SetDataObject(this.richTextBox1.SelectedText);
        //    this.richTextBox1.Cut();
        //}

        //private void contextMenuItemCopy_Click(object sender, EventArgs e)
        //{
        //    Clipboard.Clear();
        //    Clipboard.SetDataObject(this.richTextBox1.SelectedText); 
        //}

        //private void contextMenuItemPaste_Click(object sender, EventArgs e)
        //{
        //    IDataObject data = Clipboard.GetDataObject();
        //    if (data.GetDataPresent(DataFormats.Text))
        //    {
        //        this.richTextBox1.SelectedText = data.GetData(DataFormats.Text).ToString();
        //    }
        //}

    }
}