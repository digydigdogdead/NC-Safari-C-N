﻿namespace NC_Safari
{
    internal class Program
    {
        public static void Main()
        {
            Tiger fluffy = new Tiger(80);
            Penguin penny = new Penguin(20.4f);
            Goose jeff = new Goose(3);
            Bat betty = new Bat(0.7f);

            Sky sky = new Sky();
            sky.AddAnimalInEnvironment(betty);
            sky.AddAnimalInEnvironment(jeff);

            sky.CheckAnimalsInEnvironment();
        }
    }
}
