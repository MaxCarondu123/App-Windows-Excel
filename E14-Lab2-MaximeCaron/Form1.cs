using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace E14_Lab2_MaximeCaron
{
    public partial class Form1 : Form
    {
        public static Excel.Application excelApp;
        public static Excel.Workbook excelBook;
        public static Excel.Worksheet excelSheet;
        public static Excel.Range excelRange;

        private int nbrLignes;
        private int nbrPatineurs;
        private int click = 0;

        private List<string> Courses = new List<string>();
        private string ligne;
        private int nbr;
        private int compter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Ouvrir_FichierExcel();
                NbrLigne_Pat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void Ouvrir_FichierExcel()
        {
            excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Vous devez installer office");
                Application.Exit();
            }

            excelBook = excelApp?.Workbooks.Open(AppContext.BaseDirectory + "ListePatineurs.xlsx");
            excelSheet = excelBook?.Worksheets[1];
        }

        private void NbrLigne_Pat()
        {
            Excel.Range last = excelSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

            for (int y = 1; y < last.Row; y++)
            {
                if (excelSheet.Cells[y, 1].Value != null)
                {
                    nbrLignes++;
                }
            }
            nbrLignes++;

            nbrPatineurs = nbrLignes / 4;
            nbrPatineurs++;
            nbrLignes++;

            numNoPatineur.Value = nbrPatineurs;
            lblNumCourse.Text = "Course #1";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valider_Patineur() == false || Valider_Course() == false)
                {
                    return;
                }

                erpError.Clear();
                AjoutCourseList();
                ViderControl();

                Ajouter_Fichier();
              
                Courses.Clear();
                nbrLignes = nbrLignes + 3;
                numNoPatineur.Value = nbrPatineurs++;

                btnAjouter.Enabled = false;
                btnChangerCourse.Enabled = true;
                click = 0;
                lblNumCourse.Text = "Course #1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void Ajouter_Fichier()
        {
            ligne = ($"{numNoPatineur.Value} {txtNom.Text},{txtPrenom.Text} {numAge.Value}                                                        " +
                         $"{cboClub.Text}                                                               " +
                         $"{numPoints.Value}");
            excelSheet.Cells[nbrLignes, 1].Value2 = ligne;
            nbrLignes++;

            compter = 0;
            for (int c = 0; c < Courses.Count; c++)
            {
                if (c == 6 || c == 12 || c == 18)
                {
                    compter++;
                    nbr = 0;
                }
                excelSheet.Cells[nbrLignes + compter, nbr + 1].Value2 = Courses[c];
                nbr++;
            }

            excelBook.Save();
        }

        private void btnChangerCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valider_Course() == false)
                {
                    return;
                }

                erpError.Clear();
                if (click < 3)
                {
                    AjoutCourseList();
                    ViderControl();
                    click++;
                }

                if (click == 1)
                {
                    lblNumCourse.Text = "Course #2";
                }
                else
                {
                    lblNumCourse.Text = "Course #3";
                    btnAjouter.Enabled = true;
                    btnChangerCourse.Enabled = false;
                }
            }                         
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void AjoutCourseList()
        {
            Courses.Add(mskNoCourse.Text);
            Courses.Add(numDistance.Value.ToString() + " m");
            Courses.Add(txtNomCourse.Text);
            Courses.Add(numPosition.Value.ToString());
            Courses.Add(mskTemps.Text);           
            Courses.Add(numPoints.Value.ToString() + " pts");
        }

        private void ViderControl()
        {
            mskNoCourse.Clear();
            numDistance.Value = 0;
            numPosition.Value = 0;
            mskTemps.Text = "";
            txtNomCourse.Text = "";
            numPoints.Value = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                excelBook.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private bool Valider_Patineur()
        {
            bool Ok = true;

            if (txtNom.Text.Trim() == "")
            {
                erpError.SetError(txtNom, "Nom obligatoire");
                Ok = false;
            }
            if (txtPrenom.Text.Trim() == "")
            {
                erpError.SetError(txtPrenom, "Prenom obligatoire");
                Ok = false;
            }
            if (numAge.Value < 1)
            {
                erpError.SetError(numAge, "Age doit etre plus grand que 0");
                Ok = false;
            }
            if (cboClub.Text.Trim() == "")
            {
                erpError.SetError(cboClub, "Club obligatoire");
                Ok = false;
            }

            return Ok;
        }

        private bool Valider_Course()
        {
            bool Ok = true;

            if (mskNoCourse.Text == "")
            {
                erpError.SetError(mskNoCourse, "Numero de la course obligatoire");
                Ok = false;
            }
            if (numPosition.Value < 1)
            {
                erpError.SetError(numPosition, "Position doit etre plus grand que 0");
                Ok = false;
            }

            return Ok;
        }
    }
}
