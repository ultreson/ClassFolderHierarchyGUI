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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGraphique));
            this.grpSessionActive = new System.Windows.Forms.GroupBox();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lsvSession = new System.Windows.Forms.ListView();
            this.course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.days = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            resources.ApplyResources(this.grpSessionActive, "grpSessionActive");
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
            this.grpSessionActive.Name = "grpSessionActive";
            this.grpSessionActive.TabStop = false;
            // 
            // btnEffacer
            // 
            resources.ApplyResources(this.btnEffacer, "btnEffacer");
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // txtCount
            // 
            resources.ApplyResources(this.txtCount, "txtCount");
            this.txtCount.Name = "txtCount";
            // 
            // lsvSession
            // 
            resources.ApplyResources(this.lsvSession, "lsvSession");
            this.lsvSession.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.course,
            this.days});
            this.lsvSession.FullRowSelect = true;
            this.lsvSession.GridLines = true;
            this.lsvSession.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvSession.Name = "lsvSession";
            this.lsvSession.UseCompatibleStateImageBehavior = false;
            this.lsvSession.View = System.Windows.Forms.View.Details;
            // 
            // course
            // 
            resources.ApplyResources(this.course, "course");
            // 
            // days
            // 
            resources.ApplyResources(this.days, "days");
            // 
            // btnVider
            // 
            resources.ApplyResources(this.btnVider, "btnVider");
            this.btnVider.Name = "btnVider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnCreer
            // 
            resources.ApplyResources(this.btnCreer, "btnCreer");
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnAjouter
            // 
            resources.ApplyResources(this.btnAjouter, "btnAjouter");
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtNomCours
            // 
            resources.ApplyResources(this.txtNomCours, "txtNomCours");
            this.txtNomCours.Name = "txtNomCours";
            this.txtNomCours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomCours_KeyDown);
            // 
            // lblNom
            // 
            resources.ApplyResources(this.lblNom, "lblNom");
            this.lblNom.Name = "lblNom";
            // 
            // lblJoursCours
            // 
            resources.ApplyResources(this.lblJoursCours, "lblJoursCours");
            this.lblJoursCours.Name = "lblJoursCours";
            // 
            // clbJours
            // 
            resources.ApplyResources(this.clbJours, "clbJours");
            this.clbJours.CheckOnClick = true;
            this.clbJours.FormattingEnabled = true;
            this.clbJours.Items.AddRange(new object[] {
            resources.GetString("clbJours.Items"),
            resources.GetString("clbJours.Items1"),
            resources.GetString("clbJours.Items2"),
            resources.GetString("clbJours.Items3"),
            resources.GetString("clbJours.Items4")});
            this.clbJours.Name = "clbJours";
            this.clbJours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clbJours_KeyDown);
            // 
            // txtSession
            // 
            resources.ApplyResources(this.txtSession, "txtSession");
            this.txtSession.Name = "txtSession";
            this.txtSession.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSession_KeyDown);
            // 
            // lblSession
            // 
            resources.ApplyResources(this.lblSession, "lblSession");
            this.lblSession.Name = "lblSession";
            // 
            // btnSession
            // 
            resources.ApplyResources(this.btnSession, "btnSession");
            this.btnSession.Name = "btnSession";
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // FrmGraphique
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSession);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.grpSessionActive);
            this.Name = "FrmGraphique";
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
        private System.Windows.Forms.ColumnHeader course;
        private System.Windows.Forms.ColumnHeader days;
        private System.Windows.Forms.Button btnEffacer;
    }
}

