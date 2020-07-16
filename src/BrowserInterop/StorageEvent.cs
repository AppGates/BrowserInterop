using BrowserInterop.Storage;

namespace BrowserInterop
{
    public class StorageEvent
    {
        public string Key { get; set; }
        public string NewValue { get; set; }
        public string OldValue { get; set; }
#pragma warning disable CA1056 // Les propri�t�s Uri ne doivent pas �tre des cha�nes
        public string Url { get; set; }
#pragma warning restore CA1056 // Les propri�t�s Uri ne doivent pas �tre des cha�nes
        public WindowStorage Storage { get; set; }
    }
}