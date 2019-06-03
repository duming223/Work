using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node x = new Node();
            //Node y = new Node();
            //Node z = new Node();

            //Box box = new Box();

            ////case-1: box.Fisrt == x;
            //box.Add(x);
            ////Console.WriteLine(box.Last == x);

            //box.Add(y);
            ////Console.WriteLine(box.Last == y);

            //box.Add(z);
            ////case-2: box.Last == z;
            //Console.WriteLine(box.Last == z);


            //Beauty beauty = new Beauty();


            Article ate = new Article();              //文章
            ate.Author = "xr->";
            ate.Tite = $"{ate.Author}发布了一篇文章 ";
            ate.Body = "文章内容..............";
            ate.Agree = 0;
            ate.Disagree = 0;

            Comment cmt = new Comment();   //评论
            cmt.Author = "xxx";
            cmt.Tite = $"来自{cmt.Author}的评论：";
            cmt.Body = "评论内容..............";
            cmt.Agree = 0;
            cmt.Disagree = 0;

            Suggest sgt = new Suggest();          //意见
            sgt.Author = "xxx";
            sgt.Tite = $"这是一条来自{sgt.Author}的建议： ";
            sgt.Body = "意见内容..............";
            sgt.Agree = 0;
            sgt.Disagree = 0;

            Problem pbm = new Problem();       //求助
            pbm.Author = "xxx";
            pbm.Tite = $"这是一条来自{sgt.Author}的求助： ";
            pbm.Body = "求助内容..............";

            Student xr = new Student();
            var canwork = xr.CanWork;
            Console.WriteLine(canwork );
           xr
            //ate.Publish();      //发布一篇文章
            // cmt.Publish();  //发一条评论
            //sgt.Publish();   //提一个建议
            //pbm.Publish();//发布一个求助

        }
    }

    class Node
    {
        public Node Head { get; set; }
        public Node Next { get; set; }
        public Node Last { get; set; }
        public Node PugeUp { get; set; }

        public int Id { get; set; }
    }

    class Box
    {
        public Node Head { get; set; }
        public Node Next { get; set; }
        public Node Last { get; set; }
        public Node PugeUp { get; set; }


        internal void Add(Node node)
        {
            if (Last == null)
            {
                Head = node;
            }
            else
            {
                Last.Next = node;
            }
            Last = node;

        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////

    class Beauty
    {
        private static readonly bool famale = true;
        static bool Famale { get; }
        private int _age = 22;
        private bool _marryde = false;
        int height { get; set; }
        string name { get; }
    }



    //class Doublelinkde<T>
    //{

    //    public Doublelinkde<T> Previous;
    //    public Doublelinkde<T> Nxet;
    //    private T Content;

    //}
    class User : Article
    {

    }

    class Article
    {
        public string Author { get; set; } //名字
        public string Tite { get; set; }      //标题
        public string Body { get; set; }    //正文
        public int Agree { get; set; }        //点赞  
        public int Disagree { get; set; }       //踩

        public void Publish()  //发布
        {
            Console.WriteLine(Tite);
            //Console.WriteLine("-----------------------------------------------------------------");
            //Console.WriteLine(Author);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(Body);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("赞" + Agree); Console.WriteLine("踩" + Disagree);
        }
    }

    class Comment : Article//评论
    {

    }
    class Suggest : Article//意见    
    {

    }
    class Problem : Article//求助
    {

    }
    class Student
    {
      public readonly int age=12;
        readonly int abc;
       public  bool CanWork
        {
            
            get
            {
                if (age >= 16)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}


