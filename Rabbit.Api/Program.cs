namespace API
{
    /// <summary>
    /// Classe de inicializa��o do projeto
    /// </summary>
    public class Program
    {
        /// <summary>
        /// M�todo de inicializa��o do projeto
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// M�todo para cria��o do host da web
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}