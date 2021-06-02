/**************************************************************************
 *                                                                        *
 *  Copyright:   (c) 2021, Besliu Catalina                                *
 *  E-mail:      catalina.besliu@student.tuiasi.ro                        *
 *  Description: Player module for MP3Player windows forms app            *
 *                                                                        *
 **************************************************************************/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// clasa pentru prelcrarea informatiilor despre fisierele audio folosite 

namespace Player
{
    public class Player
    {
        private string[] _paths, _files;  // nume si pathuri fisiere audio
        private int _volume;        // volum player 
        private static Player instanceOf; // proprietate singleton
        private Player()
        {
            _volume = 100;
        }

        // utilizare singleton
        public static Player getInstance()
        {
            if (instanceOf == null)         // verificare existenta unei alte instante
                instanceOf = new Player();
            return instanceOf;
        }
        public string[] Paths
        {
            get
            {
                return this._paths;
            }
            set
            {
                this._paths = value;
            }
        }
        public string[] Files
        {
            get
            {
                return this._files;
            }
            set
            {
                this._files = value;
            }
        }
        public int Volume
        {
            get
            {
                return this._volume;
            }
            set
            {
                this._volume = value;
            }
        }
        public static void checkVolume(int volume)
        {
            if (volume < 0 || volume > 100)
                throw new Exception("Volume out of range");
        }

        public static void checkFiles(string[] files)
        {
            if (files.Length < 0)
                throw new Exception("No paths found");
        }
    }

}
