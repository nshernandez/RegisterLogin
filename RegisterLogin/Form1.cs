namespace RegisterLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filepath = @"C:\Users\User\Desktop\users.txt";


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //boton para registrar

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            string username = txtRegUsuario.Text;
            string nombre = txtNombre.Text; 
            string email = txtEmail.Text;
            string cedula = txtCedula.Text; 
            string password = txtRegPassword.Text;
            string confirmpassword = txtComPassword.Text;  
            
            TextWriter writer = new StreamWriter(filepath, true);   

            writer.Write("\r\nUsername: "+username);
            writer.Write("");
            writer.Write("\r\nNombre: " +nombre);  
            writer.Write("");   
            writer.Write("\r\nEmail: "+email);    
            writer.Write("");  
            writer.Write("\r\nCedula: "+cedula);  
            writer.Write("");
            writer.Write("\r\nPassword: "+password);  
            writer.Write("");          
            writer.Write("\r\nConfirm Password: "+confirmpassword);       
            writer.Write(""); 
            writer.Write("\r\n----------");

            writer.Close(); 
            MessageBox.Show("Usuario Registrado");      





        }
    }
}
