using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos
{
    public class Flores
    {
        //Variables necesarias para la clase
        private int x; //Posición en la ventana
        private double adaptacion; //Nivel de adaptación del organismo
        public int[] cromosoma = new int[6];

        public int CoordX
        {
            set { x = value; }
            get { return x; }
        }
        public double Adaptacion
        {
            set { adaptacion = value; }
            get { return adaptacion; }
        }
        public Flores()
        {
            
        }
        

    }
}
