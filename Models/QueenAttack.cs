using System;

namespace QueenAttack.Models
{
  public class Piece
  {
    public int X { get; set; }
    public int Y { get; set; }

    public Piece(int pieceX, int pieceY)
    {
      X = pieceX;
      Y = pieceY;
    }
  }
}