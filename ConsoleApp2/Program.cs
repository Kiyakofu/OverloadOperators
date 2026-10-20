using static System.Console;
namespace OverloadOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class
            //Point p1 = new Point { X = 10, Y = 10 };
            //WriteLine(p);
            //p++;
            //WriteLine(p);
            //p--;
            //WriteLine(p);

            //Point p2 = new Point { X = 20, Y = 20 };
            //Vector v1 = new Vector(p1, p2);
            //Vector v2 = new Vector { X = 2, Y = 3 };
            //WriteLine($"\tVectors:\n{v1}\n{v2}");
            //WriteLine($"Add:\n {v1 + v2}\n");
            //WriteLine($"Minus:\n {v1 - v2}\n");
            //WriteLine($"Multy:\n {v1 * 10}\n");
            //v1 *= 3;
            //WriteLine($"Multy2: {v1} \n");
            #endregion
            #region#1
            Journal j1 = new Journal("f", 50);
            Journal j2 = new Journal("g", 30);

            WriteLine(j1); WriteLine(j2);

            j1 = j1 + 10;
            j2 = j2 - 10;

            WriteLine(j1); WriteLine(j2);

            WriteLine(j1 > j2);
            WriteLine(j1 == j2);
            WriteLine(j1 != j2);
            #endregion

            #region#2
            WriteLine("...");

            Shop s1 = new Shop("f", 50);
            Shop s2 = new Shop("g", 30);

            WriteLine(s1); WriteLine(s2);

            s1 = s1 + 10;
            s2 = s2 - 10;

            WriteLine(s1); WriteLine(s2);

            WriteLine(s1 > s2);
            WriteLine(s1 == s2);
            WriteLine(s1 != s2);
            #endregion

            #region#4

            #endregion 

        }
    }
}
/*

Оператори які можна перевантажувати
-
!
~
++,--
true,false
+,-,*,/,%
&,|,^,<<,>>
==,!=,<,>,<=,>=
&&,||
[]
()
Оператори які не можна перевантажувати
+=,-=,*=,/=,%=,&=,|=,^=,<<=,>>=
=
.
?:
new
as,is,typeof
->,sizeof,*,&
*/