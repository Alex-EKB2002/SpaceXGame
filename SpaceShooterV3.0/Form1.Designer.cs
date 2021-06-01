
namespace SpaceShooterV3._0
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.HealthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EBullet = new System.Windows.Forms.PictureBox();
            this.Bullet = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.HealthHeart = new System.Windows.Forms.PictureBox();
            this.ShootingEnemy = new System.Windows.Forms.PictureBox();
            this.Bomb = new System.Windows.Forms.PictureBox();
            this.Enemy3 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Hearts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShootingEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hearts)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText
            // 
            this.ScoreText.BackColor = System.Drawing.Color.Transparent;
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreText.Location = new System.Drawing.Point(0, 261);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(624, 135);
            this.ScoreText.TabIndex = 1;
            this.ScoreText.Text = "0";
            this.ScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BackColor = System.Drawing.Color.Red;
            this.HealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HealthLabel.Location = new System.Drawing.Point(22, 21);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(25, 25);
            this.HealthLabel.TabIndex = 2;
            this.HealthLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // EBullet
            // 
            this.EBullet.Image = global::SpaceShooterV3._0.Sprites.laser;
            this.EBullet.Location = new System.Drawing.Point(606, 97);
            this.EBullet.Name = "EBullet";
            this.EBullet.Size = new System.Drawing.Size(18, 31);
            this.EBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EBullet.TabIndex = 0;
            this.EBullet.TabStop = false;
            // 
            // Bullet
            // 
            this.Bullet.Image = global::SpaceShooterV3._0.Sprites.bullet;
            this.Bullet.Location = new System.Drawing.Point(302, 422);
            this.Bullet.Name = "Bullet";
            this.Bullet.Size = new System.Drawing.Size(28, 54);
            this.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bullet.TabIndex = 0;
            this.Bullet.TabStop = false;
            // 
            // Player
            // 
            this.Player.Image = global::SpaceShooterV3._0.Sprites.spaceship;
            this.Player.Location = new System.Drawing.Point(260, 522);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(111, 97);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // HealthHeart
            // 
            this.HealthHeart.BackColor = System.Drawing.Color.Transparent;
            this.HealthHeart.Image = global::SpaceShooterV3._0.Sprites.heart;
            this.HealthHeart.Location = new System.Drawing.Point(-2, 1);
            this.HealthHeart.Name = "HealthHeart";
            this.HealthHeart.Size = new System.Drawing.Size(70, 71);
            this.HealthHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HealthHeart.TabIndex = 0;
            this.HealthHeart.TabStop = false;
            // 
            // ShootingEnemy
            // 
            this.ShootingEnemy.BackColor = System.Drawing.Color.Transparent;
            this.ShootingEnemy.Image = global::SpaceShooterV3._0.Sprites.Enemy2;
            this.ShootingEnemy.Location = new System.Drawing.Point(504, 1);
            this.ShootingEnemy.Name = "ShootingEnemy";
            this.ShootingEnemy.Size = new System.Drawing.Size(102, 90);
            this.ShootingEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShootingEnemy.TabIndex = 0;
            this.ShootingEnemy.TabStop = false;
            // 
            // Bomb
            // 
            this.Bomb.BackColor = System.Drawing.Color.Transparent;
            this.Bomb.Image = global::SpaceShooterV3._0.Sprites.bomb;
            this.Bomb.Location = new System.Drawing.Point(334, 163);
            this.Bomb.Name = "Bomb";
            this.Bomb.Size = new System.Drawing.Size(50, 50);
            this.Bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bomb.TabIndex = 0;
            this.Bomb.TabStop = false;
            // 
            // Enemy3
            // 
            this.Enemy3.BackColor = System.Drawing.Color.Transparent;
            this.Enemy3.Image = global::SpaceShooterV3._0.Sprites.Enemy5;
            this.Enemy3.Location = new System.Drawing.Point(396, 67);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(102, 90);
            this.Enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy3.TabIndex = 0;
            this.Enemy3.TabStop = false;
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.Transparent;
            this.Enemy2.Image = global::SpaceShooterV3._0.Sprites.Enemy4;
            this.Enemy2.Location = new System.Drawing.Point(217, 67);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(102, 90);
            this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2.TabIndex = 0;
            this.Enemy2.TabStop = false;
            // 
            // Enemy1
            // 
            this.Enemy1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Enemy1.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1.Image = global::SpaceShooterV3._0.Sprites.Enemy1;
            this.Enemy1.Location = new System.Drawing.Point(38, 78);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(102, 90);
            this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1.TabIndex = 0;
            this.Enemy1.TabStop = false;
            // 
            // Hearts
            // 
            this.Hearts.BackColor = System.Drawing.Color.Transparent;
            this.Hearts.Image = global::SpaceShooterV3._0.Sprites.heart;
            this.Hearts.Location = new System.Drawing.Point(182, 522);
            this.Hearts.Name = "Hearts";
            this.Hearts.Size = new System.Drawing.Size(30, 28);
            this.Hearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hearts.TabIndex = 0;
            this.Hearts.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(624, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.EBullet);
            this.Controls.Add(this.Bullet);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Hearts);
            this.Controls.Add(this.HealthHeart);
            this.Controls.Add(this.ShootingEnemy);
            this.Controls.Add(this.Bomb);
            this.Controls.Add(this.Enemy3);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.ScoreText);
            this.Name = "Form1";
            this.Text = "SpaceShooterV3.0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.EBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShootingEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hearts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox Enemy3;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Bullet;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.PictureBox ShootingEnemy;
        private System.Windows.Forms.PictureBox EBullet;
        private System.Windows.Forms.PictureBox Bomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HealthHeart;
        private System.Windows.Forms.PictureBox Hearts;
    }
}

