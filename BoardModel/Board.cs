using System;
using System.Collections.Generic;
using System.Text;

namespace BoardModel
{
    public class Board
    {
        public int Size { get; set; }

        public Cell[,] grid { get; set; }

        //constructor
        public Board(int s)
        {
            //initialize size of board
            Size = s;

            //create 2D array pf type cell
            grid = new Cell[Size, Size];

            //Fill 2D array with cells 
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    grid[i, j] = new Cell(i, j);
                }
            }
        }
        public void MarkNextLegalMove(Cell CurrentCell, string Piece)
        {
            //clear board
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    grid[i, j].Legalmoves = false;
                    grid[i, j].Occupied = false;
                }
            }
            //find legal moves and mark th
            switch (Piece)
            {
                case "Knight":
                    grid[CurrentCell.Row + 2, CurrentCell.Column + 1].Legalmoves = true;
                    grid[CurrentCell.Row + 1, CurrentCell.Column + 2].Legalmoves = true;
                    grid[CurrentCell.Row - 1, CurrentCell.Column + 2].Legalmoves = true;
                    grid[CurrentCell.Row - 2, CurrentCell.Column + 1].Legalmoves = true;
                    grid[CurrentCell.Row - 1, CurrentCell.Column - 2].Legalmoves = true;
                    grid[CurrentCell.Row - 2, CurrentCell.Column - 1].Legalmoves = true;
                    grid[CurrentCell.Row + 2, CurrentCell.Column - 1].Legalmoves = true;
                    grid[CurrentCell.Row + 1, CurrentCell.Column - 2].Legalmoves = true;


                    break;

                case "W_Pawn":
                    grid[CurrentCell.Row , CurrentCell.Column + 1].Legalmoves = true;

                    break;

                case "Bl_Pawn":
                    grid[CurrentCell.Row, CurrentCell.Column - 1].Legalmoves = true;

                    break;

                case "Rook":
                    for (int i = CurrentCell.Row; i < Size; i++)
                    {
                        grid[i, CurrentCell.Column].Legalmoves = true;
                    }
                    for (int i = CurrentCell.Row; i >= 0; i = i-1)
                    {
                        grid[i, CurrentCell.Column].Legalmoves = true;
                    }
                    for (int i = CurrentCell.Column; i < Size; i++)
                    {
                        grid[CurrentCell.Row, i].Legalmoves = true;
                    }
                    for (int i = CurrentCell.Column; i >= 0; i = i - 1)
                    {
                        grid[CurrentCell.Row, i].Legalmoves = true;
                    }

                    break;

                case "Bishop":
                    
                    for (int i = CurrentCell.Row; i < Size; i++)
                    {
                        for (int j = CurrentCell.Column; i < Size; i++)
                        {
                            grid[i, j].Legalmoves = true;
                            continue;
                        }
                    }

                    for (int i = CurrentCell.Row; i >= 0; i--)
                    {
                        for (int j = CurrentCell.Column; i >= 0; i--)
                        {
                            grid[i, j].Legalmoves = true;
                            continue;
                        }
                    }

                    for (int i = CurrentCell.Row; i < Size; i++)
                    {
                        for (int j = CurrentCell.Column; i >= 0; i--)
                        {
                            grid[i, j].Legalmoves = true;
                            continue;
                        }
                    }

                    for (int i = CurrentCell.Row; i >= 0; i--)
                    {
                        for (int j = CurrentCell.Column; i < Size; i++)
                        {
                            grid[i, j].Legalmoves = true;
                            continue;
                        }
                    }

                    break;

                case "Queen":

                    for (int i = CurrentCell.Row; i < Size; i++)
                    {
                        grid[i, CurrentCell.Column].Legalmoves = true;
                    }
                    for (int i = CurrentCell.Row; i >= 0; i = i - 1)
                    {
                        grid[i, CurrentCell.Column].Legalmoves = true;
                    }
                    for (int i = CurrentCell.Column; i < Size; i++)
                    {
                        grid[CurrentCell.Row, i].Legalmoves = true;
                    }
                    for (int i = CurrentCell.Column; i >= 0; i = i - 1)
                    {
                        grid[CurrentCell.Row, i].Legalmoves = true;
                    }

                    for (int i = CurrentCell.Row; i < Size; i++)
                    {
                        for (int j = CurrentCell.Column; i < Size; i++)
                        {
                            grid[i, j].Legalmoves = true;
                        }
                    }

                    for (int i = CurrentCell.Row; i >= 0; i = i - 1)
                    {
                        for (int j = CurrentCell.Column; i >= 0; i = i - 1)
                        {
                            grid[i, j].Legalmoves = true;
                        }
                    }

                    for (int i = CurrentCell.Row; i < Size; i++)
                    {
                        for (int j = CurrentCell.Column; i >= 0; i = i - 1)
                        {
                            grid[i, j].Legalmoves = true;
                        }
                    }

                    for (int i = CurrentCell.Row; i >= 0; i = i - 1)
                    {
                        for (int j = CurrentCell.Column; i < Size; i++)
                        {
                            grid[i, j].Legalmoves = true;
                        }
                    }

                    break;

                case "King":

                    grid[CurrentCell.Row, CurrentCell.Column + 1].Legalmoves = true;
                    grid[CurrentCell.Row + 1, CurrentCell.Column + 1].Legalmoves = true;
                    grid[CurrentCell.Row + 1, CurrentCell.Column].Legalmoves = true;
                    grid[CurrentCell.Row + 1, CurrentCell.Column - 1].Legalmoves = true;
                    grid[CurrentCell.Row, CurrentCell.Column - 1].Legalmoves = true;
                    grid[CurrentCell.Row - 1, CurrentCell.Column - 1].Legalmoves = true;
                    grid[CurrentCell.Row - 1, CurrentCell.Column].Legalmoves = true;
                    grid[CurrentCell.Row - 1, CurrentCell.Column - 1].Legalmoves = true;
               
                    break;
                    
            }

            grid[CurrentCell.Row, CurrentCell.Column].Occupied = true;

        }
    }
}
