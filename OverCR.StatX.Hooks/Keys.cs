﻿namespace OverCR.StatX.Hooks
{
    public enum Keys
    {
        LeftMouseButton = 0x01,     
        RightMouseButton = 0x02,    
        Break = 0x03,              
        MiddleMousButton = 0x04,    
        XMouseButton1 = 0x05,       
        XMouseButton2 = 0x06,       
               
        Backspace = 0x08,   
        Tab = 0x09,         
                            
        Clear = 0x0C,       
        Return = 0x0D,      
                            
        Shift = 0x10,       
        Control = 0x11,     
        Alt = 0x12,        
        Pause = 0x13,       
        CapsLock = 0x14,    
        KanaIME = 0x15,     
        HangulIME = 0x15,   
                            
        JunjaIME = 0x17,    
        FinalIME = 0x18,    
        HanjaIME = 0x19,    
        KanjiIME = 0x19,    
                            
        Escape = 0x1B,      
        Convert = 0x1C,                        
        NonConvert = 0x1D,  
        Accept = 0x1E,                       
        ModeChange = 0x1F,  
        Space = 0x20,       
        PageUp = 0x21,      
        PageDown = 0x22,    
        End = 0x23,         
        Home = 0x24,        
        LeftArrow = 0x25,   
        UpArrow = 0x26,     
        RightArrow = 0x27,  
        DownArrow = 0x28,   
        Select = 0x29,      
        Print = 0x2A,       
        Execute = 0x2B,     
        PrintScreen = 0x2C, 
        Insert = 0x2D,      
        Delete = 0x2E,      
        Help = 0x2F,        
        Alpha0 = 0x30,      
        Alpha1 = 0x31,      
        Alpha2 = 0x32,      
        Alpha3 = 0x33,      
        Alpha4 = 0x34,      
        Alpha5 = 0x35,      
        Alpha6 = 0x36,      
        Alpha7 = 0x37,      
        Alpha8 = 0x38,      
        Alpha9 = 0x39,      
                            
        A = 0x41,       
        B = 0x42,       
        C = 0x43,       
        D = 0x44,       
        E = 0x45,       
        F = 0x46,       
        G = 0x47,       
        H = 0x48,       
        I = 0x49,       
        J = 0x4A,       
        K = 0x4B,       
        L = 0x4C,       
        M = 0x4D,       
        N = 0x4E,       
        O = 0x4F,                                 
        P = 0x50,       
        Q = 0x51,       
        R = 0x52,       
        S = 0x53,       
        T = 0x54,       
        U = 0x55,       
        V = 0x56,       
        W = 0x57,       
        X = 0x58,       
        Y = 0x59,       
        Z = 0x5A,       
        LeftWindows = 0x5B,
        RightWindows = 0x5C,
        ContextMenu = 0x5D,
                            
        Sleep = 0x5F,       
        Num0 = 0x60,     
        Num1 = 0x61,     
        Num2 = 0x62,     
        Num3 = 0x63,     
        Num4 = 0x64,     
        Num5 = 0x65,     
        Num6 = 0x66,     
        Num7 = 0x67,     
        Num8 = 0x68,     
        Num9 = 0x69,     
        NumAsterisk = 0x6A, 
        NumPlus = 0x6B,     
        NumComma = 0x6C,   
        NumMinus = 0x6D,    
        NumDecimal = 0x6E,  
        NumSlash = 0x6F,    
        F1 = 0x70,          
        F2 = 0x71,          
        F3 = 0x72,          
        F4 = 0x73,          
        F5 = 0x74,          
        F6 = 0x75,          
        F7 = 0x76,          
        F8 = 0x77,          
        F9 = 0x78,          
        F10 = 0x79,         
        F11 = 0x7A,         
        F12 = 0x7B,         
        F13 = 0x7C,         
        F14 = 0x7D,         
        F15 = 0x7E,         
        F16 = 0x7F,         
        F17 = 0x80,         
        F18 = 0x81,         
        F19 = 0x82,         
        F20 = 0x83,         
        F21 = 0x84,         
        F22 = 0x85,         
        F23 = 0x86,         
        F24 = 0x87,         
                            
        NumLock = 0x90,     
        ScrollLock = 0x91,  
                                            
        LeftShift = 0xA0,   
        RightShift = 0xA1,  
        LeftControl = 0xA2, 
        RightControl = 0xA3,    
        LeftAlt = 0xA4,       
        RightAlt = 0xA5,      
        BrowserBack = 0xA6,    
        BrowserForward = 0xA7, 
        BrowserRefresh = 0xA8, 
        BrowserStop = 0xA9,    
        BrowserSearch = 0xAA,  
        BrowserFavorites = 0xAB,
        BrowserHome = 0xAC,    
        VolumeMute = 0xAD,     
        VolumeDown = 0xAE,     
        VolumeUp = 0xAF,
        MediaNextTrack = 0xB0,
        MediaPreviousTrack = 0xB1,
        MediaStop = 0xB2,
        MediaPlayPause = 0xB3,
        LaunchMail = 0xB4,     
        LaunchMediaSelect = 0xB5,
        LaunchApp1 = 0xB6,
        LaunchApp2 = 0xB7,
        Semicolon = 0xBA,
        Plus = 0xBB,
        Comma = 0xBC,
        Minus = 0xBD,
        Period = 0xBE,
        Slash = 0xBF,
        Tilde = 0xC0,
        LeftBracket = 0xDB,
        BackSlash = 0xDC,
        RightBracket = 0xDD,
        Quote = 0xDE,
        Oem8 = 0xDF,       // Used for miscellaneous characters; it can vary by keyboard.
                            //                  0xE0,  // Reserved
                            //                  0xE1,  // OEM specific
        Oem102 = 0xE2,     // Windows 2000/XP: Either the angle bracket key or the backslash key on the RT 102-key keyboard
                            //                  0xE3-E4,  // OEM specific
        Process = 0xE5,  // Windows 95/98/Me, Windows NT 4.0, Windows 2000/XP: IME PROCESS key
                            //                  0xE6,  // OEM specific
        Packet = 0xE7,      // Windows 2000/XP: Used to pass Unicode characters as if they were keystrokes. The VK_PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods. For more information, see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN, and WM_KEYUP
                            //                  0xE8,  // Unassigned
                            //                  0xE9-F5,  // OEM specific
        OemClear = 0xFE    // Clear key
    }
}