#region part1

    #region 1

//using System;

//class book
//{
//    private string title;
//    private double price;

//    public string titleproperty
//    {
//        get { return title; }
//        set
//        {
//            if (value.Length <= 30)
//            {
//                title = value;
//            }
//        }
//    }

//    public double priceproperty
//    {
//        get { return price; }
//        set
//        {
//            if (value >= 10)
//            {
//                price = value;
//            }
//        }
//    }
//}

//class program
//{
//    static void Main()
//    {
//        book b1 = new book();
//        b1.titleproperty = "book one";
//        b1.priceproperty = 15;

//        book b2 = new book();
//        b2.titleproperty = "book two";
//        b2.priceproperty = 20;

//        Console.WriteLine(b1.titleproperty + " " + b1.priceproperty);
//        Console.WriteLine(b2.titleproperty + " " + b2.priceproperty);
//    }
//}

    #endregion

    #region 2

//using System;

//class book
//{
//    public string title { get; set; }
//    public double price { get; set; }

//    public book(string t, double p)
//    {
//        title = t;
//        price = p;
//    }

//    public override string ToString()
//    {
//        return title + " " + price;
//    }
//}

//class program
//{
//    static void Main()
//    {
//        book b = new book("book one", 15);
//        Console.WriteLine(b);
//    }
//}

    #endregion

    #region 3

//using System;

//enum courselevel
//{
//    beginner,
//    intermediate,
//    advanced
//}

//class course
//{
//    public string code { get; set; }
//    public string title { get; set; }
//    public courselevel level { get; set; }
//}

//class program
//{
//    static void Main()
//    {
//        course c = new course();
//        c.code = "101";
//        c.title = "programming";
//        c.level = courselevel.beginner;

//        Console.WriteLine(c.code + " " + c.title + " " + c.level);
//    }
//}

    #endregion

#endregion

#region part2

    #region 4

//using System;

//class product
//{
//    public int id { get; set; }
//    public string name { get; set; }
//    public double price { get; set; }

//    public product(int id, string name, double price)
//    {
//        this.id = id;
//        this.name = name;
//        this.price = price;
//    }

//    public product(int id, string name) : this(id, name, 0)
//    {
//    }

//    public product(int id) : this(id, "unknown", 0)
//    {
//    }

//    public override string ToString()
//    {
//        return id + " " + name + " " + price;
//    }
//}

//class program
//{
//    static void Main()
//    {
//        product p1 = new product(1, "phone", 500);
//        product p2 = new product(2, "laptop");
//        product p3 = new product(3);

//        Console.WriteLine(p1);
//        Console.WriteLine(p2);
//        Console.WriteLine(p3);
//    }
//}

    #endregion

    #region 5

//using System;

//class playlist
//{
//    private string name;
//    private string[] songs;

//    public playlist(string name, int maxsongs)
//    {
//        this.name = name;
//        songs = new string[maxsongs];
//    }
//}

//class program
//{
//    static void Main()
//    {
//        playlist p = new playlist("favs", 5);
//    }
//}

    #endregion

    #region 6

//using System;

//class playlist
//{
//    private string name;
//    private string[] songs;

//    public playlist(string name, int maxsongs)
//    {
//        this.name = name;
//        songs = new string[maxsongs];
//    }

//    public string this[int index]
//    {
//        get
//        {
//            if (index < 0 || index >= songs.Length)
//            {
//                throw new IndexOutOfRangeException("invalid position");
//            }
//            return songs[index];
//        }
//        set
//        {
//            if (index < 0 || index >= songs.Length)
//            {
//                throw new IndexOutOfRangeException("invalid position");
//            }
//            songs[index] = value;
//        }
//    }
//}

//class program
//{
//    static void Main()
//    {
//        playlist p = new playlist("favs", 2);
//        p[0] = "song 1";
//        p[1] = "song 2";

//        Console.WriteLine(p[0]);

//        try
//        {
//            p[5] = "song 3";
//        }
//        catch (IndexOutOfRangeException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}

    #endregion

#endregion

#region part3

    #region 7

//using System;

//struct size
//{
//    public int width;
//    public int height;

//    public size(int w, int h)
//    {
//        width = w;
//        height = h;
//    }

//    public override string ToString()
//    {
//        return width + " x " + height;
//    }
//}

//class program
//{
//    static void Main()
//    {
//        size s1 = new size(5, 10);
//        size s2 = s1;
//        s1.width = 20;

//        Console.WriteLine(s1);
//        Console.WriteLine(s2);
//    }
//}

    #endregion

    #region 8

//using System;

//enum orderstatus
//{
//    newval = 1,
//    preparing = 2,
//    delivered = 3
//}

//class program
//{
//    static void Main()
//    {
//        orderstatus status = orderstatus.preparing;
//        Console.WriteLine(status);

//        orderstatus converted = (orderstatus)2;
//        Console.WriteLine(converted);
//    }
//}

    #endregion

    #region 9
//using System;

//interface iplayable
//{
//    void play();
//}

//class song : iplayable
//{
//    public string title { get; set; }

//    public void play()
//    {
//        Console.WriteLine(title);
//    }
//}

//class program
//{
//    static void Main()
//    {
//        song s = new song();
//        s.title = "my song";
//        s.play();
//    }
//}

    #endregion

#endregion

#region part4

    #region 10

using System;

class device
{
    private string privatefield = "private";
    internal string internalfield = "internal";
    public string publicfield = "public";

    public class otherclasssameproject
    {
        public void test()
        {
            device d = new device();
        }
    }
}

class program
{
    static void Main()
    {
        device d = new device();
    }
}

    #endregion

#endregion
