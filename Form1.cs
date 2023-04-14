using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18YaşDoğrulamasıIleKayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            long TCKN = long.Parse(txtTC.Text);
            string ad = txtIsım.Text;
            string soyad = txtSoyisim.Text;
            int DoğumYılı = int.Parse(txtDogumyılı.Text);


            Kimlik.KPSPublicSoapClient service = new Kimlik.KPSPublicSoapClient();

            bool status = service.TCKimlikNoDogrula(TCKN, ad, soyad, DoğumYılı);


            int şuankiyil = DateTime.Now.Year;
            if (status == true)
            {
                if (şuankiyil - DoğumYılı >= 18)
                {
                    MessageBox.Show("Yaşınız 18 den büyükdür Kayıt sağlanıyor ");

                }
                else
                {

                    MessageBox.Show("yaşınız 18den küçüktür kayıt başarısız.");
                }

            }
            else
            {
                MessageBox.Show("tckn bilgileri doğru degildir kayıt başarısız ");
            }


        }
    }
}
