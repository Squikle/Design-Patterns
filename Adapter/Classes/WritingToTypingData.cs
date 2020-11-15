using Adapter.Interfaces;

namespace Adapter.Classes
{
    class WritingToTypingData : ITypingData
    {
        private IWriting _pen;

        public WritingToTypingData(IWriting pen)
        {
            _pen = pen;
        }
        public void Type()
        {
            _pen.Write();
        }
    }
}
