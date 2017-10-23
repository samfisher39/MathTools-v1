using System;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using NCalc;

namespace MathTools_v1
{
    public class Matrixx
    {
        public int DimI { get; set; }
        public int DimJ { get; set; }
        public double[,] Data { get; set; }

        public Matrixx()
        {
            Data = new double[1,1];
        }
        public Matrixx(double[,] data)
        {
            this.DimI = data.GetLength(0);
            this.DimJ = data.GetLength(1);
            this.Data = data;
        }
        public Matrixx(int i, int j)
        {
            this.DimI = i;
            this.DimJ = j;
            this.Data = new double[i, j];
        }

        public void Assign(int i, int j, float v)
        {
            this[i, j] = v;
        }

        public double this[int i, int j]
        {
            get { return Data[i, j]; }
            set { Data[i, j] = value; }
        }

        public string GetAllValues()
        {
            string r = String.Empty;
            for (int i = 0; i < this.DimI; i++)
            {
                for (int j = 0; j < DimJ; j++)
                {
                    r += (j == DimJ -1) ? this[i, j].ToString() : (this[i, j].ToString() + " ");
                }
                r += Environment.NewLine;
            }
            return r;
        }
    }
}
