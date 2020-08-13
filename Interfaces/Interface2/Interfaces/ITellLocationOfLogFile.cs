namespace Interfaces
{
    /// <summary>
    /// Vertel waar de log file staat.
    /// </summary>
    public interface ITellLocationOfLogFile
    {
        /// <summary>
        /// Deze method vertelt waar de location van de log file staat.
        /// </summary>
        /// <returns>Locatie van de log file.</returns>
        string LocationOfLogFile();
    }
}
