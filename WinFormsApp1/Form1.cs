using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillKodyDataGridView();
            fillLocalizationsDataGridView();
        }

        private void fillKodyDataGridView()
        {
            try
            {
                using (Ajppablab4Context db = new())
                {
                    db.KodyPocztowes.Load();
                    this.kodyPocztoweGridView.DataSource = db.KodyPocztowes.Local.ToBindingList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
            }
        }

        private void fillLocalizationsDataGridView()
        {
            try
            {
                using (Ajppablab4Context db = new())
                {
                    db.Localizations.Load();
                    this.localizationsGridView.DataSource = db.Localizations.Local.ToBindingList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
            }
        }

        private void clearKodyResultDataGridView()
        {
            this.kodPocztowySearchedGridView.Rows.Clear();
            this.kodPocztowySearchedGridView.Refresh();
        }

        private void clearLocalizationsResultDataGridView()
        {
            this.localizationsSearchedGridView.Rows.Clear();
            this.localizationsSearchedGridView.Refresh();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string? id = idTextBox.Text.Length > 0 ? idTextBox.Text : null;
                string? miejscowosc = miejscowoscTextBox.Text.Length > 0 ? miejscowoscTextBox.Text : null;
                string? powiat = powiatTextBox.Text.Length > 0 ? powiatTextBox.Text : null;
                string? adres = adresTextBox.Text.Length > 0 ? adresTextBox.Text : null;
                string? kodPocztowy = kodPocztowyTextBox.Text.Length > 0 ? kodPocztowyTextBox.Text : null;
                string? wojewodztwo = wojewodztwoTextBox.Text.Length > 0 ? wojewodztwoTextBox.Text : null;
                string? uwagi = uwagiTextBox.Text.Length > 0 ? uwagiTextBox.Text : null;

                List<KodyPocztowe> result = new();
                List<Localization> localizationsResult = new();
                Stopwatch stopwatch = new();
                stopwatch.Start();
                using (Ajppablab4Context db = new())
                {
                    result = db.KodyPocztowes.ToList();
                    if (id != null)
                    {
                        result = result.Where(kod => kod.Id.ToString().ToLower().Contains(id.ToLower())).ToList();
                    }
                    if (miejscowosc != null)
                    {
                        result = result.Where(kod => kod.Miejscowosc.ToLower().Contains(miejscowosc.ToLower())).ToList();
                    }
                    if (powiat != null)
                    {
                        result = result.Where(kod => kod.Powiat.ToLower().Contains(powiat.ToLower())).ToList();
                    }
                    if (adres != null)
                    {
                        result = result.Where(kod => kod.Adres.ToLower().Contains(adres.ToLower())).ToList();
                    }
                    if (kodPocztowy != null)
                    {
                        result = result.Where(kod => kod.KodPocztowy.ToLower().Contains(kodPocztowy.ToLower())).ToList();
                    }
                    if (wojewodztwo != null)
                    {
                        result = result.Where(kod => kod.Wojewodztwo.ToLower().Contains(wojewodztwo.ToLower())).ToList();
                    }
                    if (wojewodztwo != null)
                    {
                        result = result.Where(kod => kod.Uwagi.ToLower().Contains(uwagi.ToLower())).ToList();
                    }
                    if (result.Count < 0)
                    {
                        throw new Exception("Nothing Found");
                    }

                    if (result.Count > 0)
                    {
                        foreach (var item in result)
                        {
                            localizationsResult.AddRange(db.Localizations.Where(l => l.KodyPocztoweId == item.Id).ToList());
                        }
                    }
                }
                stopwatch.Stop();

                kodyPocztoweSearchedBindingSource.DataSource = result;
                localizationSearchedBindingSource.DataSource = localizationsResult;

                MessageBox.Show($"Search Result: {result.Count} items \nIn time: {stopwatch.Elapsed}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
            }
        }

        private void editKodPocztowyButton_Click(object sender, EventArgs e)
        {
            try
            {
                kodPocztowyChangeGroupBox.Visible = true;
                var selectedRows = kodPocztowySearchedGridView.SelectedRows;

                if (selectedRows.Count > 0)
                {
                    var selectedRow = selectedRows[0];

                    changeKodPocztowyIdTextBox.Text = selectedRow.Cells[0].Value.ToString();
                    changeKodPocztowyTextBox.Text = selectedRow.Cells[1].Value.ToString();
                    changeKodPocztowyAdresTextBox.Text = selectedRow.Cells[2].Value.ToString();
                    changeKodPocztowyMiejscowoscTextBox.Text = selectedRow.Cells[3].Value.ToString();
                    changeKodPocztowyWojewodztwoTextBox.Text = selectedRow.Cells[4].Value.ToString();
                    changeKodPocztowyPowiatTextBox.Text = selectedRow.Cells[5].Value.ToString();
                    changeKodPocztowyUwagiTextBox.Text = selectedRow.Cells[6].Value.ToString();
                }
                else
                {
                    MessageBox.Show($"You have not selected any row to modify, and now a form to create a new object is displayed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
                kodPocztowyChangeGroupBox.Visible = false;
            }
        }

        private void changesKodPocztowyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (changeKodPocztowyIdTextBox.Text == "")
                {
                    using (Ajppablab4Context db = new())
                    {
                        KodyPocztowe newKodPoczotowy = new()
                        {
                            KodPocztowy = changeKodPocztowyTextBox.Text,
                            Miejscowosc = changeKodPocztowyMiejscowoscTextBox.Text,
                            Wojewodztwo = changeKodPocztowyWojewodztwoTextBox.Text,
                            Adres = changeKodPocztowyAdresTextBox.Text,
                            Powiat = changeKodPocztowyPowiatTextBox.Text,
                            Uwagi = changeKodPocztowyUwagiTextBox.Text,
                        };

                        db.KodyPocztowes.Add(newKodPoczotowy);
                        db.SaveChanges();
                    }
                }
                else
                {
                    int? id = null;
                    if (Int32.TryParse(changeKodPocztowyIdTextBox.Text, out _)) id = Int32.Parse(changeKodPocztowyIdTextBox.Text);

                    using (Ajppablab4Context db = new())
                    {
                        var updatedKodPocztowy = db.KodyPocztowes.Where(kp => kp.Id == id).FirstOrDefault();

                        updatedKodPocztowy.KodPocztowy = changeKodPocztowyTextBox.Text;
                        updatedKodPocztowy.Miejscowosc = changeKodPocztowyMiejscowoscTextBox.Text;
                        updatedKodPocztowy.Wojewodztwo = changeKodPocztowyWojewodztwoTextBox.Text;
                        updatedKodPocztowy.Adres = changeKodPocztowyAdresTextBox.Text;
                        updatedKodPocztowy.Powiat = changeKodPocztowyPowiatTextBox.Text;
                        updatedKodPocztowy.Uwagi = changeKodPocztowyUwagiTextBox.Text;

                        db.SaveChanges();
                    }
                }

                clearKodyResultDataGridView();
                clearLocalizationsResultDataGridView();
                fillKodyDataGridView();
                fillLocalizationsDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
            }
            finally
            {
                changeKodPocztowyTextBox.Text = "";
                changeKodPocztowyMiejscowoscTextBox.Text = "";
                changeKodPocztowyWojewodztwoTextBox.Text = "";
                changeKodPocztowyAdresTextBox.Text = "";
                changeKodPocztowyPowiatTextBox.Text = "";
                changeKodPocztowyUwagiTextBox.Text = "";
                kodPocztowyChangeGroupBox.Visible = false;
            }
        }

        private void deleteKodPocztowyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = null;
                if (Int32.TryParse(changeKodPocztowyIdTextBox.Text, out _)) id = Int32.Parse(changeKodPocztowyIdTextBox.Text);

                using (Ajppablab4Context db = new())
                {
                    var deletedKodPocztowy = db.KodyPocztowes.Where(kp => kp.Id == id).FirstOrDefault();
                    db.KodyPocztowes.Remove(deletedKodPocztowy);
                    db.SaveChanges();
                }

                clearKodyResultDataGridView();
                clearLocalizationsResultDataGridView();
                fillKodyDataGridView();
                fillLocalizationsDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
            }
            finally
            {
                changeKodPocztowyTextBox.Text = "";
                changeKodPocztowyMiejscowoscTextBox.Text = "";
                changeKodPocztowyWojewodztwoTextBox.Text = "";
                changeKodPocztowyAdresTextBox.Text = "";
                changeKodPocztowyPowiatTextBox.Text = "";
                changeKodPocztowyUwagiTextBox.Text = "";
                kodPocztowyChangeGroupBox.Visible = false;
            }
        }

        private void editLocalizationButton_Click(object sender, EventArgs e)
        {
            try
            {
                localizationChangeGroupBox.Visible = true;
                var selectedRows = localizationsSearchedGridView.SelectedRows;

                if (selectedRows.Count > 0)
                {
                    var selectedRow = selectedRows[0];

                    changeLocalizationIdTextBox.Text = selectedRow.Cells[0].Value.ToString();
                    changeLocalizationKodPocztowyIdTextBox.Text = selectedRow.Cells[3].Value.ToString();
                    changeLocalizationNameTextBox.Text = selectedRow.Cells[1].Value.ToString();
                    changeLocalizationDescriptionTextBox.Text = selectedRow.Cells[2].Value.ToString();
                }
                else
                {
                    MessageBox.Show($"You have not selected any row to modify, and now a form to create a new object is displayed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
                localizationChangeGroupBox.Visible = true;
            }
        }

        private void changesLocalizationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (changeLocalizationIdTextBox.Text == "")
                {
                    using (Ajppablab4Context db = new())
                    {
                        int id;
                        if (Int32.TryParse(changeLocalizationKodPocztowyIdTextBox.Text, out _))
                        {
                            id = Int32.Parse(changeLocalizationKodPocztowyIdTextBox.Text);
                            var foreingKodPocztowy = db.KodyPocztowes.Where(kp => kp.Id == id).FirstOrDefault();

                            if (foreingKodPocztowy == null)
                            {
                                MessageBox.Show($"You are trying to bind a new object to a non-existent 'Kode Pocztowy'");
                            }
                            else
                            {
                                Localization newLocalization = new()
                                {
                                    KodyPocztoweId = id,
                                    Name = changeLocalizationNameTextBox.Text,
                                    Description = changeLocalizationDescriptionTextBox.Text
                                };

                                db.Localizations.Add(newLocalization);
                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"'Kod Pocztowy Id' must be Integer");
                        }
                    }
                }
                else
                {
                    int id = Int32.Parse(changeLocalizationIdTextBox.Text);

                    using (Ajppablab4Context db = new())
                    {
                        var updatedLocalization = db.Localizations.Where(l => l.Id == id).FirstOrDefault();

                        int kodPocztowyId;
                        if (Int32.TryParse(changeLocalizationIdTextBox.Text, out _))
                        {
                            kodPocztowyId = Int32.Parse(changeLocalizationKodPocztowyIdTextBox.Text);

                            var foreingKodPocztowy = db.KodyPocztowes.Where(kp => kp.Id == id).FirstOrDefault();

                            if (foreingKodPocztowy == null)
                            {
                                MessageBox.Show($"You are trying to bind a new object to a non-existent 'Kode Pocztowy'");
                            }
                            else
                            {
                                updatedLocalization.KodyPocztoweId = kodPocztowyId;
                                updatedLocalization.Name = changeLocalizationNameTextBox.Text;
                                updatedLocalization.Description = changeLocalizationDescriptionTextBox.Text;

                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"'Kod Pocztowy Id' must be Integer");
                        }
                    }
                }

                clearKodyResultDataGridView();
                clearLocalizationsResultDataGridView();
                fillKodyDataGridView();
                fillLocalizationsDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
            }
            finally
            {
                changeLocalizationIdTextBox.Text = "";
                changeLocalizationDescriptionTextBox.Text = "";
                changeLocalizationNameTextBox.Text = "";
                changeLocalizationKodPocztowyIdTextBox.Text = "";
                localizationChangeGroupBox.Visible = false;
            }
        }

        private void deleteLocalizationButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (Ajppablab4Context db = new())
                {
                    int? id = null;
                    if (Int32.TryParse(changeLocalizationIdTextBox.Text, out _)) id = Int32.Parse(changeLocalizationIdTextBox.Text);

                    var deletedLocalization = db.Localizations.Where(kp => kp.Id == id).FirstOrDefault();
                    db.Localizations.Remove(deletedLocalization);
                    db.SaveChanges();
                }

                clearKodyResultDataGridView();
                clearLocalizationsResultDataGridView();
                fillKodyDataGridView();
                fillLocalizationsDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
            }
            finally
            {
                changeLocalizationIdTextBox.Text = "";
                changeLocalizationDescriptionTextBox.Text = "";
                changeLocalizationNameTextBox.Text = "";
                changeLocalizationKodPocztowyIdTextBox.Text = "";
                localizationChangeGroupBox.Visible = false;
            }
        }
    }
}
