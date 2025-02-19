using System;

namespace ConstraintsOnTypeParameters
{
    class StructArray<T> where T : struct
    {
        public T[] array;
        public StructArray(int size)
        {
            array = new T[size];
        }
    }
    class RefArray<T> where T : class
    {
        public T[] array;
        public RefArray(int size)
        {
            array = new T[size];
        }
    }
    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
    {
        public U[] array { get; set; }
        public BaseArray(int size)
        {
            array = new U[size];
        }
        public void CopyArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(array, 0);
        }
    }
    interface IBase { }
    class IArray<T> where T : IBase
    {
        public T[] array;
        public IArray(int size)
        {
            array = new T[size];
        }
    }
    class DerivedFromIBase : IBase { }
    internal class Program
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }
        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            for (int i = 0; i < a.array.Length; i++)
                a.array[i] = i;
            
            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            for (int i = 0; i < b.array.Length; i++)
                b.array[i] = new StructArray<double>(i + 1);

            BaseArray<Base> c = new BaseArray<Base>(3);    
            c.array[0] = new Base();
            c.array[1] = new Derived();
            c.array[2] = CreateInstance<Derived>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            //d.array[0] = new Base(); // Base는 할당할 수 없음.
            d.array[1] = new Derived();
            d.array[2] = CreateInstance<Derived>();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.array);

            IArray<IBase> f = new IArray<IBase>(3);
            f.array[0] = new DerivedFromIBase();
        }
    }
}
