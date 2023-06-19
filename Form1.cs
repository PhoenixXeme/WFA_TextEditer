namespace WFA_TextEditer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path;
        StreamWriter sw = null;
        StreamReader sr = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {

            path = tb_load_path.Text;
            if (path.Contains(".txt"))
            {
                sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    tb_edit.Text += line + "\r\n";
                }
                sr.Close();
                lbl_fileName.Text = Path.GetFileName(path);
            }
            else
            {
                MessageBox.Show("Not a valid path or file type");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                sw = new StreamWriter(path);
                for (int i = 0; i < tb_edit.Lines.Length; i++)
                {
                    sw.WriteLine(tb_edit.Lines[i].ToString());
                }
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Cant find file location");
            }
        }

        private void cb_theme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}