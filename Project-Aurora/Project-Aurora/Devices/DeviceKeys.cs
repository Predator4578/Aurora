using System.ComponentModel;

namespace Aurora.Devices
{
    /// <summary>
    /// Enum definition, representing everysingle supported device key
    /// </summary>
    public enum DeviceKeys
    {
        /// <summary>
        /// Peripheral Device
        /// <note type="note">Setting this key will make entire peripheral device one color</note>
        /// </summary>
        [Description("All Peripheral Devices")]
        Peripheral = 0,

        /// <summary>
        /// Escape key
        /// </summary>
        [Description("Escape")]
        ESC = 1,

        /// <summary>
        /// F1 key
        /// </summary>
        [Description("F1")]
        F1 = 2,

        /// <summary>
        /// F2 key
        /// </summary>
        [Description("F2")]
        F2 = 3,

        /// <summary>
        /// F3 key
        /// </summary>
        [Description("F3")]
        F3 = 4,

        /// <summary>
        /// F4 key
        /// </summary>
        [Description("F4")]
        F4 = 5,

        /// <summary>
        /// F5 key
        /// </summary>
        [Description("F5")]
        F5 = 6,

        /// <summary>
        /// F6 key
        /// </summary>
        [Description("F6")]
        F6 = 7,

        /// <summary>
        /// F7 key
        /// </summary>
        [Description("F7")]
        F7 = 8,

        /// <summary>
        /// F8 key
        /// </summary>
        [Description("F8")]
        F8 = 9,

        /// <summary>
        /// F9 key
        /// </summary>
        [Description("F9")]
        F9 = 10,

        /// <summary>
        /// F10 key
        /// </summary>
        [Description("F10")]
        F10 = 11,

        /// <summary>
        /// F11 key
        /// </summary>
        [Description("F11")]
        F11 = 12,

        /// <summary>
        /// F12 key
        /// </summary>
        [Description("F12")]
        F12 = 13,

        /// <summary>
        /// Print Screen key
        /// </summary>
        [Description("Print Screen")]
        PRINT_SCREEN = 14,

        /// <summary>
        /// Scroll Lock key
        /// </summary>
        [Description("Scroll Lock")]
        SCROLL_LOCK = 15,

        /// <summary>
        /// Pause/Break key
        /// </summary>
        [Description("Pause")]
        PAUSE_BREAK = 16,


        /// <summary>
        /// Half/Full width (Japanese layout) key
        /// </summary>
        [Description("Half/Full width")]
        JPN_HALFFULLWIDTH = 152,

        /// <summary>
        /// OEM 5 key
        /// </summary>
        [Description("OEM 5")]
        OEM5 = 156,

        /// <summary>
        /// Tilde key
        /// </summary>
        [Description("Tilde")]
        TILDE = 17,

        /// <summary>
        /// One key
        /// </summary>
        [Description("1")]
        ONE = 18,

        /// <summary>
        /// Two key
        /// </summary>
        [Description("2")]
        TWO = 19,

        /// <summary>
        /// Three key
        /// </summary>
        [Description("3")]
        THREE = 20,

        /// <summary>
        /// Four key
        /// </summary>
        [Description("4")]
        FOUR = 21,

        /// <summary>
        /// Five key
        /// </summary>
        [Description("5")]
        FIVE = 22,

        /// <summary>
        /// Six key
        /// </summary>
        [Description("6")]
        SIX = 23,

        /// <summary>
        /// Seven key
        /// </summary>
        [Description("7")]
        SEVEN = 24,

        /// <summary>
        /// Eight key
        /// </summary>
        [Description("8")]
        EIGHT = 25,

        /// <summary>
        /// Nine key
        /// </summary>
        [Description("9")]
        NINE = 26,

        /// <summary>
        /// Zero key
        /// </summary>
        [Description("0")]
        ZERO = 27,

        /// <summary>
        /// Minus key
        /// </summary>
        [Description("-")]
        MINUS = 28,

        /// <summary>
        /// Equals key
        /// </summary>
        [Description("=")]
        EQUALS = 29,

        /// <summary>
        /// OEM 6 key
        /// </summary>
        [Description("OEM 6")]
        OEM6 = 169,

        /// <summary>
        /// Backspace key
        /// </summary>
        [Description("Backspace")]
        BACKSPACE = 30,

        /// <summary>
        /// Insert key
        /// </summary>
        [Description("Insert")]
        INSERT = 31,

        /// <summary>
        /// Home key
        /// </summary>
        [Description("Home")]
        HOME = 32,

        /// <summary>
        /// Page up key
        /// </summary>
        [Description("Page Up")]
        PAGE_UP = 33,

        /// <summary>
        /// Numpad Lock key
        /// </summary>
        [Description("Numpad Lock")]
        NUM_LOCK = 34,

        /// <summary>
        /// Numpad divide key
        /// </summary>
        [Description("Numpad /")]
        NUM_SLASH = 35,

        /// <summary>
        /// Numpad multiply key
        /// </summary>
        [Description("Numpad *")]
        NUM_ASTERISK = 36,

        /// <summary>
        /// Numpad minus key
        /// </summary>
        [Description("Numpad -")]
        NUM_MINUS = 37,


        /// <summary>
        /// Tab key
        /// </summary>
        [Description("Tab")]
        TAB = 38,

        /// <summary>
        /// Q key
        /// </summary>
        [Description("Q")]
        Q = 39,

        /// <summary>
        /// W key
        /// </summary>
        [Description("W")]
        W = 40,

        /// <summary>
        /// E key
        /// </summary>
        [Description("E")]
        E = 41,

        /// <summary>
        /// R key
        /// </summary>
        [Description("R")]
        R = 42,

        /// <summary>
        /// T key
        /// </summary>
        [Description("T")]
        T = 43,

        /// <summary>
        /// Y key
        /// </summary>
        [Description("Y")]
        Y = 44,

        /// <summary>
        /// U key
        /// </summary>
        [Description("U")]
        U = 45,

        /// <summary>
        /// I key
        /// </summary>
        [Description("I")]
        I = 46,

        /// <summary>
        /// O key
        /// </summary>
        [Description("O")]
        O = 47,

        /// <summary>
        /// P key
        /// </summary>
        [Description("P")]
        P = 48,

        /// <summary>
        /// OEM 1 key
        /// </summary>
        [Description("OEM 1")]
        OEM1 = 170,

        /// <summary>
        /// Open Bracket key
        /// </summary>
        [Description("{")]
        OPEN_BRACKET = 49,

        /// <summary>
        /// OEM Plus key
        /// </summary>
        [Description("OEM Plus")]
        OEMPlus = 171,

        /// <summary>
        /// Close Bracket key
        /// </summary>
        [Description("}")]
        CLOSE_BRACKET = 50,

        /// <summary>
        /// Backslash key
        /// </summary>
        [Description("\\")]
        BACKSLASH = 51,

        /// <summary>
        /// Delete key
        /// </summary>
        [Description("Delete")]
        DELETE = 52,

        /// <summary>
        /// End key
        /// </summary>
        [Description("End")]
        END = 53,

        /// <summary>
        /// Page down key
        /// </summary>
        [Description("Page Down")]
        PAGE_DOWN = 54,

        /// <summary>
        /// Numpad seven key
        /// </summary>
        [Description("Numpad 7")]
        NUM_SEVEN = 55,

        /// <summary>
        /// Numpad eight key
        /// </summary>
        [Description("Numpad 8")]
        NUM_EIGHT = 56,

        /// <summary>
        /// Numpad nine key
        /// </summary>
        [Description("Numpad 9")]
        NUM_NINE = 57,

        /// <summary>
        /// Numpad add key
        /// </summary>
        [Description("Numpad +")]
        NUM_PLUS = 58,


        /// <summary>
        /// Caps Lock key
        /// </summary>
        [Description("Caps Lock")]
        CAPS_LOCK = 59,

        /// <summary>
        /// A key
        /// </summary>
        [Description("A")]
        A = 60,

        /// <summary>
        /// S key
        /// </summary>
        [Description("S")]
        S = 61,

        /// <summary>
        /// D key
        /// </summary>
        [Description("D")]
        D = 62,

        /// <summary>
        /// F key
        /// </summary>
        [Description("F")]
        F = 63,

        /// <summary>
        /// G key
        /// </summary>
        [Description("G")]
        G = 64,

        /// <summary>
        /// H key
        /// </summary>
        [Description("H")]
        H = 65,

        /// <summary>
        /// J key
        /// </summary>
        [Description("J")]
        J = 66,

        /// <summary>
        /// K key
        /// </summary>
        [Description("K")]
        K = 67,

        /// <summary>
        /// L key
        /// </summary>
        [Description("L")]
        L = 68,

        /// <summary>
        /// OEM Tilde key
        /// </summary>
        [Description("OEM Tilde")]
        OEMTilde = 157,

        /// <summary>
        /// Semicolon key
        /// </summary>
        [Description("Semicolon")]
        SEMICOLON = 69,

        /// <summary>
        /// Apostrophe key
        /// </summary>
        [Description("Apostrophe")]
        APOSTROPHE = 70,

        /// <summary>
        /// Hashtag key
        /// </summary>
        [Description("#")]
        HASHTAG = 71,

        /// <summary>
        /// Enter key
        /// </summary>
        [Description("Enter")]
        ENTER = 72,

        /// <summary>
        /// Numpad four key
        /// </summary>
        [Description("Numpad 4")]
        NUM_FOUR = 73,

        /// <summary>
        /// Numpad five key
        /// </summary>
        [Description("Numpad 5")]
        NUM_FIVE = 74,

        /// <summary>
        /// Numpad six key
        /// </summary>
        [Description("Numpad 6")]
        NUM_SIX = 75,


        /// <summary>
        /// Left Shift key
        /// </summary>
        [Description("Left Shift")]
        LEFT_SHIFT = 76,

        /// <summary>
        /// Non-US Backslash key
        /// </summary>
        [Description("Non-US Backslash")]
        BACKSLASH_UK = 77,

        /// <summary>
        /// Z key
        /// </summary>
        [Description("Z")]
        Z = 78,

        /// <summary>
        /// X key
        /// </summary>
        [Description("X")]
        X = 79,

        /// <summary>
        /// C key
        /// </summary>
        [Description("C")]
        C = 80,

        /// <summary>
        /// V key
        /// </summary>
        [Description("V")]
        V = 81,

        /// <summary>
        /// B key
        /// </summary>
        [Description("B")]
        B = 82,

        /// <summary>
        /// N key
        /// </summary>
        [Description("N")]
        N = 83,

        /// <summary>
        /// M key
        /// </summary>
        [Description("M")]
        M = 84,

        /// <summary>
        /// Comma key
        /// </summary>
        [Description("Comma")]
        COMMA = 85,

        /// <summary>
        /// Period key
        /// </summary>
        [Description("Period")]
        PERIOD = 86,

        /// <summary>
        /// Forward Slash key
        /// </summary>
        [Description("Forward Slash")]
        FORWARD_SLASH = 87,

        /// <summary>
        /// OEM 8 key
        /// </summary>
        [Description("OEM 8")]
        OEM8 = 158,

        /// <summary>
        /// OEM 102 key
        /// </summary>
        [Description("OEM 102")]
        OEM102 = 159,

        /// <summary>
        /// Right Shift key
        /// </summary>
        [Description("Right Shift")]
        RIGHT_SHIFT = 88,

        /// <summary>
        /// Arrow Up key
        /// </summary>
        [Description("Arrow Up")]
        ARROW_UP = 89,

        /// <summary>
        /// Numpad one key
        /// </summary>
        [Description("Numpad 1")]
        NUM_ONE = 90,

        /// <summary>
        /// Numpad two key
        /// </summary>
        [Description("Numpad 2")]
        NUM_TWO = 91,

        /// <summary>
        /// Numpad three key
        /// </summary>
        [Description("Numpad 3")]
        NUM_THREE = 92,

        /// <summary>
        /// Numpad enter key
        /// </summary>
        [Description("Numpad Enter")]
        NUM_ENTER = 93,


        /// <summary>
        /// Left Control key
        /// </summary>
        [Description("Left Control")]
        LEFT_CONTROL = 94,

        /// <summary>
        /// Left Windows key
        /// </summary>
        [Description("Left Windows Key")]
        LEFT_WINDOWS = 95,

        /// <summary>
        /// Left Alt key
        /// </summary>
        [Description("Left Alt")]
        LEFT_ALT = 96,

        /// <summary>
        /// Non-conversion (Japanese layout) key
        /// </summary>
        [Description("Non-conversion")]
        JPN_MUHENKAN = 153,

