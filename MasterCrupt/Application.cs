﻿namespace MasterCrupt
{
    public class Application
    {
        public void Leet(string message, UI ui)
        {
            ui.SetLeeted(Leeter.Leet(message));
        }

        private static void Main(string[] args)
        {
            var ui = new UI();
        }
    }
}