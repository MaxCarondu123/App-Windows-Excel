namespace E14_Lab2_MaximeCaron
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblNoPatineur = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblPointsTotal = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.numPointsTotal = new System.Windows.Forms.NumericUpDown();
            this.cboClub = new System.Windows.Forms.ComboBox();
            this.numNoPatineur = new System.Windows.Forms.NumericUpDown();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblNomCourse = new System.Windows.Forms.Label();
            this.lblTemps = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblNoCourse = new System.Windows.Forms.Label();
            this.lblNumCourse = new System.Windows.Forms.Label();
            this.txtNomCourse = new System.Windows.Forms.TextBox();
            this.numDistance = new System.Windows.Forms.NumericUpDown();
            this.numPosition = new System.Windows.Forms.NumericUpDown();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.mskNoCourse = new System.Windows.Forms.MaskedTextBox();
            this.btnChangerCourse = new System.Windows.Forms.Button();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.mskTemps = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointsTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoPatineur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Enabled = false;
            this.btnAjouter.Location = new System.Drawing.Point(330, 327);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(136, 56);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Enregistrer de l\'Ajout";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblNoPatineur
            // 
            this.lblNoPatineur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoPatineur.Location = new System.Drawing.Point(12, 26);
            this.lblNoPatineur.Name = "lblNoPatineur";
            this.lblNoPatineur.Size = new System.Drawing.Size(122, 27);
            this.lblNoPatineur.TabIndex = 1;
            this.lblNoPatineur.Text = "No Patineur:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(140, 67);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(257, 26);
            this.txtNom.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNom.Location = new System.Drawing.Point(12, 67);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(122, 27);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrenom.Location = new System.Drawing.Point(12, 110);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(122, 27);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prenom:";
            // 
            // lblAge
            // 
            this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAge.Location = new System.Drawing.Point(12, 153);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(122, 27);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age:";
            // 
            // lblClub
            // 
            this.lblClub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClub.Location = new System.Drawing.Point(12, 200);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(122, 27);
            this.lblClub.TabIndex = 6;
            this.lblClub.Text = "Club:";
            // 
            // lblPointsTotal
            // 
            this.lblPointsTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPointsTotal.Location = new System.Drawing.Point(12, 249);
            this.lblPointsTotal.Name = "lblPointsTotal";
            this.lblPointsTotal.Size = new System.Drawing.Size(122, 27);
            this.lblPointsTotal.TabIndex = 7;
            this.lblPointsTotal.Text = "Points Total:";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(140, 110);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(257, 26);
            this.txtPrenom.TabIndex = 9;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(140, 153);
            this.numAge.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(68, 26);
            this.numAge.TabIndex = 10;
            // 
            // numPointsTotal
            // 
            this.numPointsTotal.Location = new System.Drawing.Point(140, 250);
            this.numPointsTotal.Name = "numPointsTotal";
            this.numPointsTotal.Size = new System.Drawing.Size(110, 26);
            this.numPointsTotal.TabIndex = 11;
            // 
            // cboClub
            // 
            this.cboClub.FormattingEnabled = true;
            this.cboClub.Items.AddRange(new object[] {
            "Chicoutimi",
            "Baie-Comeau",
            "St-Felicien",
            "LaBaie",
            "Jonquiere",
            "Roberval",
            "Alma",
            "Dolbeau"});
            this.cboClub.Location = new System.Drawing.Point(140, 200);
            this.cboClub.Name = "cboClub";
            this.cboClub.Size = new System.Drawing.Size(247, 28);
            this.cboClub.TabIndex = 12;
            // 
            // numNoPatineur
            // 
            this.numNoPatineur.Enabled = false;
            this.numNoPatineur.Location = new System.Drawing.Point(140, 25);
            this.numNoPatineur.Name = "numNoPatineur";
            this.numNoPatineur.Size = new System.Drawing.Size(120, 26);
            this.numNoPatineur.TabIndex = 13;
            // 
            // lblPoints
            // 
            this.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPoints.Location = new System.Drawing.Point(440, 236);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(122, 27);
            this.lblPoints.TabIndex = 19;
            this.lblPoints.Text = "Points:";
            // 
            // lblNomCourse
            // 
            this.lblNomCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomCourse.Location = new System.Drawing.Point(440, 187);
            this.lblNomCourse.Name = "lblNomCourse";
            this.lblNomCourse.Size = new System.Drawing.Size(122, 27);
            this.lblNomCourse.TabIndex = 18;
            this.lblNomCourse.Text = "Nom Course:";
            // 
            // lblTemps
            // 
            this.lblTemps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemps.Location = new System.Drawing.Point(440, 140);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(122, 27);
            this.lblTemps.TabIndex = 17;
            this.lblTemps.Text = "Temps:";
            // 
            // lblPosition
            // 
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPosition.Location = new System.Drawing.Point(440, 97);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(122, 27);
            this.lblPosition.TabIndex = 16;
            this.lblPosition.Text = "Position:";
            // 
            // lblDistance
            // 
            this.lblDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistance.Location = new System.Drawing.Point(440, 54);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(122, 27);
            this.lblDistance.TabIndex = 15;
            this.lblDistance.Text = "Distance:";
            // 
            // lblNoCourse
            // 
            this.lblNoCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoCourse.Location = new System.Drawing.Point(440, 13);
            this.lblNoCourse.Name = "lblNoCourse";
            this.lblNoCourse.Size = new System.Drawing.Size(122, 27);
            this.lblNoCourse.TabIndex = 14;
            this.lblNoCourse.Text = "No Course:";
            // 
            // lblNumCourse
            // 
            this.lblNumCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumCourse.Location = new System.Drawing.Point(499, 285);
            this.lblNumCourse.Name = "lblNumCourse";
            this.lblNumCourse.Size = new System.Drawing.Size(122, 27);
            this.lblNumCourse.TabIndex = 20;
            this.lblNumCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomCourse
            // 
            this.txtNomCourse.Location = new System.Drawing.Point(579, 187);
            this.txtNomCourse.Name = "txtNomCourse";
            this.txtNomCourse.Size = new System.Drawing.Size(257, 26);
            this.txtNomCourse.TabIndex = 21;
            // 
            // numDistance
            // 
            this.numDistance.Location = new System.Drawing.Point(579, 54);
            this.numDistance.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.numDistance.Name = "numDistance";
            this.numDistance.Size = new System.Drawing.Size(82, 26);
            this.numDistance.TabIndex = 22;
            // 
            // numPosition
            // 
            this.numPosition.Location = new System.Drawing.Point(579, 96);
            this.numPosition.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.numPosition.Name = "numPosition";
            this.numPosition.Size = new System.Drawing.Size(82, 26);
            this.numPosition.TabIndex = 23;
            // 
            // numPoints
            // 
            this.numPoints.DecimalPlaces = 3;
            this.numPoints.Location = new System.Drawing.Point(579, 235);
            this.numPoints.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(82, 26);
            this.numPoints.TabIndex = 25;
            // 
            // mskNoCourse
            // 
            this.mskNoCourse.Location = new System.Drawing.Point(579, 13);
            this.mskNoCourse.Mask = "00A";
            this.mskNoCourse.Name = "mskNoCourse";
            this.mskNoCourse.Size = new System.Drawing.Size(82, 26);
            this.mskNoCourse.TabIndex = 26;
            // 
            // btnChangerCourse
            // 
            this.btnChangerCourse.Location = new System.Drawing.Point(627, 285);
            this.btnChangerCourse.Name = "btnChangerCourse";
            this.btnChangerCourse.Size = new System.Drawing.Size(57, 27);
            this.btnChangerCourse.TabIndex = 27;
            this.btnChangerCourse.Text = ">";
            this.btnChangerCourse.UseVisualStyleBackColor = true;
            this.btnChangerCourse.Click += new System.EventHandler(this.btnChangerCourse_Click);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // mskTemps
            // 
            this.mskTemps.Location = new System.Drawing.Point(579, 141);
            this.mskTemps.Mask = "0: 00.00";
            this.mskTemps.Name = "mskTemps";
            this.mskTemps.Size = new System.Drawing.Size(100, 26);
            this.mskTemps.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 409);
            this.Controls.Add(this.mskTemps);
            this.Controls.Add(this.btnChangerCourse);
            this.Controls.Add(this.mskNoCourse);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.numPosition);
            this.Controls.Add(this.numDistance);
            this.Controls.Add(this.txtNomCourse);
            this.Controls.Add(this.lblNumCourse);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblNomCourse);
            this.Controls.Add(this.lblTemps);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblNoCourse);
            this.Controls.Add(this.numNoPatineur);
            this.Controls.Add(this.cboClub);
            this.Controls.Add(this.numPointsTotal);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPointsTotal);
            this.Controls.Add(this.lblClub);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNoPatineur);
            this.Controls.Add(this.btnAjouter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointsTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoPatineur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblNoPatineur;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label lblPointsTotal;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.NumericUpDown numPointsTotal;
        private System.Windows.Forms.ComboBox cboClub;
        private System.Windows.Forms.NumericUpDown numNoPatineur;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblNomCourse;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblNoCourse;
        private System.Windows.Forms.Label lblNumCourse;
        private System.Windows.Forms.TextBox txtNomCourse;
        private System.Windows.Forms.NumericUpDown numDistance;
        private System.Windows.Forms.NumericUpDown numPosition;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.MaskedTextBox mskNoCourse;
        private System.Windows.Forms.Button btnChangerCourse;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.MaskedTextBox mskTemps;
    }
}