        /// <summary>
        /// Spacebar key
        /// </summary>
        [Description("Spacebar")]
        SPACE = 97,

        /// <summary>
        /// Conversion (Japanese layout) key
        /// </summary>
        [Description("Conversion")]
        JPN_HENKAN = 154,

        /// <summary>
        /// Hiragana/Katakana (Japanese layout) key
        /// </summary>
        [Description("Hiragana/Katakana")]
        JPN_HIRAGANA_KATAKANA = 155,

        /// <summary>
        /// Right Alt key
        /// </summary>
        [Description("Right Alt")]
        RIGHT_ALT = 98,

        /// <summary>
        /// Right Windows key
        /// </summary>
        [Description("Right Windows Key")]
        RIGHT_WINDOWS = 99,

        /// <summary>
        /// Application Select key
        /// </summary>
        [Description("Application Select Key")]
        APPLICATION_SELECT = 100,

        /// <summary>
        /// Right Control key
        /// </summary>
        [Description("Right Control")]
        RIGHT_CONTROL = 101,

        /// <summary>
        /// Arrow Left key
        /// </summary>
        [Description("Arrow Left")]
        ARROW_LEFT = 102,

        /// <summary>
        /// Arrow Down key
        /// </summary>
        [Description("Arrow Down")]
        ARROW_DOWN = 103,

        /// <summary>
        /// Arrow Right key
        /// </summary>
        [Description("Arrow Right")]
        ARROW_RIGHT = 104,

        /// <summary>
        /// Numpad zero key
        /// </summary>
        [Description("Numpad 0")]
        NUM_ZERO = 105,

        /// <summary>
        /// Numpad period key
        /// </summary>
        [Description("Numpad Period")]
        NUM_PERIOD = 106,


        /// <summary>
        /// Function key
        /// </summary>
        [Description("FN Key")]
        FN_Key = 107,


        /// <summary>
        /// Macrokey 1 key
        /// </summary>
        [Description("G1")]
        G1 = 108,

        /// <summary>
        /// Macrokey 2 key
        /// </summary>
        [Description("G2")]
        G2 = 109,

        /// <summary>
        /// Macrokey 3 key
        /// </summary>
        [Description("G3")]
        G3 = 110,

        /// <summary>
        /// Macrokey 4 key
        /// </summary>
        [Description("G4")]
        G4 = 111,

        /// <summary>
        /// Macrokey 5 key
        /// </summary>
        [Description("G5")]
        G5 = 112,

        /// <summary>
        /// Macrokey 6 key
        /// </summary>
        [Description("G6")]
        G6 = 113,

        /// <summary>
        /// Macrokey 7 key
        /// </summary>
        [Description("G7")]
        G7 = 114,

        /// <summary>
        /// Macrokey 8 key
        /// </summary>
        [Description("G8")]
        G8 = 115,

        /// <summary>
        /// Macrokey 9 key
        /// </summary>
        [Description("G9")]
        G9 = 116,

        /// <summary>
        /// Macrokey 10 key
        /// </summary>
        [Description("G10")]
        G10 = 117,

        /// <summary>
        /// Macrokey 11 key
        /// </summary>
        [Description("G11")]
        G11 = 118,

        /// <summary>
        /// Macrokey 12 key
        /// </summary>
        [Description("G12")]
        G12 = 119,

        /// <summary>
        /// Macrokey 13 key
        /// </summary>
        [Description("G13")]
        G13 = 120,

        /// <summary>
        /// Macrokey 14 key
        /// </summary>
        [Description("G14")]
        G14 = 121,

        /// <summary>
        /// Macrokey 15 key
        /// </summary>
        [Description("G15")]
        G15 = 122,

        /// <summary>
        /// Macrokey 16 key
        /// </summary>
        [Description("G16")]
        G16 = 123,

        /// <summary>
        /// Macrokey 17 key
        /// </summary>
        [Description("G17")]
        G17 = 124,

        /// <summary>
        /// Macrokey 18 key
        /// </summary>
        [Description("G18")]
        G18 = 125,

        /// <summary>
        /// Macrokey 19 key
        /// </summary>
        [Description("G19")]
        G19 = 126,

        /// <summary>
        /// Macrokey 20 key
        /// </summary>
        [Description("G20")]
        G20 = 127,


        /// <summary>
        /// Brand Logo
        /// </summary>
        [Description("Brand Logo")]
        LOGO = 128,

        /// <summary>
        /// Brand Logo #2
        /// </summary>
        [Description("Brand Logo #2")]
        LOGO2 = 129,

        /// <summary>
        /// Brand Logo #3
        /// </summary>
        [Description("Brand Logo #3")]
        LOGO3 = 130,

        /// <summary>
        /// Brightness Switch
        /// </summary>
        [Description("Brightness Switch")]
        BRIGHTNESS_SWITCH = 131,

        /// <summary>
        /// Lock Switch
        /// </summary>
        [Description("Lock Switch")]
        LOCK_SWITCH = 132,


        /// <summary>
        /// Multimedia Play/Pause
        /// </summary>
        [Description("Media Play/Pause")]
        MEDIA_PLAY_PAUSE = 133,

        /// <summary>
        /// Multimedia Play
        /// </summary>
        [Description("Media Play")]
        MEDIA_PLAY = 134,

        /// <summary>
        /// Multimedia Pause
        /// </summary>
        [Description("Media Pause")]
        MEDIA_PAUSE = 135,

        /// <summary>
        /// Multimedia Stop
        /// </summary>
        [Description("Media Stop")]
        MEDIA_STOP = 136,

        /// <summary>
        /// Multimedia Previous
        /// </summary>
        [Description("Media Previous")]
        MEDIA_PREVIOUS = 137,

        /// <summary>
        /// Multimedia Next
        /// </summary>
        [Description("Media Next")]
        MEDIA_NEXT = 138,


        /// <summary>
        /// Volume Mute
        /// </summary>
        [Description("Volume Mute")]
        VOLUME_MUTE = 139,

        /// <summary>
        /// Volume Down
        /// </summary>
        [Description("Volume Down")]
        VOLUME_DOWN = 140,

        /// <summary>
        /// Volume Up
        /// </summary>
        [Description("Volume Up")]
        VOLUME_UP = 141,


        /// <summary>
        /// Additional Light 1
        /// </summary>
        [Description("Additional Light 1")]
        ADDITIONALLIGHT1 = 142,

        /// <summary>
        /// Additional Light 2
        /// </summary>
        [Description("Additional Light 2")]
        ADDITIONALLIGHT2 = 143,

        /// <summary>
        /// Additional Light 3
        /// </summary>
        [Description("Additional Light 3")]
        ADDITIONALLIGHT3 = 144,

        /// <summary>
        /// Additional Light 4
        /// </summary>
        [Description("Additional Light 4")]
        ADDITIONALLIGHT4 = 145,

        /// <summary>
        /// Additional Light 5
        /// </summary>
        [Description("Additional Light 5")]
        ADDITIONALLIGHT5 = 146,

        /// <summary>
        /// Additional Light 6
        /// </summary>
        [Description("Additional Light 6")]
        ADDITIONALLIGHT6 = 147,

        /// <summary>
        /// Additional Light 7
        /// </summary>
        [Description("Additional Light 7")]
        ADDITIONALLIGHT7 = 148,

        /// <summary>
        /// Additional Light 8
        /// </summary>
        [Description("Additional Light 8")]
        ADDITIONALLIGHT8 = 149,

        /// <summary>
        /// Additional Light 9
        /// </summary>
        [Description("Additional Light 9")]
        ADDITIONALLIGHT9 = 150,

        /// <summary>
        /// Additional Light 10
        /// </summary>
        [Description("Additional Light 10")]
        ADDITIONALLIGHT10 = 151,

        /// <summary>
        /// Peripheral Logo
        /// </summary>
        [Description("Peripheral Logo")]
        Peripheral_Logo = 160,

        /// <summary>
        /// Peripheral Scroll Wheel
        /// </summary>
        [Description("Peripheral Scroll Wheel")]
        Peripheral_ScrollWheel = 161,

        /// <summary>
        /// Peripheral Front-facing lights
        /// </summary>
        [Description("Peripheral Front Lights")]
        Peripheral_FrontLight = 162,

        /// <summary>
        /// Profile key 1
        /// </summary>
        [Description("Profile Key 1")]
        Profile_Key1 = 163,

        /// <summary>
        /// Profile key 2
        /// </summary>
        [Description("Profile Key 2")]
        Profile_Key2 = 164,

        /// <summary>
        /// Profile key 3
        /// </summary>
        [Description("Profile Key 3")]
        Profile_Key3 = 165,

        /// <summary>
        /// Profile key 4
        /// </summary>
        [Description("Profile Key 4")]
        Profile_Key4 = 166,

        /// <summary>
        /// Profile key 5
        /// </summary>
        [Description("Profile Key 5")]
        Profile_Key5 = 167,

        /// <summary>
        /// Profile key 6
        /// </summary>
        [Description("Profile Key 6")]
        Profile_Key6 = 168,

        /// <summary>
        /// Numpad 00
        /// </summary>
        [Description("Numpad 00")]
        NUM_ZEROZERO = 169,

        /// <summary>
        /// Macrokey 0 key
        /// </summary>
        [Description("G0")]
        G0 = 170,

        /// <summary>
        /// Macrokey 0 key
        /// </summary>
        [Description("Left FN")]
        LEFT_FN = 171,

        /// <summary>
        /// Additional Light 11
        /// </summary>
        [Description("Additional Light 11")]
        ADDITIONALLIGHT11 = 172,

        /// <summary>
        /// Additional Light 12
        /// </summary>
        [Description("Additional Light 12")]
        ADDITIONALLIGHT12 = 173,

        /// <summary>
        /// Additional Light 13
        /// </summary>
        [Description("Additional Light 13")]
        ADDITIONALLIGHT13 = 174,

        /// <summary>
        /// Additional Light 14
        /// </summary>
        [Description("Additional Light 14")]
        ADDITIONALLIGHT14 = 175,

        /// <summary>
        /// Additional Light 15
        /// </summary>
        [Description("Additional Light 15")]
        ADDITIONALLIGHT15 = 176,

        /// <summary>
        /// Additional Light 16
        /// </summary>
        [Description("Additional Light 16")]
        ADDITIONALLIGHT16 = 177,

        /// <summary>
        /// Additional Light 17
        /// </summary>
        [Description("Additional Light 17")]
        ADDITIONALLIGHT17 = 178,

        /// <summary>
        /// Additional Light 18
        /// </summary>
        [Description("Additional Light 18")]
        ADDITIONALLIGHT18 = 179,

        /// <summary>
        /// Additional Light 19
        /// </summary>
        [Description("Additional Light 19")]
        ADDITIONALLIGHT19 = 180,

        /// <summary>
        /// Additional Light 20
        /// </summary>
        [Description("Additional Light 20")]
        ADDITIONALLIGHT20 = 181,

        /// <summary>
        /// Additional Light 21
        /// </summary>
        [Description("Additional Light 21")]
        ADDITIONALLIGHT21 = 182,

        /// <summary>
        /// Additional Light 22
        /// </summary>
        [Description("Additional Light 22")]
        ADDITIONALLIGHT22 = 183,

        /// <summary>
        /// Additional Light 23
        /// </summary>
        [Description("Additional Light 23")]
        ADDITIONALLIGHT23 = 184,

        /// <summary>
        /// Additional Light 24
        /// </summary>
        [Description("Additional Light 24")]
        ADDITIONALLIGHT24 = 185,

        /// <summary>
        /// Additional Light 25
        /// </summary>
        [Description("Additional Light 25")]
        ADDITIONALLIGHT25 = 186,

        /// <summary>
        /// Additional Light 26
        /// </summary>
        [Description("Additional Light 26")]
        ADDITIONALLIGHT26 = 187,

        /// <summary>
        /// Additional Light 27
        /// </summary>
        [Description("Additional Light 27")]
        ADDITIONALLIGHT27 = 188,

        /// <summary>
        /// Additional Light 28
        /// </summary>
        [Description("Additional Light 28")]
        ADDITIONALLIGHT28 = 189,

        /// <summary>
        /// Additional Light 29
        /// </summary>
        [Description("Additional Light 29")]
        ADDITIONALLIGHT29 = 190,

        /// <summary>
        /// Additional Light 30
        /// </summary>
        [Description("Additional Light 30")]
        ADDITIONALLIGHT30 = 191,

        /// <summary>
        /// Additional Light 31
        /// </summary>
        [Description("Additional Light 31")]
        ADDITIONALLIGHT31 = 192,

