

namespace PokemonHGSSMoveEditor
{
    public static class Constants
    {
        public const string MOVELISTFILENAME = "moves.txt";
        public const string TYPELISTFILENAME = "types.txt";

        public const int HGSSMOVEDATAOFFSET = 33153788; //0x01F9E2FC
        public const int DPMOVEDATAOFFSET = 30861564; //0x01D6E8FC
        public const int PLMOVEDATAOFFSET = 99729660; //0x05F1C0FC
        public const int HGSSMOVEFILEOFFSET = 33149952; //0x01F9D400
        public const int DPMOVEFILEOFFSET = 30857728; //0x01D6DA00
        public const int PLMOVEFILEOFFSET = 99725824;  //0x05F1B200

        public const int HEADERSIZE = 10;
        public const int NUMMOVEDATABYTES = 16;

        public const int MOVENUMVALUES = 14;

        public const int DEFAULTNUMMOVES = 470;
        public const int DEFAULTNUMTYPES = 18;

        public const int MAXPERCENTAGE = 100;
        public const int MINFLAGVALUE = 0;
        public const int MAXPRIORITY = 127;
        public const int NUMFLAGS = 8;

        public const int MINCONTESTEFFECT = 1;
        public const int MAXCONTESTEFFECT = 22;
        public const int MAXEFFECTVALUE = 510;

        public const int EFFECTINDEX = 0;
        public const int EFFECTEXTINDEX = 1;
        public const int CATEGORYINDEX = 2;
        public const int POWERINDEX = 3;
        public const int TYPEINDEX = 4;
        public const int ACCURACYINDEX = 5;
        public const int PPINDEX = 6;
        public const int EFFECTCHANCEINDEX = 7;
        public const int TARGETINDEX = 8;
        public const int TARGETEXTINDEX = 9;
        public const int PRIORITYINDEX = 10;
        public const int FLAGSINDEX = 11;
        public const int CONTESTEFFECTINDEX = 12;
        public const int CONTESTCONDITIONINDEX = 13;

        public const int CONTACTFLAGINDEX = 0;
        public const int PROTECTFLAGINDEX = 1;
        public const int MAGICCOATFLAGINDEX = 2;
        public const int SNATCHFLAGINDEX = 3;
        public const int MIRRORMOVEFLAGINDEX = 4;
        public const int KINGSROCKFLAGINDEX = 5;
        public const int KEEPHPBARFLAGINDEX = 6;
        public const int HIDESHADOWFLAGINDEX = 7;

        public const string DEFAULTERRORMSG = "Error! An unexpected exception occurred";
    }
}
