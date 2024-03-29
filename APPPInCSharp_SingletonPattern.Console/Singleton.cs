﻿namespace APPPInCSharp_SingletonPattern.Console
{
    public class Singleton
    {
        private static Singleton theInstance = null;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (theInstance == null)
                {
                    theInstance = new Singleton();
                }
                return theInstance;
            }
        }
    }
}