        /// <summary>
        /// Additional Light 32
        /// </summary>
        [Description("Additional Light 32")]
        ADDITIONALLIGHT32 = 193,

        /// <summary>
        /// Mousepad Light 1
        /// </summary>
        [Description("Mousepad Light 1")]
        MOUSEPADLIGHT1 = 201,

        /// <summary>
        /// Mousepad Light 2
        /// </summary>
        [Description("Mousepad Light 2")]
        MOUSEPADLIGHT2 = 202,

        /// <summary>
        /// Mousepad Light 1
        /// </summary>
        [Description("Mousepad Light 3")]
        MOUSEPADLIGHT3 = 203,

        /// <summary>
        /// Mousepad Light 2
        /// </summary>
        [Description("Mousepad Light 4")]
        MOUSEPADLIGHT4 = 204,

        /// <summary>
        /// Mousepad Light 1
        /// </summary>
        [Description("Mousepad Light 5")]
        MOUSEPADLIGHT5 = 205,

        /// <summary>
        /// Mousepad Light 2
        /// </summary>
        [Description("Mousepad Light 6")]
        MOUSEPADLIGHT6 = 206,

        /// <summary>
        /// Mousepad Light 1
        /// </summary>
        [Description("Mousepad Light 7")]
        MOUSEPADLIGHT7 = 207,

        /// <summary>
        /// Mousepad Light 2
        /// </summary>
        [Description("Mousepad Light 8")]
        MOUSEPADLIGHT8 = 208,

        /// <summary>
        /// Mousepad Light 1
        /// </summary>
        [Description("Mousepad Light 9")]
        MOUSEPADLIGHT9 = 209,

        /// <summary>
        /// Mousepad Light 2
        /// </summary>
        [Description("Mousepad Light 10")]
        MOUSEPADLIGHT10 = 210,

        /// <summary>
        /// Mousepad Light 2
        /// </summary>
        [Description("Mousepad Light 11")]
        MOUSEPADLIGHT11 = 211,

        /// <summary>
        /// Mousepad Light 1
        /// </summary>
        [Description("Mousepad Light 12")]
        MOUSEPADLIGHT12 = 212,

        /// <summary>
        /// Mousepad Light 2
        /// </summary>
        [Description("Mousepad Light 13")]
        MOUSEPADLIGHT13 = 213,

        /// <summary>
        /// Mousepad Light 1
        /// </summary>
        [Description("Mousepad Light 14")]
        MOUSEPADLIGHT14 = 214,

        /// <summary>
        /// Mousepad Light 2
        /// </summary>
        [Description("Mousepad Light 15")]
        MOUSEPADLIGHT15 = 215,

        ///<summary>
        /// Calculator Key
        /// </summary>
        [Description("Calculator")]
        CALC = 216,

        /// <summary>
        /// Peripheral Light 1
        /// </summary>
        [Description("Peripheral Light 1")]
        PERIPHERAL_LIGHT1 = 217,

        /// <summary>
        /// Peripheral Light 2
        /// </summary>
        [Description("Peripheral Light 2")]
        PERIPHERAL_LIGHT2 = 218,

        /// <summary>
        /// Peripheral Light 3
        /// </summary>
        [Description("Peripheral Light 3")]
        PERIPHERAL_LIGHT3 = 219,

        /// <summary>
        /// Peripheral Light 4
        /// </summary>
        [Description("Peripheral Light 4")]
        PERIPHERAL_LIGHT4 = 220,

        /// <summary>
        /// Peripheral Light 5
        /// </summary>
        [Description("Peripheral Light 5")]
        PERIPHERAL_LIGHT5 = 221,

        /// <summary>
        /// Peripheral Light 6
        /// </summary>
        [Description("Peripheral Light 6")]
        PERIPHERAL_LIGHT6 = 222,

        /// <summary>
        /// Peripheral Light 7
        /// </summary>
        [Description("Peripheral Light 7")]
        PERIPHERAL_LIGHT7 = 223,

        /// <summary>
        /// Peripheral Light 8
        /// </summary>
        [Description("Peripheral Light 8")]
        PERIPHERAL_LIGHT8 = 224,

        /// <summary>
        /// Peripheral Light 9
        /// </summary>
        [Description("Peripheral Light 9")]
        PERIPHERAL_LIGHT9 = 225,

        /// <summary>
        /// Peripheral Light 10
        /// </summary>
        [Description("Peripheral Light 10")]
        PERIPHERAL_LIGHT10 = 226,

        /// <summary>
        /// Peripheral Light 11
        /// </summary>
        [Description("Peripheral Light 11")]
        PERIPHERAL_LIGHT11 = 227,

        /// <summary>
        /// Peripheral Light 12
        /// </summary>
        [Description("Peripheral Light 12")]
        PERIPHERAL_LIGHT12 = 228,

        /// <summary>
        /// Peripheral Light 13
        /// </summary>
        [Description("Peripheral Light 13")]
        PERIPHERAL_LIGHT13 = 229,

        /// <summary>
        /// Peripheral Light 14
        /// </summary>
        [Description("Peripheral Light 14")]
        PERIPHERAL_LIGHT14 = 230,

        /// <summary>
        /// Peripheral Light 15
        /// </summary>
        [Description("Peripheral Light 15")]
        PERIPHERAL_LIGHT15 = 231,

        /// <summary>
        /// Peripheral Light 16
        /// </summary>
        [Description("Peripheral Light 16")]
        PERIPHERAL_LIGHT16 = 232,

        /// <summary>
        /// Peripheral Light 17
        /// </summary>
        [Description("Peripheral Light 17")]
        PERIPHERAL_LIGHT17 = 233,

        /// <summary>
        /// Peripheral Light 18
        /// </summary>
        [Description("Peripheral Light 18")]
        PERIPHERAL_LIGHT18 = 234,

        /// <summary>
        /// Peripheral Light 19
        /// </summary>
        [Description("Peripheral Light 19")]
        PERIPHERAL_LIGHT19 = 235,

        /// <summary>
        /// Peripheral Light 20
        /// </summary>
        [Description("Peripheral Light 20")]
        PERIPHERAL_LIGHT20 = 236,

        /// <summary>
        /// Peripheral DPI
        /// </summary>
        [Description("PERIPHERAL_DPI")]
        PERIPHERAL_DPI = 237,

        /// <summary>
        /// None
        /// </summary>
        [Description("None")]
        NONE = -1,

        //////////////////////////////////////////////   START OF MY ADDITIONS
        ////
        //////////////////////////////////////////////   LOGO LIGHTS and SINGLE LIGHTS begin here      
        //////////////////////////////////////////////   "LOGO" Range is 1000 - 1200
        //////////////////////////////////////////////   Added Mousepadlogo, Headsetlogo, Headsetstrip, Coolerlogo, Mobologo, 
        ////
        //////////////////////////////////////////////   MOUSEPADLOGO begin here 
        //////////////////////////////////////////////   Added 1 Mousepad LOGO (Goliathus Extended 1)

        /// <summary>
        /// Mousepad Logo 
        /// </summary>
        [Description("Mousepad Logo")]
        MOUSEPAD_LOGO = 1000,

        //////////////////////////////////////////////   HEADSETSTANDLOGO begin here 
        //////////////////////////////////////////////   Added 1 HEADSETSTAND LOGO (Corsair ST100 1)

        /// <summary>
        /// Mousepad Logo 
        /// </summary>
        [Description("Headset Stand Logo")]
        HEADSETSTAND_LOGO = 1010,

        //////////////////////////////////////////////   HEADSETLIGHTS begin here 
        //////////////////////////////////////////////   Added Headset Logo, Headset Light Strip (Logitech G933 2)

        /// <summary>
        /// Headset Logo
        /// </summary>
        [Description("Headset Logo")]
        HEADSET_LOGO = 1020,

        /// <summary>
        /// Headset Light Strip
        /// </summary>
        [Description("Headset Light strip")]
        HEADSET_STRIP = 1021,

        //////////////////////////////////////////////   MOBO_LOGO begin here 
        //////////////////////////////////////////////   Added up to 1 MOBO LOGO (Asus Z270 Formula 1)

        /// <summary>
        /// Cooler Logo
        /// </summary>
        [Description("Mobo Logo")]
        MOBO_LOGO = 1030,

        //////////////////////////////////////////////   COOLERLOGO begin here 
        //////////////////////////////////////////////   Added 1 Cooler Logo (NZXT KRAKEN SERIES X62 1)

        /// <summary>
        /// Cooler Logo
        /// </summary>
        [Description("Cooler Logo")]
        COOLER_LOGO = 1040,

        //////////////////////////////////////////////   GPULOGO begin here 
        //////////////////////////////////////////////   Added 1 GPU Logo (Gainward GTX 1080 1)

        /// <summary>
        /// GPU Logo
        /// </summary>
        [Description("GPU Logo")]
        GPU_LOGO = 1050,

        //////////////////////////////////////////////   DRAMLOGO begin here 
        //////////////////////////////////////////////   Added 1 DRAM Logo (Generic RAM 1)

        /// <summary>
        /// DRAM Logo
        /// </summary>
        [Description("DRAM Logo")]
        DRAM_LOGO = 1060,

        //////////////////////////////////////////////   LEDLOGO begin here 
        //////////////////////////////////////////////   Added 1 LED Logo (Generic LEDstrip 1)

        /// <summary>
        /// LED Logo
        /// </summary>
        [Description("LED Logo")]
        LED_LOGO = 1070,

        //////////////////////////////////////////////   GAMEPADLOGO begin here 
        //////////////////////////////////////////////   Added 1 GAMEPAD Logo (Various 1)

        /// <summary>
        /// GAMEPAD Logo
        /// </summary>
        [Description("Gamepad Logo")]
        GAMEPAD_LOGO = 1080,

        //////////////////////////////////////////////   HUELOGO begin here 
        //////////////////////////////////////////////   Added 1 Hue Logo (HUE BULB 1)

        /// <summary>
        /// Hue Logo
        /// </summary>
        [Description("Hue Logo")]
        HUE_LOGO = 1090,

        //////////////////////////////////////////////   ADDITIONALLIGHTS begin here 
        //////////////////////////////////////////////   "ADDITIONALLIGHTS" Range is 1201 - 1250
        //////////////////////////////////////////////   Added up to Nr. 40 Additional Lights (32 Originally)(Hueplus 40)

        /// <summary>
        /// Additional Light 33
        /// </summary>
        [Description("Additional Light 33")]
        ADDITIONALLIGHT33 = 1201,

        /// <summary>
        /// Additional Light 34
        /// </summary>
        [Description("Additional Light 34")]
        ADDITIONALLIGHT34 = 1202,

        /// <summary>
        /// Additional Light 35
        /// </summary>
        [Description("Additional Light 35")]
        ADDITIONALLIGHT35 = 1203,

        /// <summary>
        /// Additional Light 36
        /// </summary>
        [Description("Additional Light 36")]
        ADDITIONALLIGHT36 = 1204,

        /// <summary>
        /// Additional Light 37
        /// </summary>
        [Description("Additional Light 37")]
        ADDITIONALLIGHT37 = 1205,

        /// <summary>
        /// Additional Light 38
        /// </summary>
        [Description("Additional Light 38")]
        ADDITIONALLIGHT38 = 1206,

        /// <summary>
        /// Additional Light 39
        /// </summary>
        [Description("Additional Light 39")]
        ADDITIONALLIGHT39 = 1207,

        /// <summary>
        /// Additional Light 40
        /// </summary>
        [Description("Additional Light 40")]
        ADDITIONALLIGHT40 = 1208,

        //////////////////////////////////////////////   MOUSELIGHTS begin here 
        //////////////////////////////////////////////   "MOUSELIGHTS" Range is 1251 - 1300
        //////////////////////////////////////////////   Added up to 5 MouseLights (Various)

        /// <summary>
        /// Mouse Light 1
        /// </summary>
        [Description("Mouse Light 1")]
        MOUSELIGHT1 = 1251,

        /// <summary>
        /// Mouse Light 2
        /// </summary>
        [Description("Mouse Light 2")]
        MOUSELIGHT2 = 1252,

        /// <summary>
        /// Mouse Light 3
        /// </summary>
        [Description("Mouse Light 3")]
        MOUSELIGHT3 = 1253,

        /// <summary>
        /// Mouse Light 4
        /// </summary>
        [Description("Mouse Light 4")]
        MOUSELIGHT4 = 1254,

        /// <summary>
        /// Mouse Light 5
        /// </summary>
        [Description("Mouse Light 5")]
        MOUSELIGHT5 = 1255,

