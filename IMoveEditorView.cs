
using System.Collections.Generic;


namespace PokemonHGSSMoveEditor
{
    public interface IMoveEditorView
    {
        void displayError(string errorMsg);
        void displayError(string errorMsg, string exceptionMsg);
    }
}
