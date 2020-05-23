using System;
using System.Collections.Generic;
using System.Text;

namespace _06_NullOperators
{
    class MyClass
    {
        #region ?? null-coalescing operator
        void Test(int? a, int? b)
        {
            int c;

            //if (a != null)
            //    c = (int)a;
            //else 
            //    c = 0;

            //c = (a != null) ? (int)a : 0;

            c = a ?? 0;
            c = a ?? b ?? -1;
            
            Console.WriteLine(c);
        }
        #endregion

        #region C# 8.0  ??= null-coalescing assignment operator
        void Test(List<int> scores, int? a, string b)
        {
            a = a ?? 0;
            a ??= 0;

            (scores ??= new List<int>()).Add(1);
            scores.Add(a ??= 0);
        }
        #endregion

        #region ?. ?[] null-conditional operator
        public event EventHandler<int> Completed;
        void Test(List<int> scores)
        {
            Completed?.Invoke(this, 100);

            var x = scores?[0];
            int? size;
            size = scores == null ? null : (int?)scores.Count;

            size = scores?.Count;
            int siz = scores?.Count ?? 0;

            scores?.Sort();

            Item parent = new Item();
            var p = parent?.Child?.Child?.Child;
        }

        class Item
        {
            public Item Child { get; set; }
        }
        #endregion
    }
}
