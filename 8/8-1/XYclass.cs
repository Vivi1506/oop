using System;

namespace lab8
{
    public class XYclass
    {
        private int x;
        private int y;
        private int[] array;

        public XYclass(int x, int y)
        {
            this.x = x;
            this.y = y;
            array = new int[2] {this.x, this.y};
        }
        public int this[int index]
        {
            get
            {
                try
                {
                    return array[index];
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid index");
                    throw;
                }
               


            }
            set
            {
                try
                {
                    array[index] = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid index");
                    throw;
                }
            }
        }
    }
}