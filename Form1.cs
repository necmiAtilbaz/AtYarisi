using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            tmrYaris.Start();
        }

        private void tmrYaris_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left+=rnd.Next(1,50);
            pictureBox2.Left+=rnd.Next(1,50);
            pictureBox3.Left+=rnd.Next(1,50);

            if (pictureBox1.Right>=label1.Left)
            {
                tmrYaris.Stop();
                DialogResult dr = MessageBox.Show("1.At yarışı kazandı.Tekrar oynamak ister misiniz?", "At Yarışı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pictureBox1.Left=pictureBox2.Left=pictureBox3.Left=0;
                    tmrYaris.Start();
                }
                else
                {
                    Close();
                }
            }
            else if (pictureBox2.Right>=label1.Left)
            {
                tmrYaris.Stop();
                DialogResult dr = MessageBox.Show("2.At yarışı kazandı.Tekrar oynamak ister misiniz?", "At Yarışı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = 0;
                    tmrYaris.Start();
                }
                else
                {
                    Close();
                }
            }
            else if (pictureBox3.Right>=label1.Left)
            {

                tmrYaris.Stop();
                DialogResult dr = MessageBox.Show("3.At yarışı kazandı.Tekrar oynamak ister misiniz?", "At Yarışı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = 0;
                    tmrYaris.Start();
                }
                else
                {
                    Close();
                }

            }
        }
        //Timer başladığı zaman atlar rastgele bir sayıya göre hareket edecek.
        //picturebox ın sağının konumu label ın solunun konumuna değdiği zaman oyun bitecek
        //?? random sayi ile picturebox nasıl taşınır ? (+=)
        // oyun bitişinde 1.,2,3. at kazandı yazısı ekrana gösterilecek (hangisi kazanırsa.)
    }
}
