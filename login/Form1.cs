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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // A�ade el car�cter presionado al final del texto actual
            string currentText = textBox2.Text;
            currentText += e.KeyChar;

            // Convierte el texto a puntos, excepto el �ltimo car�cter
            string maskedText = new string('*', currentText.Length - 1) + currentText.LastOrDefault();

            // Actualiza el texto del TextBox con el texto enmascarado
            textBox2.Text = maskedText;

            // Mueve el cursor al final del TextBox
            textBox2.SelectionStart = textBox2.Text.Length;

            // Inicia el temporizador para ocultar el �ltimo car�cter despu�s de 1 segundo
            timer1.Start();

            // Evita que el car�cter se muestre en el TextBox
            e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Detiene el temporizador
            timer1.Stop();

            // Obtiene el texto actual del TextBox
            string currentText = textBox2.Text;

            // Enmascara el �ltimo car�cter
            string maskedText = new string('*', currentText.Length - 1);

            // Actualiza el texto del TextBox con el texto enmascarado
            textBox2.Text = maskedText;

            // Mueve el cursor al final del TextBox
            textBox2.SelectionStart = textBox2.Text.Length;
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
    }
}
