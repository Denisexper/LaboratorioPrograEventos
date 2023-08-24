using jugueteLibrary;

namespace Laboratorio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validamos();
            if(Validamos())
            {
                storeLIstBox.Items.Add(addnombretxtbox.Text);
            }
            

        }
        private bool Validamos()
        {
            bool ok = true;
            if(addnombretxtbox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(addnombretxtbox, "Ingresa el juguete nuevo");
            }
            return ok;
        }

        private void Eliminarbutton2_Click(object sender, EventArgs e)
        {
            storeLIstBox.Items.Remove(storeLIstBox.SelectedItem);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            storeLIstBox.Items.Add("Cubos....23$");
            storeLIstBox.Items.Add("Carrito...12$");
            storeLIstBox.Items.Add("Yoyo....21$");
            storeLIstBox.Items.Add("Trompo..12$");
            storeLIstBox.Items.Add("Canicas..0.5$");
            storeLIstBox.Items.Add("Balon....21$");
            storeLIstBox.Items.Add("Cuerda...12$");
            storeLIstBox.Items.Add("Legos....23$");

            //List<juguete> juguetes = new List<juguete>();
            //juguetes.Add(new juguete() { Id = 23, Name = "Casa" });

            //storeLIstBox.DataSource = juguetes;
            //storeLIstBox.DisplayMember = "Name";
            //storeLIstBox.ValueMember = "Id";
        }

        private void comprarbutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (Validaciones())
            {
                MessageBox.Show("Tu compra se realizo con exito!");
            }
            
        }

        private void imformacionbtt_MouseClick(object sender, MouseEventArgs e)
        {
            if (Validaciones())
            {
                MessageBox.Show(tttexbox.Text, "Nombre del Cliente: ");
                MessageBox.Show("numero de venta: 23 " +
                    "|| mejores clientes hasta el momento: Oracio Diaz, Gilber Guevara " + " || juguetes mas vendidos: Canicas " + "  || Cantidad de la compra: 1 Unidad");

            }

        }

        private void comprarbutton_Click(object sender, EventArgs e)
        {
            Validaciones();
        }
        private bool Validaciones()
        {
            bool ok = true;
            if (tttexbox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tttexbox, "Ingresa el nombre");
            }
            if (storeLIstBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(storeLIstBox, "Selecciona un juguete");
            }

            return ok;
        }
    }
}