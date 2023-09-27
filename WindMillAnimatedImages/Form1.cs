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
            // EN INSTANTES...
        }

        private void DrawWindMillsEvent(object sender, PaintEventArgs e)
        {
            // EN INSTANTES...
        }

        private void AddWindMills()
        {
            // Método que servirá de base para agregar molinos de viento.

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