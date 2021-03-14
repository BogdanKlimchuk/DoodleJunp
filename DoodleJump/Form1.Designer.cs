
namespace DoodleJump
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.playButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::DoodleJump.Properties.Resources.starn_button;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.Location = new System.Drawing.Point(12, 159);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 50);
            this.playButton.TabIndex = 0;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoodleJump.Properties.Resources.backMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(314, 501);
            this.Controls.Add(this.playButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Doodle Jump";
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playButton;
    }
}

