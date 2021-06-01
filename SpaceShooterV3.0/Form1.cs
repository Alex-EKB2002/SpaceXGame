using System;
using System.Windows.Forms;

namespace SpaceShooterV3._0
{
    public partial class Form1 : Form
    {
        bool moveLeft, moveRight, isShooting, isGameOver,enemyIsShooting, autoShooting;
        int score = 0;
        int health = 3;
        readonly int playerSpeed = 12;
        readonly int enemySpeed = 6;
        readonly int shootingEnemySpeed = 4;
        int bulletSpeed;
        int EbulletSpeed;
        int bombSpeed = 10;
        int heartsSpeed = 8;

        readonly Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            // Движение объектов сверху-вниз
            Enemy1.Top += enemySpeed;
            Enemy2.Top += enemySpeed;
            Enemy3.Top += enemySpeed;
            ShootingEnemy.Top += shootingEnemySpeed;
            Bomb.Top += bombSpeed;
            Hearts.Top += heartsSpeed;
            // Условия проигрыша
            if (Enemy1.Top > 710 || Enemy2.Top > 710 || Enemy3.Top > 710 || ShootingEnemy.Top > 710 || health == 0)
            {
               GameOver();
            }
            // Движение персонажа + не дает выйти за пределы формы 
            if (moveLeft == true && Player.Left > 0)
            {
                Player.Left -= playerSpeed;
            }

            if (moveRight == true && Player.Left < 512)
            {
                Player.Left += playerSpeed;
            }

            // Не дает спамить выстрелами
            if (isShooting == true)
            {
                bulletSpeed = 20;
                Bullet.Top -= bulletSpeed;
            }
            else
            {
                Bullet.Left = -300;
                bulletSpeed = 0;
            }
            //Не дает спамить выстрелами врагу
            if (enemyIsShooting == true)
            {
                EbulletSpeed = 15;
                EBullet.Top += EbulletSpeed;
            }
            else
            {
                EBullet.Left = -300;
                EbulletSpeed = 0;
            }

            if (Bullet.Top < 0)
            {
                isShooting = false;
            }
            if (EBullet.Top < 0 || EBullet.Top > 710)
            {
                enemyIsShooting = false;
            }
            
            if (enemyIsShooting == false)
            {
                enemyIsShooting = true;
                EBullet.Top = ShootingEnemy.Top + 110;
                EBullet.Left = ShootingEnemy.Left - 13 + (ShootingEnemy.Width / 2);
            }


            // Взаимодействие с первым врагом
            if (Bullet.Bounds.IntersectsWith(Enemy1.Bounds) || (Bullet.Bounds.IntersectsWith(Bomb.Bounds) && Enemy1.Top > 0 && Enemy1.Top < 710))
            {
                AddScore();
                Enemy1.Top = -450;
                Enemy1.Left = rnd.Next(20, 550);
                isShooting = false;
            }
            // Взаимодействие со вторым врагом
            if (Bullet.Bounds.IntersectsWith(Enemy2.Bounds) || (Bullet.Bounds.IntersectsWith(Bomb.Bounds) && Enemy2.Top > 0 && Enemy2.Top < 710))
            {
                AddScore();
                Enemy2.Top = -650;
                Enemy2.Left = rnd.Next(20, 550);
                isShooting = false;
            }
            // Взаимодействие с третьим врагом
            if (Bullet.Bounds.IntersectsWith(Enemy3.Bounds) || (Bullet.Bounds.IntersectsWith(Bomb.Bounds) && Enemy3.Top > 0 && Enemy3.Top < 710))
            {
                AddScore();
                Enemy3.Top = -750;
                Enemy3.Left = rnd.Next(20, 550);
                isShooting = false;
            }
            // Взаимодействие с четвертым врагом
            if (Bullet.Bounds.IntersectsWith(ShootingEnemy.Bounds) || (Bullet.Bounds.IntersectsWith(Bomb.Bounds) && ShootingEnemy.Top > 0 && ShootingEnemy.Top < 710))
            {
                AddScore();
                ShootingEnemy.Top = -950;
                ShootingEnemy.Left = rnd.Next(20, 550);
                isShooting = false;
            }
            // Взаимодействие вражеской пули и игрока
            if (EBullet.Bounds.IntersectsWith(Player.Bounds))
            {
                EBullet.Left = -300;
                RemoveHealth();
            }
            // Взаимодействие пули игрока и бомбы
            if (Bullet.Bounds.IntersectsWith(Bomb.Bounds))
            {
                Bomb.Left = -300;
                isShooting = false;
            }
            // Взаимодействеи игрока и сердец
            if (Player.Bounds.IntersectsWith(Hearts.Bounds) && health < 9)
            {
                Hearts.Left = -300;
                AddHealth();
            }


