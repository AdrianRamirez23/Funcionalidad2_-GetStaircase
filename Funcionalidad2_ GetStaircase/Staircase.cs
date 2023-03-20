using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad2__GetStaircase
{
    public class Staircase
    {
        public void GetStaircase(string agent, int high)
        {
            switch (agent)
            {
                case "A":
                    rigth(high);
                    break;
                case "B":
                    left(high);
                    break;
                case "C":
                    hexagonal(high);
                    break;
                
            }
        }
        public string ResultMethod(string agent)
        {
            switch (agent)
            {
                case "A":
                    return "Escalera alineada a la derecha";
                    break;
                case "B":
                    return "Escalera alineada a la izquierda";
                    break;
                case "C":
                    return "Escalera hexagonal";
                    break;
                default:
                    return null;
                    break;
            }
        }
        internal void rigth(int high)
        {
            int start = high - 1, finish = 1;
            bool endTask = false;

            while (!endTask)
            {
                string result = string.Empty;
                for (int i = 0; i < start; i++)
                {
                    if (i == 0)
                    {
                        result = "*";
                    }
                    else
                    {
                        result = result + "*";
                    }
                }
                for (int j = 0; j < finish; j++)
                {
                    result = result + "#";
                }
                Console.WriteLine(result.Replace("*", " "));
                start--;
                finish++;
                if (finish > high)
                    endTask = true;
            }
        }
        internal void left(int high) 
        {
            int start = 1;
            bool endTask = false;

            while (!endTask)
            {
                string result = string.Empty;
                for (int i = 0; i < start; i++)
                {
                    if (i == 0)
                    {
                        result = "#";
                    }
                    else
                    {
                        result = result + "#";
                    }
                }
               
                Console.WriteLine(result);
                start++;
                if (start > high)
                    endTask = true;
            }
        }
        internal void hexagonal(int high) 
        {
            int start = high / 2, finish = high;
            bool endTask = false;

            while (!endTask)
            {
                string result = string.Empty;
                for (int i = 0; i < start; i++)
                {
                    if (i == 0)
                    {
                        result = "*";
                    }
                    else
                    {
                        result = result + "*";
                    }
                }
                for (int j = 0; j < finish; j++)
                {
                    result = result + "#";
                }
                Console.WriteLine(result.Replace("*", " "));
                start--;
                finish = finish + 2;
                if (finish > high*2)
                    endTask = true;
            }
            endTask= false;
            finish = finish-3;
            start = 1;
            while (!endTask)
            {
                string result = string.Empty;
                for (int i = 0; i < start; i++)
                {
                    if (i == 0)
                    {
                        result = "*";
                    }
                    else
                    {
                        result = result + "*";
                    }
                }
                for (int j = 0; j < finish; j++)
                {
                    result = result + "#";
                }
                Console.WriteLine(result.Replace("*", " "));
                start++;
                finish = finish - 2;
                if (finish < high)
                    endTask = true;
            }
        }
    }
}