        //////////////////////////////////////////////   MOUSEPADLIGHTS begin here 
        //////////////////////////////////////////////   "MOUSEPADLIGHTS" Range is 1301 - 1350
        //////////////////////////////////////////////   Added up to Nr. 20 Mousepad Lights (15 Originally)(Firefly Chroma 15)

        /// <summary>
        /// Mousepad Light 16
        /// </summary>
        [Description("Mousepad Light 16")]
        MOUSEPADLIGHT16 = 1301,

        /// <summary>
        /// Mousepad Light 17
        /// </summary>
        [Description("Mousepad Light 17")]
        MOUSEPADLIGHT17 = 1302,

        /// <summary>
        /// Mousepad Light 18
        /// </summary>
        [Description("Mousepad Light 18")]
        MOUSEPADLIGHT18 = 1303,

        /// <summary>
        /// Mousepad Light 19
        /// </summary>
        [Description("Mousepad Light 19")]
        MOUSEPADLIGHT19 = 1304,

        /// <summary>
        /// Mousepad Light 20
        /// </summary>
        [Description("Mousepad Light 20")]
        MOUSEPADLIGHT20 = 1305,

        //////////////////////////////////////////////   HEADSETLIGHTS begin here 
        //////////////////////////////////////////////   "HEADSETLIGHTS" Range is 1351 - 1400
        //////////////////////////////////////////////   Added up to 5 HeadsetLights (Various)

        /// <summary>
        /// Headset Light 1
        /// </summary>
        [Description("Headset Light 1")]
        HEADSETLIGHT1 = 1351,

        /// <summary>
        /// Headset Light 2
        /// </summary>
        [Description("Headset Light 2")]
        HEADSETLIGHT2 = 1352,

        /// <summary>
        /// Headset Light 3
        /// </summary>
        [Description("Headset Light 3")]
        HEADSETLIGHT3 = 1353,

        /// <summary>
        /// Headset Light 4
        /// </summary>
        [Description("Headset Light 4")]
        HEADSETLIGHT4 = 1354,

        /// <summary>
        /// Headset Light 5
        /// </summary>
        [Description("Headset Light 5")]
        HEADSETLIGHT5 = 1355,

        //////////////////////////////////////////////   HEADSETSTANDLIGHTS begin here 
        //////////////////////////////////////////////   "HEADSETSTANDLIGHTS" Range is 1401 - 1450
        //////////////////////////////////////////////   Added up to 20 HeadsetStandLights (Basestation Chroma 15)

        /// <summary>
        /// Headset Stand Light 1
        /// </summary>
        [Description("Headset Stand Light 1")]
        HEADSETSTANDLIGHT1 = 1401,

        /// <summary>
        /// Headset Stand Light 2
        /// </summary>
        [Description("Headset Stand Light 2")]
        HEADSETSTANDLIGHT2 = 1402,

        /// <summary>
        /// Headset Stand Light 3
        /// </summary>
        [Description("Headset Stand Light 3")]
        HEADSETSTANDLIGHT3 = 1403,

        /// <summary>
        /// Headset Stand Light 4
        /// </summary>
        [Description("Headset Stand Light 4")]
        HEADSETSTANDLIGHT4 = 1404,

        /// <summary>
        /// Headset Stand Light 5
        /// </summary>
        [Description("Headset Stand Light 5")]
        HEADSETSTANDLIGHT5 = 1405,

        /// <summary>
        /// Headset Stand Light 6
        /// </summary>
        [Description("Headset Stand Light 6")]
        HEADSETSTANDLIGHT6 = 1406,

        /// <summary>
        /// Headset Stand Light 7
        /// </summary>
        [Description("Headset Stand Light 7")]
        HEADSETSTANDLIGHT7 = 1407,

        /// <summary>
        /// Headset Stand Light 8
        /// </summary>
        [Description("Headset Stand Light 8")]
        HEADSETSTANDLIGHT8 = 1408,

        /// <summary>
        /// Headset Stand Light 9
        /// </summary>
        [Description("Headset Stand Light 9")]
        HEADSETSTANDLIGHT9 = 1409,

        /// <summary>
        /// Headset Stand Light 10
        /// </summary>
        [Description("Headset Stand Light 10")]
        HEADSETSTANDLIGHT10 = 1410,

        /// <summary>
        /// Headset Stand Light 11
        /// </summary>
        [Description("Headset Stand Light 11")]
        HEADSETSTANDLIGHT11 = 1411,

        /// <summary>
        /// Headset Stand Light 12
        /// </summary>
        [Description("Headset Stand Light 12")]
        HEADSETSTANDLIGHT12 = 1412,

        /// <summary>
        /// Headset Stand Light 13
        /// </summary>
        [Description("Headset Stand Light 13")]
        HEADSETSTANDLIGHT13 = 1413,

        /// <summary>
        /// Headset Stand Light 14
        /// </summary>
        [Description("Headset Stand Light 14")]
        HEADSETSTANDLIGHT14 = 1414,

        /// <summary>
        /// Headset Stand Light 15
        /// </summary>
        [Description("Headset Stand Light 15")]
        HEADSETSTANDLIGHT15 = 1415,

        /// <summary>
        /// Headset Stand Light 16
        /// </summary>
        [Description("Headset Stand Light 16")]
        HEADSETSTANDLIGHT16 = 1416,

        /// <summary>
        /// Headset Stand Light 17
        /// </summary>
        [Description("Headset Stand Light 17")]
        HEADSETSTANDLIGHT17 = 1417,

        /// <summary>
        /// Headset Stand Light 18
        /// </summary>
        [Description("Headset Stand Light 18")]
        HEADSETSTANDLIGHT18 = 1418,

        /// <summary>
        /// Headset Stand Light 19
        /// </summary>
        [Description("Headset Stand Light 19")]
        HEADSETSTANDLIGHT19 = 1419,

        /// <summary>
        /// Headset Stand Light 20
        /// </summary>
        [Description("Headset Stand Light 20")]
        HEADSETSTANDLIGHT20 = 1420,

        //////////////////////////////////////////////   GPULIGHTS begin here 
        //////////////////////////////////////////////   "GPULIGHTS" Range is 1451 - 1500
        //////////////////////////////////////////////   Added up to 5 GPU Lights (Various)

        /// <summary>
        /// GPU Light 1
        /// </summary>
        [Description("GPU Light 1")]
        GPULIGHT1 = 1451,

        /// <summary>
        /// GPU Light 2
        /// </summary>
        [Description("GPU Light 2")]
        GPULIGHT2 = 1452,

        /// <summary>
        /// GPU Light 3
        /// </summary>
        [Description("GPU Light 3")]
        GPULIGHT3 = 1453,

        /// <summary>
        /// GPU Light 4
        /// </summary>
        [Description("GPU Light 4")]
        GPULIGHT4 = 1454,

        /// <summary>
        /// GPU Light 5
        /// </summary>
        [Description("GPU Light 5")]
        GPULIGHT5 = 1455,

        //////////////////////////////////////////////   MOBOLIGHTS begin here 
        //////////////////////////////////////////////   "MOBOLIGHTS" Range is 1501 - 1600
        //////////////////////////////////////////////   Added up to 5 MOBOLIGHTS (Asus Z270 Formula 2+2)

        /// <summary>
        /// MOBO Light 1
        /// </summary>
        [Description("Mainboard Light 1")]
        MOBOLIGHT1 = 1501,

        /// <summary>
        /// MOBO Light 2
        /// </summary>
        [Description("Mainboard Light 2")]
        MOBOLIGHT2 = 1502,

        /// <summary>
        /// MOBO Light 3
        /// </summary>
        [Description("Mainboard Light 3")]
        MOBOLIGHT3 = 1503,

        /// <summary>
        /// MOBO Light 4
        /// </summary>
        [Description("Mainboard Light 4")]
        MOBOLIGHT4 = 1504,

        /// <summary>
        /// MOBO Light 5
        /// </summary>
        [Description("Mainboard Light 5")]
        MOBOLIGHT5 = 1505,

        //////////////////////////////////////////////   COOLERLIGHTS begin here 
        //////////////////////////////////////////////   COOLERLIGHTS Range 1601 - 1650 
        //////////////////////////////////////////////   Added up to 8 Cooler Lights (NZXT KRAKEN SERIES X62)

        /// <summary>
        /// COOLER Light 1
        /// </summary>
        [Description("Cooler Light 1")]
        COOLERLIGHT1 = 1601,

        /// <summary>
        /// COOLER Light 2
        /// </summary>
        [Description("Cooler Light 2")]
        COOLERLIGHT2 = 1602,

        /// <summary>
        /// COOLER Light 3
        /// </summary>
        [Description("Cooler Light 3")]
        COOLERLIGHT3 = 1603,

        /// <summary>
        /// COOLER Light 4
        /// </summary>
        [Description("Cooler Light 4")]
        COOLERLIGHT4 = 1604,

        /// <summary>
        /// COOLER Light 5
        /// </summary>
        [Description("Cooler Light 5")]
        COOLERLIGHT5 = 1605,

        /// <summary>
        /// COOLER Light 6
        /// </summary>
        [Description("Cooler Light 6")]
        COOLERLIGHT6 = 1606,

        /// <summary>
        /// COOLER Light 7
        /// </summary>
        [Description("Cooler Light 7")]
        COOLERLIGHT7 = 1607,

        /// <summary>
        /// COOLER Light 8
        /// </summary>
        [Description("Cooler Light 8")]
        COOLERLIGHT8 = 1608,

        //////////////////////////////////////////////   GAMEPADLIGHTS begin here 
        //////////////////////////////////////////////   "GAMEPADLIGHTS" Range is 1651 - 1700
        //////////////////////////////////////////////   Added up to 5 GAMEPAD Lights (Various)

        /// <summary>
        /// GAMEPAD Light 1
        /// </summary>
        [Description("GAMEPAD Light 1")]
        GAMEPADLIGHT1 = 1651,

        /// <summary>
        /// GAMEPAD Light 2
        /// </summary>
        [Description("GAMEPAD Light 2")]
        GAMEPADLIGHT2 = 1652,

        /// <summary>
        /// GAMEPAD Light 3
        /// </summary>
        [Description("GAMEPAD Light 3")]
        GAMEPADLIGHT3 = 1653,

        /// <summary>
        /// GAMEPAD Light 4
        /// </summary>
        [Description("GAMEPAD Light 4")]
        GAMEPADLIGHT4 = 1654,

        /// <summary>
        /// GAMEPAD Light 5
        /// </summary>
        [Description("GAMEPAD Light 5")]
        GAMEPADLIGHT5 = 1655,


        //////////////////////////////////////////////   RAMLIGHTS begin here 
        //////////////////////////////////////////////   RAMLIGHTS Range 1701 - 1900 (8x25 Leds max.) 
        //////////////////////////////////////////////   Added up to 5 RAMLights for 4 DIMMs

        ////////////////////////////////// DIMM 1

        /// <summary>
        /// C0 RAM Light 1
        /// </summary>
        [Description("C0 RAM Light 1")]
        C0RAMLIGHT1 = 1701,

        /// <summary>
        /// C0 RAM Light 2
        /// </summary>
        [Description("C0 RAM Light 2")]
        C0RAMLIGHT2 = 1702,

        /// <summary>
        /// C0 RAM Light 3
        /// </summary>
        [Description("C0 RAM Light 3")]
        C0RAMLIGHT3 = 1703,

        /// <summary>
        /// C0 RAM Light 4
        /// </summary>
        [Description("C0 RAM Light 4")]
        C0RAMLIGHT4 = 1704,

        /// <summary>
        /// C0 RAM Light 5
        /// </summary>
        [Description("C0 RAM Light 5")]
        C0RAMLIGHT5 = 1705,

        ////////////////////////////////// DIMM 2
        
        /// <summary>
        /// C1 RAM Light 1
        /// </summary>
        [Description("C1 RAM Light 1")]
        C1RAMLIGHT1 = 1706,

        /// <summary>
        /// C1 RAM Light 2
        /// </summary>
        [Description("C1 RAM Light 2")]
        C1RAMLIGHT2 = 1707,

        /// <summary>
        /// C1 RAM Light 3
        /// </summary>
        [Description("C1 RAM Light 3")]
        C1RAMLIGHT3 = 1708,

        /// <summary>
        /// C1 RAM Light 4
        /// </summary>
        [Description("C1 RAM Light 4")]
        C1RAMLIGHT4 = 1709,

