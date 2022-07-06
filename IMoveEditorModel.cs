

using System.Collections.Generic;

namespace PokemonHGSSMoveEditor
{
    public interface IMoveEditorModel
    {
        bool UnsavedChanges { get; }
        bool loadMoveData(string filename);
        bool updateMoveData(int[] moveData, bool[] flags, int moveIndex);
        void storeOldValues(int[] oldValues, bool[] flags);
        (int[], bool[]) getOldValues();
        void setPreviousMoveIndex(int index);
        int getPreviousMoveIndex();
        (int[], bool[]) getMoveData(int index);
        void addNewType(string typeName);
        void addNewMove(string moveName);
        bool writeBinFile(string fileName);
        bool writeToRom(string fileName);
        bool inputMoveDataValid(string text, MoveDataType dataType);
        List<string> getMoveList();
        List<string> getTypeList();
    }
}
