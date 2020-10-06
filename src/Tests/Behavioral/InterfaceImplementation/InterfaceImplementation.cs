using fmt = go.fmt_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        public partial interface Animal
        {
            @string Type();
            @string Swim();
        }

        public partial struct Dog
        {
            public @string Name;
            public @string Breed;
        }

        public partial struct Frog
        {
            public @string Name;
            public @string Color;
        }

        private static void Main()
        {
            ptr<Frog> f = @new<Frog>();
            ptr<Dog> d = @new<Dog>();
            ref array<Animal> zoo = ref heap(new array<Animal>(new Animal[] { Animal.As(f), Animal.As(d) }), out ptr<array<Animal>> _addr_zoo);

            Animal a = Animal.As(null);
            fmt.Printf("%T\n", a);

            {
                Animal a__prev1 = a;

                foreach (var (_, __a) in zoo)
                {
                    a = __a;
                    fmt.Println(a.Type(), "can", a.Swim());
                } // Redclared post comment

                a = a__prev1;
            }

            fmt.Printf("%T\n", a);

            ShowZoo(_addr_zoo); 

            // Post function comment
            fmt.Printf("%T\n", a); 

            // vowels[ch] is true if ch is a vowel
            array<bool> vowels = new array<bool>(InitKeyedValues<bool>(128, ('a', true), ('e', true), ('i', true), ('o', true), ('u', true), ('y', true)));
            fmt.Println(vowels);
        }

        public static void ShowZoo(ptr<array<Animal>> _addr_zoo)
        {
            ref array<Animal> zoo = ref _addr_zoo.val;

            Animal a = Animal.As(null);

            foreach (var (_, __a) in zoo)
            {
                a = __a;
                fmt.Println(a.Type(), "can", a.Swim());
            }

        }

        private static @string Type(this ptr<Frog> f)
        {
            return "Frog";
        }

        private static @string Swim(this ptr<Frog> f)
        {
            return "Kick";
        }

        private static @string Swim(this ptr<Dog> d)
        {
            return "Paddle";
        }

        private static @string Type(this ptr<Dog> d)
        {
            return "Doggie";
        }
    }
}