        /// <summary>
        /// C1 RAM Light 5
        /// </summary>
        [Description("C1 RAM Light 5")]
        C1RAMLIGHT5 = 1710,

        ////////////////////////////////// DIMM 3
        
        /// <summary>
        /// C2  RAM Light 1
        /// </summary>
        [Description("C2 RAM Light 1")]
        C2RAMLIGHT1 = 1711,

        /// <summary>
        /// C2 RAM Light 2
        /// </summary>
        [Description("C2 RAM Light 2")]
        C2RAMLIGHT2 = 1712,

        /// <summary>
        /// C2 RAM Light 3
        /// </summary>
        [Description("C2 RAM Light 3")]
        C2RAMLIGHT3 = 1713,

        /// <summary>
        /// C2 RAM Light 4
        /// </summary>
        [Description("C2 RAM Light 4")]
        C2RAMLIGHT4 = 1714,

        /// <summary>
        /// C2 RAM Light 5
        /// </summary>
        [Description("C2 RAM Light 5")]
        C2RAMLIGHT5 = 1715,
        
        ////////////////////////////////// DIMM 4
        
        /// <summary>
        /// C3 RAM Light 1
        /// </summary>
        [Description("C3 RAM Light 1")]
        C3RAMLIGHT1 = 1716,

        /// <summary>
        /// C3 RAM Light 2
        /// </summary>
        [Description("C3 RAM Light 2")]
        C3RAMLIGHT2 = 1717,

        /// <summary>
        /// C3 RAM Light 3
        /// </summary>
        [Description("C3 RAM Light 3")]
        C3RAMLIGHT3 = 1718,

        /// <summary>
        /// C3 RAM Light 4
        /// </summary>
        [Description("C3 RAM Light 4")]
        C3RAMLIGHT4 = 1719,

        /// <summary>
        /// C3 RAM Light 5
        /// </summary>
        [Description("C3 RAM Light 5")]
        C3RAMLIGHT5 = 1720,

        //////////////////////////////////////////////   HUELIGHTS begin here 
        //////////////////////////////////////////////   "HUELIGHTS" Range is 1901 - 1950
        //////////////////////////////////////////////   Added up to 5 HUE Lights (Various)

        /// <summary>
        /// HUE Light 1
        /// </summary>
        [Description("HUE Light 1")]
        HUELIGHT1 = 1901,

        /// <summary>
        /// HUE Light 2
        /// </summary>
        [Description("HUE Light 2")]
        HUELIGHT2 = 1902,

        /// <summary>
        /// HUE Light 3
        /// </summary>
        [Description("HUE Light 3")]
        HUELIGHT3 = 1903,

        /// <summary>
        /// HUE Light 4
        /// </summary>
        [Description("HUE Light 4")]
        HUELIGHT4 = 1904,

        /// <summary>
        /// HUE Light 5
        /// </summary>
        [Description("HUE Light 5")]
        HUELIGHT5 = 1905,

        //////////////////////////////////////////////   LEDLIGHTS begin here 
        //////////////////////////////////////////////   LEDLIGHTS Range 2001 - 3000 (1000 Leds) 
        //////////////////////////////////////////////   Added up to 400 LEDLIGHTS for 3 Devices (2x2 Zone + 1x3 Zone)

        //////////////////////////////////////////////   Adding First NZXT HUE PLUS (2 Zones)
        //////////////////////////////////////////////   First Zone (32, Channel 0 Lights)

        /// <summary>
        /// C0 Led Light 1
        /// </summary>
        [Description("C0 Led Light 1")]
        C0LEDLIGHT1 = 2001,

        /// <summary>
        /// C0 Led Light 2
        /// </summary>
        [Description("C0 Led Light 2")]
        C0LEDLIGHT2 = 2002,

        /// <summary>
        /// C0 Led Light 3
        /// </summary>
        [Description("C0 Led Light 3")]
        C0LEDLIGHT3 = 2003,

        /// <summary>
        /// C0 Led Light 4
        /// </summary>
        [Description("C0 Led Light 4")]
        C0LEDLIGHT4 = 2004,

        /// <summary>
        /// C0 Led Light 5
        /// </summary>
        [Description("C0 Led Light 5")]
        C0LEDLIGHT5 = 2005,

        /// <summary>
        /// C0 Led Light 6
        /// </summary>
        [Description("C0 Led Light 6")]
        C0LEDLIGHT6 = 2006,

        /// <summary>
        /// C0 Led Light 7
        /// </summary>
        [Description("C0 Led Light 7")]
        C0LEDLIGHT7 = 2007,

        /// <summary>
        /// C0 Led Light 8
        /// </summary>
        [Description("C0 Led Light 8")]
        C0LEDLIGHT8 = 2008,

        /// <summary>
        /// C0 Led Light 9
        /// </summary>
        [Description("C0 Led Light 9")]
        C0LEDLIGHT9 = 2009,

        /// <summary>
        /// C0 Led Light 10
        /// </summary>
        [Description("C0 Led Light 10")]
        C0LEDLIGHT10 = 2010,

        /// <summary>
        /// C0 Led Light 11
        /// </summary>
        [Description("C0 Led Light 11")]
        C0LEDLIGHT11 = 2011,

        /// <summary>
        /// C0 Led Light 12
        /// </summary>
        [Description("C0 Led Light 12")]
        C0LEDLIGHT12 = 2012,

        /// <summary>
        /// C0 Led Light 13
        /// </summary>
        [Description("C0 Led Light 13")]
        C0LEDLIGHT13 = 2013,
 
        /// <summary>
        /// C0 Led Light 14
        /// </summary>
        [Description("C0 Led Light 14")]
        C0LEDLIGHT14 = 2014,
 
        /// <summary>
        /// C0 Led Light 15
        /// </summary>
        [Description("C0 Led Light 15")]
        C0LEDLIGHT15 = 2015,
 
        /// <summary>
        /// C0 Led Light 16
        /// </summary>
        [Description("C0 Led Light 16")]
        C0LEDLIGHT16 = 2016,
 
        /// <summary>
        /// C0 Led Light 17
        /// </summary>
        [Description("C0 Led Light 17")]
        C0LEDLIGHT17 = 2017,

        /// <summary>
        /// C0 Led Light 18
        /// </summary>
        [Description("C0 Led Light 18")]
        C0LEDLIGHT18 = 2018,

        /// <summary>
        /// C0 Led Light 19
        /// </summary>
        [Description("C0 Led Light 19")]
        C0LEDLIGHT19 = 2019,

        /// <summary>
        /// C0 Led Light 20
        /// </summary>
        [Description("C0 Led Light 20")]
        C0LEDLIGHT20 = 2020,

        /// <summary>
        /// C0 Led Light 21
        /// </summary>
        [Description("C0 Led Light 21")]
        C0LEDLIGHT21 = 2021,

        /// <summary>
        /// C0 Led Light 22
        /// </summary>
        [Description("C0 Led Light 22")]
        C0LEDLIGHT22 = 2022,

        /// <summary>
        /// C0 Led Light 23
        /// </summary>
        [Description("C0 Led Light 23")]
        C0LEDLIGHT23 = 2023,

        /// <summary>
        /// C0 Led Light 24
        /// </summary>
        [Description("C0 Led Light 24")]
        C0LEDLIGHT24 = 2024,

        /// <summary>
        /// C0 Led Light 25
        /// </summary>
        [Description("C0 Led Light 25")]
        C0LEDLIGHT25 = 2025,

        /// <summary>
        /// C0 Led Light 26
        /// </summary>
        [Description("C0 Led Light 26")]
        C0LEDLIGHT26 = 2026,

        /// <summary>
        /// C0 Led Light 27
        /// </summary>
        [Description("C0 Led Light 27")]
        C0LEDLIGHT27 = 2027,

        /// <summary>
        /// C0 Led Light 28
        /// </summary>
        [Description("C0 Led Light 28")]
        C0LEDLIGHT28 = 2028,

        /// <summary>
        /// C0 Led Light 29
        /// </summary>
        [Description("C0 Led Light 29")]
        C0LEDLIGHT29 = 2029,

        /// <summary>
        /// C0 Led Light 30
        /// </summary>
        [Description("C0 Led Light 30")]
        C0LEDLIGHT30 = 2030,

        /// <summary>
        /// C0 Led Light 31
        /// </summary>
        [Description("C0 Led Light 31")]
        C0LEDLIGHT31 = 2031,

        /// <summary>
        /// C0 Led Light 32
        /// </summary>
        [Description("C0 Led Light 32")]
        C0LEDLIGHT32 = 2032,

        /// <summary>
        /// C0 Led Light 33
        /// </summary>
        [Description("C0 Led Light 33")]
        C0LEDLIGHT33 = 2033,

        /// <summary>
        /// C0 Led Light 34
        /// </summary>
        [Description("C0 Led Light 34")]
        C0LEDLIGHT34 = 2034,

        /// <summary>
        /// C0 Led Light 35
        /// </summary>
        [Description("C0 Led Light 35")]
        C0LEDLIGHT35 = 2035,

        /// <summary>
        /// C0 Led Light 36
        /// </summary>
        [Description("C0 Led Light 36")]
        C0LEDLIGHT36 = 2036,

        /// <summary>
        /// C0 Led Light 37
        /// </summary>
        [Description("C0 Led Light 37")]
        C0LEDLIGHT37 = 2037,

        /// <summary>
        /// C0 Led Light 38
        /// </summary>
        [Description("C0 Led Light 38")]
        C0LEDLIGHT38 = 2038,

        /// <summary>
        /// C0 Led Light 39
        /// </summary>
        [Description("C0 Led Light 39")]
        C0LEDLIGHT39 = 2039,

        /// <summary>
        /// C0 Led Light 40
        /// </summary>
        [Description("C0 Led Light 40")]
        C0LEDLIGHT40 = 2040,

        /// <summary>
        /// C0 Led Light 41
        /// </summary>
        [Description("C0 Led Light 41")]
        C0LEDLIGHT41 = 2041,

        /// <summary>
        /// C0 Led Light 42
        /// </summary>
        [Description("C0 Led Light 42")]
        C0LEDLIGHT42 = 2042,

        /// <summary>
        /// C0 Led Light 43
        /// </summary>
        [Description("C0 Led Light 43")]
        C0LEDLIGHT43 = 2043,

        /// <summary>
        /// C0 Led Light 44
        /// </summary>
        [Description("C0 Led Light 44")]
        C0LEDLIGHT44 = 2044,

        /// <summary>
        /// C0 Led Light 45
        /// </summary>
        [Description("C0 Led Light 45")]
        C0LEDLIGHT45 = 2045,

        /// <summary>
        /// C0 Led Light 46
        /// </summary>
        [Description("C0 Led Light 46")]
        C0LEDLIGHT46 = 2046,

        /// <summary>
        /// C0 Led Light 47
        /// </summary>
        [Description("C0 Led Light 47")]
        C0LEDLIGHT47 = 2047,

        /// <summary>
        /// C0 Led Light 48
        /// </summary>
        [Description("C0 Led Light 48")]
        C0LEDLIGHT48 = 2048,

        /// <summary>
        /// C0 Led Light 49
        /// </summary>
        [Description("C0 Led Light 49")]
        C0LEDLIGHT49 = 2049,

        /// <summary>
        /// C0 Led Light 50
        /// </summary>
        [Description("C0 Led Light 50")]
        C0LEDLIGHT50 = 2050,

        /// <summary>
        /// C0 Led Light 51
        /// </summary>
        [Description("C0 Led Light 51")]
        C0LEDLIGHT51 = 2051,

        /// <summary>
        /// C0 Led Light 52
        /// </summary>
        [Description("C0 Led Light 52")]
        C0LEDLIGHT52 = 2052,

        /// <summary>
        /// C0 Led Light 53
        /// </summary>
        [Description("C0 Led Light 53")]
        C0LEDLIGHT53 = 2053,

        /// <summary>
        /// C0 Led Light 54
        /// </summary>
        [Description("C0 Led Light 54")]
        C0LEDLIGHT54 = 2054,

        /// <summary>
        /// C0 Led Light 55
        /// </summary>
        [Description("C0 Led Light 55")]
        C0LEDLIGHT55 = 2055,

        /// <summary>
        /// C0 Led Light 56
        /// </summary>
        [Description("C0 Led Light 56")]
        C0LEDLIGHT56 = 2056,

        /// <summary>
        /// C0 Led Light 57
        /// </summary>
        [Description("C0 Led Light 57")]
        C0LEDLIGHT57 = 2057,

        /// <summary>
        /// C0 Led Light 58
        /// </summary>
        [Description("C0 Led Light 58")]
        C0LEDLIGHT58 = 2058,

