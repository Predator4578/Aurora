﻿using System.ComponentModel;

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

        /// <summary>
        /// Additional Light 41
        /// </summary>
        [Description("Additional Light 41")]
        ADDITIONALLIGHT41 = 1209,

        /// <summary>
        /// Additional Light 42
        /// </summary>
        [Description("Additional Light 42")]
        ADDITIONALLIGHT42 = 1210,

        /// <summary>
        /// Additional Light 43
        /// </summary>
        [Description("Additional Light 43")]
        ADDITIONALLIGHT43 = 1211,

        /// <summary>
        /// Additional Light 44
        /// </summary>
        [Description("Additional Light 44")]
        ADDITIONALLIGHT44 = 1212,

        /// <summary>
        /// Additional Light 45
        /// </summary>
        [Description("Additional Light 45")]
        ADDITIONALLIGHT45 = 1213,

        /// <summary>
        /// Additional Light 46
        /// </summary>
        [Description("Additional Light 46")]
        ADDITIONALLIGHT46 = 1214,

        /// <summary>
        /// Additional Light 47
        /// </summary>
        [Description("Additional Light 47")]
        ADDITIONALLIGHT47 = 1215,

        /// <summary>
        /// Additional Light 48
        /// </summary>
        [Description("Additional Light 48")]
        ADDITIONALLIGHT48 = 1216,

        /// <summary>
        /// Additional Light 49
        /// </summary>
        [Description("Additional Light 49")]
        ADDITIONALLIGHT49 = 1217,

        /// <summary>
        /// Additional Light 50
        /// </summary>
        [Description("Additional Light 50")]
        ADDITIONALLIGHT50 = 1218,

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



        /// <summary>
        /// Mouse Light 11
        /// </summary>
        [Description("Mouse Light 11")]
        MOUSELIGHT11 = 1261,

        /// <summary>
        /// Mouse Light 12
        /// </summary>
        [Description("Mouse Light 12")]
        MOUSELIGHT12 = 1262,

        /// <summary>
        /// Mouse Light 13
        /// </summary>
        [Description("Mouse Light 13")]
        MOUSELIGHT13 = 1263,

        /// <summary>
        /// Mouse Light 14
        /// </summary>
        [Description("Mouse Light 14")]
        MOUSELIGHT14 = 1264,

        /// <summary>
        /// Mouse Light 15
        /// </summary>
        [Description("Mouse Light 15")]
        MOUSELIGHT15 = 1265,

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




        /// <summary>
        /// SS Mousepad Light 1
        /// </summary>
        [Description("SS Mousepad Light 1")]
        SSMOUSEPADLIGHT1 = 1333,

        /// <summary>
        /// SS Mousepad Light 2
        /// </summary>
        [Description("SS Mousepad Light 2")]
        SSMOUSEPADLIGHT2 = 1334,

        /// <summary>
        /// SS Mousepad Light 3
        /// </summary>
        [Description("SS Mousepad Light 3")]
        SSMOUSEPADLIGHT3 = 1335,

        /// <summary>
        /// SS Mousepad Light 4
        /// </summary>
        [Description("SS Mousepad Light 4")]
        SSMOUSEPADLIGHT4 = 1336,

        /// <summary>
        /// SS Mousepad Light 5
        /// </summary>
        [Description("SS Mousepad Light 5")]
        SSMOUSEPADLIGHT5 = 1337,

        /// <summary>
        /// SS Mousepad Light 6
        /// </summary>
        [Description("SS Mousepad Light 6")]
        SSMOUSEPADLIGHT6 = 1338,

        /// <summary>
        /// SS Mousepad Light 7
        /// </summary>
        [Description("SS Mousepad Light 7")]
        SSMOUSEPADLIGHT7 = 1339,

        /// <summary>
        /// SS Mousepad Light 8
        /// </summary>
        [Description("SS Mousepad Light 8")]
        SSMOUSEPADLIGHT8 = 1340,

        /// <summary>
        /// SS Mousepad Light 9
        /// </summary>
        [Description("SS Mousepad Light 9")]
        SSMOUSEPADLIGHT9 = 1341,

        /// <summary>
        /// SS Mousepad Light 10
        /// </summary>
        [Description("SS Mousepad Light 10")]
        SSMOUSEPADLIGHT10 = 1342,

        /// <summary>
        /// SS Mousepad Light 11
        /// </summary>
        [Description("SS Mousepad Light 11")]
        SSMOUSEPADLIGHT11 = 1343,

        /// <summary>
        /// SS Mousepad Light 12
        /// </summary>
        [Description("SS Mousepad Light 12")]
        SSMOUSEPADLIGHT12 = 1344,

        /// <summary>
        /// SS Mousepad Light 13
        /// </summary>
        [Description("SS Mousepad Light 13")]
        SSMOUSEPADLIGHT13 = 1345,

        /// <summary>
        /// SS Mousepad Light 14
        /// </summary>
        [Description("SS Mousepad Light 14")]
        SSMOUSEPADLIGHT14 = 1346,

        /// <summary>
        /// SS Mousepad Light 15
        /// </summary>
        [Description("SS Mousepad Light 15")]
        SSMOUSEPADLIGHT15 = 1347,

        /// <summary>
        /// SS Mousepad Light 16
        /// </summary>
        [Description("SS Mousepad Light 16")]
        SSMOUSEPADLIGHT16 = 1348,

        /// <summary>
        /// SS Mousepad Light Bottom
        /// </summary>
        [Description("SS Mousepad Light Bottom")]
        SSMOUSEPADLIGHTBOTTOM = 1349,

        /// <summary>
        /// SS Mousepad Light Top
        /// </summary>
        [Description("SS Mousepad Light Top")]
        SSMOUSEPADLIGHTTOP = 1350,

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

        /// <summary>
        /// MOBO Light 6
        /// </summary>
        [Description("Mainboard Light 6")]
        MOBOLIGHT6 = 1506,

        /// <summary>
        /// MOBO Light 7
        /// </summary>
        [Description("Mainboard Light 7")]
        MOBOLIGHT7 = 1507,

        /// <summary>
        /// MOBO Light 8
        /// </summary>
        [Description("Mainboard Light 8")]
        MOBOLIGHT8 = 1508,

        /// <summary>
        /// MOBO Light 9
        /// </summary>
        [Description("Mainboard Light 9")]
        MOBOLIGHT9 = 1509,

        /// <summary>
        /// MOBO Light 10
        /// </summary>
        [Description("Mainboard Light 10")]
        MOBOLIGHT10 = 1510,

        /// <summary>
        /// MOBO Light 11
        /// </summary>
        [Description("Mainboard Light 11")]
        MOBOLIGHT11 = 1511,

        /// <summary>
        /// MOBO Light 12
        /// </summary>
        [Description("Mainboard Light 12")]
        MOBOLIGHT12 = 1512,

        /// <summary>
        /// MOBO Light 13
        /// </summary>
        [Description("Mainboard Light 13")]
        MOBOLIGHT13 = 1513,

        /// <summary>
        /// MOBO Light 14
        /// </summary>
        [Description("Mainboard Light 14")]
        MOBOLIGHT14 = 1514,

        /// <summary>
        /// MOBO Light 15
        /// </summary>
        [Description("Mainboard Light 15")]
        MOBOLIGHT15 = 1515,

        /// <summary>
        /// MOBO Light 16
        /// </summary>
        [Description("Mainboard Light 16")]
        MOBOLIGHT16 = 1516,

        /// <summary>
        /// MOBO Light 17
        /// </summary>
        [Description("Mainboard Light 17")]
        MOBOLIGHT17 = 1517,

        /// <summary>
        /// MOBO Light 18
        /// </summary>
        [Description("Mainboard Light 18")]
        MOBOLIGHT18 = 1518,

        /// <summary>
        /// MOBO Light 19
        /// </summary>
        [Description("Mainboard Light 19")]
        MOBOLIGHT19 = 1519,

        /// <summary>
        /// MOBO Light 20
        /// </summary>
        [Description("Mainboard Light 20")]
        MOBOLIGHT20 = 1520,

        /// <summary>
        /// MOBO Light 21
        /// </summary>
        [Description("Mainboard Light 21")]
        MOBOLIGHT21 = 1521,

        /// <summary>
        /// MOBO Light 22
        /// </summary>
        [Description("Mainboard Light 22")]
        MOBOLIGHT22 = 1522,

        /// <summary>
        /// MOBO Light 23
        /// </summary>
        [Description("Mainboard Light 23")]
        MOBOLIGHT23 = 1523,

        /// <summary>
        /// MOBO Light 24
        /// </summary>
        [Description("Mainboard Light 24")]
        MOBOLIGHT24 = 1524,

        /// <summary>
        /// MOBO Light 25
        /// </summary>
        [Description("Mainboard Light 25")]
        MOBOLIGHT25 = 1525,

        /// <summary>
        /// MOBO Light 26
        /// </summary>
        [Description("Mainboard Light 26")]
        MOBOLIGHT26 = 1526,

        /// <summary>
        /// MOBO Light 27
        /// </summary>
        [Description("Mainboard Light 27")]
        MOBOLIGHT27 = 1527,

        /// <summary>
        /// MOBO Light 28
        /// </summary>
        [Description("Mainboard Light 28")]
        MOBOLIGHT28 = 1528,

        /// <summary>
        /// MOBO Light 29
        /// </summary>
        [Description("Mainboard Light 29")]
        MOBOLIGHT29 = 1529,

        /// <summary>
        /// MOBO Light 30
        /// </summary>
        [Description("Mainboard Light 30")]
        MOBOLIGHT30 = 1530,

        /// <summary>
        /// MOBO Light 31
        /// </summary>
        [Description("Mainboard Light 31")]
        MOBOLIGHT31 = 1531,

        /// <summary>
        /// MOBO Light 32
        /// </summary>
        [Description("Mainboard Light 32")]
        MOBOLIGHT32 = 1532,

        /// <summary>
        /// MOBO Light 33
        /// </summary>
        [Description("Mainboard Light 33")]
        MOBOLIGHT33 = 1533,

        /// <summary>
        /// MOBO Light 34
        /// </summary>
        [Description("Mainboard Light 34")]
        MOBOLIGHT34 = 1534,

        /// <summary>
        /// MOBO Light 35
        /// </summary>
        [Description("Mainboard Light 35")]
        MOBOLIGHT35 = 1535,

        /// <summary>
        /// MOBO Light 36
        /// </summary>
        [Description("Mainboard Light 36")]
        MOBOLIGHT36 = 1536,

        /// <summary>
        /// MOBO Light 37
        /// </summary>
        [Description("Mainboard Light 37")]
        MOBOLIGHT37 = 1537,

        /// <summary>
        /// MOBO Light 38
        /// </summary>
        [Description("Mainboard Light 38")]
        MOBOLIGHT38 = 1538,

        /// <summary>
        /// MOBO Light 39
        /// </summary>
        [Description("Mainboard Light 39")]
        MOBOLIGHT39 = 1539,

        /// <summary>
        /// MOBO Light 40
        /// </summary>
        [Description("Mainboard Light 40")]
        MOBOLIGHT40 = 1540,

        /// <summary>
        /// MOBO Light 41
        /// </summary>
        [Description("Mainboard Light 41")]
        MOBOLIGHT41 = 1541,

        /// <summary>
        /// MOBO Light 42
        /// </summary>
        [Description("Mainboard Light 42")]
        MOBOLIGHT42 = 1542,

        /// <summary>
        /// MOBO Light 43
        /// </summary>
        [Description("Mainboard Light 43")]
        MOBOLIGHT43 = 1543,

        /// <summary>
        /// MOBO Light 44
        /// </summary>
        [Description("Mainboard Light 44")]
        MOBOLIGHT44 = 1544,

        /// <summary>
        /// MOBO Light 45
        /// </summary>
        [Description("Mainboard Light 45")]
        MOBOLIGHT45 = 1545,

        /// <summary>
        /// MOBO Light 46
        /// </summary>
        [Description("Mainboard Light 46")]
        MOBOLIGHT46 = 1546,

        /// <summary>
        /// MOBO Light 47
        /// </summary>
        [Description("Mainboard Light 47")]
        MOBOLIGHT47 = 1547,

        /// <summary>
        /// MOBO Light 48
        /// </summary>
        [Description("Mainboard Light 48")]
        MOBOLIGHT48 = 1548,

        /// <summary>
        /// MOBO Light 49
        /// </summary>
        [Description("Mainboard Light 49")]
        MOBOLIGHT49 = 1549,

        /// <summary>
        /// MOBO Light 50
        /// </summary>
        [Description("Mainboard Light 50")]
        MOBOLIGHT50 = 1550,

        /// <summary>
        /// MOBO Light 51
        /// </summary>
        [Description("Mainboard Light 51")]
        MOBOLIGHT51 = 1551,

        /// <summary>
        /// MOBO Light 52
        /// </summary>
        [Description("Mainboard Light 52")]
        MOBOLIGHT52 = 1552,

        /// <summary>
        /// MOBO Light 53
        /// </summary>
        [Description("Mainboard Light 53")]
        MOBOLIGHT53 = 1553,

        /// <summary>
        /// MOBO Light 54
        /// </summary>
        [Description("Mainboard Light 54")]
        MOBOLIGHT54 = 1554,

        /// <summary>
        /// MOBO Light 55
        /// </summary>
        [Description("Mainboard Light 55")]
        MOBOLIGHT55 = 1555,

        /// <summary>
        /// MOBO Light 56
        /// </summary>
        [Description("Mainboard Light 56")]
        MOBOLIGHT56 = 1556,

        /// <summary>
        /// MOBO Light 57
        /// </summary>
        [Description("Mainboard Light 57")]
        MOBOLIGHT57 = 1557,

        /// <summary>
        /// MOBO Light 58
        /// </summary>
        [Description("Mainboard Light 58")]
        MOBOLIGHT58 = 1558,

        /// <summary>
        /// MOBO Light 59
        /// </summary>
        [Description("Mainboard Light 59")]
        MOBOLIGHT59 = 1559,

        /// <summary>
        /// MOBO Light 60
        /// </summary>
        [Description("Mainboard Light 60")]
        MOBOLIGHT60 = 1560,

        /// <summary>
        /// MOBO Light 61
        /// </summary>
        [Description("Mainboard Light 61")]
        MOBOLIGHT61 = 1561,

        /// <summary>
        /// MOBO Light 62
        /// </summary>
        [Description("Mainboard Light 62")]
        MOBOLIGHT62 = 1562,

        /// <summary>
        /// MOBO Light 63
        /// </summary>
        [Description("Mainboard Light 63")]
        MOBOLIGHT63 = 1563,

        /// <summary>
        /// MOBO Light 64
        /// </summary>
        [Description("Mainboard Light 64")]
        MOBOLIGHT64 = 1564,

        /// <summary>
        /// MOBO Light 65
        /// </summary>
        [Description("Mainboard Light 65")]
        MOBOLIGHT65 = 1565,

        /// <summary>
        /// MOBO Light 66
        /// </summary>
        [Description("Mainboard Light 66")]
        MOBOLIGHT66 = 1566,

        /// <summary>
        /// MOBO Light 67
        /// </summary>
        [Description("Mainboard Light 67")]
        MOBOLIGHT67 = 1567,

        /// <summary>
        /// MOBO Light 68
        /// </summary>
        [Description("Mainboard Light 68")]
        MOBOLIGHT68 = 1568,

        /// <summary>
        /// MOBO Light 69
        /// </summary>
        [Description("Mainboard Light 69")]
        MOBOLIGHT69 = 1569,

        /// <summary>
        /// MOBO Light 70
        /// </summary>
        [Description("Mainboard Light 70")]
        MOBOLIGHT70 = 1570,

        /// <summary>
        /// MOBO Light 71
        /// </summary>
        [Description("Mainboard Light 71")]
        MOBOLIGHT71 = 1571,

        /// <summary>
        /// MOBO Light 72
        /// </summary>
        [Description("Mainboard Light 72")]
        MOBOLIGHT72 = 1572,

        /// <summary>
        /// MOBO Light 73
        /// </summary>
        [Description("Mainboard Light 73")]
        MOBOLIGHT73 = 1573,

        /// <summary>
        /// MOBO Light 74
        /// </summary>
        [Description("Mainboard Light 74")]
        MOBOLIGHT74 = 1574,

        /// <summary>
        /// MOBO Light 75
        /// </summary>
        [Description("Mainboard Light 75")]
        MOBOLIGHT75 = 1575,

        /// <summary>
        /// MOBO Light 76
        /// </summary>
        [Description("Mainboard Light 76")]
        MOBOLIGHT76 = 1576,

        /// <summary>
        /// MOBO Light 77
        /// </summary>
        [Description("Mainboard Light 77")]
        MOBOLIGHT77 = 1577,

        /// <summary>
        /// MOBO Light 78
        /// </summary>
        [Description("Mainboard Light 78")]
        MOBOLIGHT78 = 1578,

        /// <summary>
        /// MOBO Light 79
        /// </summary>
        [Description("Mainboard Light 79")]
        MOBOLIGHT79 = 1579,

        /// <summary>
        /// MOBO Light 80
        /// </summary>
        [Description("Mainboard Light 80")]
        MOBOLIGHT80 = 1580,

        /// <summary>
        /// MOBO Light 81
        /// </summary>
        [Description("Mainboard Light 81")]
        MOBOLIGHT81 = 1581,

        /// <summary>
        /// MOBO Light 82
        /// </summary>
        [Description("Mainboard Light 82")]
        MOBOLIGHT82 = 1582,

        /// <summary>
        /// MOBO Light 83
        /// </summary>
        [Description("Mainboard Light 83")]
        MOBOLIGHT83 = 1583,

        /// <summary>
        /// MOBO Light 84
        /// </summary>
        [Description("Mainboard Light 84")]
        MOBOLIGHT84 = 1584,

        /// <summary>
        /// MOBO Light 85
        /// </summary>
        [Description("Mainboard Light 85")]
        MOBOLIGHT85 = 1585,

        /// <summary>
        /// MOBO Light 86
        /// </summary>
        [Description("Mainboard Light 86")]
        MOBOLIGHT86 = 1586,

        /// <summary>
        /// MOBO Light 87
        /// </summary>
        [Description("Mainboard Light 87")]
        MOBOLIGHT87 = 1587,

        /// <summary>
        /// MOBO Light 88
        /// </summary>
        [Description("Mainboard Light 88")]
        MOBOLIGHT88 = 1588,

        /// <summary>
        /// MOBO Light 89
        /// </summary>
        [Description("Mainboard Light 89")]
        MOBOLIGHT89 = 1589,

        /// <summary>
        /// MOBO Light 90
        /// </summary>
        [Description("Mainboard Light 90")]
        MOBOLIGHT90 = 1590,

        /// <summary>
        /// MOBO Light 91
        /// </summary>
        [Description("Mainboard Light 91")]
        MOBOLIGHT91 = 1591,

        /// <summary>
        /// MOBO Light 92
        /// </summary>
        [Description("Mainboard Light 92")]
        MOBOLIGHT92 = 1592,

        /// <summary>
        /// MOBO Light 93
        /// </summary>
        [Description("Mainboard Light 93")]
        MOBOLIGHT93 = 1593,

        /// <summary>
        /// MOBO Light 94
        /// </summary>
        [Description("Mainboard Light 94")]
        MOBOLIGHT94 = 1594,

        /// <summary>
        /// MOBO Light 95
        /// </summary>
        [Description("Mainboard Light 95")]
        MOBOLIGHT95 = 1595,

        /// <summary>
        /// MOBO Light 96
        /// </summary>
        [Description("Mainboard Light 96")]
        MOBOLIGHT96 = 1596,

        /// <summary>
        /// MOBO Light 97
        /// </summary>
        [Description("Mainboard Light 97")]
        MOBOLIGHT97 = 1597,

        /// <summary>
        /// MOBO Light 98
        /// </summary>
        [Description("Mainboard Light 98")]
        MOBOLIGHT98 = 1598,

        /// <summary>
        /// MOBO Light 99
        /// </summary>
        [Description("Mainboard Light 99")]
        MOBOLIGHT99 = 1599,

        /// <summary>
        /// MOBO Light 100
        /// </summary>
        [Description("Mainboard Light 100")]
        MOBOLIGHT100 = 1600,

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

        /// <summary>
        /// C0 RAM Light 6
        /// </summary>
        [Description("C0 RAM Light 6")]
        C0RAMLIGHT6 = 1741,

        /// <summary>
        /// C0 RAM Light 7
        /// </summary>
        [Description("C0 RAM Light 7")]
        C0RAMLIGHT7 = 1742,

        /// <summary>
        /// C0 RAM Light 8
        /// </summary>
        [Description("C0 RAM Light 8")]
        C0RAMLIGHT8 = 1743,

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

        /// <summary>
        /// C1 RAM Light 6
        /// </summary>
        [Description("C1 RAM Light 6")]
        C1RAMLIGHT6 = 1746,

        /// <summary>
        /// C1 RAM Light 7
        /// </summary>
        [Description("C1 RAM Light 7")]
        C1RAMLIGHT7 = 1747,

        /// <summary>
        /// C1 RAM Light 8
        /// </summary>
        [Description("C1 RAM Light 8")]
        C1RAMLIGHT8 = 1748,

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

        /// <summary>
        /// C2 RAM Light 6
        /// </summary>
        [Description("C2 RAM Light 6")]
        C2RAMLIGHT6 = 1751,

        /// <summary>
        /// C2 RAM Light 7
        /// </summary>
        [Description("C2 RAM Light 7")]
        C2RAMLIGHT7 = 1752,

        /// <summary>
        /// C2 RAM Light 8
        /// </summary>
        [Description("C2 RAM Light 8")]
        C2RAMLIGHT8 = 1753,

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

        /// <summary>
        /// C3 RAM Light 6
        /// </summary>
        [Description("C3 RAM Light 6")]
        C3RAMLIGHT6 = 1756,

        /// <summary>
        /// C3 RAM Light 7
        /// </summary>
        [Description("C3 RAM Light 7")]
        C3RAMLIGHT7 = 1757,

        /// <summary>
        /// C3 RAM Light 8
        /// </summary>
        [Description("C3 RAM Light 8")]
        C3RAMLIGHT8 = 1758,

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

        /// <summary>
        /// C1 Led Light 41
        /// </summary>
        [Description("C1 Led Light 41")]
        C1LEDLIGHT41 = 2141,

        /// <summary>
        /// C1 Led Light 42
        /// </summary>
        [Description("C1 Led Light 42")]
        C1LEDLIGHT42 = 2142,

        /// <summary>
        /// C1 Led Light 43
        /// </summary>
        [Description("C1 Led Light 43")]
        C1LEDLIGHT43 = 2143,

        /// <summary>
        /// C1 Led Light 44
        /// </summary>
        [Description("C1 Led Light 44")]
        C1LEDLIGHT44 = 2144,

        /// <summary>
        /// C1 Led Light 45
        /// </summary>
        [Description("C1 Led Light 45")]
        C1LEDLIGHT45 = 2145,

        /// <summary>
        /// C1 Led Light 46
        /// </summary>
        [Description("C1 Led Light 46")]
        C1LEDLIGHT46 = 2146,

        /// <summary>
        /// C1 Led Light 47
        /// </summary>
        [Description("C1 Led Light 47")]
        C1LEDLIGHT47 = 2147,

        /// <summary>
        /// C1 Led Light 48
        /// </summary>
        [Description("C1 Led Light 48")]
        C1LEDLIGHT48 = 2148,

        /// <summary>
        /// C1 Led Light 49
        /// </summary>
        [Description("C1 Led Light 49")]
        C1LEDLIGHT49 = 2149,

        /// <summary>
        /// C1 Led Light 50
        /// </summary>
        [Description("C1 Led Light 50")]
        C1LEDLIGHT50 = 2150,

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

        /// <summary>
        /// C2 Led Light 41
        /// </summary>
        [Description("C2 Led Light 41")]
        C2LEDLIGHT41 = 2241,

        /// <summary>
        /// C2 Led Light 42
        /// </summary>
        [Description("C2 Led Light 42")]
        C2LEDLIGHT42 = 2242,

        /// <summary>
        /// C2 Led Light 43
        /// </summary>
        [Description("C2 Led Light 43")]
        C2LEDLIGHT43 = 2243,

        /// <summary>
        /// C2 Led Light 44
        /// </summary>
        [Description("C2 Led Light 44")]
        C2LEDLIGHT44 = 2244,

        /// <summary>
        /// C2 Led Light 45
        /// </summary>
        [Description("C2 Led Light 45")]
        C2LEDLIGHT45 = 2245,

        /// <summary>
        /// C2 Led Light 46
        /// </summary>
        [Description("C2 Led Light 46")]
        C2LEDLIGHT46 = 2246,

        /// <summary>
        /// C2 Led Light 47
        /// </summary>
        [Description("C2 Led Light 47")]
        C2LEDLIGHT47 = 2247,

        /// <summary>
        /// C2 Led Light 48
        /// </summary>
        [Description("C2 Led Light 48")]
        C2LEDLIGHT48 = 2248,

        /// <summary>
        /// C2 Led Light 49
        /// </summary>
        [Description("C2 Led Light 49")]
        C2LEDLIGHT49 = 2249,

        /// <summary>
        /// C2 Led Light 50
        /// </summary>
        [Description("C2 Led Light 50")]
        C2LEDLIGHT50 = 2250,

        /// <summary>
        /// C2 Led Light 51
        /// </summary>
        [Description("C2 Led Light 51")]
        C2LEDLIGHT51 = 2251,

        /// <summary>
        /// C2 Led Light 52
        /// </summary>
        [Description("C2 Led Light 52")]
        C2LEDLIGHT52 = 2252,

        /// <summary>
        /// C2 Led Light 53
        /// </summary>
        [Description("C2 Led Light 53")]
        C2LEDLIGHT53 = 2253,

        /// <summary>
        /// C2 Led Light 54
        /// </summary>
        [Description("C2 Led Light 54")]
        C2LEDLIGHT54 = 2254,

        /// <summary>
        /// C2 Led Light 55
        /// </summary>
        [Description("C2 Led Light 55")]
        C2LEDLIGHT55 = 2255,

        /// <summary>
        /// C2 Led Light 56
        /// </summary>
        [Description("C2 Led Light 56")]
        C2LEDLIGHT56 = 2256,

        /// <summary>
        /// C2 Led Light 57
        /// </summary>
        [Description("C2 Led Light 57")]
        C2LEDLIGHT57 = 2257,

        /// <summary>
        /// C2 Led Light 58
        /// </summary>
        [Description("C2 Led Light 58")]
        C2LEDLIGHT58 = 2258,

        /// <summary>
        /// C2 Led Light 59
        /// </summary>
        [Description("C2 Led Light 59")]
        C2LEDLIGHT59 = 2259,

        /// <summary>
        /// C2 Led Light 60
        /// </summary>
        [Description("C2 Led Light 60")]
        C2LEDLIGHT60 = 2260,

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

        /// <summary>
        /// C3 Led Light 41
        /// </summary>
        [Description("C3 Led Light 41")]
        C3LEDLIGHT41 = 2341,

        /// <summary>
        /// C3 Led Light 42
        /// </summary>
        [Description("C3 Led Light 42")]
        C3LEDLIGHT42 = 2342,

        /// <summary>
        /// C3 Led Light 43
        /// </summary>
        [Description("C3 Led Light 43")]
        C3LEDLIGHT43 = 2343,

        /// <summary>
        /// C3 Led Light 44
        /// </summary>
        [Description("C3 Led Light 44")]
        C3LEDLIGHT44 = 2344,

        /// <summary>
        /// C3 Led Light 45
        /// </summary>
        [Description("C3 Led Light 45")]
        C3LEDLIGHT45 = 2345,

        /// <summary>
        /// C3 Led Light 46
        /// </summary>
        [Description("C3 Led Light 46")]
        C3LEDLIGHT46 = 2346,

        /// <summary>
        /// C3 Led Light 47
        /// </summary>
        [Description("C3 Led Light 47")]
        C3LEDLIGHT47 = 2347,

        /// <summary>
        /// C3 Led Light 48
        /// </summary>
        [Description("C3 Led Light 48")]
        C3LEDLIGHT48 = 2348,

        /// <summary>
        /// C3 Led Light 49
        /// </summary>
        [Description("C3 Led Light 49")]
        C3LEDLIGHT49 = 2349,

        /// <summary>
        /// C3 Led Light 50
        /// </summary>
        [Description("C3 Led Light 50")]
        C3LEDLIGHT50 = 2350,

        //////////////////////////////////////////////   Adding E1.31 Devices (4 Zones)
        //////////////////////////////////////////////   First Zone (70, Channel 4 Lights)(Monitor Mitte)

        /// <summary>
        /// C4 Led Light 1
        /// </summary>
        [Description("C4 Led Light 1")]
        C4LEDLIGHT1 = 2401,

        /// <summary>
        /// C4 Led Light 2
        /// </summary>
        [Description("C4 Led Light 2")]
        C4LEDLIGHT2 = 2402,

        /// <summary>
        /// C4 Led Light 3
        /// </summary>
        [Description("C4 Led Light 3")]
        C4LEDLIGHT3 = 2403,

        /// <summary>
        /// C4 Led Light 4
        /// </summary>
        [Description("C4 Led Light 4")]
        C4LEDLIGHT4 = 2404,

        /// <summary>
        /// C4 Led Light 5
        /// </summary>
        [Description("C4 Led Light 5")]
        C4LEDLIGHT5 = 2405,

        /// <summary>
        /// C4 Led Light 6
        /// </summary>
        [Description("C4 Led Light 6")]
        C4LEDLIGHT6 = 2406,

        /// <summary>
        /// C4 Led Light 7
        /// </summary>
        [Description("C4 Led Light 7")]
        C4LEDLIGHT7 = 2407,

        /// <summary>
        /// C4 Led Light 8
        /// </summary>
        [Description("C4 Led Light 8")]
        C4LEDLIGHT8 = 2408,

        /// <summary>
        /// C4 Led Light 9
        /// </summary>
        [Description("C4 Led Light 9")]
        C4LEDLIGHT9 = 2409,

        /// <summary>
        /// C4 Led Light 10
        /// </summary>
        [Description("C4 Led Light 10")]
        C4LEDLIGHT10 = 2410,

        /// <summary>
        /// C4 Led Light 11
        /// </summary>
        [Description("C4 Led Light 11")]
        C4LEDLIGHT11 = 2411,

        /// <summary>
        /// C4 Led Light 12
        /// </summary>
        [Description("C4 Led Light 12")]
        C4LEDLIGHT12 = 2412,

        /// <summary>
        /// C4 Led Light 13
        /// </summary>
        [Description("C4 Led Light 13")]
        C4LEDLIGHT13 = 2413,

        /// <summary>
        /// C4 Led Light 14
        /// </summary>
        [Description("C4 Led Light 14")]
        C4LEDLIGHT14 = 2414,

        /// <summary>
        /// C4 Led Light 15
        /// </summary>
        [Description("C4 Led Light 15")]
        C4LEDLIGHT15 = 2415,

        /// <summary>
        /// C4 Led Light 16
        /// </summary>
        [Description("C4 Led Light 16")]
        C4LEDLIGHT16 = 2416,

        /// <summary>
        /// C4 Led Light 17
        /// </summary>
        [Description("C4 Led Light 17")]
        C4LEDLIGHT17 = 2417,

        /// <summary>
        /// C4 Led Light 18
        /// </summary>
        [Description("C4 Led Light 18")]
        C4LEDLIGHT18 = 2418,

        /// <summary>
        /// C4 Led Light 19
        /// </summary>
        [Description("C4 Led Light 19")]
        C4LEDLIGHT19 = 2419,

        /// <summary>
        /// C4 Led Light 20
        /// </summary>
        [Description("C4 Led Light 20")]
        C4LEDLIGHT20 = 2420,

        /// <summary>
        /// C4 Led Light 21
        /// </summary>
        [Description("C4 Led Light 21")]
        C4LEDLIGHT21 = 2421,

        /// <summary>
        /// C4 Led Light 22
        /// </summary>
        [Description("C4 Led Light 22")]
        C4LEDLIGHT22 = 2422,

        /// <summary>
        /// C4 Led Light 23
        /// </summary>
        [Description("C4 Led Light 23")]
        C4LEDLIGHT23 = 2423,

        /// <summary>
        /// C4 Led Light 24
        /// </summary>
        [Description("C4 Led Light 24")]
        C4LEDLIGHT24 = 2424,

        /// <summary>
        /// C4 Led Light 25
        /// </summary>
        [Description("C4 Led Light 25")]
        C4LEDLIGHT25 = 2425,

        /// <summary>
        /// C4 Led Light 26
        /// </summary>
        [Description("C4 Led Light 26")]
        C4LEDLIGHT26 = 2426,

        /// <summary>
        /// C4 Led Light 27
        /// </summary>
        [Description("C4 Led Light 27")]
        C4LEDLIGHT27 = 2427,

        /// <summary>
        /// C4 Led Light 28
        /// </summary>
        [Description("C4 Led Light 28")]
        C4LEDLIGHT28 = 2428,

        /// <summary>
        /// C4 Led Light 29
        /// </summary>
        [Description("C4 Led Light 29")]
        C4LEDLIGHT29 = 2429,

        /// <summary>
        /// C4 Led Light 30
        /// </summary>
        [Description("C4 Led Light 30")]
        C4LEDLIGHT30 = 2430,

        /// <summary>
        /// C4 Led Light 31
        /// </summary>
        [Description("C4 Led Light 31")]
        C4LEDLIGHT31 = 2431,

        /// <summary>
        /// C4 Led Light 32
        /// </summary>
        [Description("C4 Led Light 32")]
        C4LEDLIGHT32 = 2432,

        /// <summary>
        /// C4 Led Light 33
        /// </summary>
        [Description("C4 Led Light 33")]
        C4LEDLIGHT33 = 2433,

        /// <summary>
        /// C4 Led Light 34
        /// </summary>
        [Description("C4 Led Light 34")]
        C4LEDLIGHT34 = 2434,

        /// <summary>
        /// C4 Led Light 35
        /// </summary>
        [Description("C4 Led Light 35")]
        C4LEDLIGHT35 = 2435,

        /// <summary>
        /// C4 Led Light 36
        /// </summary>
        [Description("C4 Led Light 36")]
        C4LEDLIGHT36 = 2436,

        /// <summary>
        /// C4 Led Light 37
        /// </summary>
        [Description("C4 Led Light 37")]
        C4LEDLIGHT37 = 2437,

        /// <summary>
        /// C4 Led Light 38
        /// </summary>
        [Description("C4 Led Light 38")]
        C4LEDLIGHT38 = 2438,

        /// <summary>
        /// C4 Led Light 39
        /// </summary>
        [Description("C4 Led Light 39")]
        C4LEDLIGHT39 = 2439,

        /// <summary>
        /// C4 Led Light 40
        /// </summary>
        [Description("C4 Led Light 40")]
        C4LEDLIGHT40 = 2440,

        /// <summary>
        /// C4 Led Light 41
        /// </summary>
        [Description("C4 Led Light 41")]
        C4LEDLIGHT41 = 2441,

        /// <summary>
        /// C4 Led Light 42
        /// </summary>
        [Description("C4 Led Light 42")]
        C4LEDLIGHT42 = 2442,

        /// <summary>
        /// C4 Led Light 43
        /// </summary>
        [Description("C4 Led Light 43")]
        C4LEDLIGHT43 = 2443,

        /// <summary>
        /// C4 Led Light 44
        /// </summary>
        [Description("C4 Led Light 44")]
        C4LEDLIGHT44 = 2444,

        /// <summary>
        /// C4 Led Light 45
        /// </summary>
        [Description("C4 Led Light 45")]
        C4LEDLIGHT45 = 2445,

        /// <summary>
        /// C4 Led Light 46
        /// </summary>
        [Description("C4 Led Light 46")]
        C4LEDLIGHT46 = 2446,

        /// <summary>
        /// C4 Led Light 47
        /// </summary>
        [Description("C4 Led Light 47")]
        C4LEDLIGHT47 = 2447,

        /// <summary>
        /// C4 Led Light 48
        /// </summary>
        [Description("C4 Led Light 48")]
        C4LEDLIGHT48 = 2448,

        /// <summary>
        /// C4 Led Light 49
        /// </summary>
        [Description("C4 Led Light 49")]
        C4LEDLIGHT49 = 2449,

        /// <summary>
        /// C4 Led Light 50
        /// </summary>
        [Description("C4 Led Light 50")]
        C4LEDLIGHT50 = 2450,

        //////////////////////////////////////////////   Second Zone (70, Channel 5 Lights)(Monitor Links)

        /// <summary>
        /// C5 Led Light 1
        /// </summary>
        [Description("C5 Led Light 1")]
        C5LEDLIGHT1 = 2501,

        /// <summary>
        /// C5 Led Light 2
        /// </summary>
        [Description("C5 Led Light 2")]
        C5LEDLIGHT2 = 2502,

        /// <summary>
        /// C5 Led Light 3
        /// </summary>
        [Description("C5 Led Light 3")]
        C5LEDLIGHT3 = 2503,

        /// <summary>
        /// C5 Led Light 4
        /// </summary>
        [Description("C5 Led Light 4")]
        C5LEDLIGHT4 = 2504,

        /// <summary>
        /// C5 Led Light 5
        /// </summary>
        [Description("C5 Led Light 5")]
        C5LEDLIGHT5 = 2505,

        /// <summary>
        /// C5 Led Light 6
        /// </summary>
        [Description("C5 Led Light 6")]
        C5LEDLIGHT6 = 2506,

        /// <summary>
        /// C5 Led Light 7
        /// </summary>
        [Description("C5 Led Light 7")]
        C5LEDLIGHT7 = 2507,

        /// <summary>
        /// C5 Led Light 8
        /// </summary>
        [Description("C5 Led Light 8")]
        C5LEDLIGHT8 = 2508,

        /// <summary>
        /// C5 Led Light 9
        /// </summary>
        [Description("C5 Led Light 9")]
        C5LEDLIGHT9 = 2509,

        /// <summary>
        /// C5 Led Light 10
        /// </summary>
        [Description("C5 Led Light 10")]
        C5LEDLIGHT10 = 2510,

        /// <summary>
        /// C5 Led Light 11
        /// </summary>
        [Description("C5 Led Light 11")]
        C5LEDLIGHT11 = 2511,

        /// <summary>
        /// C5 Led Light 12
        /// </summary>
        [Description("C5 Led Light 12")]
        C5LEDLIGHT12 = 2512,

        /// <summary>
        /// C5 Led Light 13
        /// </summary>
        [Description("C5 Led Light 13")]
        C5LEDLIGHT13 = 2513,

        /// <summary>
        /// C5 Led Light 14
        /// </summary>
        [Description("C5 Led Light 14")]
        C5LEDLIGHT14 = 2514,

        /// <summary>
        /// C5 Led Light 15
        /// </summary>
        [Description("C5 Led Light 15")]
        C5LEDLIGHT15 = 2515,

        /// <summary>
        /// C5 Led Light 16
        /// </summary>
        [Description("C5 Led Light 16")]
        C5LEDLIGHT16 = 2516,

        /// <summary>
        /// C5 Led Light 17
        /// </summary>
        [Description("C5 Led Light 17")]
        C5LEDLIGHT17 = 2517,

        /// <summary>
        /// C5 Led Light 18
        /// </summary>
        [Description("C5 Led Light 18")]
        C5LEDLIGHT18 = 2518,

        /// <summary>
        /// C5 Led Light 19
        /// </summary>
        [Description("C5 Led Light 19")]
        C5LEDLIGHT19 = 2519,

        /// <summary>
        /// C5 Led Light 20
        /// </summary>
        [Description("C5 Led Light 20")]
        C5LEDLIGHT20 = 2520,

        /// <summary>
        /// C5 Led Light 21
        /// </summary>
        [Description("C5 Led Light 21")]
        C5LEDLIGHT21 = 2521,

        /// <summary>
        /// C5 Led Light 22
        /// </summary>
        [Description("C5 Led Light 22")]
        C5LEDLIGHT22 = 2522,

        /// <summary>
        /// C5 Led Light 23
        /// </summary>
        [Description("C5 Led Light 23")]
        C5LEDLIGHT23 = 2523,

        /// <summary>
        /// C5 Led Light 24
        /// </summary>
        [Description("C5 Led Light 24")]
        C5LEDLIGHT24 = 2524,

        /// <summary>
        /// C5 Led Light 25
        /// </summary>
        [Description("C5 Led Light 25")]
        C5LEDLIGHT25 = 2525,

        /// <summary>
        /// C5 Led Light 26
        /// </summary>
        [Description("C5 Led Light 26")]
        C5LEDLIGHT26 = 2526,

        /// <summary>
        /// C5 Led Light 27
        /// </summary>
        [Description("C5 Led Light 27")]
        C5LEDLIGHT27 = 2527,

        /// <summary>
        /// C5 Led Light 28
        /// </summary>
        [Description("C5 Led Light 28")]
        C5LEDLIGHT28 = 2528,

        /// <summary>
        /// C5 Led Light 29
        /// </summary>
        [Description("C5 Led Light 29")]
        C5LEDLIGHT29 = 2529,

        /// <summary>
        /// C5 Led Light 30
        /// </summary>
        [Description("C5 Led Light 30")]
        C5LEDLIGHT30 = 2530,

        /// <summary>
        /// C5 Led Light 31
        /// </summary>
        [Description("C5 Led Light 31")]
        C5LEDLIGHT31 = 2531,

        /// <summary>
        /// C5 Led Light 32
        /// </summary>
        [Description("C5 Led Light 32")]
        C5LEDLIGHT32 = 2532,

        /// <summary>
        /// C5 Led Light 33
        /// </summary>
        [Description("C5 Led Light 33")]
        C5LEDLIGHT33 = 2533,

        /// <summary>
        /// C5 Led Light 34
        /// </summary>
        [Description("C5 Led Light 34")]
        C5LEDLIGHT34 = 2534,

        /// <summary>
        /// C5 Led Light 35
        /// </summary>
        [Description("C5 Led Light 35")]
        C5LEDLIGHT35 = 2535,

        /// <summary>
        /// C5 Led Light 36
        /// </summary>
        [Description("C5 Led Light 36")]
        C5LEDLIGHT36 = 2536,

        /// <summary>
        /// C5 Led Light 37
        /// </summary>
        [Description("C5 Led Light 37")]
        C5LEDLIGHT37 = 2537,

        /// <summary>
        /// C5 Led Light 38
        /// </summary>
        [Description("C5 Led Light 38")]
        C5LEDLIGHT38 = 2538,

        /// <summary>
        /// C5 Led Light 39
        /// </summary>
        [Description("C5 Led Light 39")]
        C5LEDLIGHT39 = 2539,

        /// <summary>
        /// C5 Led Light 40
        /// </summary>
        [Description("C5 Led Light 40")]
        C5LEDLIGHT40 = 2540,

        /// <summary>
        /// C5 Led Light 41
        /// </summary>
        [Description("C5 Led Light 41")]
        C5LEDLIGHT41 = 2541,

        /// <summary>
        /// C5 Led Light 42
        /// </summary>
        [Description("C5 Led Light 42")]
        C5LEDLIGHT42 = 2542,

        /// <summary>
        /// C5 Led Light 43
        /// </summary>
        [Description("C5 Led Light 43")]
        C5LEDLIGHT43 = 2543,

        /// <summary>
        /// C5 Led Light 44
        /// </summary>
        [Description("C5 Led Light 44")]
        C5LEDLIGHT44 = 2544,

        /// <summary>
        /// C5 Led Light 45
        /// </summary>
        [Description("C5 Led Light 45")]
        C5LEDLIGHT45 = 2545,

        /// <summary>
        /// C5 Led Light 46
        /// </summary>
        [Description("C5 Led Light 46")]
        C5LEDLIGHT46 = 2546,

        /// <summary>
        /// C5 Led Light 47
        /// </summary>
        [Description("C5 Led Light 47")]
        C5LEDLIGHT47 = 2547,

        /// <summary>
        /// C5 Led Light 48
        /// </summary>
        [Description("C5 Led Light 48")]
        C5LEDLIGHT48 = 2548,

        /// <summary>
        /// C5 Led Light 49
        /// </summary>
        [Description("C5 Led Light 49")]
        C5LEDLIGHT49 = 2549,

        /// <summary>
        /// C5 Led Light 50
        /// </summary>
        [Description("C5 Led Light 50")]
        C5LEDLIGHT50 = 2550,

        //////////////////////////////////////////////   Third Zone (70, Channel 6 Lights)(Monitor Rechts)

        /// <summary>
        /// C6 Led Light 1
        /// </summary>
        [Description("C6 Led Light 1")]
        C6LEDLIGHT1 = 2601,

        /// <summary>
        /// C6 Led Light 2
        /// </summary>
        [Description("C6 Led Light 2")]
        C6LEDLIGHT2 = 2602,

        /// <summary>
        /// C6 Led Light 3
        /// </summary>
        [Description("C6 Led Light 3")]
        C6LEDLIGHT3 = 2603,

        /// <summary>
        /// C6 Led Light 4
        /// </summary>
        [Description("C6 Led Light 4")]
        C6LEDLIGHT4 = 2604,

        /// <summary>
        /// C6 Led Light 5
        /// </summary>
        [Description("C6 Led Light 5")]
        C6LEDLIGHT5 = 2605,

        /// <summary>
        /// C6 Led Light 6
        /// </summary>
        [Description("C6 Led Light 6")]
        C6LEDLIGHT6 = 2606,

        /// <summary>
        /// C6 Led Light 7
        /// </summary>
        [Description("C6 Led Light 7")]
        C6LEDLIGHT7 = 2607,

        /// <summary>
        /// C6 Led Light 8
        /// </summary>
        [Description("C6 Led Light 8")]
        C6LEDLIGHT8 = 2608,

        /// <summary>
        /// C6 Led Light 9
        /// </summary>
        [Description("C6 Led Light 9")]
        C6LEDLIGHT9 = 2609,

        /// <summary>
        /// C6 Led Light 10
        /// </summary>
        [Description("C6 Led Light 10")]
        C6LEDLIGHT10 = 2610,

        /// <summary>
        /// C6 Led Light 11
        /// </summary>
        [Description("C6 Led Light 11")]
        C6LEDLIGHT11 = 2611,

        /// <summary>
        /// C6 Led Light 12
        /// </summary>
        [Description("C6 Led Light 12")]
        C6LEDLIGHT12 = 2612,

        /// <summary>
        /// C6 Led Light 13
        /// </summary>
        [Description("C6 Led Light 13")]
        C6LEDLIGHT13 = 2613,

        /// <summary>
        /// C6 Led Light 14
        /// </summary>
        [Description("C6 Led Light 14")]
        C6LEDLIGHT14 = 2614,

        /// <summary>
        /// C6 Led Light 15
        /// </summary>
        [Description("C6 Led Light 15")]
        C6LEDLIGHT15 = 2615,

        /// <summary>
        /// C6 Led Light 16
        /// </summary>
        [Description("C6 Led Light 16")]
        C6LEDLIGHT16 = 2616,

        /// <summary>
        /// C6 Led Light 17
        /// </summary>
        [Description("C6 Led Light 17")]
        C6LEDLIGHT17 = 2617,

        /// <summary>
        /// C6 Led Light 18
        /// </summary>
        [Description("C6 Led Light 18")]
        C6LEDLIGHT18 = 2618,

        /// <summary>
        /// C6 Led Light 19
        /// </summary>
        [Description("C6 Led Light 19")]
        C6LEDLIGHT19 = 2619,

        /// <summary>
        /// C6 Led Light 20
        /// </summary>
        [Description("C6 Led Light 20")]
        C6LEDLIGHT20 = 2620,

        /// <summary>
        /// C6 Led Light 21
        /// </summary>
        [Description("C6 Led Light 21")]
        C6LEDLIGHT21 = 2621,

        /// <summary>
        /// C6 Led Light 22
        /// </summary>
        [Description("C6 Led Light 22")]
        C6LEDLIGHT22 = 2622,

        /// <summary>
        /// C6 Led Light 23
        /// </summary>
        [Description("C6 Led Light 23")]
        C6LEDLIGHT23 = 2623,

        /// <summary>
        /// C6 Led Light 24
        /// </summary>
        [Description("C6 Led Light 24")]
        C6LEDLIGHT24 = 2624,

        /// <summary>
        /// C6 Led Light 25
        /// </summary>
        [Description("C6 Led Light 25")]
        C6LEDLIGHT25 = 2625,

        /// <summary>
        /// C6 Led Light 26
        /// </summary>
        [Description("C6 Led Light 26")]
        C6LEDLIGHT26 = 2626,

        /// <summary>
        /// C6 Led Light 27
        /// </summary>
        [Description("C6 Led Light 27")]
        C6LEDLIGHT27 = 2627,

        /// <summary>
        /// C6 Led Light 28
        /// </summary>
        [Description("C6 Led Light 28")]
        C6LEDLIGHT28 = 2628,

        /// <summary>
        /// C6 Led Light 29
        /// </summary>
        [Description("C6 Led Light 29")]
        C6LEDLIGHT29 = 2629,

        /// <summary>
        /// C6 Led Light 30
        /// </summary>
        [Description("C6 Led Light 30")]
        C6LEDLIGHT30 = 2630,

        /// <summary>
        /// C6 Led Light 31
        /// </summary>
        [Description("C6 Led Light 31")]
        C6LEDLIGHT31 = 2631,

        /// <summary>
        /// C6 Led Light 32
        /// </summary>
        [Description("C6 Led Light 32")]
        C6LEDLIGHT32 = 2632,

        /// <summary>
        /// C6 Led Light 33
        /// </summary>
        [Description("C6 Led Light 33")]
        C6LEDLIGHT33 = 2633,

        /// <summary>
        /// C6 Led Light 34
        /// </summary>
        [Description("C6 Led Light 34")]
        C6LEDLIGHT34 = 2634,

        /// <summary>
        /// C6 Led Light 35
        /// </summary>
        [Description("C6 Led Light 35")]
        C6LEDLIGHT35 = 2635,

        /// <summary>
        /// C6 Led Light 36
        /// </summary>
        [Description("C6 Led Light 36")]
        C6LEDLIGHT36 = 2636,

        /// <summary>
        /// C6 Led Light 37
        /// </summary>
        [Description("C6 Led Light 37")]
        C6LEDLIGHT37 = 2637,

        /// <summary>
        /// C6 Led Light 38
        /// </summary>
        [Description("C6 Led Light 38")]
        C6LEDLIGHT38 = 2638,

        /// <summary>
        /// C6 Led Light 39
        /// </summary>
        [Description("C6 Led Light 39")]
        C6LEDLIGHT39 = 2639,

        /// <summary>
        /// C6 Led Light 40
        /// </summary>
        [Description("C6 Led Light 40")]
        C6LEDLIGHT40 = 2640,

        /// <summary>
        /// C6 Led Light 41
        /// </summary>
        [Description("C6 Led Light 41")]
        C6LEDLIGHT41 = 2641,

        /// <summary>
        /// C6 Led Light 42
        /// </summary>
        [Description("C6 Led Light 42")]
        C6LEDLIGHT42 = 2642,

        /// <summary>
        /// C6 Led Light 43
        /// </summary>
        [Description("C6 Led Light 43")]
        C6LEDLIGHT43 = 2643,

        /// <summary>
        /// C6 Led Light 44
        /// </summary>
        [Description("C6 Led Light 44")]
        C6LEDLIGHT44 = 2644,

        /// <summary>
        /// C6 Led Light 45
        /// </summary>
        [Description("C6 Led Light 45")]
        C6LEDLIGHT45 = 2645,

        /// <summary>
        /// C6 Led Light 46
        /// </summary>
        [Description("C6 Led Light 46")]
        C6LEDLIGHT46 = 2646,

        /// <summary>
        /// C6 Led Light 47
        /// </summary>
        [Description("C6 Led Light 47")]
        C6LEDLIGHT47 = 2647,

        /// <summary>
        /// C6 Led Light 48
        /// </summary>
        [Description("C6 Led Light 48")]
        C6LEDLIGHT48 = 2648,

        /// <summary>
        /// C6 Led Light 49
        /// </summary>
        [Description("C6 Led Light 49")]
        C6LEDLIGHT49 = 2649,

        /// <summary>
        /// C6 Led Light 50
        /// </summary>
        [Description("C6 Led Light 50")]
        C6LEDLIGHT50 = 2650,

        //////////////////////////////////////////////   Fourth Zone (100, Channel 7 Lights)(NEW DESK STRIP)

        /// <summary>
        /// C7 Led Light 1
        /// </summary>
        [Description("C7 Led Light 1")]
        C7LEDLIGHT1 = 2701,

        /// <summary>
        /// C7 Led Light 2
        /// </summary>
        [Description("C7 Led Light 2")]
        C7LEDLIGHT2 = 2702,

        /// <summary>
        /// C7 Led Light 3
        /// </summary>
        [Description("C7 Led Light 3")]
        C7LEDLIGHT3 = 2703,

        /// <summary>
        /// C7 Led Light 4
        /// </summary>
        [Description("C7 Led Light 4")]
        C7LEDLIGHT4 = 2704,

        /// <summary>
        /// C7 Led Light 5
        /// </summary>
        [Description("C7 Led Light 5")]
        C7LEDLIGHT5 = 2705,

        /// <summary>
        /// C7 Led Light 6
        /// </summary>
        [Description("C7 Led Light 6")]
        C7LEDLIGHT6 = 2706,

        /// <summary>
        /// C7 Led Light 7
        /// </summary>
        [Description("C7 Led Light 7")]
        C7LEDLIGHT7 = 2707,

        /// <summary>
        /// C7 Led Light 8
        /// </summary>
        [Description("C7 Led Light 8")]
        C7LEDLIGHT8 = 2708,

        /// <summary>
        /// C7 Led Light 9
        /// </summary>
        [Description("C7 Led Light 9")]
        C7LEDLIGHT9 = 2709,

        /// <summary>
        /// C7 Led Light 10
        /// </summary>
        [Description("C7 Led Light 10")]
        C7LEDLIGHT10 = 2710,

        /// <summary>
        /// C7 Led Light 11
        /// </summary>
        [Description("C7 Led Light 11")]
        C7LEDLIGHT11 = 2711,

        /// <summary>
        /// C7 Led Light 12
        /// </summary>
        [Description("C7 Led Light 12")]
        C7LEDLIGHT12 = 2712,

        /// <summary>
        /// C7 Led Light 13
        /// </summary>
        [Description("C7 Led Light 13")]
        C7LEDLIGHT13 = 2713,

        /// <summary>
        /// C7 Led Light 14
        /// </summary>
        [Description("C7 Led Light 14")]
        C7LEDLIGHT14 = 2714,

        /// <summary>
        /// C7 Led Light 15
        /// </summary>
        [Description("C7 Led Light 15")]
        C7LEDLIGHT15 = 2715,

        /// <summary>
        /// C7 Led Light 16
        /// </summary>
        [Description("C7 Led Light 16")]
        C7LEDLIGHT16 = 2716,

        /// <summary>
        /// C7 Led Light 17
        /// </summary>
        [Description("C7 Led Light 17")]
        C7LEDLIGHT17 = 2717,

        /// <summary>
        /// C7 Led Light 18
        /// </summary>
        [Description("C7 Led Light 18")]
        C7LEDLIGHT18 = 2718,

        /// <summary>
        /// C7 Led Light 19
        /// </summary>
        [Description("C7 Led Light 19")]
        C7LEDLIGHT19 = 2719,

        /// <summary>
        /// C7 Led Light 20
        /// </summary>
        [Description("C7 Led Light 20")]
        C7LEDLIGHT20 = 2720,

        /// <summary>
        /// C7 Led Light 21
        /// </summary>
        [Description("C7 Led Light 21")]
        C7LEDLIGHT21 = 2721,

        /// <summary>
        /// C7 Led Light 22
        /// </summary>
        [Description("C7 Led Light 22")]
        C7LEDLIGHT22 = 2722,

        /// <summary>
        /// C7 Led Light 23
        /// </summary>
        [Description("C7 Led Light 23")]
        C7LEDLIGHT23 = 2723,

        /// <summary>
        /// C7 Led Light 24
        /// </summary>
        [Description("C7 Led Light 24")]
        C7LEDLIGHT24 = 2724,

        /// <summary>
        /// C7 Led Light 25
        /// </summary>
        [Description("C7 Led Light 25")]
        C7LEDLIGHT25 = 2725,

        /// <summary>
        /// C7 Led Light 26
        /// </summary>
        [Description("C7 Led Light 26")]
        C7LEDLIGHT26 = 2726,

        /// <summary>
        /// C7 Led Light 27
        /// </summary>
        [Description("C7 Led Light 27")]
        C7LEDLIGHT27 = 2727,

        /// <summary>
        /// C7 Led Light 28
        /// </summary>
        [Description("C7 Led Light 28")]
        C7LEDLIGHT28 = 2728,

        /// <summary>
        /// C7 Led Light 29
        /// </summary>
        [Description("C7 Led Light 29")]
        C7LEDLIGHT29 = 2729,

        /// <summary>
        /// C7 Led Light 30
        /// </summary>
        [Description("C7 Led Light 30")]
        C7LEDLIGHT30 = 2730,

        /// <summary>
        /// C7 Led Light 31
        /// </summary>
        [Description("C7 Led Light 31")]
        C7LEDLIGHT31 = 2731,

        /// <summary>
        /// C7 Led Light 32
        /// </summary>
        [Description("C7 Led Light 32")]
        C7LEDLIGHT32 = 2732,

        /// <summary>
        /// C7 Led Light 33
        /// </summary>
        [Description("C7 Led Light 33")]
        C7LEDLIGHT33 = 2733,

        /// <summary>
        /// C7 Led Light 34
        /// </summary>
        [Description("C7 Led Light 34")]
        C7LEDLIGHT34 = 2734,

        /// <summary>
        /// C7 Led Light 35
        /// </summary>
        [Description("C7 Led Light 35")]
        C7LEDLIGHT35 = 2735,

        /// <summary>
        /// C7 Led Light 36
        /// </summary>
        [Description("C7 Led Light 36")]
        C7LEDLIGHT36 = 2736,

        /// <summary>
        /// C7 Led Light 37
        /// </summary>
        [Description("C7 Led Light 37")]
        C7LEDLIGHT37 = 2737,

        /// <summary>
        /// C7 Led Light 38
        /// </summary>
        [Description("C7 Led Light 38")]
        C7LEDLIGHT38 = 2738,

        /// <summary>
        /// C7 Led Light 39
        /// </summary>
        [Description("C7 Led Light 39")]
        C7LEDLIGHT39 = 2739,

        /// <summary>
        /// C7 Led Light 40
        /// </summary>
        [Description("C7 Led Light 40")]
        C7LEDLIGHT40 = 2740,

        /// <summary>
        /// C7 Led Light 41
        /// </summary>
        [Description("C7 Led Light 41")]
        C7LEDLIGHT41 = 2741,

        /// <summary>
        /// C7 Led Light 42
        /// </summary>
        [Description("C7 Led Light 42")]
        C7LEDLIGHT42 = 2742,

        /// <summary>
        /// C7 Led Light 43
        /// </summary>
        [Description("C7 Led Light 43")]
        C7LEDLIGHT43 = 2743,

        /// <summary>
        /// C7 Led Light 44
        /// </summary>
        [Description("C7 Led Light 44")]
        C7LEDLIGHT44 = 2744,

        /// <summary>
        /// C7 Led Light 45
        /// </summary>
        [Description("C7 Led Light 45")]
        C7LEDLIGHT45 = 2745,

        /// <summary>
        /// C7 Led Light 46
        /// </summary>
        [Description("C7 Led Light 46")]
        C7LEDLIGHT46 = 2746,

        /// <summary>
        /// C7 Led Light 47
        /// </summary>
        [Description("C7 Led Light 47")]
        C7LEDLIGHT47 = 2747,

        /// <summary>
        /// C7 Led Light 48
        /// </summary>
        [Description("C7 Led Light 48")]
        C7LEDLIGHT48 = 2748,

        /// <summary>
        /// C7 Led Light 49
        /// </summary>
        [Description("C7 Led Light 49")]
        C7LEDLIGHT49 = 2749,

        /// <summary>
        /// C7 Led Light 50
        /// </summary>
        [Description("C7 Led Light 50")]
        C7LEDLIGHT50 = 2750,

        //////////////////////////////////////////////   Fifth Zone (100, Channel 8 Lights)(Various)

        /// <summary>
        /// C8 Led Light 1
        /// </summary>
        [Description("C8 Led Light 1")]
        C8LEDLIGHT1 = 2801,


        /// <summary>
        /// C8 Led Light 2
        /// </summary>
        [Description("C8 Led Light 2")]
        C8LEDLIGHT2 = 2802,

        /// <summary>
        /// C8 Led Light 3
        /// </summary>
        [Description("C8 Led Light 3")]
        C8LEDLIGHT3 = 2803,

        /// <summary>
        /// C8 Led Light 4
        /// </summary>
        [Description("C8 Led Light 4")]
        C8LEDLIGHT4 = 2804,

        /// <summary>
        /// C8 Led Light 5
        /// </summary>
        [Description("C8 Led Light 5")]
        C8LEDLIGHT5 = 2805,

        /// <summary>
        /// C8 Led Light 6
        /// </summary>
        [Description("C8 Led Light 6")]
        C8LEDLIGHT6 = 2806,

        /// <summary>
        /// C8 Led Light 7
        /// </summary>
        [Description("C8 Led Light 7")]
        C8LEDLIGHT7 = 2807,

        /// <summary>
        /// C8 Led Light 8
        /// </summary>
        [Description("C8 Led Light 8")]
        C8LEDLIGHT8 = 2808,

        /// <summary>
        /// C8 Led Light 9
        /// </summary>
        [Description("C8 Led Light 9")]
        C8LEDLIGHT9 = 2809,

        /// <summary>
        /// C8 Led Light 10
        /// </summary>
        [Description("C8 Led Light 10")]
        C8LEDLIGHT10 = 2810,

        /// <summary>
        /// C8 Led Light 11
        /// </summary>
        [Description("C8 Led Light 11")]
        C8LEDLIGHT11 = 2811,

        /// <summary>
        /// C8 Led Light 12
        /// </summary>
        [Description("C8 Led Light 12")]
        C8LEDLIGHT12 = 2812,

        /// <summary>
        /// C8 Led Light 13
        /// </summary>
        [Description("C8 Led Light 13")]
        C8LEDLIGHT13 = 2813,

        /// <summary>
        /// C8 Led Light 14
        /// </summary>
        [Description("C8 Led Light 14")]
        C8LEDLIGHT14 = 2814,

        /// <summary>
        /// C8 Led Light 15
        /// </summary>
        [Description("C8 Led Light 15")]
        C8LEDLIGHT15 = 2815,

        /// <summary>
        /// C8 Led Light 16
        /// </summary>
        [Description("C8 Led Light 16")]
        C8LEDLIGHT16 = 2816,

        /// <summary>
        /// C8 Led Light 17
        /// </summary>
        [Description("C8 Led Light 17")]
        C8LEDLIGHT17 = 2817,

        /// <summary>
        /// C8 Led Light 18
        /// </summary>
        [Description("C8 Led Light 18")]
        C8LEDLIGHT18 = 2818,

        /// <summary>
        /// C8 Led Light 19
        /// </summary>
        [Description("C8 Led Light 19")]
        C8LEDLIGHT19 = 2819,

        /// <summary>
        /// C8 Led Light 20
        /// </summary>
        [Description("C8 Led Light 20")]
        C8LEDLIGHT20 = 2820,

        /// <summary>
        /// C8 Led Light 21
        /// </summary>
        [Description("C8 Led Light 21")]
        C8LEDLIGHT21 = 2821,

        /// <summary>
        /// C8 Led Light 22
        /// </summary>
        [Description("C8 Led Light 22")]
        C8LEDLIGHT22 = 2822,

        /// <summary>
        /// C8 Led Light 23
        /// </summary>
        [Description("C8 Led Light 23")]
        C8LEDLIGHT23 = 2823,

        /// <summary>
        /// C8 Led Light 24
        /// </summary>
        [Description("C8 Led Light 24")]
        C8LEDLIGHT24 = 2824,

        /// <summary>
        /// C8 Led Light 25
        /// </summary>
        [Description("C8 Led Light 25")]
        C8LEDLIGHT25 = 2825,

        /// <summary>
        /// C8 Led Light 26
        /// </summary>
        [Description("C8 Led Light 26")]
        C8LEDLIGHT26 = 2826,

        /// <summary>
        /// C8 Led Light 27
        /// </summary>
        [Description("C8 Led Light 27")]
        C8LEDLIGHT27 = 2827,

        /// <summary>
        /// C8 Led Light 28
        /// </summary>
        [Description("C8 Led Light 28")]
        C8LEDLIGHT28 = 2828,

        /// <summary>
        /// C8 Led Light 29
        /// </summary>
        [Description("C8 Led Light 29")]
        C8LEDLIGHT29 = 2829,

        /// <summary>
        /// C8 Led Light 30
        /// </summary>
        [Description("C8 Led Light 30")]
        C8LEDLIGHT30 = 2830,

        /// <summary>
        /// C8 Led Light 31
        /// </summary>
        [Description("C8 Led Light 31")]
        C8LEDLIGHT31 = 2831,

        /// <summary>
        /// C8 Led Light 32
        /// </summary>
        [Description("C8 Led Light 32")]
        C8LEDLIGHT32 = 2832,

        /// <summary>
        /// C8 Led Light 33
        /// </summary>
        [Description("C8 Led Light 33")]
        C8LEDLIGHT33 = 2833,

        /// <summary>
        /// C8 Led Light 34
        /// </summary>
        [Description("C8 Led Light 34")]
        C8LEDLIGHT34 = 2834,

        /// <summary>
        /// C8 Led Light 35
        /// </summary>
        [Description("C8 Led Light 35")]
        C8LEDLIGHT35 = 2835,

        /// <summary>
        /// C8 Led Light 36
        /// </summary>
        [Description("C8 Led Light 36")]
        C8LEDLIGHT36 = 2836,

        /// <summary>
        /// C8 Led Light 37
        /// </summary>
        [Description("C8 Led Light 37")]
        C8LEDLIGHT37 = 2837,

        /// <summary>
        /// C8 Led Light 38
        /// </summary>
        [Description("C8 Led Light 38")]
        C8LEDLIGHT38 = 2838,

        /// <summary>
        /// C8 Led Light 39
        /// </summary>
        [Description("C8 Led Light 39")]
        C8LEDLIGHT39 = 2839,

        /// <summary>
        /// C8 Led Light 40
        /// </summary>
        [Description("C8 Led Light 40")]
        C8LEDLIGHT40 = 2840,

        /// <summary>
        /// C8 Led Light 41
        /// </summary>
        [Description("C8 Led Light 41")]
        C8LEDLIGHT41 = 2841,

        /// <summary>
        /// C8 Led Light 42
        /// </summary>
        [Description("C8 Led Light 42")]
        C8LEDLIGHT42 = 2842,

        /// <summary>
        /// C8 Led Light 43
        /// </summary>
        [Description("C8 Led Light 43")]
        C8LEDLIGHT43 = 2843,

        /// <summary>
        /// C8 Led Light 44
        /// </summary>
        [Description("C8 Led Light 44")]
        C8LEDLIGHT44 = 2844,

        /// <summary>
        /// C8 Led Light 45
        /// </summary>
        [Description("C8 Led Light 45")]
        C8LEDLIGHT45 = 2845,

        /// <summary>
        /// C8 Led Light 46
        /// </summary>
        [Description("C8 Led Light 46")]
        C8LEDLIGHT46 = 2846,

        /// <summary>
        /// C8 Led Light 47
        /// </summary>
        [Description("C8 Led Light 47")]
        C8LEDLIGHT47 = 2847,

        /// <summary>
        /// C8 Led Light 48
        /// </summary>
        [Description("C8 Led Light 48")]
        C8LEDLIGHT48 = 2848,

        /// <summary>
        /// C8 Led Light 49
        /// </summary>
        [Description("C8 Led Light 49")]
        C8LEDLIGHT49 = 2849,

        /// <summary>
        /// C8 Led Light 50
        /// </summary>
        [Description("C8 Led Light 50")]
        C8LEDLIGHT50 = 2850,

        //////////////////////////////////////////////   Fifth Zone (100, Channel 9 Lights)(Various)

        /// <summary>
        /// C9 Led Light 1
        /// </summary>
        [Description("C9 Led Light 1")]
        C9LEDLIGHT1 = 2901,

        /// <summary>
        /// C9 Led Light 2
        /// </summary>
        [Description("C9 Led Light 2")]
        C9LEDLIGHT2 = 2902,

        /// <summary>
        /// C9 Led Light 3
        /// </summary>
        [Description("C9 Led Light 3")]
        C9LEDLIGHT3 = 2903,

        /// <summary>
        /// C9 Led Light 4
        /// </summary>
        [Description("C9 Led Light 4")]
        C9LEDLIGHT4 = 2904,

        /// <summary>
        /// C9 Led Light 5
        /// </summary>
        [Description("C9 Led Light 5")]
        C9LEDLIGHT5 = 2905,

        /// <summary>
        /// C9 Led Light 6
        /// </summary>
        [Description("C9 Led Light 6")]
        C9LEDLIGHT6 = 2906,

        /// <summary>
        /// C9 Led Light 7
        /// </summary>
        [Description("C9 Led Light 7")]
        C9LEDLIGHT7 = 2907,

        /// <summary>
        /// C9 Led Light 8
        /// </summary>
        [Description("C9 Led Light 8")]
        C9LEDLIGHT8 = 2908,

        /// <summary>
        /// C9 Led Light 9
        /// </summary>
        [Description("C9 Led Light 9")]
        C9LEDLIGHT9 = 2909,

        /// <summary>
        /// C9 Led Light 10
        /// </summary>
        [Description("C9 Led Light 10")]
        C9LEDLIGHT10 = 2910,

        /// <summary>
        /// C9 Led Light 11
        /// </summary>
        [Description("C9 Led Light 11")]
        C9LEDLIGHT11 = 2911,

        /// <summary>
        /// C9 Led Light 12
        /// </summary>
        [Description("C9 Led Light 12")]
        C9LEDLIGHT12 = 2912,

        /// <summary>
        /// C9 Led Light 13
        /// </summary>
        [Description("C9 Led Light 13")]
        C9LEDLIGHT13 = 2913,

        /// <summary>
        /// C9 Led Light 14
        /// </summary>
        [Description("C9 Led Light 14")]
        C9LEDLIGHT14 = 2914,

        /// <summary>
        /// C9 Led Light 15
        /// </summary>
        [Description("C9 Led Light 15")]
        C9LEDLIGHT15 = 2915,

        /// <summary>
        /// C9 Led Light 16
        /// </summary>
        [Description("C9 Led Light 16")]
        C9LEDLIGHT16 = 2916,

        /// <summary>
        /// C9 Led Light 17
        /// </summary>
        [Description("C9 Led Light 17")]
        C9LEDLIGHT17 = 2917,

        /// <summary>
        /// C9 Led Light 18
        /// </summary>
        [Description("C9 Led Light 18")]
        C9LEDLIGHT18 = 2918,

        /// <summary>
        /// C9 Led Light 19
        /// </summary>
        [Description("C9 Led Light 19")]
        C9LEDLIGHT19 = 2919,

        /// <summary>
        /// C9 Led Light 20
        /// </summary>
        [Description("C9 Led Light 20")]
        C9LEDLIGHT20 = 2920,

        /// <summary>
        /// C9 Led Light 21
        /// </summary>
        [Description("C9 Led Light 21")]
        C9LEDLIGHT21 = 2921,

        /// <summary>
        /// C9 Led Light 22
        /// </summary>
        [Description("C9 Led Light 22")]
        C9LEDLIGHT22 = 2922,

        /// <summary>
        /// C9 Led Light 23
        /// </summary>
        [Description("C9 Led Light 23")]
        C9LEDLIGHT23 = 2923,

        /// <summary>
        /// C9 Led Light 24
        /// </summary>
        [Description("C9 Led Light 24")]
        C9LEDLIGHT24 = 2924,

        /// <summary>
        /// C9 Led Light 25
        /// </summary>
        [Description("C9 Led Light 25")]
        C9LEDLIGHT25 = 2925,

        /// <summary>
        /// C9 Led Light 26
        /// </summary>
        [Description("C9 Led Light 26")]
        C9LEDLIGHT26 = 2926,

        /// <summary>
        /// C9 Led Light 27
        /// </summary>
        [Description("C9 Led Light 27")]
        C9LEDLIGHT27 = 2927,

        /// <summary>
        /// C9 Led Light 28
        /// </summary>
        [Description("C9 Led Light 28")]
        C9LEDLIGHT28 = 2928,

        /// <summary>
        /// C9 Led Light 29
        /// </summary>
        [Description("C9 Led Light 29")]
        C9LEDLIGHT29 = 2929,

        /// <summary>
        /// C9 Led Light 30
        /// </summary>
        [Description("C9 Led Light 30")]
        C9LEDLIGHT30 = 2930,

        /// <summary>
        /// C9 Led Light 31
        /// </summary>
        [Description("C9 Led Light 31")]
        C9LEDLIGHT31 = 2931,

        /// <summary>
        /// C9 Led Light 32
        /// </summary>
        [Description("C9 Led Light 32")]
        C9LEDLIGHT32 = 2932,

        /// <summary>
        /// C9 Led Light 33
        /// </summary>
        [Description("C9 Led Light 33")]
        C9LEDLIGHT33 = 2933,

        /// <summary>
        /// C9 Led Light 34
        /// </summary>
        [Description("C9 Led Light 34")]
        C9LEDLIGHT34 = 2934,

        /// <summary>
        /// C9 Led Light 35
        /// </summary>
        [Description("C9 Led Light 35")]
        C9LEDLIGHT35 = 2935,

        /// <summary>
        /// C9 Led Light 36
        /// </summary>
        [Description("C9 Led Light 36")]
        C9LEDLIGHT36 = 2936,

        /// <summary>
        /// C9 Led Light 37
        /// </summary>
        [Description("C9 Led Light 37")]
        C9LEDLIGHT37 = 2937,

        /// <summary>
        /// C9 Led Light 38
        /// </summary>
        [Description("C9 Led Light 38")]
        C9LEDLIGHT38 = 2938,

        /// <summary>
        /// C9 Led Light 39
        /// </summary>
        [Description("C9 Led Light 39")]
        C9LEDLIGHT39 = 2939,

        /// <summary>
        /// C9 Led Light 40
        /// </summary>
        [Description("C9 Led Light 40")]
        C9LEDLIGHT40 = 2940,

        /// <summary>
        /// C9 Led Light 41
        /// </summary>
        [Description("C9 Led Light 41")]
        C9LEDLIGHT41 = 2941,

        /// <summary>
        /// C9 Led Light 42
        /// </summary>
        [Description("C9 Led Light 42")]
        C9LEDLIGHT42 = 2942,

        /// <summary>
        /// C9 Led Light 43
        /// </summary>
        [Description("C9 Led Light 43")]
        C9LEDLIGHT43 = 2943,

        /// <summary>
        /// C9 Led Light 44
        /// </summary>
        [Description("C9 Led Light 44")]
        C9LEDLIGHT44 = 2944,

        /// <summary>
        /// C9 Led Light 45
        /// </summary>
        [Description("C9 Led Light 45")]
        C9LEDLIGHT45 = 2945,

        /// <summary>
        /// C9 Led Light 46
        /// </summary>
        [Description("C9 Led Light 46")]
        C9LEDLIGHT46 = 2946,

        /// <summary>
        /// C9 Led Light 47
        /// </summary>
        [Description("C9 Led Light 47")]
        C9LEDLIGHT47 = 2947,

        /// <summary>
        /// C9 Led Light 48
        /// </summary>
        [Description("C9 Led Light 48")]
        C9LEDLIGHT48 = 2948,

        /// <summary>
        /// C9 Led Light 49
        /// </summary>
        [Description("C9 Led Light 49")]
        C9LEDLIGHT49 = 2949,

        /// <summary>
        /// C9 Led Light 50
        /// </summary>
        [Description("C9 Led Light 50")]
        C9LEDLIGHT50 = 2950,
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
