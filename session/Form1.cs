using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session
{
    public partial class FrmGraphique : Form
    {
        private Session m_session;
        private int count;

        public FrmGraphique()
        {
            InitializeComponent();
            grpSessionActive.Enabled = false;
            txtSession.Enabled = true;
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            if (txtSession.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom pour la session.");
                txtSession.Focus();
                return;
            }
            m_session = new Session(txtSession.Text);
            txtSession.Enabled = false;
            btnSession.Enabled = false;
            grpSessionActive.Enabled = true;
            grpSessionActive.Text = m_session.Nom;
            txtNomCours.Focus();
            count = 0;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNomCours.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom");
                txtNomCours.Focus();
                return;
            }
            if (clbJours.CheckedItems.Count == 0)
            {
                MessageBox.Show("Veuillez choisir les jours du cours");
                return;
            }
            bool[] tabJours = new bool[5];
            int NbJours = clbJours.CheckedItems.Count;
            for (int index = 0; index < 5; index++)
            {
                tabJours[index] = clbJours.GetItemChecked(index);
                clbJours.SetItemChecked(index, false);
            }
            m_session.Liste.Add(new Cours(txtNomCours.Text, NbJours, tabJours));
            ListViewItem item = new ListViewItem(m_session.Liste.CoursAt(count).Nom);
            string jours = null;
            for (int jour = 0; jour < m_session.Liste.CoursAt(count).NombreDeJours; jour++)
            {
                jours += m_session.Liste.CoursAt(count).TabNomsJours[jour].Substring(0,3);
                if (jour < m_session.Liste.CoursAt(count).NombreDeJours - 1)
                {
                    jours += ", ";
                }
            }
            item.SubItems.Add(jours);
            lsvSession.Items.Add(item);
            count++;
            txtCount.Text = count.ToString();
            txtNomCours.Text = null;
            txtNomCours.Focus();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            var reponse = MessageBox.Show("Avez-vous terminé?", "Avertissement", MessageBoxButtons.YesNo);
            if (reponse == DialogResult.Yes)
            {
                FolderBrowserDialog Dialogue = new FolderBrowserDialog();
                var result = Dialogue.ShowDialog();
                if (result == DialogResult.OK)
                {
                    m_session.Creer((Dialogue.SelectedPath));
                    MessageBox.Show("Dossiers Créés dans " + Dialogue.SelectedPath);
                }
            }
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            var reponse = MessageBox.Show("La session sera supprimée. \n Voulez-vous continuer?", "Avertissement", MessageBoxButtons.YesNo);
            if (reponse == DialogResult.Yes)
            {
                grpSessionActive.Enabled = false;
                txtSession.Enabled = true;
                btnSession.Enabled = true;
                grpSessionActive.Text = "Session Active";
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
                    m_session.Liste.RemoveAt(lsvSession.SelectedIndices[i]);
                    lsvSession.Items.RemoveAt(lsvSession.SelectedIndices[i]);
                    count--;
                }
                txtCount.Text = count.ToString();
                txtNomCours.Text = null;
                txtNomCours.Focus();
            }
        }
    }
}
