﻿using Habilitations.controleur;
using System;
using System.Windows.Forms;

namespace Habilitations
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _ = new Controle();
        }
    }
}
