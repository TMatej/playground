namespace LanguageBasicsExercises.Exercises;

internal class Polymorphism
{
    private interface I
    {
        void F1();
        void F2();
    }

    private class A : I
    {
        public virtual void F1()
        {
            Console.WriteLine("{A:F1}");
        }

        public virtual void F2()
        {
            Console.WriteLine("{A:F2}");
        }
    }

    private class B : A
    {
        public override void F1()
        {
            Console.WriteLine("{B:F1}");
        }

        public new void F2()
        {
            Console.WriteLine("{B:F2}");
        }
    }

    private class C : A, I
    {
        public override void F1()
        {
            Console.WriteLine("{C:F1}");
        }

        public new void F2()
        {
            Console.WriteLine("{C:F2}");
        }
    }

    internal void Run()
    {
        Console.WriteLine("A a1 = new B()");
        A a1 = new B();
        a1.F1();    //
        a1.F2();    //

        Console.WriteLine("I i1 = a1");
        I i1 = a1;
        i1.F1();    // 
        i1.F2();    //

        Console.WriteLine("A a2 = new C()");
        A a2 = new C();
        a2.F1();    // 
        a2.F2();    // 

        Console.WriteLine("I i2 = a2");
        I i2 = a2;
        i2.F1();    // 
        i2.F2();    // 

        Console.WriteLine("B b1 = a1 as B");
        B b1 = a1 as B;
        b1.F1();    // 
        b1.F2();    // 

        Console.WriteLine("I i3 = b2");
        B b2 = new B();
        I i3 = b2;
        i3.F1();    // 
        i3.F2();    //

        A a3 = new A();
        B b3 = a3 as B;
        b3.F1();    //
    }
}
