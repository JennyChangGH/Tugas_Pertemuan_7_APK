namespace Tugas_Pertemuan_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHitung_Click(object? sender, EventArgs e)
        {
            // Validasi input
            if (!TryParseScores(
                out double t1,
                out double t2,
                out double t3,
                out double t4,
                out double t5,
                out double uts,
                out double uas))
            {
                MessageBox.Show(
                    "Pastikan semua nilai diisi dengan angka antara 0 sampai 100.",
                    "Input Tidak Valid",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Hitung rata-rata tugas
            double rataRataTugas =
                (t1 + t2 + t3 + t4 + t5) / 5.0;

            // Hitung nilai akhir
            double nilaiAkhir =
                (rataRataTugas * 0.50) +
                (uts * 0.20) +
                (uas * 0.30);

            // Tentukan grade
            string grade = GetGrade(nilaiAkhir);

            // Tentukan kategori fuzzy
            string kategoriFuzzy = GetFuzzyCategory(nilaiAkhir);

            // Tentukan status
            string status =
                nilaiAkhir >= 60
                ? "LULUS"
                : "TIDAK LULUS";

            // Tampilkan hasil
            labelRataTugasValue.Text =
                rataRataTugas.ToString("F2");

            labelUTSValue.Text =
                uts.ToString("F2");

            labelUASValue.Text =
                uas.ToString("F2");

            labelNilaiAkhirValue.Text =
                nilaiAkhir.ToString("F2");

            labelKategoriValue.Text =
                $"{grade} - {kategoriFuzzy}";

            labelStatusValue.Text =
                status;
        }

        private bool TryParseScores(
            out double t1,
            out double t2,
            out double t3,
            out double t4,
            out double t5,
            out double uts,
            out double uas)
        {
            t1 = 0;
            t2 = 0;
            t3 = 0;
            t4 = 0;
            t5 = 0;
            uts = 0;
            uas = 0;

            bool valid =
                double.TryParse(textBoxT1.Text, out t1) &&
                double.TryParse(textBoxT2.Text, out t2) &&
                double.TryParse(textBoxT3.Text, out t3) &&
                double.TryParse(textBoxT4.Text, out t4) &&
                double.TryParse(textBoxT5.Text, out t5) &&
                double.TryParse(textBoxUTS.Text, out uts) &&
                double.TryParse(textBoxUAS.Text, out uas);

            if (!valid)
            {
                return false;
            }

            return
                InRange(t1) &&
                InRange(t2) &&
                InRange(t3) &&
                InRange(t4) &&
                InRange(t5) &&
                InRange(uts) &&
                InRange(uas);
        }

        private static bool InRange(double nilai)
        {
            return nilai >= 0 && nilai <= 100;
        }

        private static string GetGrade(double nilai)
        {
            if (nilai >= 85)
                return "A";

            if (nilai >= 70)
                return "B";

            if (nilai >= 60)
                return "C";

            if (nilai >= 50)
                return "D";

            return "E";
        }

        private static string GetFuzzyCategory(double nilai)
        {
            if (nilai >= 85)
                return "Tinggi";

            if (nilai >= 70)
                return "Sedang";

            if (nilai >= 60)
                return "Cukup";

            if (nilai >= 50)
                return "Kurang";

            return "Rendah";
        }

        private void buttonReset_Click(object? sender, EventArgs e)
        {
            textBoxT1.Clear();
            textBoxT2.Clear();
            textBoxT3.Clear();
            textBoxT4.Clear();
            textBoxT5.Clear();
            textBoxUTS.Clear();
            textBoxUAS.Clear();

            labelRataTugasValue.Text = "-";
            labelUTSValue.Text = "-";
            labelUASValue.Text = "-";
            labelNilaiAkhirValue.Text = "-";
            labelKategoriValue.Text = "-";
            labelStatusValue.Text = "-";

            textBoxT1.Focus();
        }
    }
}