namespace Latih8_WinformEvent
{
    public partial class Form1 : Form
    {

        private List<KaryawanModel> _listKaryawan;
        private BindingSource _bindingSource;

        public Form1()
        {
            InitializeComponent();
            GenerateData();
        }

        public void GenerateData()
        {
            _listKaryawan = new List<KaryawanModel>
            {
                new KaryawanModel("16650", "Rifki Ardian", new DateTime(2008, 4, 3), "Laki-laki", "Puri Indah Santoso C4, Bantul", "manager Personal"),
                new KaryawanModel("16651", "Ardian Yoga", new DateTime(2004, 9, 2), "Laki-laki", "Jl.Kaliurang Km 3, Sleman", "Manager"),
                new KaryawanModel("16652", "Rifki Sigit", new DateTime(2005, 4, 8), "Laki-laki", "Mranggen CT4/211, Jogjakarta", "Manager Pemasaran"),
                new KaryawanModel("16653", "Lathif Nur", new DateTime(2007, 4, 5), "Laki-laki", "Pelem Legi-1, Parangtritis", "Manager Pabrik"),
                new KaryawanModel("16654", "Rifki Daffa", new DateTime(2008, 2, 7), "Laki-laki", "Puri Indah Santoso C4, Bantul", "Administrasi"),
                new KaryawanModel("16655", "Bintang Riando", new DateTime(2008, 8, 4), "Laki-laki", "Suryatmajan GT-V/311, Jogjakarta", "Administrasi"),

            };

            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _listKaryawan;


            comboBox1.Items.Add("Laki-Laki");
            comboBox1.Items.Add("Perempuan");

            comboBox2.Items.Add("Manager");
            comboBox2.Items.Add("Manager Personal");
            comboBox2.Items.Add("Manager Pemasaran");
            comboBox2.Items.Add("Administrasi");
            comboBox2.Items.Add("Manager Pabrik");

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.Columns["NIK"].Width = 50;
            dataGridView1.Columns["Nama"].Width = 150;
            dataGridView1.Columns["TglLahir"].Width = 100;
            dataGridView1.Columns["Gender"].Width = 100;
            dataGridView1.Columns["Alamat"].Width = 150;
            dataGridView1.Columns["Job"].Width = 100;
            dataGridView1.Columns["TglLahir"].DefaultCellStyle.Format = "dd-MM-yyyy";

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var nik = dataGridView1.CurrentRow.Cells["NIK"].Value.ToString();
            var karyawan = _listKaryawan.FirstOrDefault(x => x.NIK == nik);

            textBox1.Text = karyawan.NIK;
            textBox2.Text = karyawan.Nama;
            dateTimePicker1.Value = karyawan.TglLahir;
            comboBox1.Text = karyawan.Gender;
            richTextBox1.Text = karyawan.Alamat;
            comboBox2.Text = karyawan.Job;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            _listKaryawan.FirstOrDefault(x => x.NIK == textBox1.Text).Nama = textBox2.Text;
            dataGridView1.Refresh();
        }

        private void richTextBox1_Validated(object sender, EventArgs e)
        {
            _listKaryawan.FirstOrDefault(x => x.NIK == textBox1.Text).Alamat = richTextBox1.Text;
            dataGridView1.Refresh();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _listKaryawan.FirstOrDefault(x => x.NIK == textBox1.Text).TglLahir = dateTimePicker1.Value;
            dataGridView1.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _listKaryawan.FirstOrDefault(x => x.NIK == textBox1.Text).Job = comboBox2.Text;
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _listKaryawan.FirstOrDefault(x => x.NIK == textBox1.Text).Gender = comboBox1.Text;
            dataGridView1.Refresh();
        }
    }
}
