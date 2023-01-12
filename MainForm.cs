using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Debug = System.Diagnostics.Debug;
using System.IO;

namespace NTP_2023_01_12_odev
{
    /// <summary>
    /// Clicked button mode.
    /// </summary>
    public enum Mode : byte
    {
        /// <summary>
        /// First button was clicked.
        /// </summary>
        First,
        /// <summary>
        /// Second buttton was clicked.
        /// </summary>
        Second
    }
    public partial class MainForm : Form
    {
        protected Mode mode = Mode.First;

        readonly Size BTN_SZ = new Size(100, 100);
        public MainForm()
        {
            InitializeComponent();
        }
        int id = 0;
        private void MainForm_Load(object sender, EventArgs e)
        {
            CardImagesList imgLs = new CardImagesList();
            (int coordX, int coordY) = (0, 0);
            for (int i = 1; i <= 16; i++)
            {
                Button btn = new Button(); // create a new button.
                btn.Location = new Point(coordX, coordY); // Set the location of the button.
                btn.Size = BTN_SZ; // Size is 50x50.
                btn.Name = $"cardButton{i}"; // Name is *cardButton{i}*
                btn.Text = i.ToString(); // Text is *{i}*
                btn.BackgroundImageLayout = ImageLayout.Stretch; // Background image layout is stretch.
                btn.Click += delegate (object _sender, EventArgs _e)
                { 
                    if(this.mode == Mode.First)
                    {
                        this.mode = Mode.Second;
                        btn.BackgroundImage = imgLs[id % 8];
                    } 
                    else
                    {
                        this.mode = Mode.First;
                        btn.BackgroundImage = null;
                        btn.BackColor = SystemColors.Control;
                    }
                };

                coordX += 105;
                if (i % 4 == 0)
                {
                    coordY += 105;
                    coordX = 0;
                }
                this.Controls.Add(btn);

                notifyIcon1.Icon = Icon;

                notifyIcon1.ShowBalloonTip(3000, "NTP Ödevi", "Yükleme Tamamlandı", ToolTipIcon.Info);
            }


        }

    }
}
