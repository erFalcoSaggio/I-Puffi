using I_Puffi.Properties;
using Microsoft.VisualBasic.Devices;
using System.Media;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;

namespace I_Puffi
{
    public partial class frm_Principale : Form
    {

        public int dim = 50;
        public int numero_di_case = 0; // numero di case "distrutte"
        public int punteggioGargamella = 0;
        public bool turnoDelPlayer = true; // inizializzo a vero
        Coordinates player;
        Coordinates casa;
        Coordinates gargamella;

        // creo la coordinate
        Coordinates[] alberi = new Coordinates[10];

        public Panel pnl_Giocatore;
        public Panel pnl_Casa;
        public Panel pnl_Gargamella;
        public frm_Principale()
        {

            InitializeComponent();
            // aggiorno il numero delle case (della lbl)
            lbl_PunteggioPlayer.Text = numero_di_case.ToString();

            // rendo invisibili alcuni elementi
            lbl_AvvisiDentroilPanel.Visible = false;
            pnl_AvvisiSopraMappa.Visible = false;

            // creo il pannello del giocatore 'puffo' e lo inserisco nel pannello mappa
            pnl_Giocatore = new Panel();
            pnl_Giocatore.Size = new System.Drawing.Size(30, 30);
            pnl_Giocatore.Location = new System.Drawing.Point(50, 50);
            pnl_Giocatore.BackColor = System.Drawing.Color.Blue;
            pnl_Giocatore.Name = "pnl_Giocatore";
            pnl_Giocatore.TabIndex = 3;
            pnl_Mappa.Controls.Add(pnl_Giocatore); // aggiungo al pannello
            // passo le coordinate default
            player = new Coordinates(50, 50);

            // ---------------------------------------- //
            // pnl della casa
            pnl_Casa = new Panel();
            pnl_Casa.Size = new System.Drawing.Size(30, 30);
            pnl_Casa.Name = "pnl_Casa";
            pnl_Casa.Location = new System.Drawing.Point(generaUnMultiploDi50(), generaUnMultiploDi50());
            pnl_Casa.BackColor = System.Drawing.Color.Red;
            pnl_Casa.TabIndex = 3;
            pnl_Mappa.Controls.Add(pnl_Casa); // aggiungo al pannello
            // passo le coordinate default
            casa = new Coordinates(pnl_Casa.Location.X, pnl_Casa.Location.Y);

            // ---------------------------------------- //
            // pnl di gargamella
            pnl_Gargamella = new Panel();
            pnl_Gargamella.Size = new System.Drawing.Size(30, 30);
            pnl_Gargamella.Location = new System.Drawing.Point(generaUnMultiploDi50(), generaUnMultiploDi50());
            pnl_Gargamella.Name = "pnl_Gargamella";
            pnl_Gargamella.BackColor = System.Drawing.Color.Black;
            pnl_Gargamella.TabIndex = 3;
            pnl_Mappa.Controls.Add(pnl_Gargamella); // aggiungo al pannello
            // passo le coordinate default
            gargamella = new Coordinates(pnl_Gargamella.Location.X, pnl_Gargamella.Location.Y);

            // ---------------------------------------- //
            // la foresta incantata
            // creazione alberi //AGGIUNGERE FUNZIONE
            generazioneAlberi();
        }

        public void muoviPuffo(int mx, int my)
        {
            player.X += mx;
            player.Y += my;

            //controllo di copuff.X copufo.Y
            pnl_Giocatore.Location = new System.Drawing.Point(player.X, player.Y);
        }

        public void muoviGargamella(int mx, int my)
        {
            gargamella.X += mx;
            gargamella.Y += my;

            //controllo di copuff.X copufo.Y
            pnl_Gargamella.Location = new System.Drawing.Point(gargamella.X, gargamella.Y);
        }


