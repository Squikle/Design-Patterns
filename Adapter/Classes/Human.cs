using Adapter.Interfaces;

namespace Adapter.Classes
{
    class Human
    {
        public void InputData(ITypingData typingData)
        {
            typingData.Type();
        }
    }
}
