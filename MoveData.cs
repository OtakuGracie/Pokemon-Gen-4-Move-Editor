using System.Collections.Generic;


namespace PokemonHGSSMoveEditor
{
    public partial class MoveEditorModel : IMoveEditorModel
    {
        List<string> moveList = new List<string>(Constants.DEFAULTNUMMOVES);
        List<string> typeList = new List<string>(Constants.DEFAULTNUMTYPES);
        List<byte[]> moveData = new List<byte[]>(Constants.DEFAULTNUMMOVES);
        byte[] trailingBytes = new byte[Constants.HGSSMOVEDATAOFFSET - Constants.HGSSMOVEFILEOFFSET]; //stores bytes between the start of the file containing move data and the start of move data
        byte[] oldValues = new byte[Constants.NUMMOVEDATABYTES];
        int previousMoveIndex;
        private bool unsavedChanges = false;
        public bool UnsavedChanges { get => unsavedChanges; }

        public bool updateMoveData(int[] moveData, bool[] flags, int moveIndex)
        {
            byte[] byteMoveData = convertMoveDataToBytes(moveData, flags);
            
            //check if the passed move data has changed from what was previously stored
            for (int i = 0; i < Constants.NUMMOVEDATABYTES; i++)
            {
                if (byteMoveData[i] != this.moveData[moveIndex][i])
                {
                    this.moveData[moveIndex] = byteMoveData;
                    unsavedChanges = true;
                    return true;
                }
            }

            return false;
        }
        

        public int getNumMoves()
        {
            return moveList.Count;
        }

        public (int[], bool[]) getMoveData(int moveIndex)
        {
            int[] moveData;
            bool[] flags;

            if (this.moveData != null)
            {
                (moveData, flags) = convertMoveDataToIntAndBool(this.moveData[moveIndex]);

                return (moveData, flags);
            }
            else
            {
                return (null, null);
            }
        }

        public List<string> getMoveList()
        {
            if (moveList.Count == 0)
            {
                List<string> results = readListFile(Constants.MOVELISTFILENAME);

                if (results != null)
                {
                    moveList = results;
                    
                }
                else
                {
                    return null;
                }
            }

            return moveList;
        }

        public List<string> getTypeList()
        {
            List<string> results = readListFile(Constants.TYPELISTFILENAME);

            if (typeList.Count == 0)
            {
                if (results != null)
                {
                    typeList = results;
                }
                else
                {
                    return null;
                }
            }
            
            return typeList;
        }

        public bool loadMoveData(string filename)
        {
            List<byte[]> fileData;

            fileData = readBinFile(filename);

            if (fileData == null)
            {
                return false;
            }

            trailingBytes = fileData[0];

            if (moveData.Count > 0)
            {
                moveData.Clear();
            }

            //subtract one from fileData count to account for the first byte array containing the trailing bytes
            for (int i = 1; i < fileData.Count - 1; i++)
            {
                moveData.Add(fileData[i]);
            }

            unsavedChanges = false;

            return true;
        }

        public void storeOldValues(int[] oldValues, bool[] flags)
        {
            this.oldValues = convertMoveDataToBytes(oldValues, flags);
        }

        public (int[], bool[]) getOldValues()
        {
            (int[] oldValues, bool[] flags) = convertMoveDataToIntAndBool(this.oldValues);

            return (oldValues, flags);
        }

        public void setPreviousMoveIndex(int index)
        {
            previousMoveIndex = index;
        }

        public int getPreviousMoveIndex()
        {
            return previousMoveIndex;
        }

        public void addNewType(string typeName)
        {
            typeList.Add(typeName);
            appendListFile(Constants.TYPELISTFILENAME, typeName);
        }

        public void addNewMove(string moveName)
        {
            moveList.Add(moveName);
            appendListFile(Constants.MOVELISTFILENAME, moveName);
            moveData.Add(new byte[Constants.NUMMOVEDATABYTES]);
            unsavedChanges = true;
        }

        //takes passed int array and bool array of move data and converts them to a byte array matching move data structure in the games to be stored
        public byte[] convertMoveDataToBytes(int[] moveData, bool[] flags)
        {
            
            moveData[Constants.FLAGSINDEX] = ArrayConverter.BoolToIndByte(flags);

            moveData[Constants.EFFECTEXTINDEX] = moveData[Constants.EFFECTINDEX] / (byte.MaxValue + 1);
            moveData[Constants.EFFECTINDEX] %= (byte.MaxValue + 1);

            moveData[Constants.TARGETEXTINDEX] = moveData[Constants.TARGETINDEX] / (byte.MaxValue + 1);
            moveData[Constants.TARGETINDEX] %= (byte.MaxValue + 1);

            return ArrayConverter.IntToByte(moveData);
        }

        //takes passed byte array matching move data structure in games and converts it to an int and bool array for displaying data from
        public (int[], bool[]) convertMoveDataToIntAndBool(byte[] byteMoveData)
        {
            int[] intMoveData = ArrayConverter.ByteToInt(byteMoveData);
            bool[] flags = ArrayConverter.IndByteToBool(byteMoveData[Constants.FLAGSINDEX]);

            intMoveData[Constants.EFFECTINDEX] = byteMoveData[Constants.EFFECTEXTINDEX] * (byte.MaxValue + 1) + byteMoveData[Constants.EFFECTINDEX];
            intMoveData[Constants.TARGETINDEX] = byteMoveData[Constants.TARGETEXTINDEX] * (byte.MaxValue + 1) + byteMoveData[Constants.TARGETINDEX];

            return (intMoveData, flags);
        }

        //checks if move data input by the user is valid and returns true if it is
        public bool inputMoveDataValid(string text, MoveDataType dataType)
        {
            int data;

            if (int.TryParse(text, out data))
            {
                switch(dataType)
                {
                    case MoveDataType.EFFECT:
                        return (data <= Constants.MAXEFFECTVALUE);
                    case MoveDataType.POWER:
                        return (data <= byte.MaxValue);
                    case MoveDataType.ACCURACY:
                    case MoveDataType.EFFECTCHANCE:
                        return (data <= 100);
                    case MoveDataType.PP:
                        return true;
                    case MoveDataType.PRIORITY:
                        return (System.Math.Abs(data) <= Constants.MAXPRIORITY);
                    case MoveDataType.CONTESTEFFECT:
                        return (data <= Constants.MAXCONTESTEFFECT && data >= Constants.MINCONTESTEFFECT);
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }


    }
}
