using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;

namespace UDO.Forms
{
    public partial class GuzergahEkleDuzenleForm : Form
    {
        private readonly GuzergahManager guzergahManager;
        private readonly bool duzenleModu;
        private int guzergahID;
        private List<GuzergahIskele> guzergahIskeleler;

        // Constructor for adding a new route
        public GuzergahEkleDuzenleForm()
        {
            InitializeComponent();
            guzergahManager = new GuzergahManager();
            duzenleModu = false;
            guzergahID = 0;
            guzergahIskeleler = new List<GuzergahIskele>();
        }

        // Constructor for editing an existing route
        public GuzergahEkleDuzenleForm(int guzergahID)
        {
            InitializeComponent();
            guzergahManager = new GuzergahManager();
            duzenleModu = true;
            this.guzergahID = guzergahID;
            guzergahIskeleler = new List<GuzergahIskele>();
        }

        private void GuzergahEkleDuzenleForm_Load(object sender, EventArgs e)
        {
            // Set up the form based on whether it's Add or Edit mode
            ConfigureForm();

            // Load available iskeleler (piers/docks)
            LoadIskeleler();

            if (duzenleModu)
            {
                // Load existing route data for editing
                LoadExistingGuzergah();
            }
        }

        private void ConfigureForm()
        {
            if (duzenleModu)
            {
                lblBaslik.Text = "GÜZERGAH DÜZENLE";
                this.Text = "Güzergah Düzenle";
            }
            else
            {
                lblBaslik.Text = "YENİ GÜZERGAH EKLE";
                this.Text = "Güzergah Ekle";
            }
        }

