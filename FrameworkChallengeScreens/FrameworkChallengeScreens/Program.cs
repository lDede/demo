using System;
using System.Windows.Forms;

namespace FrameworkChallengeScreens.View
{
    static class Program
    {
        /* Portuguese (PT-BR)
         * Autor: André de Sousa Valentim
         * Data: 01/07/2020
         * 
         * Código de Honra (Retirado da Internet)
         * "Como realizar uma requisição HTTP WEB REQUEST através de GET"
         * https://stackoverflow.com/questions/44775645/how-to-get-data-from-json-api-with-c-sharp-using-httpwebrequest
         * - Presente em FrameworkChallengeScreens.Model.GetMethodConnectionRequest
         * 
         * English
         * Author: André de Sousa Valentim
         * Date: 01/07/2020
         * 
         * Honor Code (Get from Internet)
         * "Como realizar uma requisição HTTP WEB REQUEST através de GET"
         * https://stackoverflow.com/questions/44775645/how-to-get-data-from-json-api-with-c-sharp-using-httpwebrequest
         * - Found in FrameworkChallengeScreens.Model.GetMethodConnectionRequest
         */

        /// <summary>
        /// Main start point for application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainMenu());
        }
    }
}