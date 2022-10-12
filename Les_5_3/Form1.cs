namespace Les_5_3
{
    public partial class Form1 : Form
    {
        int[] Wachttijden = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                Wachttijden[i] = new Random().Next(2000);

            DateTime starttijd = DateTime.Now;

            tbAsynchroonResult.Text = "";
            for (int i=0; i<10; i++)
            {
                TraagheidAsynchroon traagheid = new TraagheidAsynchroon(i, Wachttijden[i], tbAsynchroonResult);
                traagheid.Wacht();
            }
            tbAsynchroonTijd.Text = (DateTime.Now - starttijd).ToString();


            tbSynchroonResultaat.Text = "";
            for (int i=0; i<10; i++)
            {
                Traagheid traagheid = new Traagheid(i, Wachttijden[i]);
                tbSynchroonResultaat.Text += traagheid.Wacht();
            }

            tbSynchroonTijd.Text = (DateTime.Now - starttijd).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}