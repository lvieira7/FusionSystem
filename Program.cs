namespace FusionSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }

        // Configuração padrão dos formulários
        public static void Default(Form form)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(
                width: 1030
                , height: 600
                );
        }
    }
}