using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_List_Board_Comments
{
    /*
     app   --   DataBase
        (CRUD)

     1.select
     2.insert
     3.update
     4.delete

     create table Board(boardID int...);
     create table comments(commentID int...);

     App : select boardID, title, content, from board;

     객체지향 언어
     객체 맵핑

     class Board {
         private int boardID;
     }

     class comments {
         private int commentID;
     }

    1. CASE_1
        select boardID , title from board where boardID=2;

        Board board = new Board();
        board.BoardID = 데이터

    2. CASE_2
    select boardID , title from board  데이터 건수 150건
    List<Board> boardlist = new ...
    boardlist.add(new Board());
    ....
    ....
    .... 데이터 건수 만큼 돌면 된다(150번)
    boardlist 안에 Board 객체 150개

    */

    class Board
    {

        // title, contents, ... 
        private List<Comment> comments; // wht 활용 측면 // board는 comment를 여러 개 가질 수 있다.
        public void addComment(Comment comment)
        {
            comments.Add(comment); // 댓글 write
        }
    }

    class Comment
    {
        // contents, ...
        private Board board;

        public void setBoard(Board board)
        {
            this.board = board;
            board.addComment(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.addComment(new Comment());
            board.addComment(new Comment());
            board.addComment(new Comment());

        }
    }
}
