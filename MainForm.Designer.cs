
namespace NTP_2023_01_12_odev
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.imgLs = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // niMain
            // 
            this.niMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niMain.BalloonTipText = "Yükleme Tamamlandı";
            this.niMain.BalloonTipTitle = "NTP Ödevi";
            this.niMain.Text = "NTP Ödevi Çalışıyor";
            this.niMain.Visible = true;
            // 
            // imgLs
            // 
            this.imgLs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLs.ImageStream")));
            this.imgLs.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLs.Images.SetKeyName(0, "80e2ea4e-2f1f-44c5-89f3-4a03d3c695c5.jpg");
            this.imgLs.Images.SetKeyName(1, "9f073f3f-4f87-4af2-b826-6580b01ca1bd.jpg");
            this.imgLs.Images.SetKeyName(2, "CBF9F046-F3BE-4F6B-B326-D79A1091A127.jpeg");
            this.imgLs.Images.SetKeyName(3, "2abd6969-f556-49ae-8d81-a61739d40a3f.jpg");
            this.imgLs.Images.SetKeyName(4, "5c1f0ece-d01d-44b8-9114-602a33a24cd3.jpg");
            this.imgLs.Images.SetKeyName(5, "40be127a-5d9f-4ae7-8e06-c670f300f1d1.jpg");
            this.imgLs.Images.SetKeyName(6, "2fd5eb08-43b8-4e33-bc46-2c694aa7caf1.jpg");
            this.imgLs.Images.SetKeyName(7, "b80c10da-1371-418f-90f6-8612eef77a1f.jpg");
            this.imgLs.Images.SetKeyName(8, "80e2ea4e-2f1f-44c5-89f3-4a03d3c695c5.jpg");
            this.imgLs.Images.SetKeyName(9, "9f073f3f-4f87-4af2-b826-6580b01ca1bd.jpg");
            this.imgLs.Images.SetKeyName(10, "CBF9F046-F3BE-4F6B-B326-D79A1091A127.jpeg");
            this.imgLs.Images.SetKeyName(11, "2abd6969-f556-49ae-8d81-a61739d40a3f.jpg");
            this.imgLs.Images.SetKeyName(12, "5c1f0ece-d01d-44b8-9114-602a33a24cd3.jpg");
            this.imgLs.Images.SetKeyName(13, "40be127a-5d9f-4ae7-8e06-c670f300f1d1.jpg");
            this.imgLs.Images.SetKeyName(14, "2fd5eb08-43b8-4e33-bc46-2c694aa7caf1.jpg");
            this.imgLs.Images.SetKeyName(15, "b80c10da-1371-418f-90f6-8612eef77a1f.jpg");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 501);
            this.Name = "MainForm";
            this.Text = "Kart Eşleştirme oyunu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.ImageList imgLs;
    }
}

