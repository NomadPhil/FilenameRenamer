using FileHelpers;

namespace AudioRenamer
{
    [DelimitedRecord(","), IgnoreFirst(1)]
    class AudioMapping
    {
        public string OriginalFileName { get; set; }
        public string NewFileName { get; set; }
    }
}