        /// <summary>
        /// C0 Led Light 59
        /// </summary>
        [Description("C0 Led Light 59")]
        C0LEDLIGHT59 = 2059,

        /// <summary>
        /// C0 Led Light 60
        /// </summary>
        [Description("C0 Led Light 60")]
        C0LEDLIGHT60 = 2060,

        /// <summary>
        /// C0 Led Light 61
        /// </summary>
        [Description("C0 Led Light 61")]
        C0LEDLIGHT61 = 2061,

        /// <summary>
        /// C0 Led Light 62
        /// </summary>
        [Description("C0 Led Light 62")]
        C0LEDLIGHT62 = 2062,

        /// <summary>
        /// C0 Led Light 63
        /// </summary>
        [Description("C0 Led Light 63")]
        C0LEDLIGHT63 = 2063,

        /// <summary>
        /// C0 Led Light 64
        /// </summary>
        [Description("C0 Led Light 64")]
        C0LEDLIGHT64 = 2064,

        /// <summary>
        /// C0 Led Light 65
        /// </summary>
        [Description("C0 Led Light 65")]
        C0LEDLIGHT65 = 2065,

        /// <summary>
        /// C0 Led Light 66
        /// </summary>
        [Description("C0 Led Light 66")]
        C0LEDLIGHT66 = 2066,

        /// <summary>
        /// C0 Led Light 67
        /// </summary>
        [Description("C0 Led Light 67")]
        C0LEDLIGHT67 = 2067,

        /// <summary>
        /// C0 Led Light 68
        /// </summary>
        [Description("C0 Led Light 68")]
        C0LEDLIGHT68 = 2068,

        /// <summary>
        /// C0 Led Light 69
        /// </summary>
        [Description("C0 Led Light 69")]
        C0LEDLIGHT69 = 2069,

        /// <summary>
        /// C0 Led Light 70
        /// </summary>
        [Description("C0 Led Light 70")]
        C0LEDLIGHT70 = 2070,

        /// <summary>
        /// C0 Led Light 71
        /// </summary>
        [Description("C0 Led Light 71")]
        C0LEDLIGHT71 = 2071,

        /// <summary>
        /// C0 Led Light 72
        /// </summary>
        [Description("C0 Led Light 72")]
        C0LEDLIGHT72 = 2072,

        /// <summary>
        /// C0 Led Light 73
        /// </summary>
        [Description("C0 Led Light 73")]
        C0LEDLIGHT73 = 2073,

        /// <summary>
        /// C0 Led Light 74
        /// </summary>
        [Description("C0 Led Light 74")]
        C0LEDLIGHT74 = 2074,

        /// <summary>
        /// C0 Led Light 75
        /// </summary>
        [Description("C0 Led Light 75")]
        C0LEDLIGHT75 = 2075,

        /// <summary>
        /// C0 Led Light 76
        /// </summary>
        [Description("C0 Led Light 76")]
        C0LEDLIGHT76 = 2076,

        /// <summary>
        /// C0 Led Light 77
        /// </summary>
        [Description("C0 Led Light 77")]
        C0LEDLIGHT77 = 2077,

        /// <summary>
        /// C0 Led Light 78
        /// </summary>
        [Description("C0 Led Light 78")]
        C0LEDLIGHT78 = 2078,

        /// <summary>
        /// C0 Led Light 79
        /// </summary>
        [Description("C0 Led Light 79")]
        C0LEDLIGHT79 = 2079,

        /// <summary>
        /// C0 Led Light 80
        /// </summary>
        [Description("C0 Led Light 80")]
        C0LEDLIGHT80 = 2080,

        /// <summary>
        /// C0 Led Light 81
        /// </summary>
        [Description("C0 Led Light 81")]
        C0LEDLIGHT81 = 2081,

        /// <summary>
        /// C0 Led Light 82
        /// </summary>
        [Description("C0 Led Light 82")]
        C0LEDLIGHT82 = 2082,

        /// <summary>
        /// C0 Led Light 83
        /// </summary>
        [Description("C0 Led Light 83")]
        C0LEDLIGHT83 = 2083,

        /// <summary>
        /// C0 Led Light 84
        /// </summary>
        [Description("C0 Led Light 84")]
        C0LEDLIGHT84 = 2084,

        /// <summary>
        /// C0 Led Light 85
        /// </summary>
        [Description("C0 Led Light 85")]
        C0LEDLIGHT85 = 2085,

        /// <summary>
        /// C0 Led Light 86
        /// </summary>
        [Description("C0 Led Light 86")]
        C0LEDLIGHT86 = 2086,

        /// <summary>
        /// C0 Led Light 87
        /// </summary>
        [Description("C0 Led Light 87")]
        C0LEDLIGHT87 = 2087,

        /// <summary>
        /// C0 Led Light 88
        /// </summary>
        [Description("C0 Led Light 88")]
        C0LEDLIGHT88 = 2088,

        /// <summary>
        /// C0 Led Light 89
        /// </summary>
        [Description("C0 Led Light 89")]
        C0LEDLIGHT89 = 2089,

        /// <summary>
        /// C0 Led Light 90
        /// </summary>
        [Description("C0 Led Light 90")]
        C0LEDLIGHT90 = 2090,

        /// <summary>
        /// C0 Led Light 91
        /// </summary>
        [Description("C0 Led Light 91")]
        C0LEDLIGHT91 = 2091,

        /// <summary>
        /// C0 Led Light 92
        /// </summary>
        [Description("C0 Led Light 92")]
        C0LEDLIGHT92 = 2092,

        /// <summary>
        /// C0 Led Light 93
        /// </summary>
        [Description("C0 Led Light 93")]
        C0LEDLIGHT93 = 2093,

        /// <summary>
        /// C0 Led Light 94
        /// </summary>
        [Description("C0 Led Light 94")]
        C0LEDLIGHT94 = 2094,

        /// <summary>
        /// C0 Led Light 95
        /// </summary>
        [Description("C0 Led Light 95")]
        C0LEDLIGHT95 = 2095,

        /// <summary>
        /// C0 Led Light 96
        /// </summary>
        [Description("C0 Led Light 96")]
        C0LEDLIGHT96 = 2096,

        /// <summary>
        /// C0 Led Light 97
        /// </summary>
        [Description("C0 Led Light 97")]
        C0LEDLIGHT97 = 2097,

        /// <summary>
        /// C0 Led Light 98
        /// </summary>
        [Description("C0 Led Light 98")]
        C0LEDLIGHT98 = 2098,

        /// <summary>
        /// C0 Led Light 99
        /// </summary>
        [Description("C0 Led Light 99")]
        C0LEDLIGHT99 = 2099,

        /// <summary>
        /// C0 Led Light 100
        /// </summary>
        [Description("C0 Led Light 100")]
        C0LEDLIGHT100 = 2100,

        //////////////////////////////////////////////   Second Zone (32, Channel 1 Lights)

        /// <summary>
        /// C1 Led Light 1
        /// </summary>
        [Description("C1 Led Light 1")]
        C1LEDLIGHT1 = 2101,

        /// <summary>
        /// C1 Led Light 2
        /// </summary>
        [Description("C1 Led Light 2")]
        C1LEDLIGHT2 = 2102,

        /// <summary>
        /// C1 Led Light 3
        /// </summary>
        [Description("C1 Led Light 3")]
        C1LEDLIGHT3 = 2103,

        /// <summary>
        /// C1 Led Light 4
        /// </summary>
        [Description("C1 Led Light 4")]
        C1LEDLIGHT4 = 2104,

        /// <summary>
        /// C1 Led Light 5
        /// </summary>
        [Description("C1 Led Light 5")]
        C1LEDLIGHT5 = 2105,

        /// <summary>
        /// C1 Led Light 6
        /// </summary>
        [Description("C1 Led Light 6")]
        C1LEDLIGHT6 = 2106,

        /// <summary>
        /// C1 Led Light 7
        /// </summary>
        [Description("C1 Led Light 7")]
        C1LEDLIGHT7 = 2107,

        /// <summary>
        /// C1 Led Light 8
        /// </summary>
        [Description("C1 Led Light 8")]
        C1LEDLIGHT8 = 2108,

        /// <summary>
        /// C1 Led Light 9
        /// </summary>
        [Description("C1 Led Light 9")]
        C1LEDLIGHT9 = 2109,

        /// <summary>
        /// C1 Led Light 10
        /// </summary>
        [Description("C1 Led Light 10")]
        C1LEDLIGHT10 = 2110,

        /// <summary>
        /// C1 Led Light 11
        /// </summary>
        [Description("C1 Led Light 11")]
        C1LEDLIGHT11 = 2111,

        /// <summary>
        /// C1 Led Light 12
        /// </summary>
        [Description("C1 Led Light 12")]
        C1LEDLIGHT12 = 2112,

        /// <summary>
        /// C1 Led Light 13
        /// </summary>
        [Description("C1 Led Light 13")]
        C1LEDLIGHT13 = 2113,

        /// <summary>
        /// C1 Led Light 14
        /// </summary>
        [Description("C1 Led Light 14")]
        C1LEDLIGHT14 = 2114,

        /// <summary>
        /// C1 Led Light 15
        /// </summary>
        [Description("C1 Led Light 15")]
        C1LEDLIGHT15 = 2115,

        /// <summary>
        /// C1 Led Light 16
        /// </summary>
        [Description("C1 Led Light 16")]
        C1LEDLIGHT16 = 2116,

        /// <summary>
        /// C1 Led Light 17
        /// </summary>
        [Description("C1 Led Light 17")]
        C1LEDLIGHT17 = 2117,

        /// <summary>
        /// C1 Led Light 18
        /// </summary>
        [Description("C1 Led Light 18")]
        C1LEDLIGHT18 = 2118,

        /// <summary>
        /// C1 Led Light 19
        /// </summary>
        [Description("C1 Led Light 19")]
        C1LEDLIGHT19 = 2119,

        /// <summary>
        /// C1 Led Light 20
        /// </summary>
        [Description("C1 Led Light 20")]
        C1LEDLIGHT20 = 2120,

        /// <summary>
        /// C1 Led Light 21
        /// </summary>
        [Description("C1 Led Light 21")]
        C1LEDLIGHT21 = 2121,

        /// <summary>
        /// C1 Led Light 22
        /// </summary>
        [Description("C1 Led Light 22")]
        C1LEDLIGHT22 = 2122,

        /// <summary>
        /// C1 Led Light 23
        /// </summary>
        [Description("C1 Led Light 23")]
        C1LEDLIGHT23 = 2123,

        /// <summary>
        /// C1 Led Light 24
        /// </summary>
        [Description("C1 Led Light 24")]
        C1LEDLIGHT24 = 2124,

        /// <summary>
        /// C1 Led Light 25
        /// </summary>
        [Description("C1 Led Light 25")]
        C1LEDLIGHT25 = 2125,

        /// <summary>
        /// C1 Led Light 26
        /// </summary>
        [Description("C1 Led Light 26")]
        C1LEDLIGHT26 = 2126,

        /// <summary>
        /// C1 Led Light 27
        /// </summary>
        [Description("C1 Led Light 27")]
        C1LEDLIGHT27 = 2127,

        /// <summary>
        /// C1 Led Light 28
        /// </summary>
        [Description("C1 Led Light 28")]
        C1LEDLIGHT28 = 2128,

        /// <summary>
        /// C1 Led Light 29
        /// </summary>
        [Description("C1 Led Light 29")]
        C1LEDLIGHT29 = 2129,

        /// <summary>
        /// C1 Led Light 30
        /// </summary>
        [Description("C1 Led Light 30")]
        C1LEDLIGHT30 = 2130,

        /// <summary>
        /// C1 Led Light 31
        /// </summary>
        [Description("C1 Led Light 31")]
        C1LEDLIGHT31 = 2131,

        /// <summary>
        /// C1 Led Light 32
        /// </summary>
        [Description("C1 Led Light 32")]
        C1LEDLIGHT32 = 2132,

        /// <summary>
        /// C1 Led Light 33
        /// </summary>
        [Description("C1 Led Light 33")]
        C1LEDLIGHT33 = 2133,

        /// <summary>
        /// C1 Led Light 34
        /// </summary>
        [Description("C1 Led Light 34")]
        C1LEDLIGHT34 = 2134,

        /// <summary>
        /// C1 Led Light 35
        /// </summary>
        [Description("C1 Led Light 35")]
        C1LEDLIGHT35 = 2135,

        /// <summary>
        /// C1 Led Light 36
        /// </summary>
        [Description("C1 Led Light 36")]
        C1LEDLIGHT36 = 2136,

