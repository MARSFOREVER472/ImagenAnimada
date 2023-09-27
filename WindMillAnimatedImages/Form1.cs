namespace WindMillAnimatedImages
{
    public partial class Form1 : Form
    {
        // Variables a declarar en esta clase.

        List<WindMill> windMillCollection = new List<WindMill>(); // Todos los molinos de viento en la interfaz.
        int spawnTimer = 20; // Las imágenes aparecerán cada 20 segundos.
        int tempTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // Método para el temporizador de la escena.

            tempTime--; // El temporizador comienza con una cuenta regresiva cada 20 segundos.

            if (tempTime < 1) // Si el temporizador descuenta cada 1 segundo.
            {
                AddWindMills(); // LLama al método para que aparezca los molinos de viento en la escena.
                tempTime = spawnTimer;
            }

            this.Text = "NÚMERO TOTAL DE LOS MOLINOS DE VIENTO EN ESTA ESCENA - " + windMillCollection.Count;
        }

        private void DrawWindMillsEvent(object sender, PaintEventArgs e)
        {
            // Método que perite dibujar manualmente la imagen que aparecerá en escena.

            ImageAnimator.UpdateFrames(); // Se cargarán las imágenes animadas en la escena.

            // Crearemos un foreach que permita en la escena dibujar todos los molinos de viento animados por medio de aparición.

            foreach (WindMill tempImage in windMillCollection)
            {
                e.Graphics.DrawImage(tempImage.windMill, tempImage.posicionX, tempImage.posicionY, tempImage.ancho, tempImage.altura);
            }
        }

        private void AddWindMills()
        {
            // Método que servirá de base para agregar molinos de viento.

            WindMill molinosDeViento = new WindMill(); // Variable para los molinos de viento.
            windMillCollection.Add(molinosDeViento); // Añadiremos automáticamente los molinos de viento en la escena.

            for (int i = 0; i < windMillCollection.Count; i++)
            {
                ImageAnimator.Animate(windMillCollection[i].windMill, this.OnFrameChangeHandler);
            }
        }

        private void OnFrameChangeHandler(object? sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}