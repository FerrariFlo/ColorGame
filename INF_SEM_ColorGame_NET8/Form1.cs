using System.Diagnostics;

namespace INF_SEM_ColorGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Zufallsgenerator + Countdown Startwert
        private Random random = new Random();
        private int countdown = 6;

        //Farbenvorrat
        private Dictionary<string, Color> ColorMapping = new Dictionary<string, Color>
        {
            { "Rot", Color.Red },
            { "Blau", Color.Blue },
            { "Grün", Color.Green },
            { "Gelb", Color.Yellow },
            { "Violett", Color.Purple }
        };

        //Stopwatch
        private Stopwatch stopwatch = new Stopwatch();
        private long bestTime = long.MaxValue; //Beste Zeit
        private double totalReactionTime = 0;  //Gesamtzeit aller Reaktionen
        private long previousTime = 0;         //Zeit des vorherigen Versuchs

        //Um Wiederholungen zu vermeiden in DisplayRandomWord()
        private string lastWord = null;
        private Color lastColor = Color.Empty;

        //Attempts Counter
        private int attempts = 0;           //Zählt die Anzahl der Versuche
        private const int MaxAttempts = 15; //Maximale Anzahl der Versuche
        private int counter = 0;

        //Scoreboard
        private string currentPlayerName; //Aktueller Spielername
        private Dictionary<string, PlayerStats> Scoreboard = new Dictionary<string, PlayerStats>();


        //Spiel starten
        private void btnStart_Click(object sender, EventArgs e)
        {
            currentPlayerName = txtPlayerName.Text.Trim();

            if (string.IsNullOrWhiteSpace(currentPlayerName))
            {
                MessageBox.Show("Please Enter Player Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tmrStart.Enabled = true;
            btnStart.Enabled = false;
            txtPlayerName.Enabled = false;
        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {
            if (countdown > 1)
            {
                countdown--;  //Inkrement des Countdowns
                lblCountdown.Text = countdown.ToString(); //Label Update
            }
            else
            {
                tmrStart.Stop(); //Countdown stoppen, wenn der Timer aus ist
                lblCountdown.Text = "Go!";

                //Farb-Buttons aktivieren
                btnRed.Enabled = true;
                btnGreen.Enabled = true;
                btnYellow.Enabled = true;
                btnViolet.Enabled = true;
                btnBlue.Enabled = true;

                DisplayRandomWord();
            }
        }
        
        //Wort anzeigen
        public void DisplayRandomWord()
        {
            var items = ColorMapping.ToList();

            //Wähle ein neues Wort, das sich vom vorherigen unterscheidet
            string newWord = lastWord;
            while (newWord == lastWord)
            {
                int randomIndex = random.Next(items.Count);
                newWord = items[randomIndex].Key;
            }

            //Wähle eine neue Farbe, die sich von der vorherigen unterscheidet
            Color textColor = lastColor;
            while (textColor == lastColor)
            {
                textColor = ColorMapping.Values.ElementAt(random.Next(ColorMapping.Count));
            }

            //Zeige das neue Wort und die Farbe an
            lblWord.Text = newWord;
            lblWord.ForeColor = textColor;

            //Speichere die aktuelle Auswahl
            lastWord = newWord;
            lastColor = textColor;

            //Stopwatch neu starten
            stopwatch.Restart();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (sender is not Button button)
                return; //Falls der Sender kein Button ist, nichts tun (Sicherheitshalber)

            //Hole die Farbe des gedrückten Buttons
            Color buttonColor = button.BackColor;

            //Hole die Farbe des angezeigten Wortes aus dem Mapping
            if (!ColorMapping.TryGetValue(lblWord.Text, out Color correctColor))
                return;

            //Vergleiche die Button-Farbe mit der Wortfarbe
            if (buttonColor == correctColor)
            {
                HandleCorrectAnswer();
            }
            else
            {
                HandleWrongAnswer();
            }

            //Versuche erhöhen und aktualisieren
            attempts++;
            lblAttempts.Text = attempts.ToString();

            //Prüfe, ob das Spiel beendet werden muss
            if (attempts >= MaxAttempts)
            {
                EndGame();
            }
            else
            {
                //Neues Wort und Farbe anzeigen
                DisplayRandomWord();
            }
        }

        private void HandleWrongAnswer()
        {
            counter -= 100; //Punkteabzug
            lblpoints.Text = counter.ToString();
        }

        private void HandleCorrectAnswer()
        {
            //Stoppe die Stoppuhr und berechne die Reaktionszeit
            stopwatch.Stop();
            long reactionTime = stopwatch.ElapsedMilliseconds;

            //Aktualisiere Zeiten
            previousTime = reactionTime;
            totalReactionTime += reactionTime;

            //Aktualisiere die beste Zeit
            if (reactionTime < bestTime)
                bestTime = reactionTime;

            //Berechne die Punkte basierend auf der Reaktionszeit
            counter += CalculatePoints(reactionTime);

            //Aktualisiere Labels
            lblpoints.Text = counter.ToString();
            lblPreviousTime.Text = $"{previousTime} ms";
            lblBestTime.Text = $"{bestTime} ms";
            lblAverageTime.Text = attempts > 0
                ? $"{(int)(totalReactionTime / attempts)} ms"
                : "0 ms";
        }

        private int CalculatePoints(long reactionTime)
        {
            if (reactionTime <= 500) //Wenn man sehr sehr schnell ist
                return 1000;
            if (reactionTime <= 750) //Wenn man sehr schnell ist
                return 500;
            if (reactionTime <= 1250) //Wenn man schnell ist
                return 250;

            return 100; //Standardpunkte
        }

        private class PlayerStats
        {
            public int Score { get; set; }
            public long BestTime { get; set; }
            public double AverageTime { get; set; }
        }


        //Spielschluss + Player in Scoreboard eintragen
        private void EndGame()
        {
            tmrStart.Stop();

            int averageTime = attempts > 0 ? (int)(totalReactionTime / attempts) : 0;

            if (!Scoreboard.ContainsKey(currentPlayerName))
            {
                Scoreboard[currentPlayerName] = new PlayerStats
                {
                    Score = counter,
                    BestTime = bestTime,
                    AverageTime = averageTime
                };
            }
            else
            {
                var stats = Scoreboard[currentPlayerName];
                stats.Score += counter;
                stats.BestTime = Math.Min(stats.BestTime, bestTime); //Aktualisieren wenn neue Zeit beste Zeit ist
                stats.AverageTime = (stats.AverageTime + averageTime) / 2.0; // Durchschnitt aus alten und neuen Zeiten
            }

            //Spielergebnis anzeigen
            string resultMessage =
                $"Thank you for playing, {currentPlayerName}!\n\n" +
                $"Points: {counter}\n" +
                $"Best Time: {bestTime} ms\n" +
                $"Average Time: {averageTime} ms";
            MessageBox.Show(resultMessage, "Game over!");

            UpdateScoreboard();
            ResetGame();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetGame()
        {
            //Counter, Attempts und Score zurücksetzen
            countdown = 6;
            attempts = 0;
            counter = 0;
            totalReactionTime = 0;
            bestTime = long.MaxValue;
            previousTime = 0;

            //Labels zurücksetzen
            lblCountdown.Text = " ";
            lblpoints.Text = "0";
            lblAttempts.Text = "0";
            lblPreviousTime.Text = "0 ms";
            lblBestTime.Text = "0 ms";
            lblAverageTime.Text = "0 ms";
            lblWord.Text = "Get Ready!";
            lblWord.ForeColor = Color.Black;

            //Wort und Farbe zurücksetzen
            lastWord = null;
            lastColor = Color.Empty;

            //Timer stoppen (falls er läuft)
            tmrStart.Stop();

            //Farb-Buttons deaktivieren
            btnRed.Enabled = false;
            btnGreen.Enabled = false;
            btnYellow.Enabled = false;
            btnViolet.Enabled = false;
            btnBlue.Enabled = false;

            //Startbutton aktivieren
            btnStart.Enabled = true;

            //Spielernamen-Feld wieder aktivieren
            txtPlayerName.Enabled = true;
            txtPlayerName.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateScoreboard()
        {
            lvScoreboard.Items.Clear();

            foreach (var entry in Scoreboard.OrderByDescending(x => x.Value.Score))
            {
                var stats = entry.Value;
                var listItem = new ListViewItem(entry.Key); //Spielername
                listItem.SubItems.Add(stats.Score.ToString()); //Punkte
                listItem.SubItems.Add($"{stats.BestTime} ms"); //Beste Zeit
                listItem.SubItems.Add($"{(int)stats.AverageTime} ms"); //Durchschnittszeit
                lvScoreboard.Items.Add(listItem);
            }
        }

        private void InitializeScoreboard()
        {
            //Eigenschaften
            lvScoreboard.View = View.Details;
            lvScoreboard.FullRowSelect = true;
            lvScoreboard.GridLines = true;
            lvScoreboard.HeaderStyle = ColumnHeaderStyle.Clickable;

            //Spalten
            lvScoreboard.Columns.Add("Player", 120, HorizontalAlignment.Center);
            lvScoreboard.Columns.Add("Score", 140, HorizontalAlignment.Center);
            lvScoreboard.Columns.Add("Best Time", 140, HorizontalAlignment.Center);
            lvScoreboard.Columns.Add("Average Time", 120, HorizontalAlignment.Center);
        }

        private void btnCheckname_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim();

            //Länge überprüfen
            if (playerName.Length < 3 || playerName.Length > 5) //Mindestens 3 und höchstens 5 Zeichen
            {
                MessageBox.Show("Name must be between 3 and 5 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnStart.Enabled = false; //Sicherheitshalber deaktiviert lassen
                return;
            }

            //Überprüfe jedes Zeichen
            foreach (char c in playerName)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    MessageBox.Show("Name can only contain Letters and Numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnStart.Enabled = false; //Sicherheitshalber deaktiviert lassen
                    return;
                }
            }

            //Name in Großbuchstaben umwandeln und anzeigen
            txtPlayerName.Text = playerName.ToUpper();

            //Start-Button aktivieren
            btnStart.Enabled = true;

        }

        private void txtPlayerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Prüfen, ob die Enter-Taste gedrückt wurde
            {
                btnCheckname.PerformClick(); //Button press simulieren
                e.SuppressKeyPress = true; //sound unterdrücken
            }
        }
    }
}