        /// <summary>
        /// C1 Led Light 37
        /// </summary>
        [Description("C1 Led Light 37")]
        C1LEDLIGHT37 = 2137,

        /// <summary>
        /// C1 Led Light 38
        /// </summary>
        [Description("C1 Led Light 38")]
        C1LEDLIGHT38 = 2138,

        /// <summary>
        /// C1 Led Light 39
        /// </summary>
        [Description("C1 Led Light 39")]
        C1LEDLIGHT39 = 2139,

        /// <summary>
        /// C1 Led Light 40
        /// </summary>
        [Description("C1 Led Light 40")]
        C1LEDLIGHT40 = 2140,

        //////////////////////////////////////////////   Adding Second NZXT HUE PLUS (2 Zones)
        //////////////////////////////////////////////   First Zone (40, Channel 2 Lights)

        /// <summary>
        /// C2 Led Light 1
        /// </summary>
        [Description("C2 Led Light 1")]
        C2LEDLIGHT1 = 2201,

        /// <summary>
        /// C2 Led Light 2
        /// </summary>
        [Description("C2 Led Light 2")]
        C2LEDLIGHT2 = 2202,

        /// <summary>
        /// C2 Led Light 3
        /// </summary>
        [Description("C2 Led Light 3")]
        C2LEDLIGHT3 = 2203,

        /// <summary>
        /// C2 Led Light 4
        /// </summary>
        [Description("C2 Led Light 4")]
        C2LEDLIGHT4 = 2204,

        /// <summary>
        /// C2 Led Light 5
        /// </summary>
        [Description("C2 Led Light 5")]
        C2LEDLIGHT5 = 2205,

        /// <summary>
        /// C2 Led Light 6
        /// </summary>
        [Description("C2 Led Light 6")]
        C2LEDLIGHT6 = 2206,

        /// <summary>
        /// C2 Led Light 7
        /// </summary>
        [Description("C2 Led Light 7")]
        C2LEDLIGHT7 = 2207,

        /// <summary>
        /// C2 Led Light 8
        /// </summary>
        [Description("C2 Led Light 8")]
        C2LEDLIGHT8 = 2208,

        /// <summary>
        /// C2 Led Light 9
        /// </summary>
        [Description("C2 Led Light 9")]
        C2LEDLIGHT9 = 2209,

        /// <summary>
        /// C2 Led Light 10
        /// </summary>
        [Description("C2 Led Light 10")]
        C2LEDLIGHT10 = 2210,

        /// <summary>
        /// C2 Led Light 11
        /// </summary>
        [Description("C2 Led Light 11")]
        C2LEDLIGHT11 = 2211,

        /// <summary>
        /// C2 Led Light 12
        /// </summary>
        [Description("C2 Led Light 12")]
        C2LEDLIGHT12 = 2212,

        /// <summary>
        /// C2 Led Light 13
        /// </summary>
        [Description("C2 Led Light 13")]
        C2LEDLIGHT13 = 2213,

        /// <summary>
        /// C2 Led Light 14
        /// </summary>
        [Description("C2 Led Light 14")]
        C2LEDLIGHT14 = 2214,

        /// <summary>
        /// C2 Led Light 15
        /// </summary>
        [Description("C2 Led Light 15")]
        C2LEDLIGHT15 = 2215,

        /// <summary>
        /// C2 Led Light 16
        /// </summary>
        [Description("C2 Led Light 16")]
        C2LEDLIGHT16 = 2216,

        /// <summary>
        /// C2 Led Light 17
        /// </summary>
        [Description("C2 Led Light 17")]
        C2LEDLIGHT17 = 2217,

        /// <summary>
        /// C2 Led Light 18
        /// </summary>
        [Description("C2 Led Light 18")]
        C2LEDLIGHT18 = 2218,

        /// <summary>
        /// C2 Led Light 19
        /// </summary>
        [Description("C2 Led Light 19")]
        C2LEDLIGHT19 = 2219,

        /// <summary>
        /// C2 Led Light 20
        /// </summary>
        [Description("C2 Led Light 20")]
        C2LEDLIGHT20 = 2220,

        /// <summary>
        /// C2 Led Light 21
        /// </summary>
        [Description("C2 Led Light 21")]
        C2LEDLIGHT21 = 2221,

        /// <summary>
        /// C2 Led Light 22
        /// </summary>
        [Description("C2 Led Light 22")]
        C2LEDLIGHT22 = 2222,

        /// <summary>
        /// C2 Led Light 23
        /// </summary>
        [Description("C2 Led Light 23")]
        C2LEDLIGHT23 = 2223,

        /// <summary>
        /// C2 Led Light 24
        /// </summary>
        [Description("C2 Led Light 24")]
        C2LEDLIGHT24 = 2224,

        /// <summary>
        /// C2 Led Light 25
        /// </summary>
        [Description("C2 Led Light 25")]
        C2LEDLIGHT25 = 2225,

        /// <summary>
        /// C2 Led Light 26
        /// </summary>
        [Description("C2 Led Light 26")]
        C2LEDLIGHT26 = 2226,

        /// <summary>
        /// C2 Led Light 27
        /// </summary>
        [Description("C2 Led Light 27")]
        C2LEDLIGHT27 = 2227,

        /// <summary>
        /// C2 Led Light 28
        /// </summary>
        [Description("C2 Led Light 28")]
        C2LEDLIGHT28 = 2228,

        /// <summary>
        /// C2 Led Light 29
        /// </summary>
        [Description("C2 Led Light 29")]
        C2LEDLIGHT29 = 2229,

        /// <summary>
        /// C2 Led Light 30
        /// </summary>
        [Description("C2 Led Light 30")]
        C2LEDLIGHT30 = 2230,

        /// <summary>
        /// C2 Led Light 31
        /// </summary>
        [Description("C2 Led Light 31")]
        C2LEDLIGHT31 = 2231,

        /// <summary>
        /// C2 Led Light 32
        /// </summary>
        [Description("C2 Led Light 32")]
        C2LEDLIGHT32 = 2232,

        /// <summary>
        /// C2 Led Light 33
        /// </summary>
        [Description("C2 Led Light 33")]
        C2LEDLIGHT33 = 2233,

        /// <summary>
        /// C2 Led Light 34
        /// </summary>
        [Description("C2 Led Light 34")]
        C2LEDLIGHT34 = 2234,

        /// <summary>
        /// C2 Led Light 35
        /// </summary>
        [Description("C2 Led Light 35")]
        C2LEDLIGHT35 = 2235,

        /// <summary>
        /// C2 Led Light 36
        /// </summary>
        [Description("C2 Led Light 36")]
        C2LEDLIGHT36 = 2236,

        /// <summary>
        /// C2 Led Light 37
        /// </summary>
        [Description("C2 Led Light 37")]
        C2LEDLIGHT37 = 2237,

        /// <summary>
        /// C2 Led Light 38
        /// </summary>
        [Description("C2 Led Light 38")]
        C2LEDLIGHT38 = 2238,

        /// <summary>
        /// C2 Led Light 39
        /// </summary>
        [Description("C2 Led Light 39")]
        C2LEDLIGHT39 = 2239,

        /// <summary>
        /// C2 Led Light 40
        /// </summary>
        [Description("C2 Led Light 40")]
        C2LEDLIGHT40 = 2240,

        //////////////////////////////////////////////   Second Zone (40, Channel 3 Lights)

        /// <summary>
        /// C3 Led Light 1
        /// </summary>
        [Description("C3 Led Light 1")]
        C3LEDLIGHT1 = 2301,

        /// <summary>
        /// C3 Led Light 2
        /// </summary>
        [Description("C3 Led Light 2")]
        C3LEDLIGHT2 = 2302,

        /// <summary>
        /// C3 Led Light 3
        /// </summary>
        [Description("C3 Led Light 3")]
        C3LEDLIGHT3 = 2303,

        /// <summary>
        /// C3 Led Light 4
        /// </summary>
        [Description("C3 Led Light 4")]
        C3LEDLIGHT4 = 2304,

        /// <summary>
        /// C3 Led Light 5
        /// </summary>
        [Description("C3 Led Light 5")]
        C3LEDLIGHT5 = 2305,

        /// <summary>
        /// C3 Led Light 6
        /// </summary>
        [Description("C3 Led Light 6")]
        C3LEDLIGHT6 = 2306,

        /// <summary>
        /// C3 Led Light 7
        /// </summary>
        [Description("C3 Led Light 7")]
        C3LEDLIGHT7 = 2307,

        /// <summary>
        /// C3 Led Light 8
        /// </summary>
        [Description("C3 Led Light 8")]
        C3LEDLIGHT8 = 2308,

        /// <summary>
        /// C3 Led Light 9
        /// </summary>
        [Description("C3 Led Light 9")]
        C3LEDLIGHT9 = 2309,

        /// <summary>
        /// C3 Led Light 10
        /// </summary>
        [Description("C3 Led Light 10")]
        C3LEDLIGHT10 = 2310,

        /// <summary>
        /// C3 Led Light 11
        /// </summary>
        [Description("C3 Led Light 11")]
        C3LEDLIGHT11 = 2311,

        /// <summary>
        /// C3 Led Light 12
        /// </summary>
        [Description("C3 Led Light 12")]
        C3LEDLIGHT12 = 2312,

        /// <summary>
        /// C3 Led Light 13
        /// </summary>
        [Description("C3 Led Light 13")]
        C3LEDLIGHT13 = 2313,

        /// <summary>
        /// C3 Led Light 14
        /// </summary>
        [Description("C3 Led Light 14")]
        C3LEDLIGHT14 = 2314,

        /// <summary>
        /// C3 Led Light 15
        /// </summary>
        [Description("C3 Led Light 15")]
        C3LEDLIGHT15 = 2315,

        /// <summary>
        /// C3 Led Light 16
        /// </summary>
        [Description("C3 Led Light 16")]
        C3LEDLIGHT16 = 2316,

        /// <summary>
        /// C3 Led Light 17
        /// </summary>
        [Description("C3 Led Light 17")]
        C3LEDLIGHT17 = 2317,

        /// <summary>
        /// C3 Led Light 18
        /// </summary>
        [Description("C3 Led Light 18")]
        C3LEDLIGHT18 = 2318,

        /// <summary>
        /// C3 Led Light 19
        /// </summary>
        [Description("C3 Led Light 19")]
        C3LEDLIGHT19 = 2319,

        /// <summary>
        /// C3 Led Light 20
        /// </summary>
        [Description("C3 Led Light 20")]
        C3LEDLIGHT20 = 2320,

        /// <summary>
        /// C3 Led Light 21
        /// </summary>
        [Description("C3 Led Light 21")]
        C3LEDLIGHT21 = 2321,

        /// <summary>
        /// C3 Led Light 22
        /// </summary>
        [Description("C3 Led Light 22")]
        C3LEDLIGHT22 = 2322,

        /// <summary>
        /// C3 Led Light 23
        /// </summary>
        [Description("C3 Led Light 23")]
        C3LEDLIGHT23 = 2323,

        /// <summary>
        /// C3 Led Light 24
        /// </summary>
        [Description("C3 Led Light 24")]
        C3LEDLIGHT24 = 2324,

        /// <summary>
        /// C3 Led Light 25
        /// </summary>
        [Description("C3 Led Light 25")]
        C3LEDLIGHT25 = 2325,

        /// <summary>
        /// C3 Led Light 26
        /// </summary>
        [Description("C3 Led Light 26")]
        C3LEDLIGHT26 = 2326,

        /// <summary>
        /// C3 Led Light 27
        /// </summary>
        [Description("C3 Led Light 27")]
        C3LEDLIGHT27 = 2327,

        /// <summary>
        /// C3 Led Light 28
        /// </summary>
        [Description("C3 Led Light 28")]
        C3LEDLIGHT28 = 2328,

        /// <summary>
        /// C3 Led Light 29
        /// </summary>
        [Description("C3 Led Light 29")]
        C3LEDLIGHT29 = 2329,

        /// <summary>
        /// C3 Led Light 30
        /// </summary>
        [Description("C3 Led Light 30")]
        C3LEDLIGHT30 = 2330,

        /// <summary>
        /// C3 Led Light 31
        /// </summary>
        [Description("C3 Led Light 31")]
        C3LEDLIGHT31 = 2331,

        /// <summary>
        /// C3 Led Light 32
        /// </summary>
        [Description("C3 Led Light 32")]
        C3LEDLIGHT32 = 2332,

