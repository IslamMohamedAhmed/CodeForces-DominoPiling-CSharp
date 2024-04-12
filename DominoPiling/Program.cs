using static System.Console;
using static System.Convert;
using static System.Math;



int m, n;

string str = ReadLine();

var arr = str.Split(" ");
m = ToInt32(arr[0]);
n = ToInt32(arr[1]);

WriteLine(m * n / 2);
