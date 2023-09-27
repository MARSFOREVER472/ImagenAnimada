namespace WindMillAnimatedImages
{
    public partial class Form1 : Form
    {
        // Variables a declarar en esta clase.

        List<WindMill> windMillCollection = new List<WindMill>(); // Todos los molinos de viento en la interfaz.
        int spawnTimer = 20; // Las im�genes aparecer�n cada 20 segundos.
        int tempTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // M�todo para el temporizador de la escena.

            tempTime--; // El temporizador comienza con una cuenta regresiva cada 20 segundos.

            if (tempTime < 1) // Si el temporizador descuenta cada 1 segundo.
            {
                AddWindMills(); // LLama al m�todo para que aparezca los molinos de viento en la escena.
                tempTime = spawnTimer;
            }

            this.Text = "N�MERO TOTAL DE LOS MOLINOS DE VIENTO EN ESTA ESCENA - " + windMillCollection.Count;
        }

        private void DrawWindMillsEvent(object sender, PaintEventArgs e)
        {
            // EN INSTANTES...
        }

        private void AddWindMills()
        {
            // M�todo que servir� de base para agregar molinos de viento.

            WindMill molinosDeViento = new WindMill();
            windMillCollection.Add(molinosDeViento);

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