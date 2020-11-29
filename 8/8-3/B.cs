namespace lab8_3
{
    public class B
    {
        private int[] arr = new int[]{12, 544 ,234};

        public int Length
        {
            get
            {
                return arr.Length;
            }
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }


    }
}