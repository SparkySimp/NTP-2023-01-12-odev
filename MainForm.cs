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

        public MainForm()
        {
            InitializeComponent();
        }
        #region State
        Button lastSelectedButton1, lastSelectedButton2; // Last clicked buttons.
        protected Mode mode = Mode.First; // Mode.

        readonly Size BTN_SZ = new Size(100, 100); // Size for the buttons (CONSTANT)
        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            CardImagesList imgLs = new CardImagesList(); // Initialize the resources object.
            (int coordX, int coordY) = (0, 0); // Coordinates are O(0, 0).
            for (int i = 1; i <= 16; i++) // For each of the 16 buttons...
            {
                #region Button creation
                Button btn = new Button(); // create a new button.
                btn.Location = new Point(coordX, coordY); // Set the location of the button.
                btn.Size = BTN_SZ; // Size is 50x50.
                btn.Name = $"cardButton{i}"; // Name is *cardButton{i}*
                btn.Text = ""; // Text is empty.
                btn.BackgroundImageLayout = ImageLayout.Stretch; // Background image layout is stretch.
                btn.Tag = (i > 8) ? i % 8 : i;
                #endregion
                #region Main game loop
                btn.Click += delegate (object _sender, EventArgs _e) // Handle Click of the button
                {
                    if (this.mode == Mode.First) // If this is the first card...
                    {
                        this.mode = Mode.Second; // ...next one is the second...
                        btn.BackgroundImage = imgLs[((int)btn.Tag)]; // Open the card...
                        this.lastSelectedButton1 = btn; // Keep last selected button.
                    }
                    else // If this is the second card...
                    {
                        this.mode = Mode.First; // ...next one is the first...
                        this.lastSelectedButton2 = btn; // Keep the last selected button...
                        lastSelectedButton2.BackgroundImage = imgLs[((int)btn.Tag)]; // Open the card...
                        if (lastSelectedButton1.BackgroundImage != lastSelectedButton2.BackgroundImage) // If this card does not match the previous one...
                        {
                            Task.Delay(2000).Wait(); // Wait for 2 seconds...
                            lastSelectedButton1.BackgroundImage = lastSelectedButton2.BackgroundImage = null; // Clear background images...
                            lastSelectedButton1.BackColor = lastSelectedButton2.BackColor = SystemColors.Control;
                        }
                        else return; // SUCCESS CASE!!!!
                    }
                };
                #endregion
                #region Button rendering
                coordX += 105; // Move to the next button (buttons are 100x100)...
                if (i % 4 == 0) // On every 4 button...
                {
                    coordY += 105; // Create a new line...
                    coordX = 0;
                }
                this.Controls.Add(btn); // Render the button.
                #endregion
                #region Loading end actions
                niMain.Icon = Icon;

                niMain.ShowBalloonTip(3000, "NTP Ödevi", "Yükleme Tamamlandı", ToolTipIcon.Info);
                #endregion
            }


        }

    }
}
