namespace API.Core.Swagger
{
    /// <summary>
    /// Classe para definir a versão da API
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class CustomApiVersionAttribute : Attribute
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="version"></param>
        public CustomApiVersionAttribute(string version)
        {
            Version = version;
        }

        /// <summary>
        /// Versão da classe
        /// </summary>
        public string Version { get; }
    }
}
