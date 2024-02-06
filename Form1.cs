using InsERT;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rew_Zaksieguj
{
    public partial class Form1 : Form
    {
        public static Rewizor oRewGT;
        public Form1()
        {
            InitializeComponent();
            ParametersLoad();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ParametersSave();


            try
            {
                oRewGT = UruchomRewizora();
                oRewGT.OkresObrachunkowy = new DateTime(Properties.Settings.Default.RokRoku, 1, 1);

                string sSQLWhere = $"dkr_IdRoku={Properties.Settings.Default.IdRoku} and dkr_NrWDzienniku is null";
                string sSQLOrder = "dkr_DataDekretacji, dkr_Id";
                Dekrety dekrety = oRewGT.DkrManager.OtworzKolekcje(sSQLWhere, sSQLOrder);
                int counterCurrent = 0;
                int counterAll = dekrety.Liczba;
                int counterPerSecond = 0;

                if (counterAll > 0)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    foreach (Dekret dekret in dekrety)
                    {
                        counterCurrent++;
                        counterPerSecond++;
                        richText.AppendText($"{counterCurrent}/{counterAll} {dekret.DataDekretacji:d} - {dekret.NrPelny} {Environment.NewLine}");
                        richText.ScrollToCaret();
                        dekret.Ksieguj();
                        if (stopwatch.ElapsedMilliseconds > 1000)
                        {
                            
                            richPerSecond.AppendText($"{counterCurrent}:{counterPerSecond}/s {Environment.NewLine}");
                            richPerSecond.ScrollToCaret();
                            counterPerSecond = 0;
                            stopwatch.Restart();
                        }
                    }
                    MessageBox.Show("Koniec");
                }
                else
                {
                    MessageBox.Show("Brak danych do zaksięgowania");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (oRewGT != null)
                {
                    Marshal.ReleaseComObject(oRewGT);
                }

                if (oRewGT != null)
                {
                    Marshal.ReleaseComObject(oRewGT);
                }



            }
        }

        private Rewizor UruchomRewizora()
        {
            GT gT;

            try
            {
                gT = new GT
                {
                    Produkt = ProduktEnum.gtaProduktRewizor,
                    Autentykacja = AutentykacjaEnum.gtaAutentykacjaMieszana,
                    Serwer = Properties.Settings.Default.Host,
                    Baza = Properties.Settings.Default.Database,
                    Uzytkownik = Properties.Settings.Default.SqlUser,
                    UzytkownikHaslo = Properties.Settings.Default.SqlPassword,
                    Operator = Properties.Settings.Default.User,
                    OperatorHaslo = Properties.Settings.Default.UserPassword
                };
                Rewizor rewizor = (Rewizor)gT.Uruchom(0, 6);
                rewizor.Okno.Widoczne = false;
                return rewizor;
            }
            catch (Exception)
            {
                throw;
            }
        }

       
               

       

        private void ParametersLoad()
        {
            txtSerwer.Text = Properties.Settings.Default.Host;
            txtBaza.Text = Properties.Settings.Default.Database;
            txtSqlUser.Text = Properties.Settings.Default.SqlUser;
            txtSqlPassword.Text = Properties.Settings.Default.SqlPassword;
            txtUser.Text = Properties.Settings.Default.User;
            txtUserPassword.Text = Properties.Settings.Default.UserPassword;
            numIdRoku.Value = Properties.Settings.Default.IdRoku;
            numRokRoku.Value = Properties.Settings.Default.RokRoku;
        }

        private void ParametersSave()
        {
            Properties.Settings.Default.Host = txtSerwer.Text;
            Properties.Settings.Default.Database = txtBaza.Text;
            Properties.Settings.Default.SqlUser = txtSqlUser.Text;
            Properties.Settings.Default.SqlPassword = txtSqlPassword.Text;
            Properties.Settings.Default.User = txtUser.Text;
            Properties.Settings.Default.UserPassword = txtUserPassword.Text;
            Properties.Settings.Default.IdRoku = (int)numIdRoku.Value;
            Properties.Settings.Default.RokRoku = (int)numRokRoku.Value;
            Properties.Settings.Default.Save();
        }
    }
}
