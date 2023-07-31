namespace nesnefinal2
{
    public partial class Form1 : Form
    {
        
        int ilkterim;
        int ortakfark;
        int diziuzunlugu;
        int sondeger,ilkdeger;
        int top = 0 ;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ilkterim = Convert.ToInt32(textBox1.Text);
            ortakfark = Convert.ToInt32(textBox2.Text);
            diziuzunlugu = Convert.ToInt32(textBox3.Text);
            sondeger = ilkterim + ortakfark * diziuzunlugu - ortakfark;
            ilkdeger = ilkterim ;
            top = (ilkdeger + sondeger) / 2 * diziuzunlugu ;

            textBox4.Text =Convert.ToString(top);
            
        }
    }
}