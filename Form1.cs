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
                    cflor = Color.Blue;
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
        //El ciclo de la evolución
        //Utilizamos el evento tick del timer
        private void timer_Tick(object sender, EventArgs e)
        {
            //Calculamos la adaptación
            CalculaAdaptacion();
            //Seleccionamos a los padres
            SeleccionaPadres();
            //Hacemos el crosover y la mutación
            Crossover();
            //Actualizamos la generación
            generacion++;
            //Redibujamos la ventana
            this.Invalidate();
        }

        //Función para calcular la adaptación
        private void CalculaAdaptacion()
        {
            //Variables de las operaciones del usuario
            int altura, color, tamano;
            altura = color = tamano = 0;

            //Variables necesarias para el calculo
            double Aaltura, Acolor, Atamano;
            Aaltura = Acolor = Atamano = 0.0;

            //Obtenemos la altura deseada por el usuario
            if (rbBajo.Checked == true)
                altura = 0;
            else if (rbMedio.Checked == true)
                altura = 1;
            else if (rbAlto.Checked == true)
                altura = 2;

            //Obtenemos el color deseado por el usuario
            if (rbRojo.Checked == true)
                color = 0;
            else if (rbAzul.Checked == true)
                color = 1;
            else if (rbAmarillo.Checked == true)
                color = 2;

            //Obtenemos el tamaño deseado por el usuario para la flor 
            if (rbPequeno.Checked == true)
                tamano = 0;
            else if (rbNormal.Checked == true)
                tamano = 1;
            else if (rbGrande.Checked == true)
                tamano = 2;

            //Recorremos toda la población para encontrar su adaptación
            for (int n = 0; n < 10; n++)
            {
                //Chequeamos el nivel de adaptación para la altura
                if (altura == 0)
                    //rango 10 a 100
                    Aaltura = poblacion[n].cromosoma[0] / 100;
                else if (altura == 1)
                    //rango 100 a 200
                    Aaltura = poblacion[n].cromosoma[0] / 200;
                else if (altura == 2)
                    //rango 200 a 300
                    Aaltura = poblacion[n].cromosoma[0] / 300;
                if (Aaltura > 1.0)
                    Aaltura = 1 / Aaltura;

                //Checamos el nivel de adaptación del color
                if (color == poblacion[n].cromosoma[1])
                    Acolor = 1.0;
                else
                    Acolor = 0.0;

                //Checamos el nivel de adaptación del tamaño de la flor
                if (tamano == 0)
                    //Rango de 20 a 40
                    Atamano = poblacion[n].cromosoma[4] / 40;
                else if (tamano == 1)
                    //Rango de 40 a 60
                    Atamano = poblacion[n].cromosoma[4] / 60;
                else if (tamano == 2)
                    //Rango de 60 a 80
                    Atamano = poblacion[n].cromosoma[4] / 80;


                if (Atamano > 1.0)
                    Atamano = 1 / Atamano;

                //Calculamos el valor final de adaptación
                poblacion[n].Adaptacion = (Aaltura + Acolor + Atamano) / 3;
            }
        }

        //FUNCION PARA LA SELECCION DE LOS PADRES
        private void SeleccionaPadres()
        {
            //Seleccionamos los dos mejores
            iPadreA = iPadreB = 0;

            //Encontramos el padre A
            for (int n = 0; n < 10; n++)
            {
                if (poblacion[n].Adaptacion > poblacion[iPadreA].Adaptacion)
                    iPadreA = n;
            }
            //Encontramos al padre B
            for (int n = 0; n < 10; n++)
            {
                if (poblacion[n].Adaptacion > poblacion[iPadreB].Adaptacion && iPadreA != n)
                    iPadreB = n;
            }
        }

        private void mnuInicio_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void mnuParo_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNCION PARA EL CRUCE DE CROMOSOMAS
        private void Crossover()
        {
            //Llevamos a cabo el crossover
            //Copiamos los padres ya que todo el arreglo será llenado nuevamente con hijos
            Flores PadreA = new Flores();
            Flores PadreB = new Flores();

            //Copiamos los padres
            for (int n = 0; n < 6; n++)
            {
                PadreA.cromosoma[n] = poblacion[iPadreA].cromosoma[n];

                PadreB.cromosoma[n] = poblacion[iPadreB].cromosoma[n];
            }

            //Creamos la siguiente generación
            //0 altura
            //1- Color de la flor
            //2- Color del tallo
            //3- Ancho del tallo
            //4- Tamano de la flor
            //5- Tamano del centro de la flor
            Random random = new Random(unchecked((int)DateTime.Now.Ticks));
            int desde = random.Next(0, 5);
            int hasta = random.Next(desde, 6);

            for (int n = 0; n < 10; n++)
            {
                for (int c = desde; c < hasta; c++)
                {
                    //Si el random es 0 se copia el gen del PadreA
                    //Si el random es 1, se copia el gen del PadreB
                    if (random.Next(0, 2) == 0)
                        poblacion[n].cromosoma[c] = PadreA.cromosoma[c];
                    else
                        poblacion[n].cromosoma[c] = PadreB.cromosoma[c];

                    //Incluimos la mutacion   
                    if (random.Next(0, 100) == 50)
                    {
                        if (c == 0)
                            poblacion[n].cromosoma[0] = random.Next(10, 300);

                        if (c == 1)
                            poblacion[n].cromosoma[1] = random.Next(0, 3);

                        if (c == 2)
                            poblacion[n].cromosoma[2] = random.Next(0, 3);

                        if (c == 3)
                            poblacion[n].cromosoma[3] = random.Next(5, 15);

                        if (c == 4)
                            poblacion[n].cromosoma[4] = random.Next(20, 80);

                        if (c == 5)
                            poblacion[n].cromosoma[5] = random.Next(5, 15);



                    }
                }
            }


        }
    }
}