using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private Square _square;

        public Form1()
        {
            
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Okp);
            
        }
        private void Okp(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode.ToString())
            { 
                case "Left":
                    {
                        _square.Left();
                        break;
                    }
                case "Right":
                    {

                        _square.Right();
                        break;
                    }
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       private void picture_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lengthBox.Text) > 0)
            {
                _square = new Square(this,int.Parse(this.lengthBox.Text));
                _square.DrowSquare();
                lengthBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
        }

       
    }
}
