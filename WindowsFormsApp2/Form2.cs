using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeFileDialog();
        }

        private void InitializeFileDialog()
        {
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Text (*.txt)|*.txt|" + "All files (*.*)|*.*";
            ofd.FileName = "";

            saveFileDialog1.InitialDirectory = ofd.InitialDirectory;
            saveFileDialog1.Filter = ofd.Filter;
            saveFileDialog1.FileName = "*.txt";
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            Text = "NotePad";
            txtNotepad.Text = string.Empty;
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = ofd.OpenFile();
                StreamReader sr = new StreamReader(stream);

                txtNotepad.Text = sr.ReadToEnd();

                sr.Close();
                stream.Close();

                Text = Path.GetFileName(ofd.FileName);
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (ofd.FileName == "")
            {
                tsmiSaveAs_Click(tsmiSaveAs, EventArgs.Empty);
                return;
            }

            saveFileDialog1.FileName = ofd.FileName;
            Stream stream = saveFileDialog1.OpenFile();
            StreamWriter sw = new StreamWriter(stream);

            sw.Write(txtNotepad.Text);

            sw.Close();
            stream.Close();

            Text = Path.GetFileName(saveFileDialog1.FileName);
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ofd.FileName = saveFileDialog1.FileName;
                tsmiSave_Click(tsmiSave, EventArgs.Empty);
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiUndo_Click(object sender, EventArgs e)
        {
            txtNotepad.Undo();
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            txtNotepad.Cut();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            txtNotepad.Copy();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            txtNotepad.Paste();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            txtNotepad.SelectedText = string.Empty;
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            txtNotepad.SelectAll();
        }

        private void tsmiWordWrap_Click(object sender, EventArgs e)
        {
            txtNotepad.WordWrap = !txtNotepad.WordWrap;
            tsmiWordWrap.Checked = txtNotepad.WordWrap;
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNotepad.Font = fontDialog1.Font;
            }
        }

        private void tsmiFontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNotepad.ForeColor = colorDialog1.Color;
            }
        }

        private void tsmiBackColor_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNotepad.BackColor = colorDialog1.Color;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadSetting();
        }

        private void SaveSetting()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"C# Notepad\Notepad");

                var FontName = txtNotepad.Font.FontFamily.GetName(0);
                var FontSize = Convert.ToString(txtNotepad.Font.Size);
                var FontColor = Convert.ToString(txtNotepad.ForeColor.ToArgb());
                var BackColor = Convert.ToString(txtNotepad.BackColor.ToArgb());

                rk.SetValue("FontName", FontName);
                rk.SetValue("FontSize", FontSize);
                rk.SetValue("ForeColor", FontColor);
                rk.SetValue("BackColor", BackColor);
            } catch (Exception) { }
        }

        private void LoadSetting()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"C# Notepad\Notepad");

                var FontName = Convert.ToString(rk.GetValue("FontName"));
                var FontSize = Convert.ToSingle(rk.GetValue("FontSize"));
                var ForeColor = Convert.ToInt32(rk.GetValue("ForeColor"));
                var BackColor = Convert.ToInt32(rk.GetValue("BsckColor"));

                txtNotepad.Font = new System.Drawing.Font(FontName, FontSize);
                txtNotepad.ForeColor = System.Drawing.Color.FromArgb(ForeColor);
                txtNotepad.BackColor = System.Drawing.Color.FromArgb(BackColor);

                fontDialog1.Font = txtNotepad.Font;
            } catch (Exception) { }
        }
    }
}
