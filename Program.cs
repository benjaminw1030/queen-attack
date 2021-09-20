using System;
using System.Collections.Generic;
using QueenAttack.Models;

namespace QueenAttack
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("QUEEN ATTACK");
      Console.WriteLine("-------------------");
      Console.WriteLine("Enter the position of a queen chess piece and another piece on a standard");
      Console.WriteLine("8x8 chessboard to see if the piece can be attacked by the queen.");
      Console.WriteLine("");
      Console.WriteLine("Enter Queen's X position");
      string queenXString = Console.ReadLine();
      int queenX = int.Parse(queenXString);
      RejectInvalid(queenX);
      Console.WriteLine("Enter Queen's Y position");
      string queenYString = Console.ReadLine();
      int queenY = int.Parse(queenYString);
      RejectInvalid(queenY);
      Console.WriteLine("Enter Pieces's X position");
      string pieceXString = Console.ReadLine();
      int pieceX = int.Parse(pieceXString);
      RejectInvalid(pieceX);
      Console.WriteLine("Enter Pieces's Y position");
      string pieceYString = Console.ReadLine();
      int pieceY = int.Parse(pieceYString);
      RejectInvalid(pieceY);
      Piece queen = new Piece(queenX, queenY);
      Piece piece = new Piece(pieceX, pieceY);
      CanQueenAttack(queen, piece);
    }

    public static void CanQueenAttack(Piece queen, Piece piece)
    {
      if (queen.X == piece.X && queen.Y == piece.Y)
      {
        Console.WriteLine("The piece and queen cannot be at the same position!");
      }
      else if (queen.X == piece.X || queen.Y == piece.Y || Math.Abs(queen.X - piece.X) == Math.Abs(queen.Y-piece.Y))
      {
        Console.WriteLine("This piece can be attack by the queen!");
      }
      else
      {
        Console.WriteLine("This piece is safe!");
      }
    }

    public static void RejectInvalid(int number)
    {
      if (number < 1 || number > 8)
      {
        Console.WriteLine("This is not a valid space on a chessboard. Please enter a number from 1-8.");
        Main();
      }
    }
  }  
}

//queen.x == piece.x || queen.y == piece.y 
//Abs(queen x - piece x) = Abs(queen y - piece y)

// if (queen.x - queen.y == piece.x - piece.y || queen.x + queen.y == piece.x + piece.y)

// queen.x,y 3,3 piece x,y 1,1 2,2 4,4 5,5 6,6 7,7 8,8   4,2 5,1 2,4 1,5
// queen.x,y 7,3 piece x,y 5,1 6,2 8,4    


// 1 2 3 4 5 6 7 8
// 1 2 3 4 5 6 7 8
// 1 2 3 4 5 6 7 8
// 1 2 3 4 5 6 7 8
// 1 2 3 4 5 6 7 8
// 1 2 3 4 5 6 7 8
// 1 2 3 4 5 6 7 8
// 1 2 3 4 5 6 7 8