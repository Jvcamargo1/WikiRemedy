namespace WikiRemedy
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        bool submenuexpand;
        bool butttom1expand;
        bool panelsub2expand;
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelsidebar_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void panellogo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void panelsub2timer_Tick(object sender, EventArgs e)
        {
            if (butttom1expand)
            {
                panelsub1.Height -= 10;
                if (panelsub1.Height == panelsub1.MinimumSize.Height)
                {
                    butttom1expand = false;
                    panelsub1timer.Stop();
                }
            }         
            else
            {
                panelsub1.Height += 10;
                if (panelsub1.Height == panelsub1.MaximumSize.Height)
                {
                    butttom1expand = true;
                    panelsub1timer.Stop();
                }
            }
        }

        private void sidebartime_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelsidebar.Width -= 10;
                if (panelsidebar.Width == panelsidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartime.Stop();
                }
            }
            else
            {
                panelsidebar.Width += 10;
                if (panelsidebar.Width == panelsidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartime.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form25());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm (Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void panelchildform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btmcreditos_Click(object sender, EventArgs e)
        {
            openChildForm(new Creditos());
        }

        private void picHome4_Click(object sender, EventArgs e)
        {
            sidebartime.Start();
        }

        private void panelsub1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form26());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            openChildForm(new Form19());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new Form13());
        }

        private void button26_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Form8());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new Form9());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new Form10());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new Form11());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new Form27());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new Form14());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            openChildForm(new Form15());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            openChildForm(new Form16());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            openChildForm(new Form17());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            openChildForm(new Form18());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void button22_Click(object sender, EventArgs e)
        {
            openChildForm(new Form20());
        }

        private void button23_Click(object sender, EventArgs e)
        {
            openChildForm(new Form21());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            openChildForm(new Form22());
        }

        private void button25_Click(object sender, EventArgs e)
        {
            openChildForm(new Form24());
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form23());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form12());
        }
    }
}