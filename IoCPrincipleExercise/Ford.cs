﻿namespace IoCPrincipleExercise
{
    internal class Ford : ICar
    {
        private int _miles = 0;
        public int Run()
        {
            return ++_miles;
        }
    }
}
