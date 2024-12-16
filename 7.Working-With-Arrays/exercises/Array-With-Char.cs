using System;


string messgae = "Something is very fissy!" + "Need to do something...";

char [] charArr  = messgae.ToCharArray();
Array.Reverse(charArr);

foreach (char c in charArr){
    Console.WriteLine(c);
}