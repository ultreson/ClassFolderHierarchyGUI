using ClassFolderHierarchyGUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassFolderHierarchyGUI
{
    public partial class FrmGraphique : Form
    {
        private Semester m_semester;
        private CultureInfo EnglishCulture = new CultureInfo("en-US");
        private CultureInfo FrenchCulture = new CultureInfo("fr-FR");
        public FrmGraphique()
        {
            //CultureInfo.DefaultThreadCurrentUICulture = EnglishCulture;
            //CultureInfo.DefaultThreadCurrentUICulture = FrenchCulture;
            InitializeComponent();
            grpSessionActive.Enabled = false;
            txtSession.Enabled = true;
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            if (txtSession.Text == "")
            {
                MessageBox.Show(Resources.messageNoSemesterName);
                txtSession.Focus();
                return;
            }
            m_semester = new Semester(txtSession.Text);
            txtSession.Enabled = 
            btnSession.Enabled = false;
            grpSessionActive.Enabled = true;
            grpSessionActive.Text = m_semester.Name;
            txtNomCours.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNomCours.Text == "")
            {
                MessageBox.Show(Resources.messageNoCourseName);
                txtNomCours.Focus();
                return;
            }
            if (clbJours.CheckedItems.Count == 0)
            {
                MessageBox.Show(Resources.messageNoDaysSelected);
                return;
            }
            bool[] tabDays = new bool[5];
            for (int index = 0; index < 5; index++)
            {
                tabDays[index] = clbJours.GetItemChecked(index);
                clbJours.SetItemChecked(index, false);
            }
            m_semester.List.Add(new Course(txtNomCours.Text, tabDays));
            ListViewItem item = new ListViewItem(m_semester.List.LastOrDefault().Name);
            string days = null;
            for (int day = 0; day < m_semester.List.LastOrDefault().NumberOfDays; day++)
            {
                days += m_semester.List.LastOrDefault().TabDayNames[day].Substring(0,3);
                if (day < m_semester.List.LastOrDefault().NumberOfDays - 1)
                {
                    days += ", ";
                }
            }
            item.SubItems.Add(days);
            lsvSession.Items.Add(item);
            txtCount.Text = m_semester.List.Count.ToString();
            txtNomCours.Text = null;
            txtNomCours.Focus();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show(Resources.ConfirmDone, Resources.Warning, MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    m_semester.Create((dialog.SelectedPath));
                    MessageBox.Show(Resources.FoldersCreatedIn + dialog.SelectedPath);
                }
            }
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show(Resources.messageConfirmDelete, Resources.Warning, MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                grpSessionActive.Enabled = false;
                txtSession.Enabled =
                btnSession.Enabled = true;
                grpSessionActive.Text = Form1.grpSessionActive_Text;
                lsvSession.Items.Clear();
                clbJours.SelectedIndex = -1;
                for (int item = 0; item < 5; item++)
                {
                    clbJours.SetItemChecked(item, false);
                }
                txtCount.Clear();
                txtNomCours.Clear();
                txtSession.Clear();
                txtSession.Focus();
            }
        }

        private void txtSession_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSession_Click(this, new EventArgs());
            }
        }

        private void txtNomCours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAjouter_Click(this, new EventArgs());
            }
        }

        private void clbJours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAjouter_Click(this, new EventArgs());
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            if (lsvSession.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < lsvSession.SelectedItems.Count; i++)
                {
                    m_semester.List.RemoveAt(lsvSession.SelectedIndices[i]);
                    lsvSession.Items.RemoveAt(lsvSession.SelectedIndices[i]);
                }
                txtCount.Text = m_semester.List.Count.ToString();
                txtNomCours.Text = null;
                txtNomCours.Focus();
            }
        }
    }
}
