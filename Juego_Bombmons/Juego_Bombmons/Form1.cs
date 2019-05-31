using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.IO;



namespace Juego_Bombmons
{
    public partial class GameWindow : Form
    {
        Stopwatch reloj = new Stopwatch();
        string horas, minutos, segundos, milisegundos;
        Button[,] botones;
        int[,] matriz;
        int plays_count = 0;
        string[] recordsText = new string[10];
        List<string> records = new List<string>();
        int BombmonsNumber = 10;
        int filas = 8;
        int columnas = 8;
        float fontsize = 18F;

        public GameWindow()
        {
            InitializeComponent();

            tableLayoutPanel1.ColumnCount = columnas;
            for (int i = 8; i < columnas; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            }
            tableLayoutPanel1.RowCount = filas;
            for (int i = 8; i < filas; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            }

            panel1.Visible = false;
            label3.Visible = false;
            reloj.Start();
            timer1.Enabled = true;

            botones = new Button[filas, columnas];
            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Button button = new Button();
                    tableLayoutPanel1.Controls.Add(button, i, j);

                    button.Anchor = AnchorStyles.Left;
                    button.BackColor = Color.Transparent;
                    button.Dock = DockStyle.Fill;
                    OpenAnimation.SetDecoration(button, BunifuAnimatorNS.DecorationType.None);
                    CloseAnimation.SetDecoration(button, BunifuAnimatorNS.DecorationType.None);
                    button.Font = new Font("Microsoft Sans Serif", fontsize, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    button.Location = new Point(3, 3);
                    button.Name = "button" + Convert.ToString(i) + Convert.ToString(j);
                    button.Size = new Size(64, 64);
                    button.TabIndex = 1;
                    button.Text = "button" + Convert.ToString(i) + Convert.ToString(j);
                    button.UseVisualStyleBackColor = true;
                    button.Click += new EventHandler(Button_Click);
                    button.MouseUp += new MouseEventHandler(Button_MouseUp);

                    botones[i, j] = button;
                }
            }
            
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    control.Click += Button_Click;
                }
            }

            try
            {
                string archivo = File.ReadAllText("Records.txt");
                var lineas = archivo.Split('\n');
                for (int i = 0; i < 10; i++)
                {
                    if (i < lineas.Length)
                    {
                        records.Add(lineas[i]);
                        recordsText[i] = records[i];
                    }
                    else
                    {
                        records.Add("");
                    }
                }
            }
            catch (Exception)
            {
                for (int i = 0; i < 10; i++)
                {
                    records.Add("");
                    recordsText[i] = "";
                }
            }

            label1.Text = "";
            label3.Text = "     Top 10 records:\n\n1) " + recordsText[0] + "\n\n2) " + recordsText[1] + "\n\n3) " + recordsText[2] + "\n\n4) " + recordsText[3] + "\n\n5) " + recordsText[4] + "\n\n6) " + recordsText[5] + "\n\n7) " + recordsText[6] + "\n\n8) " + recordsText[7] + "\n\n9) " + recordsText[8] + "\n\n10) " + recordsText[9];
            matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    botones[i, j].Text = "";
                    matriz[i, j] = 0;
                }
            }

            Random random = new Random();
            int a;
            int b;
            for (int i = 0; i < BombmonsNumber; i++)
            {
                a = random.Next(0, filas);
                b = random.Next(0, columnas);

                while (matriz[a, b] == 1)
                {
                    a = random.Next(0, filas);
                    b = random.Next(0, columnas);
                }
                matriz[a, b] = 1;
            }
        }
        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button button = (Button)sender;
                if (button.Text != "1" & button.Text != "2" & button.Text != "3" & button.Text != "4" & button.Text != "5" & button.Text != "6" & button.Text != "7" & button.Text != "8")
                {
                    if (button.Text == "")
                    {
                        button.ForeColor = Color.DarkRed;
                        Font fnt = new Font("Microsoft Sans Serif", fontsize*2, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        button.Font = fnt;
                        button.Text = "⚑";
                    }
                    else
                    {
                        Font fnt = new Font("Microsoft Sans Serif", fontsize, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        button.Font = fnt;
                        button.Text = "";
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                int bombmon_count = 0;
                int a, b;
                a = 0;
                b = 0;
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (botones[i, j].Name == button.Name)
                        {
                            a = i;
                            b = j;
                        }
                    }
                }
                if (matriz[a, b] == 1)
                {
                    reloj.Stop();
                    label1.Text = "PERDISTE !!";
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            if (matriz[i, j] == 1)
                            {
                                Font fnt = new Font(button.Font.FontFamily, fontsize * 2);
                                botones[i, j].Font = fnt;
                                botones[i, j].Text = "🐺";
                            }
                            botones[i, j].Enabled = false;
                        }
                    }
                }
                if (a != 0 & b != 0)
                {
                    if (matriz[a - 1, b - 1] == 1)
                    {
                        bombmon_count++;
                    }
                }
                if (a != 0)
                {
                    if (matriz[a - 1, b] == 1)
                    {
                        bombmon_count++;
                    }
                    if (b != columnas-1)
                    {
                        if (matriz[a - 1, b + 1] == 1)
                        {
                            bombmon_count++;
                        }
                    }
                }
                if (b != 0)
                {
                    if (matriz[a, b - 1] == 1)
                    {
                        bombmon_count++;
                    }
                }
                if (b != columnas - 1)
                {
                    if (matriz[a, b + 1] == 1)
                    {
                        bombmon_count++;
                    }
                }
                if (a != filas - 1 & b != 0)
                {
                    if (matriz[a + 1, b - 1] == 1)
                    {
                        bombmon_count++;
                    }
                }
                if (a != filas - 1)
                {
                    if (matriz[a + 1, b] == 1)
                    {
                        bombmon_count++;
                    }
                }
                if (a != filas - 1 & b != columnas - 1)
                {
                    if (matriz[a + 1, b + 1] == 1)
                    {
                        bombmon_count++;
                    }
                }
                if (matriz[a, b] != 1)
                {
                    if (bombmon_count == 0)
                    {
                        button.ForeColor = Color.DarkGray;
                    }
                    else if (bombmon_count == 1)
                    {
                        button.ForeColor = Color.Green;
                    }
                    else if (bombmon_count == 2)
                    {
                        button.ForeColor = Color.Orange;
                    }
                    else if (bombmon_count == 3)
                    {
                        button.ForeColor = Color.OrangeRed;
                    }
                    else if (bombmon_count == 4)
                    {
                        button.ForeColor = Color.Red;
                    }
                    else if (bombmon_count == 5)
                    {
                        button.ForeColor = Color.Red;
                    }
                    else if (bombmon_count == 6)
                    {
                        button.ForeColor = Color.IndianRed;
                    }
                    else if (bombmon_count == 7)
                    {
                        button.ForeColor = Color.DarkRed;
                    }
                    else if (bombmon_count == 8)
                    {
                        button.ForeColor = Color.DarkViolet;
                    }
                    plays_count++;
                    if (button.BackgroundImage == null)
                    {
                        button.Text = Convert.ToString(bombmon_count);
                    }
                }
                if (plays_count >= (filas*columnas) - BombmonsNumber)
                {
                    reloj.Stop();
                    timer1.Enabled = false;
                    label1.Text = "GANASTE !!";
                    label1.ForeColor = Color.LimeGreen;
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            botones[i, j].Enabled = false;
                        }
                    }
                    string str = horas + ":" + minutos + ":" + segundos + ":" + milisegundos;
                    label2.Text = "Tu tiempo: " + horas + ":" + minutos + ":" + segundos + ":" + milisegundos;
                    records.Add(str);
                    records.Sort();
                    int count = 0;

                    foreach (var record in records)
                    {
                        if (record != "" && count < 10)
                        {
                            recordsText[count] = record;
                            count++;
                        }
                    }
                    string fileText = recordsText[0] + "\n" + recordsText[1] + "\n" + recordsText[2] + "\n" + recordsText[3] + "\n" + recordsText[4] + "\n" + recordsText[5] + "\n" + recordsText[6] + "\n" + recordsText[7] + "\n" + recordsText[8] + "\n" + recordsText[9];
                    label3.Text = "     Top 10 records:\n\n1) " + recordsText[0] + "\n\n2) " + recordsText[1] + "\n\n3) " + recordsText[2] + "\n\n4) " + recordsText[3] + "\n\n5) " + recordsText[4] + "\n\n6) " + recordsText[5] + "\n\n7) " + recordsText[6] + "\n\n8) " + recordsText[7] + "\n\n9) " + recordsText[8] + "\n\n10) " + recordsText[9];
                    File.WriteAllText("Records.txt", fileText);
                }
            }
        }
        private void NewGame_Click(object sender, EventArgs e)
        {
            
            plays_count = 0;
            timer1.Enabled = true;
            reloj.Restart();
            label1.Text = "";
            matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    botones[i, j].Font = new Font("Microsoft Sans Serif", fontsize, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    botones[i, j].BackgroundImage = null;
                    botones[i, j].Enabled = true;
                    botones[i, j].Text = "";
                    matriz[i, j] = 0;
                }
            }

            Random random = new Random();
            int a;
            int b;
            for (int i = 0; i < BombmonsNumber; i++)
            {
                a = random.Next(0, filas);
                b = random.Next(0, columnas);

                while (matriz[a, b] == 1)
                {
                    a = random.Next(0, filas);
                    b = random.Next(0, columnas);
                }
                matriz[a, b] = 1;
            }
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Records_Click(object sender, EventArgs e)
        {
            if (Records.Text == "      Records")
            {
                NewGame.Visible = false;
                NewGame.Enabled = false;
                label1.Visible = false;
                label2.Visible = false;
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        botones[i, j].Visible = false;
                        botones[i, j].Enabled = false;
                    }
                }
                label3.Visible = true;
                panel1.Visible = true;
                Records.Text = "      Game";
            }
            else
            {
                NewGame.Visible = true;
                NewGame.Enabled = true;
                label1.Visible = true;
                label2.Visible = true;
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        botones[i, j].Visible = true;
                        if (label1.Text == "PERDISTE !!")
                        {
                            botones[i, j].Enabled = false;
                        }
                        else
                        {
                            botones[i, j].Enabled = true;
                        }
                    }
                }
                label3.Visible = false;
                panel1.Visible = false;
                Records.Text = "      Records";
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (MenuBar.Width == 279)
            {
                MenuBar.Visible = false;
                MenuBar.Width = 68;
                MenuPanel.Width = 90;
                CloseAnimation.Show(MenuBar);
                this.Width = 842;
            }
            else
            {
                MenuBar.Visible = false;
                MenuBar.Width = 279;
                MenuPanel.Width = 300;
                OpenAnimation.Show(MenuBar);
                this.Width = 1052;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)reloj.ElapsedMilliseconds);
            horas = ts.Hours.ToString().Length < 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();
            minutos = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            segundos = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            milisegundos = ts.Milliseconds.ToString().Length < 2 ? "0" + ts.Milliseconds.ToString() : ts.Milliseconds.ToString();
            label2.Text = horas + ":" + minutos + ":" + segundos + ":" + milisegundos[0] + milisegundos[1];
        }
    }
}
