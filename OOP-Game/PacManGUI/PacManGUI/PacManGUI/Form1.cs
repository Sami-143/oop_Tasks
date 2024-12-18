﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacMan.GameGL;
using EZInput;
using PacManGUI.GameGL;
namespace PacManGUI
{
    public partial class Form1 : Form
    {
        GamePacManPlayer pacman;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("maze.txt", 20, 70);
            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            pacman = new GamePacManPlayer(pacManImage, startCell);
            GameCell hor = new GameCell(12, 2, grid);

            printMaze(grid);
            Image ghostHorImage = Game.getGameObjectImage('H');
            Horizontal_Ghost h = new Horizontal_Ghost(ghostHorImage, hor);
            List<Ghost> ghost = new List<Ghost>();
            ghost.Add(h);
        }



        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
               
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);          
            //        printCell(cell);
                }

            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }
     

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            if(Keyboard.IsKeyPressed(Key.LeftArrow)) {
                pacman.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow)){
                pacman.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow)){
                pacman.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow)){
                pacman.move(GameDirection.Down);
            }



        }
    }
}
