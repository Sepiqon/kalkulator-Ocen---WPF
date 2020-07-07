using System;
using System.Collections.Generic;

namespace Database.AllLangs
{
    [Serializable]
    public class Lists
    {
        public static List<string> ListOcenStringList = ListOcenString();
        public static List<string> ListOcenString()
        {
            List<string> tmpstring = new List<string>() { "+", "-" };
            List<int> tmpint = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<string> tmplist = new List<string>();
            foreach (int item in tmpint)
            {
                List<string> templistitem = new List<string>();
                if (item == 1 || item == 6)
                {
                    if (item == 1)
                    {
                        templistitem.Add(item.ToString());
                        templistitem.Add(item.ToString() + tmpstring[0]);
                    }
                    if (item == 6)
                    {
                        templistitem.Add(item.ToString() + tmpstring[1]);
                        templistitem.Add(item.ToString());
                    }
                }
                else
                {
                    templistitem.Add(item.ToString() + tmpstring[1]);
                    templistitem.Add(item.ToString());
                    templistitem.Add(item.ToString() + tmpstring[0]);
                }
                foreach (string item2 in templistitem)
                {
                    tmplist.Add(item2);
                }
            }

            return tmplist;
        }
        public static List<int> ListaWag()
        {
            List<int> tmp = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                tmp.Add(i);
            }
            return tmp;

        }
    }
}