        private void btn_Left_Click(object sender, EventArgs e)
        {
            // prima controllo se può muovere
            if (turnoDelPlayer)
            {
                if (player.X > dim)
                {
                    if (!controlloAlbero(player.X - dim, player.Y)) // Controlla la nuova posizione
                    {
                        cambioTurno();
                        muoviPuffo(-dim, 0);
                        // se le coordinate possono essere aggiornate allora faccio il controllo se va in collisione con qualche elemento (ex.casa)
                        controllaCasa();
                        controllaUccisione();
                    }
                }
            }
            else
            {
                printNonilTuoTurnoAsync();
            }
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            if (turnoDelPlayer)
            {
                if (player.Y > dim)
                {
                    if (!controlloAlbero(player.X, player.Y - dim)) // Controlla la nuova posizione
                    {
                        cambioTurno();
                        muoviPuffo(0, -dim);
                        controllaCasa();
                        controllaUccisione();
                    }
                }
            }
            else
            {
                printNonilTuoTurnoAsync();
            }
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            if (turnoDelPlayer)
            {
                if (player.X < 500 - dim)
                {
                    if (!controlloAlbero(player.X + dim, player.Y)) // Controlla la nuova posizione
                    {
                        cambioTurno();
                        muoviPuffo(dim, 0);
                        controllaCasa();
                        controllaUccisione();
                    }
                }
            }
            else
            {
                printNonilTuoTurnoAsync();
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            if (turnoDelPlayer)
            {
                if (player.Y < 500 - dim)
                {
                    if (!controlloAlbero(player.X, player.Y + dim)) // Controlla la nuova posizione
                    {
                        cambioTurno();
                        muoviPuffo(0, dim);
                        controllaCasa();
                        controllaUccisione();
                    }
                }
            }
            else
            {
                printNonilTuoTurnoAsync();
            }
        }

        // ------------------------------------------------- //
        // GARGAMELLA MOVIMENTI //
        private void btn_LeftGargamella_Click(object sender, EventArgs e)
        {
            // prima controllo se può muovere
            if (!turnoDelPlayer)
            {
                if (gargamella.X > dim)
                {
                    cambioTurno();
                    muoviGargamella(-dim, 0);
                    controllaUccisione();
                }
            }
            else
            {
                printNonilTuoTurnoAsync();
            }
        }
        private void btn_UpGargamella_Click(object sender, EventArgs e)
        {
            if (!turnoDelPlayer)
            {
                if (gargamella.Y > dim)
                {
                    cambioTurno();
                    muoviGargamella(0, -dim);
                    controllaUccisione();
                }
            }
            else
            {
                printNonilTuoTurnoAsync();
            }
        }

        private void btn_RightGargamella_Click(object sender, EventArgs e)
        {
            if (!turnoDelPlayer)
            {
                if (gargamella.X < 500 - dim)
                {
                    cambioTurno();
                    muoviGargamella(dim, 0);
                    controllaUccisione();
                }
            }
            else
            {
                printNonilTuoTurnoAsync();
            }
        }

        private void btn_DownGargamella_Click(object sender, EventArgs e)
        {
            if (!turnoDelPlayer)
            {
                if (gargamella.Y < 500 - dim)
                {
                    cambioTurno();
                    muoviGargamella(0, dim);
                    controllaUccisione();
                }
            }
            else
            {
                printNonilTuoTurnoAsync();
            }
        }

        struct Coordinates
        {
            public int X;
            public int Y;

            public Coordinates(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        // qua creo la funzione per controllare (e generare) la casa in punto random. Protagonista di questa funz = casa
        private void controllaCasa()
        {
            if (casa.X == player.X && casa.Y == player.Y)
            {
                {
                    numero_di_case++;
                    lbl_PunteggioPlayer.Text = numero_di_case.ToString();
                    casa = new Coordinates(generaUnMultiploDi50(), generaUnMultiploDi50());
                    pnl_Casa.Location = new System.Drawing.Point(casa.X, casa.Y);
                    // tolgo tutti gli alberi prima
                    rimozioneAlberi();
                    // rigenero tutti gli alberi
                    generazioneAlberi();
                }
            }
        }

        // check per garga nel player
        private void controllaUccisione()
        {
            if (gargamella.X == player.X && gargamella.Y == player.Y)
            {
                punteggioGargamella++;
                numero_di_case--;
                lbl_PunteggioGargamella.Text = punteggioGargamella.ToString();
                lbl_PunteggioPlayer.Text = numero_di_case.ToString();
                player = new Coordinates(generaUnMultiploDi50(), generaUnMultiploDi50());
                pnl_Giocatore.Location = new System.Drawing.Point(player.X, player.Y);
            }
        }

        // genero numeri (multipli di 50) in questa funzione, mi servono per le X e Y dei vari oggetti (casa e altre robe)
        private int generaUnMultiploDi50()
        {
            Random rdn = new Random();
            int n;
            bool posizioneValida;

            do
            {
                n = rdn.Next(50, 501);
                n = (n / 50) * 50; // arrotonda n al multiplo di 50 più vicino

                //verifica che la posizione non sia già occupata
                posizioneValida = true;

                // controllo se la posizione è occupata dal player, dalla casa, da gargamella o da altri alberi
                if (player.X == n && player.Y == n || casa.X == n && casa.Y == n || gargamella.X == n && gargamella.Y == n)
                {
                    posizioneValida = false;
                }

                foreach (Coordinates albero in alberi)
                {
                    if (albero.X == n && albero.Y == n)
                    {
                        posizioneValida = false;
                        break;
                    }
                }

            } while (!posizioneValida); // continua finché la posizione non è valida

            return n;
        }

        // qui gestisco il bool del player / gargamella per il turno
        //private bool checkTurnodelPlayer()
        //{

        //}

        // piccola funz per l'errore "non è il tuo turno"
        private async Task printNonilTuoTurnoAsync()
        {
            pnl_AvvisiSopraMappa.Visible = true;
            lbl_AvvisiDentroilPanel.Visible = true;
            lbl_AvvisiDentroilPanel.Text = "non è il tuo turno!";
            await Task.Delay(800); // aspetta senza bloccare la UI (thread.sleep problema!!)
            pnl_AvvisiSopraMappa.Visible = false;
            lbl_AvvisiDentroilPanel.Visible = false;
        }

        // "hai perso il turno"
        private async Task printHaiPersoilTurnoAsync()
        {
            pnl_AvvisiSopraMappa.Visible = true;
            lbl_AvvisiDentroilPanel.Visible = true;
            lbl_AvvisiDentroilPanel.Text = "ha perso il turno!";
            await Task.Delay(800); // aspetta senza bloccare la UI (thread.sleep problema!!)
            pnl_AvvisiSopraMappa.Visible = false;
            lbl_AvvisiDentroilPanel.Visible = false;
        }

        // funz cambio turno
        private void cambioTurno()
        {
            if (turnoDelPlayer)
            {
                turnoDelPlayer = false;
            }
            else
            {
                turnoDelPlayer = true;
            }
        }

        // funzione per la creazione degli alberi
        private void generazioneAlberi()
        {
            int x, y;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    x = generaUnMultiploDi50();
                    y = generaUnMultiploDi50();
                }
                while ((x == player.X && y == player.Y) ||
                   (x == gargamella.X && y == gargamella.Y) ||
                   (x == casa.X && y == casa.Y));

                // Creo un nuovo pannello per l'albero
                Panel pnl_Albero = new Panel();
                pnl_Albero.Size = new System.Drawing.Size(30, 30);
                pnl_Albero.Location = new System.Drawing.Point(x, y);
                pnl_Albero.Name = "pnl_Albero";
                pnl_Albero.BackColor = System.Drawing.Color.Green;
                pnl_Albero.TabIndex = 3;
                alberi[i] = new Coordinates(x, y);

                // Aggiungo l'albero al pannello della mappa
                pnl_Mappa.Controls.Add(pnl_Albero);
            }
        }

        // devo creare la funzione per rimuovere gli alberi
        private void rimozioneAlberi()
        {
            // creo una lista temporanea con tutti i pannelli degli alberi
            List<Control> alberiDaRimuovere = new List<Control>();

            foreach (Control control in pnl_Mappa.Controls)
            {
                if (control.Name == "pnl_Albero") // prendo gli alberi
                {
                    alberiDaRimuovere.Add(control);
                }
            }

            // Rimuove tutti gli alberi dalla mappa
            foreach (Control albero in alberiDaRimuovere)
            {
                pnl_Mappa.Controls.Remove(albero);
            }
        }

        // funz check per qualche player (puffo || garga) addosso albero
        private bool controlloAlbero(int x, int y)
        {
            foreach (Coordinates albero in alberi)
            {
                if (albero.X == x && albero.Y == y)
                {
                    printHaiPersoilTurnoAsync();
                    cambioTurno();
                    return true; // Il player STA PER andare sopra un albero
                }
            }
            return false; // Nessun albero nella nuova posizione
        }


    }
}