            // Отреспавн бомбы
            if (Bomb.Top >= 710)
            {
                Bomb.Top = -1000;
                Bomb.Left = rnd.Next(20, 550);
            }
            // Отреспавн сердец
            if (Hearts.Top >= 710)
            {
                Hearts.Top = -1000;
                Hearts.Left = rnd.Next(20, 550);
            }
            label1.Text = autoShooting.ToString();
            label2.Text = Player.Left.ToString();
            label3.Text = Enemy1.Left.ToString();
            PseudoAI();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)// Даем понять, куда идем
        {
            switch (e.KeyCode.ToString())
            {
                case "Left":
                    moveLeft = true;
                    break;
                case "Right":
                    moveRight = true;
                    break; 
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)// Управление на кнопки
        {

            switch (e.KeyCode.ToString())
            {
                case "Left":
                    moveLeft = false;
                    break;
                case "Right":
                    moveRight = false;
                    break;
                case "Space":
                    if (isShooting == false)
                    {
                        isShooting = true;
                        Bullet.Top = Player.Top - 30;
                        Bullet.Left = Player.Left - 13 + (Player.Width / 2);
                    }
                    break;
                case "E":
                    autoShooting = true;
                    break;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                ResetGame();
            }
        }

        

        private void ResetGame()//рестарт игры
        {
            GameTimer.Start();
            isGameOver = false;
            autoShooting = false;
            // Рандомное появление врагов и бустов на форме
            Enemy1.Left = rnd.Next(20, 550);
            Enemy2.Left = rnd.Next(20, 550);
            Enemy3.Left = rnd.Next(20, 550);
            ShootingEnemy.Left = rnd.Next(20,550);
            Bomb.Left = rnd.Next(20, 550);
            Hearts.Left = rnd.Next(20, 550);

            Enemy1.Top = rnd.Next(0, 200) * -1;
            Enemy2.Top = rnd.Next(0, 500) * -1;
            Enemy3.Top = rnd.Next(0, 900) * -1;
            ShootingEnemy.Top = rnd.Next(0, 950) * -1;
            Bomb.Top = rnd.Next(0, 1300) * -1;
            Hearts.Top = rnd.Next(0, 2500) * -1;

            score = 0;
            health = 3;

            
            ScoreText.Text = score.ToString();
            isShooting = false;
            HealthLabel.Text = health.ToString();
        }

        private void PseudoAI()// Псевдо-искусственный интеллект
        {
            if (autoShooting == true)
            {
                if ((Player.Left < Enemy1.Left && Enemy1.Top > 0) || (Player.Left < Enemy2.Left && Enemy2.Top > 0)
                    || (Player.Left < Enemy3.Left && Enemy3.Top > 0) || (Player.Left < ShootingEnemy.Left && ShootingEnemy.Top > 0))
                {
                    Player.Left += playerSpeed;
                }
                else if ((Player.Left > Enemy1.Left && Enemy1.Top > 0) || (Player.Left > Enemy2.Left && Enemy2.Top > 0)
                    || (Player.Left > Enemy3.Left && Enemy3.Top > 0) || (Player.Left > ShootingEnemy.Left && ShootingEnemy.Top > 0))
                {
                    Player.Left -= playerSpeed;
                }
                if (Player.Left <= Enemy1.Left + 10 || Player.Left >= Enemy1.Left - 10 ||
                    Player.Left <= Enemy2.Left + 10 || Player.Left >= Enemy2.Left - 10 || 
                    Player.Left <= Enemy3.Left + 10 || Player.Left >= Enemy3.Left - 10 ||
                    Player.Left <= ShootingEnemy.Left + 10 || Player.Left >= ShootingEnemy.Left - 10)
                {
                    if (isShooting == false)
                    {
                        isShooting = true;
                        Bullet.Top = Player.Top - 30;
                        Bullet.Left = Player.Left - 13 + (Player.Width / 2);
                    }
                }

            }
           
        }

        private void GameOver()//Сообщаем о проигрыше
        {
            isGameOver = true;
            GameTimer.Stop();
            ScoreText.Text =  score.ToString() + Environment.NewLine + "Game Over!!!" + Environment.NewLine + "Press Enter to try again.";
        }

        private void AddScore()// Добавляем очки
        {
            score += 1;
            ScoreText.Text = score.ToString();
        }
        private void RemoveHealth()// Убавляем здоровье
        {
            health -= 1;
            HealthLabel.Text = health.ToString();
        }
        private void AddHealth()// Добавляем здоровье
        {
            health += 1;
            HealthLabel.Text = health.ToString();
        }
    }
}
