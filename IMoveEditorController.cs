

using System.Collections.Generic;

namespace PokemonHGSSMoveEditor
{
    public interface IMoveEditorController
    {
        
        List<string> getMoveList();
        List<string> getTypeList();
        bool loadMoveData(string fileName);
        void storeOldValues(int[] oldValues, bool[] flags);
        (int[], bool[]) getOldValues();
        void setPreviousMoveIndex(int index);
        int getPreviousMoveIndex();
        bool updateMoveData(int[] moveData, bool[] flags, int moveIndex);
        void addNewType(string typeName);
        void addNewMove(string moveName);
        bool writeToRom(string fileName);
        bool saveToBinFile(string fileName);
        bool getIsUnsavedChanges();

        void showErrorMsg(string errorMsg);
        void showErrorMsg(string errorMsg, string exceptionMsg);
        bool inputMoveDataValid(string text, MoveDataType dataType);
        void setModel(IMoveEditorModel model);
        void setView(IMoveEditorView view);
        (int[], bool[]) getMoveData(int index);
    }
}