        private void LoadIskeleler()
        {
            try
            {
                DataTable iskeleTablosu = guzergahManager.TumIskeleleriGetir();

                // Populate the combo box with available piers
                cmbMevcutIskeleler.DisplayMember = "IskeleAdi";
                cmbMevcutIskeleler.ValueMember = "IskeleID";
                cmbMevcutIskeleler.DataSource = iskeleTablosu;

                // Clear selection
                cmbMevcutIskeleler.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İskeleler yüklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExistingGuzergah()
        {
            try
            {
                // Get route details
                DataTable guzergahDetay = guzergahManager.GuzergahGetirById(guzergahID);

                if (guzergahDetay != null && guzergahDetay.Rows.Count > 0)
                {
                    DataRow guzergahSatir = guzergahDetay.Rows[0];

                    // Populate form fields with route data
                    txtGuzergahKodu.Text = guzergahSatir["GuzergahKodu"].ToString();
                    txtGuzergahAdi.Text = guzergahSatir["GuzergahAdi"].ToString();
                    txtAciklama.Text = guzergahSatir["Aciklama"] != DBNull.Value ? guzergahSatir["Aciklama"].ToString() : "";
                    txtMesafe.Text = guzergahSatir["MesafeKM"] != DBNull.Value ? guzergahSatir["MesafeKM"].ToString() : "";
                    txtTahminiSure.Text = guzergahSatir["TahminiSureDakika"] != DBNull.Value ? guzergahSatir["TahminiSureDakika"].ToString() : "";
                    chkAktif.Checked = Convert.ToBoolean(guzergahSatir["AktifMi"]);

                    // Get route-pier relationships
                    DataTable guzergahIskelelerTablosu = guzergahManager.GuzergahIskeleleriniGetir(guzergahID);

                    // Clear current list and add loaded items
                    guzergahIskeleler.Clear();

                    foreach (DataRow row in guzergahIskelelerTablosu.Rows)
                    {
                        GuzergahIskele iskele = new GuzergahIskele
                        {
                            GuzergahID = guzergahID,
                            IskeleID = Convert.ToInt32(row["IskeleID"]),
                            IskeleAdi = row["IskeleAdi"].ToString(),
                            SiraNo = Convert.ToInt32(row["SiraNo"]),
                            BeklemesDakika = Convert.ToInt32(row["BeklemesDakika"]),
                            Aciklama = row["Aciklama"] != DBNull.Value ? row["Aciklama"].ToString() : "",
                            ZorunluDurak = Convert.ToBoolean(row["ZorunluDurak"])
                        };

                        guzergahIskeleler.Add(iskele);
                    }

                    // Update the list view
                    GuncelleGuzergahIskelelerListesi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güzergah bilgileri yüklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuncelleGuzergahIskelelerListesi()
        {
            // Clear the list view
            lstGuzergahIskeleler.Items.Clear();

            // Sort the list by order number
            guzergahIskeleler.Sort((a, b) => a.SiraNo.CompareTo(b.SiraNo));

            // Add all items to the list view
            foreach (GuzergahIskele iskele in guzergahIskeleler)
            {
                ListViewItem item = new ListViewItem(iskele.SiraNo.ToString());
                item.SubItems.Add(iskele.IskeleAdi);
                item.SubItems.Add(iskele.BeklemesDakika.ToString() + " dk");
                item.SubItems.Add(iskele.ZorunluDurak ? "Evet" : "Hayır");
                item.SubItems.Add(iskele.Aciklama);
                item.Tag = iskele.IskeleID; // Store the IskeleID in the Tag property for reference

                lstGuzergahIskeleler.Items.Add(item);
            }

            // Update the status label
            lblDurakSayisi.Text = $"Toplam Durak Sayısı: {guzergahIskeleler.Count}";
        }

        private void btnIskeleEkle_Click(object sender, EventArgs e)
        {
            // Validate selection
            if (cmbMevcutIskeleler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen eklemek için bir iskele seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected pier
            int iskeleID = Convert.ToInt32(cmbMevcutIskeleler.SelectedValue);
            string iskeleAdi = cmbMevcutIskeleler.Text;

            // Check if this pier is already in the route
            if (guzergahIskeleler.Exists(x => x.IskeleID == iskeleID))
            {
                MessageBox.Show("Bu iskele zaten güzergaha eklenmiş.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create new route-pier relationship
            GuzergahIskele yeniIskele = new GuzergahIskele
            {
                GuzergahID = guzergahID,
                IskeleID = iskeleID,
                IskeleAdi = iskeleAdi,
                SiraNo = guzergahIskeleler.Count + 1, // Set as next in order
                BeklemesDakika = Convert.ToInt32(numBeklemeSuresi.Value),
                ZorunluDurak = chkZorunluDurak.Checked,
                Aciklama = txtDurakAciklama.Text.Trim()
            };

            // Add to list and update UI
            guzergahIskeleler.Add(yeniIskele);
            GuncelleGuzergahIskelelerListesi();

            // Clear inputs
            cmbMevcutIskeleler.SelectedIndex = -1;
            numBeklemeSuresi.Value = 5;
            chkZorunluDurak.Checked = true;
            txtDurakAciklama.Clear();
        }

        private void btnIskeleSil_Click(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (lstGuzergahIskeleler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir durak seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected item
            ListViewItem selectedItem = lstGuzergahIskeleler.SelectedItems[0];
            int iskeleID = (int)selectedItem.Tag;

            // Confirm deletion
            DialogResult result = MessageBox.Show("Seçili durak güzergahtan silinecek. Devam etmek istiyor musunuz?",
                "Durak Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Remove from list
                guzergahIskeleler.RemoveAll(x => x.IskeleID == iskeleID);

                // Reorder remaining items
                for (int i = 0; i < guzergahIskeleler.Count; i++)
                {
                    guzergahIskeleler[i].SiraNo = i + 1;
                }

                // Update UI
                GuncelleGuzergahIskelelerListesi();
            }
        }

        private void btnIskeleDuzenle_Click(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (lstGuzergahIskeleler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir durak seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected item
            ListViewItem selectedItem = lstGuzergahIskeleler.SelectedItems[0];
            int iskeleID = (int)selectedItem.Tag;

            // Find the corresponding item in the list
            GuzergahIskele secilenIskele = guzergahIskeleler.Find(x => x.IskeleID == iskeleID);

            if (secilenIskele != null)
            {
                // Populate edit fields
                cmbMevcutIskeleler.SelectedValue = secilenIskele.IskeleID;
                numBeklemeSuresi.Value = secilenIskele.BeklemesDakika;
                chkZorunluDurak.Checked = secilenIskele.ZorunluDurak;
                txtDurakAciklama.Text = secilenIskele.Aciklama;

                // Change button function to update
                btnIskeleEkle.Text = "Güncelle";
                btnIskeleEkle.Tag = iskeleID;

                // Add cancel button functionality
                btnIptalEt.Visible = true;
            }
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            // Reset edit fields
            cmbMevcutIskeleler.SelectedIndex = -1;
            numBeklemeSuresi.Value = 5;
            chkZorunluDurak.Checked = true;
            txtDurakAciklama.Clear();

            // Reset button function
            btnIskeleEkle.Text = "Ekle";
            btnIskeleEkle.Tag = null;

            // Hide cancel button
            btnIptalEt.Visible = false;
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (lstGuzergahIskeleler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen taşımak için bir durak seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected item
            ListViewItem selectedItem = lstGuzergahIskeleler.SelectedItems[0];
            int iskeleID = (int)selectedItem.Tag;

            // Find the corresponding item in the list
            GuzergahIskele secilenIskele = guzergahIskeleler.Find(x => x.IskeleID == iskeleID);

            if (secilenIskele != null && secilenIskele.SiraNo > 1)
            {
                // Find the item above
                GuzergahIskele ustIskele = guzergahIskeleler.Find(x => x.SiraNo == secilenIskele.SiraNo - 1);

                if (ustIskele != null)
                {
                    // Swap order numbers
                    int tempSiraNo = secilenIskele.SiraNo;
                    secilenIskele.SiraNo = ustIskele.SiraNo;
                    ustIskele.SiraNo = tempSiraNo;

                    // Update UI
                    GuncelleGuzergahIskelelerListesi();

                    // Re-select the moved item
                    foreach (ListViewItem item in lstGuzergahIskeleler.Items)
                    {
                        if ((int)item.Tag == iskeleID)
                        {
                            item.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (lstGuzergahIskeleler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen taşımak için bir durak seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected item
            ListViewItem selectedItem = lstGuzergahIskeleler.SelectedItems[0];
            int iskeleID = (int)selectedItem.Tag;

            // Find the corresponding item in the list
            GuzergahIskele secilenIskele = guzergahIskeleler.Find(x => x.IskeleID == iskeleID);

            if (secilenIskele != null && secilenIskele.SiraNo < guzergahIskeleler.Count)
            {
                // Find the item below
                GuzergahIskele altIskele = guzergahIskeleler.Find(x => x.SiraNo == secilenIskele.SiraNo + 1);

                if (altIskele != null)
                {
                    // Swap order numbers
                    int tempSiraNo = secilenIskele.SiraNo;
                    secilenIskele.SiraNo = altIskele.SiraNo;
                    altIskele.SiraNo = tempSiraNo;

                    // Update UI
                    GuncelleGuzergahIskelelerListesi();

                    // Re-select the moved item
                    foreach (ListViewItem item in lstGuzergahIskeleler.Items)
                    {
                        if ((int)item.Tag == iskeleID)
                        {
                            item.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Validate input
            if (!ValidateInput())
                return;

            try
            {
                bool success;

                if (duzenleModu)
                {
                    // Update existing route
                    success = guzergahManager.GuzergahGuncelle(
                        guzergahID,
                        txtGuzergahKodu.Text.Trim(),
                        txtGuzergahAdi.Text.Trim(),
                        txtAciklama.Text.Trim(),
                        !string.IsNullOrEmpty(txtMesafe.Text) ? Convert.ToDouble(txtMesafe.Text) : 0,
                        !string.IsNullOrEmpty(txtTahminiSure.Text) ? Convert.ToInt32(txtTahminiSure.Text) : 0,
                        chkAktif.Checked,
                        guzergahIskeleler
                    );

                    if (success)
                    {
                        MessageBox.Show("Güzergah başarıyla güncellendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Güzergah güncellenirken bir hata oluştu.", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Add new route
                    success = guzergahManager.GuzergahEkle(
                        txtGuzergahKodu.Text.Trim(),
                        txtGuzergahAdi.Text.Trim(),
                        txtAciklama.Text.Trim(),
                        !string.IsNullOrEmpty(txtMesafe.Text) ? Convert.ToDouble(txtMesafe.Text) : 0,
                        !string.IsNullOrEmpty(txtTahminiSure.Text) ? Convert.ToInt32(txtTahminiSure.Text) : 0,
                        chkAktif.Checked,
                        guzergahIskeleler,
                        out guzergahID
                    );

                    if (success)
                    {
                        MessageBox.Show("Yeni güzergah başarıyla eklendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Güzergah eklenirken bir hata oluştu.", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Check route code
            if (string.IsNullOrEmpty(txtGuzergahKodu.Text.Trim()))
            {
                MessageBox.Show("Güzergah kodu boş olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuzergahKodu.Focus();
                return false;
            }

            // Check route name
            if (string.IsNullOrEmpty(txtGuzergahAdi.Text.Trim()))
            {
                MessageBox.Show("Güzergah adı boş olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuzergahAdi.Focus();
                return false;
            }

            // Check if there are at least 2 piers in the route
            if (guzergahIskeleler.Count < 2)
            {
                MessageBox.Show("Bir güzergahta en az 2 iskele bulunmalıdır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check distance
            if (!string.IsNullOrEmpty(txtMesafe.Text.Trim()))
            {
                double mesafe;
                if (!double.TryParse(txtMesafe.Text, out mesafe) || mesafe <= 0)
                {
                    MessageBox.Show("Mesafe pozitif bir sayı olmalıdır.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMesafe.Focus();
                    return false;
                }
            }

            // Check estimated time
            if (!string.IsNullOrEmpty(txtTahminiSure.Text.Trim()))
            {
                int sure;
                if (!int.TryParse(txtTahminiSure.Text, out sure) || sure <= 0)
                {
                    MessageBox.Show("Tahmini süre pozitif bir sayı olmalıdır.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTahminiSure.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Değişiklikleriniz kaydedilmeyecek. Devam etmek istiyor musunuz?",
                "İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        // Helper method to allow only numbers and decimal point in TextBox
        private void txtSayisal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        // Helper method to allow only integers in TextBox
        private void txtTamSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}