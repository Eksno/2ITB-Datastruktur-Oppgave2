namespace _2ITB_Datastruktur_Oppgave1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Globals.AddBasicCarBrands(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = Globals.AddCarBrand(this, txtInputField.Text);

            if (!success)
            {
                lblWarn.Text = "Brand + \"" + txtInputField.Text + "\" already exists";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool success = Globals.RemoveCarBrand(this, lblDebug, txtInputField.Text);

            if (!success)
            {
                lblWarn.Text = "Index of brand or brand name \"" + txtInputField.Text + "\" does not exist";
            }
        }
    }
}