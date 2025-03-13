using System.Media;
using System.Resources;

namespace I_Puffi
{
    public partial class frm_Principale : Form
    {

        public int dim = 50;
        public int numero_di_case = 0; // numero di case "distrutte"
        Coordinates player;
        Coordinates casa;
        public Panel pnl_Giocatore;
        public Panel pnl_Casa;
        public frm_Principale()
        {

            InitializeComponent();
            // aggiorno il numero delle case (della lbl)
            lbl_NumeroDiCase.Text = numero_di_case.ToString();
            // creo il pannello del giocatore 'puffo' e lo inserisco nel pannello mappa
            pnl_Giocatore = new Panel();
            pnl_Giocatore.Size = new System.Drawing.Size(30, 30);
            pnl_Giocatore.Location = new System.Drawing.Point(50, 50);
            pnl_Giocatore.Name = "pnl_Giocatore";
            pnl_Giocatore.BackColor = System.Drawing.Color.Blue;
            pnl_Giocatore.TabIndex = 0;
            pnl_Mappa.Controls.Add(pnl_Giocatore); // aggiungo al pannello
            // passo le coordinate default
            player = new Coordinates(50, 50);

            // ---------------------------------------- //
            // pnl della casa
            pnl_Casa = new Panel();
            pnl_Casa.Size = new System.Drawing.Size(30, 30);
            pnl_Casa.Location = new System.Drawing.Point(generaUnMultiploDi50(), generaUnMultiploDi50());
            pnl_Casa.Name = "pnl_Giocatore";
            pnl_Casa.BackColor = System.Drawing.Color.Red;
            pnl_Casa.TabIndex = 0;
            pnl_Mappa.Controls.Add(pnl_Casa); // aggiungo al pannello
            // passo le coordinate default
            casa = new Coordinates(generaUnMultiploDi50(), generaUnMultiploDi50());

        }

        public void muoviPuffo(int mx, int my)
        {
            player.X += mx;
            player.Y += my;

            //controllo di copuff.X copufo.Y
            pnl_Giocatore.Location = new System.Drawing.Point(player.X, player.Y);
        }

        private void pnl_Giocatore_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            if (player.X > dim)
            {
                muoviPuffo(-dim, 0);
                // se le coordinate possono essere aggiornate allora faccio il controllo se va in collisione con qualche elemento (ex.casa)
                controllaCasa();
            }
        }
        private void btn_Up_Click(object sender, EventArgs e)
        {
            if (player.Y > dim)
            {
                muoviPuffo(0, -dim);
                controllaCasa();
            }
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            if (player.X < 600 - dim)
            {
                muoviPuffo(dim, 0);
                controllaCasa();
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            if (player.Y < 600 - dim)
            {
                muoviPuffo(0, dim);
                controllaCasa();
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
                    lbl_NumeroDiCase.Text = numero_di_case.ToString();
                    casa = new Coordinates(generaUnMultiploDi50(), generaUnMultiploDi50());
                    pnl_Casa.Location = new System.Drawing.Point(casa.X, casa.Y);
                }
            }
        }

        // genero numeri (multipli di 50) in questa funzione, mi servono per le X e Y dei vari oggetti (casa e altre robe)
        private int generaUnMultiploDi50()
        {
            Random rdn = new Random(Environment.TickCount);
            int n = rdn.Next(601);
            return (n / 50) * 50;// arrotondo n al multiplo di 50 più vicino
        }

    }
}