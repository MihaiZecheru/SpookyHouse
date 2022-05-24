// System.Windows.Extensions.dll

using System;
using System.Media;

namespace SpookyHouse
{
    class SpookyHouse
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            // check to make sure user is on windows
            if (!OperatingSystem.IsWindows())
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You must be on a Windows device to use this application");
                Console.ReadKey();
                return;
            }
            
            SoundPlayer SpookyPlayer = new SoundPlayer("spooky.wav");
            SpookyPlayer.Load();
            SpookyPlayer.PlayLooping();

            Console.SetWindowSize(Console.WindowWidth, 20);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
                                                                    ,           ^'^  _
                                                                    )               (_) ^'^
                               _/\_                    .---------. ((        ^'^
                               (('>                    )`'`'`'`'`( ||                 ^'^
                          _    /^|                    /`'`'`'`'`'`\||           ^'^
                          =>--/__|m---               /`'`'`'`'`'`'`\|
                               ^^           ,,,,,,, /`'`'`'`'`'`'`'`\      ,
                                           .-------.`|`````````````|`  .   )
                                          / .^. .^. \|  ,^^, ,^^,  |  / \ ((
                                         /  |_| |_|  \  |__| |__|  | /,-,\||
                              _         /_____________\ |')| |  |  |/ |_| \|
                             (')         |  __   __  |  '==' '=='  /_______\     _
                            (' ')        | /  \ /  \ |   _______   |,^, ,^,|    (')
                             \  \        | |--| |--| |  ((--.--))  ||_| |_||   (' ')
                           _  ^^^ _      | |__| |('| |  ||  |  ||  |,-, ,-,|   /  /
                         ,' ',  ,' ',    |           |  ||  |  ||  ||_| |_||   ^^^
,,,..,...,,,,...,,..,,.,,|RIP|,.|RIP|,.,,'==========='==''=='==''=='=======',,....,,,,,.,..,,.,,...,..,.,,,...,..,,,.,,.
");
            Console.ReadKey();
        }
    }
}
