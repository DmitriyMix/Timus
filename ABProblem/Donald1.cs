﻿using Antlr.Runtime.Misc;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Donald1
{
    class Program
    {
       
        static void Main()
        {
            int pos = 1;
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();


            Dictionary<string, int> box1 = new Dictionary<string, int>
            {
                { "Alice", 1},
                {"Ariel", 1 },
                {"Aurora", 1 },
                {"Phil", 1 },
                {"Peter", 1 },
                {"Olaf", 1 },
                {"Phoebus", 1 },
                {"Ralph", 1 },
                {"Robin", 1 },

                { "Bambi", 2 },
                {  "Belle", 2 },
                {  "Bolt", 2 },
                {  "Mulan", 2 },
                {  "Mowgli", 2 },
                {  "Mickey", 2 },
                {  "Silver", 2 },
                {  "Simba", 2 },
                {  "Stitch", 2 },

                {  "Dumbo", 3 },
                {  "Genie", 3 },
                {  "Jiminy", 3 },
                {  "Kuzko", 3 },
                { "Kida", 3 },
                { "Kenai", 3 },
                {  "Tarzan", 3 },
                {  "Tiana", 3 },
                {  "Winnie", 3 }
        };
            var s = "Winnie";
            var boxNumber = box1[s];
            for (int i = 0; i < n; i++)
            {
              
            }
        }
    }
}




