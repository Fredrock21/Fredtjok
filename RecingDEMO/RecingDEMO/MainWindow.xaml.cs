﻿using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading;

namespace RecingDEMO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer gameTimer = new DispatcherTimer();

        int lifes = 1;
        double dis = 0;
        int moveX = 0;
        bool gameOver;
        Rect F1HitBox;


        public MainWindow()
        {
            InitializeComponent();

            gameTimer.Tick += MainEventTimer;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            StartGame();

        }

        private void MainEventTimer(object sender, EventArgs e)
        {
            livs.Content = "lives: " + lifes;
            distanc.Content = "Distanc " + dis + " m";

            F1HitBox = new Rect(Canvas.GetLeft(F1), Canvas.GetTop(F1), F1.Width, F1.Height);

            Canvas.SetLeft(F1, Canvas.GetLeft(F1) + moveX);

            if (Canvas.GetLeft(F1) < -25 || Canvas.GetLeft(F1) > 460)
            {
                EndGame();
            }

            foreach (var y in MyCanvas.Children.OfType<Image>())
            {
                if ((string)y.Tag == "Line1" || (string)y.Tag == "Line2" || (string)y.Tag == "Line3" || (string)y.Tag == "Line4" || (string)y.Tag == "Line5")
                {
                    Canvas.SetTop(y, Canvas.GetTop(y) + 10);

                    if (Canvas.GetTop(y) > 300)
                    {
                        Canvas.SetTop(y, -60);

                        dis += 1;
                    }

                }

                Random speed = new Random();
                int cars = speed.Next(2, 7);

                if ((string)y.Tag == "car1" || (string)y.Tag == "car2" || (string)y.Tag == "car3" || (string)y.Tag == "car4" || (string)y.Tag == "car5")
                {
                    Canvas.SetTop(y, Canvas.GetTop(y) + cars);

                    if (Canvas.GetTop(y) > 400)
                    {
                        Canvas.SetTop(y, -90);
                    }

                }

                Rect CarHitBox1 = new Rect(Canvas.GetLeft(car1), Canvas.GetTop(car1), car1.Width, car1.Height);
                if (F1HitBox.IntersectsWith(CarHitBox1))
                {
                    EndGame();
                }

                Rect CarHitBox2 = new Rect(Canvas.GetLeft(car2), Canvas.GetTop(car2), car2.Width, car2.Height);
                if (F1HitBox.IntersectsWith(CarHitBox2))
                {
                    EndGame();
                }

                Rect CarHitBox3 = new Rect(Canvas.GetLeft(car3), Canvas.GetTop(car3), car3.Width, car3.Height);
                if (F1HitBox.IntersectsWith(CarHitBox3))
                {
                    EndGame();
                }

                Rect CarHitBox4 = new Rect(Canvas.GetLeft(car4), Canvas.GetTop(car4), car4.Width, car4.Height);
                if (F1HitBox.IntersectsWith(CarHitBox4))
                {
                    EndGame();
                }
            }
        }

        private void Stering(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                F1.RenderTransform = new RotateTransform(-5);
                moveX = -5;
            }
            if (e.Key == Key.Right)
            {
                F1.RenderTransform = new RotateTransform(5);
                moveX = 5;
            }

            if (e.Key == Key.R)
            {
                StartGame();
            }
        }

        private void Crusing(object sender, KeyEventArgs e)
        {
            F1.RenderTransform = new RotateTransform(0);
            moveX = 0;
        }

        private void StartGame()
        {
            MyCanvas.Focus();

            gameOver = false;

            Canvas.SetLeft(F1, 220);

            lifes = 1;

            dis = 0;

            foreach (var y in MyCanvas.Children.OfType<Image>())
            {
                if ((string)y.Tag == "Line1")
                {

                    Canvas.SetTop(y, 300);
                }

                if ((string)y.Tag == "Line2")
                {
                    Canvas.SetTop(y, 210);
                }

                if ((string)y.Tag == "Line3")
                {
                    Canvas.SetTop(y, 120);
                }

                if ((string)y.Tag == "Line4")
                {
                    Canvas.SetTop(y, 30);
                }
                if ((string)y.Tag == "Line5")
                {
                    Canvas.SetTop(y, -60);
                }

                if ((string)y.Tag == "car1")
                {
                    Canvas.SetTop(y, -400);
                }
                if ((string)y.Tag == "car2")
                {
                    Canvas.SetTop(y, -100);
                }
                if ((string)y.Tag == "car3")
                {
                    Canvas.SetTop(y, -340);
                }
                if ((string)y.Tag == "car4")
                {
                    Canvas.SetTop(y, -200);
                }
            }
            gameTimer.Start();
        }

        private void EndGame()
        {
            gameTimer.Stop();
            gameOver = true;

            lifes = 0;
            livs.Content = "lives: " + lifes + " press R to start agen.";
        }
    }
}

