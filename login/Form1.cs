namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Vincular el evento KeyDown al TextBox
            textBox1.KeyDown += new KeyEventHandler(textBox1_KeyDown);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Verifica si el texto ya contiene @gmail.com
                if (!textBox1.Text.Contains("@gmail.com"))
                {
                    // A�ade @gmail.com al final del texto si no est� presente
                    textBox1.Text += "@gmail.com";
                    // Ajusta la posici�n del cursor al final del texto
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
                // Suprime el comportamiento predeterminado de la tecla Enter
                e.Handled = true;
            }
        }

        private string realPassword = "";
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el car�cter ingresado es un Backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                // No modifica el texto del TextBox si es un Backspace
                return;
            }

            // A�ade el car�cter presionado al final del texto real
            realPassword += e.KeyChar;

            // Convierte el texto a puntos, excepto el �ltimo car�cter
            string maskedText = new string('*', realPassword.Length - 1) + realPassword.LastOrDefault();

            // Actualiza el texto del TextBox con el texto enmascarado
            textBox2.Text = maskedText;

            // Mueve el cursor al final del TextBox
            textBox2.SelectionStart = textBox2.Text.Length;

            // Evita que el car�cter se muestre en el TextBox
            e.Handled = true;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (textBox2.SelectionLength > 0)
                {
                    textBox2.SelectedText = "";
                }
                else if (textBox2.SelectionStart > 0)
                {
                    int caret = textBox2.SelectionStart;
                    textBox2.Text = textBox2.Text.Substring(0, caret - 1) + textBox2.Text.Substring(caret);
                    textBox2.SelectionStart = caret - 1;
                }
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Muestra el texto real cuando el CheckBox est� marcado
                textBox2.Text = realPassword;
            }
            else
            {
                // Enmascarar el texto real cuando el CheckBox no est� marcado
                string maskedText = new string('*', realPassword.Length);
                textBox2.Text = maskedText;

                // Actualiza realPassword para reflejar el cambio
                realPassword = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crear una instancia del formulario password
            password passwordForm = new password();
        
            // Mostrar el formulario
            passwordForm.Show();
    
            // Opcional: Cambiar el color del texto del enlace para indicar que ha sido visitado
            linkLabel1.LinkVisited = true;
        }
    }
}
