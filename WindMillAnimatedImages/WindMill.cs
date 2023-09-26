using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindMillAnimatedImages
{
    internal class WindMill
    {
        // Esta es la clase para el molino de viento en animación .gif.

        Random random = new Random(); // Variable aleatoria.
        public int posicionX; // Posición en X.
        public int posicionY; // Posición en Y.
        public int altura; // Altura de la imagen.
        public int ancho; // Ancho de la imagen.
        public Image windMill; // Imagen de la clase.

        // Crearemos una imagen con estas variables declaradas anteriormente en esta clase.

        public WindMill()
        {
            posicionX = random.Next(10, 760); // Posición aleatoria de la imagen horizontalmente en X.
            posicionY = random.Next(10, 400); // Posición aleatoria de la imagen verticalmente en Y.
            altura = 50; // La altura de esta imagen es de 50 metros.
            ancho = 50; // El ancho de esta imagen es de 50 metros.
            windMill = Properties.Resources.Windmill; // Esta imagen será cargada en la interfaz ejecutable en Windows Forms.
        }
    }
}
