namespace array
{
    public class DSArray:ICloneable
    {
        private object[] innerarray { get; set; }
        public int Length => innerarray.Length;
        public DSArray(int defualtsize=16)
        {
            innerarray = new object[defualtsize];
        }
        public void SetValue(object value, int index)
        {

            if (!(index >= 0 && index < innerarray.Length))
                throw new ArgumentOutOfRangeException();

            
            if (value == null)

                throw new ArgumentNullException();
            innerarray[index] = value;
            return;



        }
        public object GetValue(int index)
        {
            if (!(index >= 0 && index < innerarray.Length))
                throw new ArgumentOutOfRangeException();

                return innerarray[index];

            
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}