        /// <summary>
        /// C3 Led Light 33
        /// </summary>
        [Description("C3 Led Light 33")]
        C3LEDLIGHT33 = 2333,

        /// <summary>
        /// C3 Led Light 34
        /// </summary>
        [Description("C3 Led Light 34")]
        C3LEDLIGHT34 = 2334,

        /// <summary>
        /// C3 Led Light 35
        /// </summary>
        [Description("C3 Led Light 35")]
        C3LEDLIGHT35 = 2335,

        /// <summary>
        /// C3 Led Light 36
        /// </summary>
        [Description("C3 Led Light 36")]
        C3LEDLIGHT36 = 2336,

        /// <summary>
        /// C3 Led Light 37
        /// </summary>
        [Description("C3 Led Light 37")]
        C3LEDLIGHT37 = 2337,

        /// <summary>
        /// C3 Led Light 38
        /// </summary>
        [Description("C3 Led Light 38")]
        C3LEDLIGHT38 = 2338,

        /// <summary>
        /// C3 Led Light 39
        /// </summary>
        [Description("C3 Led Light 39")]
        C3LEDLIGHT39 = 2339,

        /// <summary>
        /// C3 Led Light 40
        /// </summary>
        [Description("C3 Led Light 40")]
        C3LEDLIGHT40 = 2340,

        //////////////////////////////////////////////   Adding E1.31 Devices (4 Zones)
        //////////////////////////////////////////////   First Zone (70, Channel 4 Lights)(Monitor Mitte)

        /// <summary>
        /// C4 Led Light 1
        /// </summary>
        [Description("C4 Led Light 1")]
        C4LEDLIGHT1 = 2401,

        /// <summary>
        /// C4 Led Light 10
        /// </summary>
        [Description("C4 Led Light 10")]
        C4LEDLIGHT10 = 2410,

        /// <summary>
        /// C4 Led Light 26
        /// </summary>
        [Description("C4 Led Light 26")]
        C4LEDLIGHT26 = 2426,

        /// <summary>
        /// C4 Led Light 35
        /// </summary>
        [Description("C4 Led Light 35")]
        C4LEDLIGHT35 = 2435,

        //////////////////////////////////////////////   Second Zone (70, Channel 5 Lights)(Monitor Links)

        /// <summary>
        /// C5 Led Light 1
        /// </summary>
        [Description("C5 Led Light 1")]
        C5LEDLIGHT1 = 2501,

        /// <summary>
        /// C5 Led Light 10
        /// </summary>
        [Description("C5 Led Light 10")]
        C5LEDLIGHT10 = 2510,

        /// <summary>
        /// C5 Led Light 26
        /// </summary>
        [Description("C5 Led Light 26")]
        C5LEDLIGHT26 = 2526,

        /// <summary>
        /// C5 Led Light 35
        /// </summary>
        [Description("C5 Led Light 35")]
        C5LEDLIGHT35 = 2535,

        //////////////////////////////////////////////   Third Zone (70, Channel 6 Lights)(Monitor Rechts)

        /// <summary>
        /// C6 Led Light 1
        /// </summary>
        [Description("C6 Led Light 1")]
        C6LEDLIGHT1 = 2601,

        /// <summary>
        /// C6 Led Light 10
        /// </summary>
        [Description("C6 Led Light 10")]
        C6LEDLIGHT10 = 2610,

        /// <summary>
        /// C6 Led Light 26
        /// </summary>
        [Description("C6 Led Light 26")]
        C6LEDLIGHT26 = 2626,

        /// <summary>
        /// C6 Led Light 35
        /// </summary>
        [Description("C6 Led Light 35")]
        C6LEDLIGHT35 = 2635,

        //////////////////////////////////////////////   Fourth Zone (100, Channel 7 Lights)(NEW DESK STRIP)

        /// <summary>
        /// C7 Led Light 1
        /// </summary>
        [Description("C7 Led Light 1")]
        C7LEDLIGHT1 = 2701,

        //////////////////////////////////////////////   Fifth Zone (100, Channel 8 Lights)(Various)

        /// <summary>
        /// C8 Led Light 1
        /// </summary>
        [Description("C8 Led Light 1")]
        C8LEDLIGHT1 = 2801,

        //////////////////////////////////////////////   Fifth Zone (100, Channel 9 Lights)(Various)

        /// <summary>
        /// C9 Led Light 1
        /// </summary>
        [Description("C9 Led Light 1")]
        C9LEDLIGHT1 = 2901,

        //////////////////////////////////////////////   Fifth Zone (100, Channel 10 Lights)(Various)

        /// <summary>
        /// C10 Led Light 1
        /// </summary>
        [Description("C10 Led Light 1")]
        C10LEDLIGHT1 = 3001,

        /// <summary>
        /// C10 Led Light 2
        /// </summary>
        [Description("C10 Led Light 2")]
        C10LEDLIGHT2 = 3002,

        /// <summary>
        /// C10 Led Light 3
        /// </summary>
        [Description("C10 Led Light 3")]
        C10LEDLIGHT3 = 3003,

        /// <summary>
        /// C10 Led Light 4
        /// </summary>
        [Description("C10 Led Light 4")]
        C10LEDLIGHT4 = 3004,

        /// <summary>
        /// C10 Led Light 5
        /// </summary>
        [Description("C10 Led Light 5")]
        C10LEDLIGHT5 = 3005,

        /// <summary>
        /// C10 Led Light 6
        /// </summary>
        [Description("C10 Led Light 6")]
        C10LEDLIGHT6 = 3006,

        /// <summary>
        /// C10 Led Light 7
        /// </summary>
        [Description("C10 Led Light 7")]
        C10LEDLIGHT7 = 3007,

        /// <summary>
        /// C10 Led Light 8
        /// </summary>
        [Description("C10 Led Light 8")]
        C10LEDLIGHT8 = 3008,

        /// <summary>
        /// C10 Led Light 9
        /// </summary>
        [Description("C10 Led Light 9")]
        C10LEDLIGHT9 = 3009,

        /// <summary>
        /// C10 Led Light 10
        /// </summary>
        [Description("C10 Led Light 10")]
        C10LEDLIGHT10 = 3010,

        /// <summary>
        /// C10 Led Light 11
        /// </summary>
        [Description("C10 Led Light 11")]
        C10LEDLIGHT11 = 3011,

        /// <summary>
        /// C10 Led Light 12
        /// </summary>
        [Description("C10 Led Light 12")]
        C10LEDLIGHT12 = 3012,

        /// <summary>
        /// C10 Led Light 13
        /// </summary>
        [Description("C10 Led Light 13")]
        C10LEDLIGHT13 = 3013,

        /// <summary>
        /// C10 Led Light 14
        /// </summary>
        [Description("C10 Led Light 14")]
        C10LEDLIGHT14 = 3014,

        /// <summary>
        /// C10 Led Light 15
        /// </summary>
        [Description("C10 Led Light 15")]
        C10LEDLIGHT15 = 3015,

        /// <summary>
        /// C10 Led Light 16
        /// </summary>
        [Description("C10 Led Light 16")]
        C10LEDLIGHT16 = 3016,

        /// <summary>
        /// C10 Led Light 17
        /// </summary>
        [Description("C10 Led Light 17")]
        C10LEDLIGHT17 = 3017,

        /// <summary>
        /// C10 Led Light 18
        /// </summary>
        [Description("C10 Led Light 18")]
        C10LEDLIGHT18 = 3018,

        /// <summary>
        /// C10 Led Light 19
        /// </summary>
        [Description("C10 Led Light 19")]
        C10LEDLIGHT19 = 3019,

        /// <summary>
        /// C10 Led Light 20
        /// </summary>
        [Description("C10 Led Light 20")]
        C10LEDLIGHT20 = 3020,

        /// <summary>
        /// C10 Led Light 21
        /// </summary>
        [Description("C10 Led Light 21")]
        C10LEDLIGHT21 = 3021,

        /// <summary>
        /// C10 Led Light 22
        /// </summary>
        [Description("C10 Led Light 22")]
        C10LEDLIGHT22 = 3022,

        /// <summary>
        /// C10 Led Light 23
        /// </summary>
        [Description("C10 Led Light 23")]
        C10LEDLIGHT23 = 3023,

        /// <summary>
        /// C10 Led Light 24
        /// </summary>
        [Description("C10 Led Light 24")]
        C10LEDLIGHT24 = 3024,

        /// <summary>
        /// C10 Led Light 25
        /// </summary>
        [Description("C10 Led Light 25")]
        C10LEDLIGHT25 = 3025,

        /// <summary>
        /// C10 Led Light 26
        /// </summary>
        [Description("C10 Led Light 26")]
        C10LEDLIGHT26 = 3026,

        /// <summary>
        /// C10 Led Light 27
        /// </summary>
        [Description("C10 Led Light 27")]
        C10LEDLIGHT27 = 3027,

        /// <summary>
        /// C10 Led Light 28
        /// </summary>
        [Description("C10 Led Light 28")]
        C10LEDLIGHT28 = 3028,

        /// <summary>
        /// C10 Led Light 29
        /// </summary>
        [Description("C10 Led Light 29")]
        C10LEDLIGHT29 = 3029,

        /// <summary>
        /// C10 Led Light 30
        /// </summary>
        [Description("C10 Led Light 30")]
        C10LEDLIGHT30 = 3030,

        /// <summary>
        /// C10 Led Light 31
        /// </summary>
        [Description("C10 Led Light 31")]
        C10LEDLIGHT31 = 3031,

        /// <summary>
        /// C10 Led Light 32
        /// </summary>
        [Description("C10 Led Light 32")]
        C10LEDLIGHT32 = 3032,

        /// <summary>
        /// C10 Led Light 33
        /// </summary>
        [Description("C10 Led Light 33")]
        C10LEDLIGHT33 = 3033,

        /// <summary>
        /// C10 Led Light 34
        /// </summary>
        [Description("C10 Led Light 34")]
        C10LEDLIGHT34 = 3034,

        /// <summary>
        /// C10 Led Light 35
        /// </summary>
        [Description("C10 Led Light 35")]
        C10LEDLIGHT35 = 3035,

        /// <summary>
        /// C10 Led Light 36
        /// </summary>
        [Description("C10 Led Light 36")]
        C10LEDLIGHT36 = 3036,

        /// <summary>
        /// C10 Led Light 37
        /// </summary>
        [Description("C10 Led Light 37")]
        C10LEDLIGHT37 = 3037,

        /// <summary>
        /// C10 Led Light 38
        /// </summary>
        [Description("C10 Led Light 38")]
        C10LEDLIGHT38 = 3038,

        /// <summary>
        /// C10 Led Light 39
        /// </summary>
        [Description("C10 Led Light 39")]
        C10LEDLIGHT39 = 3039,

        /// <summary>
        /// C10 Led Light 40
        /// </summary>
        [Description("C10 Led Light 40")]
        C10LEDLIGHT40 = 3040,

        /// <summary>
        /// C10 Led Light 41
        /// </summary>
        [Description("C10 Led Light 41")]
        C10LEDLIGHT41 = 3041,

        /// <summary>
        /// C10 Led Light 42
        /// </summary>
        [Description("C10 Led Light 42")]
        C10LEDLIGHT42 = 3042,

        /// <summary>
        /// C10 Led Light 43
        /// </summary>
        [Description("C10 Led Light 43")]
        C10LEDLIGHT43 = 3043,

        /// <summary>
        /// C10 Led Light 44
        /// </summary>
        [Description("C10 Led Light 44")]
        C10LEDLIGHT44 = 3044,

        /// <summary>
        /// C10 Led Light 45
        /// </summary>
        [Description("C10 Led Light 45")]
        C10LEDLIGHT45 = 3045,

        /// <summary>
        /// C10 Led Light 46
        /// </summary>
        [Description("C10 Led Light 46")]
        C10LEDLIGHT46 = 3046,

        /// <summary>
        /// C10 Led Light 47
        /// </summary>
        [Description("C10 Led Light 47")]
        C10LEDLIGHT47 = 3047,

        /// <summary>
        /// C10 Led Light 48
        /// </summary>
        [Description("C10 Led Light 48")]
        C10LEDLIGHT48 = 3048,

        /// <summary>
        /// C10 Led Light 49
        /// </summary>
        [Description("C10 Led Light 49")]
        C10LEDLIGHT49 = 3049,

        /// <summary>
        /// C10 Led Light 50
        /// </summary>
        [Description("C10 Led Light 50")]
        C10LEDLIGHT50 = 3050,

        // ADD 50 More here








        //////////////////////////////////////////////   to Support more LED Lights i need more time to Edit
    };
}
