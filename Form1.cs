namespace AlgoritmosGeneticos
{
    public partial class Form1 : Form
    {
        public Flores[] poblacion = new Flores[10];
        private int generacion = 0;
        private int iPadreA, iPadreB;
        public Form1()
        {
            /*
             *Necesario para admitirel Diseñador de Windows Forms 
             */
            InitializeComponent();
            /*
             * TODO: Agregar código de constructor después 
             */
            Random random = new Random(unchecked((int)
                DateTime.Now.Ticks));
            for(int n = 0; n < 10; n++)
            {
                Flores temp = new Flores();
                poblacion[n] = temp;
                poblacion[n].CoordX = n * 80 + 40;

                //Iniciamos el cromosoma con valores al azar

                //La altura va de 10 a 300
                poblacion[n].cromosoma[0] = random.Next(10,300);

                //El color de la flor 0-rojo, 1-azul, 2-amarillo
                poblacion[n].cromosoma[1] = random.Next(0,3);

                //El color del tallo. Diferentes tonos de verde
                poblacion[n].cromosoma[2] = random.Next(0,3);

                //El ancho del tallo. De 5 a 15
                poblacion[n].cromosoma[3] = random.Next(5,15);

                //El tamaño de la flor. De 20 a 80
                poblacion[n].cromosoma[4] = random.Next(20,80);

                //El tamaño del centro de la flor. De 5 a 15
                poblacion[n].cromosoma[5] = random.Next(5,15);
            }

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Pintamos un suelo
            e.Graphics.FillRectangle(Brushes.DarkGreen, 0, 550, 800, 50);
            for (int n = 0; n < 10; n++)
            {
                //0 altura
                //1- Color de la flor
                //2- Color del tallo
                //3- Ancho del tallo
                //4- Tamano de la flor
                //5- Tamano del centro de la flor

                //Pintamos el tallo
                if (poblacion[n].cromosoma[2] == 0)
                    e.Graphics.FillRectangle(Brushes.DarkGreen,
                                            poblacion[n].CoordX, 550 - poblacion[n].cromosoma[0],
                                            poblacion[n].cromosoma[3],
                                            poblacion[n].cromosoma[0]
                                            );
                else if (poblacion[n].cromosoma[2] == 1)
                    e.Graphics.FillRectangle(Brushes.Green,
                                            poblacion[n].CoordX,
                                            550 - poblacion[n].cromosoma[0],
                                            poblacion[n].cromosoma[3],
                                            poblacion[n].cromosoma[0]);
                else if (poblacion[n].cromosoma[2] == 2)
                    e.Graphics.FillRectangle(Brushes.LightGreen,
                                            poblacion[n].CoordX,
                                            550 - poblacion[n].cromosoma[0],
                                            poblacion[n].cromosoma[3],
                                            poblacion[n].cromosoma[0]);

                //Pintamos la flor
                Color cflor = new Color();
                if (poblacion[n].cromosoma[1] == 0)
                    cflor = Color.Red;
                else if (poblacion[n].cromosoma[1] == 1)
                    cflor = Color.Red;
                else if (poblacion[n].cromosoma[1] == 2)
                    cflor = Color.Yellow;

                e.Graphics.FillEllipse(new SolidBrush(cflor),
                                       poblacion[n].CoordX + poblacion[n].cromosoma[3] / 2 - poblacion[n].cromosoma[4] / 2,
                                       550 - poblacion[n].cromosoma[0] - poblacion[n].cromosoma[4] / 2,
                                       poblacion[n].cromosoma[4],
                                       poblacion[n].cromosoma[4]);
                //Pintamos la flor
                e.Graphics.FillEllipse(Brushes.DarkOrange,
                                       poblacion[n].CoordX + poblacion[n].cromosoma[3] / 2 - poblacion[n].cromosoma[5] / 2,
                                       550 - poblacion[n].cromosoma[0] - poblacion[n].cromosoma[5] / 2,
                                       poblacion[n].cromosoma[5],
                                       poblacion[n].cromosoma[5]);
            }
            lblGeneracion.Text = "Generacion:   " + generacion.ToString();
        }
    }
}