namespace CodigoClase16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Genera las columnas de forma automática
            //Por defecto =true
            dgvDemo.AutoGenerateColumns = false;

            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona { Apellido = "Torrico", Nombre = "Hugo", Edad = 36, Telefono = "5555555" });

            Persona persona = new Persona();

            persona.Apellido = "";
            persona.Nombre = "";
            persona.Nacionalidad.Pasaporte = "";




            //Header: Lo que se va mostrar en la cabecera
            //Name: El nombre del control
            //DataPropertyName: Tiene que llamarse igual que tu propiedad


            dgvDemo.DataSource = personas;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
