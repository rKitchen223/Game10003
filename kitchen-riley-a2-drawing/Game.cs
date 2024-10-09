// Include code libraries you need below (use the namespace).
using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("A Bird Moving");
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;
            Window.ClearBackground(Color.Blue);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Draw.FillColor = Color.Red;
            Draw.LineColor = Color.Black;
            //Draw.Capsule(400, 200, 500, 200, 60);
            DrawBird();

        }

        void DrawBird()
        {
            /// The Wing Body
            Draw.Triangle(500, 300, 320, 280, 500, 250);
            Draw.Triangle(500, 300, 680, 280, 500, 250);

            /// The Head Body
            Draw.Ellipse(500, 300, 100, 150);
            Draw.Quad(500, 380, 450, 470, 500, 530, 550, 470);
           

            /// The Second Wing Body
            //Draw.Triangle(300, 400, 400, 380, 600, 80);

            Draw.Circle(500, 220, 50);

            

            
            

        }
    }
}





        

         

















        
    

           

            
           

