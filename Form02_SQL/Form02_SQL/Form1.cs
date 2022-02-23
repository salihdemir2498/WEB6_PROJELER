using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Form02_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Buraya yazılacaklar çalıştırılması denecek kodlar.Eğer çalışıyorsa, sorun yok.
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=Sirket100; User=sa; Pwd=123";
                //sql server authentication metodu ile bağlantı sağlar.
                //sql server authentication metodu ile bağlantı sağlar.
                //baglanti.ConnectionString = @"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=Sirket100; Trusted_Connection=true";
                //windows authentication metodu ile bağlantı sağlar.
                baglanti.Open();

                baglanti.Close();
                MessageBox.Show("Veri tabanına bağlantı başarılı");
            }
            catch (Exception ex)
            {
                //try scopuna yazılan kodlarda hata varsa buraya düşer.
                //MessageBox.Show("Bağlantı sorunu var.");
                MessageBox.Show(ex.Message);
                throw;
            }

            
            
            
   

        }
    }
}
