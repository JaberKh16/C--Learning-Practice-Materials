/*
    String In C#
    ============
    In C#, String can be used in two forms-
        1. Via Aliasing => string
        2. Via Class => String

    Properties & Methdos In String Class
    ------------------------------------
    String Class provides some properties and methods to work with which are the following -
    
    1. String Properies:
        a. String.Empty
        b. String.Length
    
    2. String Methods:

        a. String.Clone()
        b. String.Compare()
        c. String.Concat()
        d. String.Contains()
        e. String.Copy()
        f. String.CopyTo()
        g. String.StartsWith()
        h. String.EndsWith()
        i. String.Equals()
        j. String.Format()
        k. String.GetHashCode()
        l. String.GetType()
        m. String.GetTypeCode()
        n. String.IndexOf()
        o. String.Insert(),
        p. String.IsNullOrEmpty()
        q. String.Join()
        r. String.LastIndexOf()
        s. String.Remove()
        t. String.Replace()
        u. String.Split()
        v. String.SubString()
        w. String.ToString()
        x. String.ToCharArray()
        y. String.Trim()
        z. String.TryCopyTo()

        
*/
using System;


// Program-1: Defining Single String
string path1 = "C:\\program\\Document";
string path2 = @"C:\program\Document"; // declaring a verbatim string

Console.WriteLine($"{path1}");
Console.WriteLine($"{path2}");


// Program-2: Concatenate With String Interpolation and String Format
string s1 = "A new string";
const string s2 = "is something to talk about";
string s3 = $"{s1} {s2} in any language"; // concate through string interpolation
string s4 = String.Format("{0} {1}", s1, s2); // concate through string format

Console.WriteLine(s3);
Console.WriteLine(s4);


// Program-3: Check If Two Strings Reference is equal
string a = "hello";
string b = "h";
// Append to contents of 'b'
b += "ello";

Console.WriteLine(a == b); // Returns True - Value check
Console.WriteLine(object.ReferenceEquals(a, b)); // Returns False - Reference check


