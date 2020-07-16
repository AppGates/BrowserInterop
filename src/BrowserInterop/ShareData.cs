namespace BrowserInterop
{
    /// <summary>
    /// An object containing data to share. At least one of the fields must be specified.
    /// </summary>
    public class ShareData
    {
        /// <summary>
        ///  the title to be shared.
        /// </summary>
        /// <value></value>
        public string Title { get; set; }

        /// <summary>
        ///  text to be shared.
        /// </summary>
        /// <value></value>
        public string Text { get; set; }

        /// <summary>
        /// URL to be shared.
        /// </summary>
        /// <value></value>
#pragma warning disable CA1056 // Les propri�t�s Uri ne doivent pas �tre des cha�nes
        public string Url { get; set; }
#pragma warning restore CA1056 // Les propri�t�s Uri ne doivent pas �tre des cha�nes
    }
}