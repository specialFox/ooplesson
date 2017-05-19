﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Walls
    {

        List<Figure> wallList;

        public Walls(int mapWidth,int mapHeight) {

            wallList = new List<Figure>();

            wallList.Add(new HorizontalLine(0, mapWidth-2, 0, '+'));
            wallList.Add(new HorizontalLine(0, mapWidth - 2, mapHeight-1, '+'));
            wallList.Add(new VerticalLine(0, mapHeight-1, 0, '+'));
            wallList.Add(new VerticalLine(0, mapHeight-1, mapWidth-2, '+'));
        }

        internal bool IsHit(Figure snake) {
            foreach (var wall in wallList) {
                if (wall.IsHit(snake)) {
                    return true;
                }
            }
            return false;
        }

        public void Draw() {
            foreach (var f in wallList) {
                f.Draw();
            }
        }
    }
}
