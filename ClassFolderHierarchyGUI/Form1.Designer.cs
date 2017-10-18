namespace ClassFolderHierarchyGUI
{
    partial class FrmGraphique
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSessionActive = new System.Windows.Forms.GroupBox();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lsvSession = new System.Windows.Forms.ListView();
            this.cours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVider = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNomCours = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblJoursCours = new System.Windows.Forms.Label();
            this.clbJours = new System.Windows.Forms.CheckedListBox();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.lblSession = new System.Windows.Forms.Label();
            this.btnSession = new System.Windows.Forms.Button();
            this.grpSessionActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSessionActive
            // 
            this.grpSessionActive.Controls.Add(this.btnEffacer);
            this.grpSessionActive.Controls.Add(this.txtCount);
            this.grpSessionActive.Controls.Add(this.lsvSession);
            this.grpSessionActive.Controls.Add(this.btnVider);
            this.grpSessionActive.Controls.Add(this.btnCreer);
            this.grpSessionActive.Controls.Add(this.btnAjouter);
            this.grpSessionActive.Controls.Add(this.txtNomCours);
            this.grpSessionActive.Controls.Add(this.lblNom);
            this.grpSessionActive.Controls.Add(this.lblJoursCours);
            this.grpSessionActive.Controls.Add(this.clbJours);
            this.grpSessionActive.Location = new System.Drawing.Point(12, 71);
            this.grpSessionActive.Name = "grpSessionActive";
            this.grpSessionActive.Size = new System.Drawing.Size(545, 236);
            this.grpSessionActive.TabIndex = 0;
            this.grpSessionActive.TabStop = false;
            this.grpSessionActive.Text = "Session active";
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(17, 146);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(119, 37);
            this.btnEffacer.TabIndex = 16;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(227, 163);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(37, 20);
            this.txtCount.TabIndex = 15;
            // 
            // lsvSession
            // 
            this.lsvSession.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cours,
            this.jours});
            this.lsvSession.FullRowSelect = true;
            this.lsvSession.GridLines = true;
            this.lsvSession.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvSession.Location = new System.Drawing.Point(272, 16);
            this.lsvSession.Name = "lsvSession";
            this.lsvSession.Size = new System.Drawing.Size(267, 211);
            this.lsvSession.TabIndex = 14;
            this.lsvSession.UseCompatibleStateImageBehavior = false;
            this.lsvSession.View = System.Windows.Forms.View.Details;
            // 
            // cours
            // 
            this.cours.Text = "cours";
            this.cours.Width = 130;
            // 
            // jours
            // 
            this.jours.Text = "jours";
            this.jours.Width = 130;
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(159, 189);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(107, 41);
            this.btnVider.TabIndex = 13;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(17, 189);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(119, 41);
            this.btnCreer.TabIndex = 12;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(6, 107);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(168, 32);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtNomCours
            // 
            this.txtNomCours.Location = new System.Drawing.Point(6, 65);
            this.txtNomCours.Name = "txtNomCours";
            this.txtNomCours.Size = new System.Drawing.Size(168, 20);
            this.txtNomCours.TabIndex = 10;
            this.txtNomCours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomCours_KeyDown);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 35);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(76, 13);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom du cours:";
            // 
            // lblJoursCours
            // 
            this.lblJoursCours.AutoSize = true;
            this.lblJoursCours.Location = new System.Drawing.Point(188, 16);
            this.lblJoursCours.Name = "lblJoursCours";
            this.lblJoursCours.Size = new System.Drawing.Size(76, 13);
            this.lblJoursCours.TabIndex = 8;
            this.lblJoursCours.Text = "Jours du cours";
            // 
            // clbJours
            // 
            this.clbJours.CheckOnClick = true;
            this.clbJours.FormattingEnabled = true;
            this.clbJours.Items.AddRange(new object[] {
            "lundi",
            "mardi",
            "mercredi",
            "jeudi",
            "vendredi"});
            this.clbJours.Location = new System.Drawing.Point(191, 45);
            this.clbJours.Name = "clbJours";
            this.clbJours.Size = new System.Drawing.Size(75, 94);
            this.clbJours.TabIndex = 7;
            this.clbJours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clbJours_KeyDown);
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(114, 9);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(443, 20);
            this.txtSession.TabIndex = 1;
            this.txtSession.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSession_KeyDown);
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(12, 12);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(96, 13);
            this.lblSession.TabIndex = 2;
            this.lblSession.Text = "Nom de la session:";
            // 
            // btnSession
            // 
            this.btnSession.Location = new System.Drawing.Point(15, 42);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(542, 23);
            this.btnSession.TabIndex = 3;
            this.btnSession.Text = "Commencer session";
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // FrmGraphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 319);
            this.Controls.Add(this.btnSession);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.grpSessionActive);
            this.Name = "FrmGraphique";
            this.Text = "Session.cs";
            this.grpSessionActive.ResumeLayout(false);
            this.grpSessionActive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSessionActive;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtNomCours;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblJoursCours;
        private System.Windows.Forms.CheckedListBox clbJours;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.ListView lsvSession;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.ColumnHeader cours;
        private System.Windows.Forms.ColumnHeader jours;
        private System.Windows.Forms.Button btnEffacer;
    }
}

