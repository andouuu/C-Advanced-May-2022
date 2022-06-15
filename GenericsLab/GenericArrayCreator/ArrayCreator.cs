namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] array = new T[length];
            for (var index = 0; index < array.Length; index++)
            {
                array[index] = item;
            }
            return array;
        }
    }
}