namespace Tugas_Pertemuan_7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            labelTitle = new Label();
            labelSubtitle = new Label();

            panelInput = new Panel();
            labelInputTitle = new Label();

            labelT1 = new Label();
            labelT2 = new Label();
            labelT3 = new Label();
            labelT4 = new Label();
            labelT5 = new Label();
            labelUTS = new Label();
            labelUAS = new Label();

            textBoxT1 = new TextBox();
            textBoxT2 = new TextBox();
            textBoxT3 = new TextBox();
            textBoxT4 = new TextBox();
            textBoxT5 = new TextBox();
            textBoxUTS = new TextBox();
            textBoxUAS = new TextBox();

            buttonHitung = new Button();
            buttonReset = new Button();

            panelResult = new Panel();
            labelResultTitle = new Label();

            labelRataTugas = new Label();
            labelUTSResult = new Label();
            labelUASResult = new Label();
            labelNilaiAkhir = new Label();
            labelKategori = new Label();
            labelStatus = new Label();

            labelRataTugasValue = new Label();
            labelUTSValue = new Label();
            labelUASValue = new Label();
            labelNilaiAkhirValue = new Label();
            labelKategoriValue = new Label();
            labelStatusValue = new Label();

            SuspendLayout();

            // =========================
            // FORM
            // =========================
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.FromArgb(242, 245, 249);
            ClientSize = new Size(1000, 650);

            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem Penilaian Mahasiswa";

            // =========================
            // HEADER
            // =========================
            panelHeader.BackColor = Color.FromArgb(31, 78, 121);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Size = new Size(1000, 115);

            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(40, 22);
            labelTitle.Text = "SISTEM PENILAIAN MAHASISWA";
            labelTitle.Font = new Font(
                "Segoe UI",
                22F,
                FontStyle.Bold
            );
            labelTitle.ForeColor = Color.White;

            labelSubtitle.AutoSize = true;
            labelSubtitle.Location = new Point(43, 70);
            labelSubtitle.Text =
                "Perhitungan nilai akhir dan kategori fuzzy";
            labelSubtitle.ForeColor =
                Color.FromArgb(220, 230, 240);

            panelHeader.Controls.Add(labelTitle);
            panelHeader.Controls.Add(labelSubtitle);

            // =========================
            // PANEL INPUT
            // =========================
            panelInput.BackColor = Color.White;
            panelInput.BorderStyle = BorderStyle.FixedSingle;
            panelInput.Location = new Point(40, 145);
            panelInput.Size = new Size(420, 440);

            labelInputTitle.AutoSize = true;
            labelInputTitle.Location = new Point(25, 20);
            labelInputTitle.Text = "Input Nilai";
            labelInputTitle.Font = new Font(
                "Segoe UI",
                15F,
                FontStyle.Bold
            );
            labelInputTitle.ForeColor =
                Color.FromArgb(31, 78, 121);

            // =========================
            // LABEL INPUT
            // =========================
            labelT1.Text = "Tugas 1";
            labelT1.AutoSize = true;
            labelT1.Location = new Point(35, 80);

            labelT2.Text = "Tugas 2";
            labelT2.AutoSize = true;
            labelT2.Location = new Point(35, 125);

            labelT3.Text = "Tugas 3";
            labelT3.AutoSize = true;
            labelT3.Location = new Point(35, 170);

            labelT4.Text = "Tugas 4";
            labelT4.AutoSize = true;
            labelT4.Location = new Point(35, 215);

            labelT5.Text = "Tugas 5";
            labelT5.AutoSize = true;
            labelT5.Location = new Point(35, 260);

            labelUTS.Text = "UTS";
            labelUTS.AutoSize = true;
            labelUTS.Location = new Point(35, 305);

            labelUAS.Text = "UAS";
            labelUAS.AutoSize = true;
            labelUAS.Location = new Point(35, 350);

            // =========================
            // TEXTBOX
            // =========================
            textBoxT1.Location = new Point(160, 75);
            textBoxT1.Size = new Size(210, 25);

            textBoxT2.Location = new Point(160, 120);
            textBoxT2.Size = new Size(210, 25);

            textBoxT3.Location = new Point(160, 165);
            textBoxT3.Size = new Size(210, 25);

            textBoxT4.Location = new Point(160, 210);
            textBoxT4.Size = new Size(210, 25);

            textBoxT5.Location = new Point(160, 255);
            textBoxT5.Size = new Size(210, 25);

            textBoxUTS.Location = new Point(160, 300);
            textBoxUTS.Size = new Size(210, 25);

            textBoxUAS.Location = new Point(160, 345);
            textBoxUAS.Size = new Size(210, 25);

            // =========================
            // BUTTON HITUNG
            // =========================
            buttonHitung.Text = "Hitung Nilai";
            buttonHitung.Location = new Point(160, 390);
            buttonHitung.Size = new Size(130, 35);

            buttonHitung.BackColor =
                Color.FromArgb(31, 78, 121);

            buttonHitung.ForeColor = Color.White;
            buttonHitung.FlatStyle = FlatStyle.Flat;
            buttonHitung.FlatAppearance.BorderSize = 0;

            buttonHitung.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            buttonHitung.Click +=
                buttonHitung_Click;

            // =========================
            // BUTTON RESET
            // =========================
            buttonReset.Text = "Reset";
            buttonReset.Location = new Point(300, 390);
            buttonReset.Size = new Size(70, 35);

            buttonReset.BackColor =
                Color.FromArgb(220, 223, 228);

            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.FlatAppearance.BorderSize = 0;

            buttonReset.Click +=
                buttonReset_Click;

            panelInput.Controls.Add(labelInputTitle);

            panelInput.Controls.Add(labelT1);
            panelInput.Controls.Add(labelT2);
            panelInput.Controls.Add(labelT3);
            panelInput.Controls.Add(labelT4);
            panelInput.Controls.Add(labelT5);
            panelInput.Controls.Add(labelUTS);
            panelInput.Controls.Add(labelUAS);

            panelInput.Controls.Add(textBoxT1);
            panelInput.Controls.Add(textBoxT2);
            panelInput.Controls.Add(textBoxT3);
            panelInput.Controls.Add(textBoxT4);
            panelInput.Controls.Add(textBoxT5);
            panelInput.Controls.Add(textBoxUTS);
            panelInput.Controls.Add(textBoxUAS);

            panelInput.Controls.Add(buttonHitung);
            panelInput.Controls.Add(buttonReset);

            // =========================
            // PANEL HASIL
            // =========================
            panelResult.BackColor = Color.White;
            panelResult.BorderStyle = BorderStyle.FixedSingle;
            panelResult.Location = new Point(490, 145);
            panelResult.Size = new Size(470, 440);

            labelResultTitle.Text = "Hasil Perhitungan";
            labelResultTitle.AutoSize = true;
            labelResultTitle.Location = new Point(30, 20);

            labelResultTitle.Font = new Font(
                "Segoe UI",
                15F,
                FontStyle.Bold
            );

            labelResultTitle.ForeColor =
                Color.FromArgb(31, 78, 121);

            // =========================
            // LABEL HASIL
            // =========================
            labelRataTugas.Text = "Rata-rata Tugas";
            labelRataTugas.AutoSize = true;
            labelRataTugas.Location = new Point(35, 90);

            labelUTSResult.Text = "Nilai UTS";
            labelUTSResult.AutoSize = true;
            labelUTSResult.Location = new Point(35, 135);

            labelUASResult.Text = "Nilai UAS";
            labelUASResult.AutoSize = true;
            labelUASResult.Location = new Point(35, 180);

            labelNilaiAkhir.Text = "Nilai Akhir";
            labelNilaiAkhir.AutoSize = true;
            labelNilaiAkhir.Location = new Point(35, 240);

            labelKategori.Text = "Kategori Fuzzy";
            labelKategori.AutoSize = true;
            labelKategori.Location = new Point(35, 300);

            labelStatus.Text = "Status";
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(35, 360);

            // =========================
            // NILAI HASIL
            // =========================
            labelRataTugasValue.Text = "-";
            labelRataTugasValue.AutoSize = true;
            labelRataTugasValue.Location =
                new Point(270, 90);

            labelUTSValue.Text = "-";
            labelUTSValue.AutoSize = true;
            labelUTSValue.Location =
                new Point(270, 135);

            labelUASValue.Text = "-";
            labelUASValue.AutoSize = true;
            labelUASValue.Location =
                new Point(270, 180);

            labelNilaiAkhirValue.Text = "-";
            labelNilaiAkhirValue.AutoSize = true;
            labelNilaiAkhirValue.Location =
                new Point(270, 230);

            labelNilaiAkhirValue.Font = new Font(
                "Segoe UI",
                20F,
                FontStyle.Bold
            );

            labelNilaiAkhirValue.ForeColor =
                Color.FromArgb(31, 78, 121);

            labelKategoriValue.Text = "-";
            labelKategoriValue.AutoSize = true;
            labelKategoriValue.Location =
                new Point(270, 292);

            labelKategoriValue.Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Bold
            );

            labelStatusValue.Text = "-";
            labelStatusValue.AutoSize = true;
            labelStatusValue.Location =
                new Point(270, 350);

            labelStatusValue.Font = new Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );

            panelResult.Controls.Add(labelResultTitle);

            panelResult.Controls.Add(labelRataTugas);
            panelResult.Controls.Add(labelUTSResult);
            panelResult.Controls.Add(labelUASResult);
            panelResult.Controls.Add(labelNilaiAkhir);
            panelResult.Controls.Add(labelKategori);
            panelResult.Controls.Add(labelStatus);

            panelResult.Controls.Add(labelRataTugasValue);
            panelResult.Controls.Add(labelUTSValue);
            panelResult.Controls.Add(labelUASValue);
            panelResult.Controls.Add(labelNilaiAkhirValue);
            panelResult.Controls.Add(labelKategoriValue);
            panelResult.Controls.Add(labelStatusValue);

            // =========================
            // TAMBAHKAN KE FORM
            // =========================
            Controls.Add(panelHeader);
            Controls.Add(panelInput);
            Controls.Add(panelResult);

            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Label labelSubtitle;

        private Panel panelInput;
        private Label labelInputTitle;

        private Label labelT1;
        private Label labelT2;
        private Label labelT3;
        private Label labelT4;
        private Label labelT5;
        private Label labelUTS;
        private Label labelUAS;

        private TextBox textBoxT1;
        private TextBox textBoxT2;
        private TextBox textBoxT3;
        private TextBox textBoxT4;
        private TextBox textBoxT5;
        private TextBox textBoxUTS;
        private TextBox textBoxUAS;

        private Button buttonHitung;
        private Button buttonReset;

        private Panel panelResult;
        private Label labelResultTitle;

        private Label labelRataTugas;
        private Label labelUTSResult;
        private Label labelUASResult;
        private Label labelNilaiAkhir;
        private Label labelKategori;
        private Label labelStatus;

        private Label labelRataTugasValue;
        private Label labelUTSValue;
        private Label labelUASValue;
        private Label labelNilaiAkhirValue;
        private Label labelKategoriValue;
        private Label labelStatusValue;
    }
}