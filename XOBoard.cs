using System;
using System.Collections.Generic;

public class XOBoard {

  // empty is zero
  // x is one
  // o is two
  // example: [0][0][1] board left top cornor is on x
  int[][][] board;
  int size = 3; //size need to be minimum 3

  public XOBoard(int[][][] board, int size) {
    this.board = board;
    this.size = size;
  }

  private void BoardInit() {
    for (int i = 0; i < size; i++) {
      for (int j = 0; j < size; j++) {
        this.board[i][j][0] = 0;
      }
    }

  }

  public static void Main() {

  }

  public void Put(int positionX, int positionY, int sign) {
    if (board[positionX][positionY][0] != 0) {
      board[positionX][positionY][0] = sign;
    }
  }

  private String Status() {
    int counter = 0; //to know if draw or none

    //for draw
    for (int i = 0; i < size; i++) {
      for (int j = 0; j < size; j++) {
        if (this.board[i][j][0] != 0) //count moves
          counter++;
      }
    }
    if (counter == (size * size))
      return "draw";

    //for x or o win
    for (int i = 0; i < size - 2; i++) {
      for (int j = 0; j < size - 2; j++) {

        //x win
        if (this.board[i][j][0] == 1 && this.board[i + 1][j][0] == 1 && this.board[i + 2][j][0] == 1)
          return "x";
        else
        if (this.board[i][j][0] == 1 && this.board[i][j + 1][0] == 1 && this.board[i][j + 2][0] == 1)
          return "x";
        else
        if (this.board[i][j][0] == 1 && this.board[i + 1][j + 1][0] == 1 && this.board[i + 2][j + 2][0] == 1)
          return "x";

        else //o win

          if (this.board[i][j][0] == 2 && this.board[i + 1][j][0] == 2 && this.board[i + 2][j][0] == 2)
            return "o";
          else
        if (this.board[i][j][0] == 2 && this.board[i][j + 1][0] == 2 && this.board[i][j + 2][0] == 2)
          return "o";
        else
        if (this.board[i][j][0] == 2 && this.board[i + 1][j + 1][0] == 2 && this.board[i + 2][j + 2][0] == 2)
          return "o";

      }
    }

    return "none"; //a draw for default

  }
  public void Display() {
    for (int i = 0; i < size - 2; i++) {
      for (int j = 0; j < size - 2; j++) {
        switch (this.board[i][j][0]) {
        case 1:
          Console.WriteLine("x");
          break;
        case 2:
          Console.WriteLine("o");
          break;
        default:
          Console.WriteLine("_");
          break;
        }
      }
      Console.WriteLine(); // for a new line

    }

  }
}
