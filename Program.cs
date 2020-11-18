using System;
using System.Threading;
using System.Media;

namespace TDI_Task_04
{

    class Program
    {
        static Random rand = new Random();

        // ПРИВЕТСТВЕННЫЙ РЕСУНОК И СООБЩЕНИЯ О КОНЦЕ ИГРЫ

        static void PrintGameArt()
        {
            Console.Title = "ARENA";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
      █░█░█ █▀▀ █░░ █▀▀ █▀█ █▀▄▀█ █▀▀   ▀█▀ █▀█   ▄▀█ █▀█ █▀▀ █▄░█ ▄▀█
      ▀▄▀▄▀ ██▄ █▄▄ █▄▄ █▄█ █░▀░█ ██▄   ░█░ █▄█   █▀█ █▀▄ ██▄ █░▀█ █▀█");
            Console.ResetColor();

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                                      /|
                                     |\|
                                     |||
                                     |||
                                     |||
                                     |||
                                     |||
                                     |||
                                  ~-[{o}]-~
                                     |/|
              ___                    |/|
             ///~`     |\\_          `0'         =\\\\         . .
            ,  |='  ,))\_| ~-_                    _)  \      _/_/|
           / ,' ,;((((((    ~ \                  `~~~\-~-_ /~ (_/\
         /' -~/~)))))))'\_   _/'                      \_  /'  D   |
        (       (((((( ~-/ ~-/                          ~-;  /    \--_
         ~~--|   ))''    ')  `                            `~~\_    \   )
             :        (_  ~\           ,                    /~~-     ./
              \        \_   )--__  /(_/)                   |    )    )|
    ___       |_     \__/~-__    ~~   ,'      /,_;,   __--(   _/      |
  //~~\`\    /' ~~~----|     ~~~~~~~~'        \-  ((~~    __-~        |
((()   `\`\_(_     _-~~-\                      ``~~ ~~~~~~   \_      /
 )))     ~----'   /      \                                   )       )
  (         ;`~--'        :                                _-    ,;;(
            |    `\       |                             _-~    ,;;;;)
            |    /'`\     ;                          _-~          _/
           /~   /    |    )                         /;;;''  ,;;:-~
          |    /     / | /                         |;;'   ,''
          /   /     |  \\|                         |   ,;(
        _/  /'       \  \_)                   .---__\_    \,--._______
       ( )|'         (~-_|                   (;;'  ;;;~~~/' `;;|  `;;;\
        ) `\_         |-_;;--__               ~~~----__/'    /'_______/
        `----'       (   `~--_ ~~~;;------------~~~~~ ;;;'_/'
                     `~~~~~~~~'~~~-----....___;;;____---~~

");
            Console.ResetColor();
        }

        static void PrintLoseMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
█▄█ █▀█ █░█   █░░ █▀█ █▀ █▀▀   █▀▀ ▄▀█ █▀▄▀█ █▀▀   █▀█ █░█ █▀▀ █▀█
░█░ █▄█ █▄█   █▄▄ █▄█ ▄█ ██▄   █▄█ █▀█ █░▀░█ ██▄   █▄█ ▀▄▀ ██▄ █▀▄");

            Console.ResetColor();
        }

        static void PrintWinMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"
█▄█ █▀█ █░█   █░█░█ █ █▄░█   █▀▀ ▄▀█ █▀▄▀█ █▀▀   █▀█ █░█ █▀▀ █▀█
░█░ █▄█ █▄█   ▀▄▀▄▀ █ █░▀█   █▄█ █▀█ █░▀░█ ██▄   █▄█ ▀▄▀ ██▄ █▀▄");

            Console.ResetColor();
        }

        // РИСУНКИ БОССОВ

        static void PrintBossSkeleton()
        {
            Console.Write("\n||| You are fighting against a ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("SIMPLE SKELETON");
            Console.ResetColor();
            Console.Write(" ! |||\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;



            Console.WriteLine(@"                              _.--''-._
  .                         .'         '.
 / \    ,^.         /(     Y             |      )\
/   `---. |--'\    (  \__..'--   -   -- -'''-.-'  )
|        :|    `>   '.     l_..-------.._l      .'
|      __l;__ .'      '-.__.||_.-'v'-._||`'----'
 \  .-' | |  `              l._       _.'
  \/    | |                   l`^^'^^'j
        | |                _   \_____/     _
        j |               l `--__)-'(__.--' |
        | |               | /`---``-----''1 |  ,-----.
        | |               )/  `--' '---'   \'-'  ___  `-.
        | |              //  `-'  '`----'  /  ,-'   I`.  \
      _ L |_            //  `-.-.'`-----' /  /  |   |  `. \
     '._' / \         _/(   `/   )- ---' ;  /__.J   L.__.\ :
      `._;/7(-.......'  /        ) (     |  |            | |
      `._;l _'--------_/        )-'/     :  |___.    _._./ ;
        | |                 .__ )-'\  __  \  \  I   1   / /
        `-'                /   `-\-(-'   \ \  `.|   | ,' /
                           \__  `-'    __/  `-. `---'',-'
                              )-._.-- (        `-----'
                             )(  l\ o ('..-.
                       _..--' _'-' '--'.-. |
                __,,-'' _,,-''            \ \
               f'. _,,-'                   \ \
              ()--  |                       \ \
                \.  |                       /  \
                  \ \                      |._  |
                   \ \                     |  ()|
                    \ \                     \  /
                     ) `-.                   | |
                    // .__)                  | |
                 _.//7'                      | |
               '---'                         j_| `
                                            (| |
                                             |  \
                                             |lllj
                                             |||||");
        }

        static void PrintBossOgre()
        {
            Console.Write("\n||| You are fighting against an ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("OGRE");
            Console.ResetColor();
            Console.Write(" ! |||\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine(@"           _......._
       .-'.'.'.'.'.'.`-.
     .'.'.'.'.'.'.'.'.'.`.
    /.'.'               '.\
    |.'    _.--...--._     |
    \    `._.-.....-._.'   /
    |     _..- .-. -.._   |
 .-.'    `.   ((@))  .'   '.-.
( ^ \      `--.   .-'     / ^ )
 \  /         .   .       \  /
 /          .'     '.  .-    \
( _.\    \ (_`-._.-'_)    /._\)
 `-' \   ' .--.          / `-'
     |  / /|_| `-._.'\   |
     |   |       |_| |   /-.._
 _..-\   `.--.______.'  |
      \       .....     |
       `.  .'      `.  /
         \           .'
          `-..___..-`
");
        }

        static void PrintBossWerewolf()
        {
            Console.Write("\n||| You are fighting against a ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("WEREWOLF");
            Console.ResetColor();
            Console.Write(" ! |||\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine(@"                                             ,--,  ,.-.
               ,                   \,       '-,-`,'-.' | ._
              /|           \    ,   |\         }  )/  / `-,',
              [ ,          |\  /|   | |        /  \|  |/`  ,`
              | |       ,.`  `,` `, | |  _,...(   (      .',
              \  \  __ ,-` `  ,  , `/ |,'      Y     (   /_L\
               \  \_\,``,   ` , ,  /  |         )         _,/
                \  '  `  ,_ _`_,-,<._.<        /         /
                 ', `>.,`  `  `   ,., |_      |         /
                   \/`  `,   `   ,`  | /__,.-`    _,   `\
               -,-..\  _  \  `  /  ,  / `._) _,-\`       \
                \_,,.) /\    ` /  / ) (-,, ``    ,        |
               ,` )  | \_\       '-`  |  `(               \
              /  /```(   , --, ,' \   |`<`    ,            |
             /  /_,--`\   <\  V /> ,` )<_/)  | \      _____)
       ,-, ,`   `   (_,\ \    |   /) / __/  /   `----`
      (-, \           ) \ ('_.-._)/ /,`    /
      | /  `          `/ \\ V   V, /`     /
   ,--\(        ,     <_/`\\     ||      /
  (   ,``-     \/|         \-A.A-`|     /
 ,>,_ )_,..(    )\          -,,_-`  _--`
(_ \|`   _,/_  /  \_            ,--`
 \( `   <.,../`     `-.._   _,-`
");
        }

        static void PrintBossNecromancer()
        {
            Console.Write("\n||| You are fighting against a ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("NECROMANCER");
            Console.ResetColor();
            Console.Write(" ! |||\n\n");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"                                         .""--..__
                     _                     []       ``-.._
                  .'` `'.                  ||__           `-._
                 /    ,-.\                 ||_ ```---..__     `-.
                /    /:::\\               /|//}          ``--._  `.
                |    |:::||              |////}                `-. \
                |    |:::||             //'///                    `.\
                |    |:::||            //  ||'                      `|
                /    |:::|/        _,-//\  ||
               /`    |:::|`-,__,-'`  |/  \ ||
             /`  |   |'' ||           \   |||
           /`    \   |   ||            |  /||
         |`       |  |   |)            \ | ||
        |          \ |   /      ,.__    \| ||
        /           `         /`    `\   | ||
       |                     /        \  / ||
       |                     |        | /  ||
       /         /           |        `(   ||
      /          .           /          )  ||
     |            \          |     ________||
    /             |          /     `-------.|
   |\            /          |              ||
   \/`-._       |           /              ||
    //   `.    /`           |              ||
   //`.    `. |             \              ||
  ///\ `-._  )/             |              ||
 //// )   .(/               |              ||
 ||||   ,'` )               /              //
 ||||  /                    /             || 
 `\\` /`                    |             // 
     |`                     \            ||  
    /                        |           //  
  /`                          \         //   
/`                            |        ||    
`-.___,-.      .-.        ___,'        (/    
         `---'`   `'----'`
");
        }

        static void PrintBossAncientGiant()
        {
            Console.Write("\n||| You are fighting against an ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("ANCIENT GIANT");
            Console.ResetColor();
            Console.Write(" ! |||\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(@"                             . `  `. .`  ` .
                        . `     `.  ;  .`     ` .
                     .`           \   /           `.
                   .`     . - .   ( @ )   . - .     `.
                  /    .`      `.  '-'  .'      `.    \
          /\    .`    /   .--.   `-._.-'   .--.   \    `.    /\
        .`  `. /    .'  .`    `. `.   .` .`    `.  `.    \ .`  `.
      .`     .`    /   /        \  \ /  /        \   \    `.     `.
     /      /    .'   /   . ''' .\     /. ''' .   \   `.    \      \
    |    .`(    /    |   /        \   /        \   |    \    )`.    |
     \   | /  .'      \ |   /##\  |   |  /##\   | /      `.  \ |   /
      |  / | /         \\  | ###| /   \ |### |  //         \ | \  |
    .`\  | \/)       _.-'.  \##/ |     | \##/  .'-._       (\/ |  /`.
   /   | |  (      .`     `-.   /       \   .-'     `.      )  | |   \
  |  .`\ \   )               `.'         `.'               (   / /`.  |
  /\/  | |                  .'             `.                  | |  \/\
  \   / /     /            (   .-.     .-.   )            \     \ \   /
   `./ |    .`              `.(   `._.'   ).'              `.    | \ /
   / \ \   /.`\      )._           ) (           _.(      /`.\   / /  \
  /  |  `-'/   \    /  ''--.__    .' '.    __.--''  \    /   \`-'  |   \
  |   `---'/  .`'.  '.       ''--..___..--''       .'  .'`.  \`---'    |
  |    _.-/  /   |'.  '.                         .'  .'|   \  \-._     |
  /\ .`  |  /|  /   '.  ''---....._____.....---''  .'   \  |\ |   `.  /
 |  /     \/ \ |       - . _     _.---._     _ . -       \ /|/      \|
 \ /          \/            ''--._______.--''             \|         \
 .`        \                                                 /        `.
/       ;   |  `.                                       .`  |   ;       \
| (      )  /    \                  ^                  /    \  (      ) |
|  `.      / .`   `.              .` `.              .`   `. \      .`  |
\         \         `-._         /     \         _.-`         /         /
 \         \  _.-`   _  `--.__.-`       `-.__.--`  _   `-._  /         /
 |          `-._    / )   _                   _   ( \    _.-`          |
  \             `-.` (   / )    `-.___.-`    ( \   ) `.-`             /
   \      `.         /.-' / )               ( \ '-.\         .`      /
    `-._     `.     |  .-' / )  `-.___.-`  ( \ '-.  |     .`     _.-`
    /   `--._        \  .-' / )           ( \ '-.  /        _.--`  \
    |   |   \`--.._   |  .-' /  `-.___.-`  \ '-.  |   _..--`/  |    |
     `./     \ .`  `-/.__.--'               '--.__.\-`  `. /    `.  |
      |     / |_           -._            _.-            _| \    |\/
       `.  | /  ''--..__            _            __..--''  \ |  .`
       | \/  |==  ==    ''--..__/\_/ \_/\__..--''    ==  ==|  \/ \
       \     \ _==   ==   ==   / o)|-|(o \   ==   ==   ==_ /     /
       |    /|  ''--..__==  == \ (\) (/) / ==  ==__..--'' ||\    |
        \  / |      |  |''--..__\ )\_/( /__..--''   _.-'\ \\ \  /
         \|  /     /  /          \/___\/     \\ _.-'     \ \\ |/
             |    /  /  :                     \\\    @ .-'  ||
             \_.-`  /          :            : || \_.-'      \\
             /___.-`                          ||       _     \\
             | :                       :       \\     / (    ||
             /               :                  \\    =:_\   \\
             |   :                              ||     )      \\
             |         :                 :      \\          _.//
              \     /\                           \\     _.-'
              |    |  \    |\   :            |\   ||_.-'   |
              | : /   |   /  |      /|      /  |   /|     /
              \  /    \  |   \     | |     | `./  |  \   /
              | / `    |/  `. |    / \  : /    | /    \  |
              \|\ `            \  |   |  | `   \|    ` \ |
                 | `     `.     \ /   / /  `  `.     ` ||/
                 \  `        ,   \|   \ | `          ` /
                  | `.      ,    |    |/            ` |   .    .
                   \             /     \           ,`/     \  /
                    \    . - .   |     |   . - .    /     ( O  )
                     \  .`-._ . /       \ . _.-'.  /       )  (
                     \  : _.-': |       | :`-._ :  /      (    )
                     |   `- -`  \       /  `- -`   |        \ /
          )\         |    ___   |       |   ___    |         |
       )\/ (         /_.-'___'-._\     /_.-'___'-._\        /
      (  @  )       [__.-'   '-._]     [_.-'   '-.__]      |
       \( )/       /|\ _ \   /_  /     \  _\   /_  /   /|  /
           \      | /|`   | |  -_| /\  |_-  | |  ` |  | / /
       |\   |  |\/ | /.-` | |`-._\/ |  /_.-`| |`-. \ /  |/|\       /|
  /\  /  \   \ \ \ \ \-_ /   \.-'/\ \  \'-./   \ _-/ |  / / \ /\  | \
 | / |  / /\ | /  |/ /`-.\ _ /.-'\|  \ /'-.\ _ /.-`\ / | /  / | \ \ |
 \ | \ | |  \\\|  \ .`-_ // \ \ .-\  // -./ / \\ _-`.  \ | |  / / | \
 / \ / \ |  //|\  .`,`__//___\ \__/   \__/ /___\\__`,`. |/ \ / | /  |
 \ |/  |/  |/ |/ /_-_--_--_---,--.`) (`,--.---_--_--_-_\\|  \| \/   \
 / \|  /   /\ /\(_`'_`'_`'_) (____)   (____) (_`'_`'_`'_)/  /\  |   /
");
        }

        static void PrintBossBelial()
        {
            Console.Write("\n||| You are fighting against a ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("BELIAL");
            Console.ResetColor();
            Console.Write(" ! |||\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\tGeneral of the army of Hell!\n\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(@"                            ,-.
       ___,---.__          /'|`\          __,---,___
    ,-'    \`    `-.____,-'  |  `-.____,-'    //    `-.
  ,'        |           ~'\     /`~           |        `.
 /      ___//              `. ,'          ,  , \___      \
|    ,-'   `-.__   _         |        ,    __,-'   `-.    |
|   /          /\_  `   .    |    ,      _/\          \   |
\  |           \ \`-.___ \   |   / ___,-'/ /           |  /
 \  \           | `._   `\\  |  //'   _,' |           /  /
  `-.\         /'  _ `---'' , . ``---' _  `\         /,-'
     ``       /     \    ,='/ \`=.    /     \       ''
             |__   /|\_,--.,-.--,--._/|\   __|
             /  `./  \\`\ |  |  | /,//' \,'  \
            /   /     ||--+--|--+-/-|     \   \
           |   |     /'\_\_\ | /_/_/`\     |   |
            \   \__, \_     `~'     _/ .__/   /
             `-._,-'   `-._______,-'   `-._,-'
");
        }

        static void PrintBossSatan()
        {
            Console.Write("\n||| You are fighting against a ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("SATAN");
            Console.ResetColor();
            Console.Write(" !!! |||\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tPrepare to DIE!\n\n");
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"      ,',            ,,,,,;;;;;;;;;;;;;;;;;;;;;,,,,,             ,',
     ;  ',        ,;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;,         ,  ',
     ;    ;     ,;;;;;; ;;; ;;  ;;;;;;;;;  ;;  ;;; ;;;;,       ;    ;
     ;     `, ,;;;;;;    ;    ;  ;;;;;;;  ;     ;    ;;;;,   ,'     ;
     ,       ',;;  ;           ;   ;;;   ;             ;  ;,'       ,
      ',       ; ,,,,,,,,,,     ;   ;   ;       ,,,,,,,,,,'.       ,
         ,    ,'          ',    ;       ;    ,''           ',    ,'
         ;;.,'                   ;     ;    '                '..'
        ;;;;                '    ;     ;   '                  ;;
       ;;;;  ;               ',  ;  ;  ;  '                ;  ;;;
 :,    ;;;;   ;;               ',;  ;  ;,'               ;;   ;;;
 ,`,   ;;;;     ;;;               ; ; ;                ;;;    ;;;;    ';
:  `,  ,;;;      ;;;;;;;;;;;;;;;,,  ;   ,,;;;;;;;;;;;;;;;     ;;;,  .' ;
;  ; `,;;;;                                                   ;;;; .'   ;
:  ;`, : ;;,,,,     ;''/\'';.                .;''/\'';,  ,'''';; ;' ,'; ;
:  ;  `; ;;    ',,'  \ \/ /  ',  ;     ;   ,'  \ \/ /  ',     ;; ;,'  ; ;
:  `,  ; ;;      '.,,;,,,;,.'    ;     ;    '.,,;,,,;,.'      ;; ;   ,  ;
`,  ; @; ;;                ,'    ;     ;    ',                ;; ;@ ;   ,
  `,'. ; ;               ,'      ;     ;      ',               ; ;  ; ,' 
   `, ',          ,''''''       ;       ;       '''''',          ;,' ;
     `, :       ,'             ;         ;             '',       ;  ;
      '',    ,''              ;     ;     ;               ',     ;''
        ',  '                (,     ;      )                ',  ,'
         ',                    '''''''''''''                   ,'
           '.             ;;;;;;;;;;;;;;;;;;;;;;              ,
             ,          ,;;;;;;;;;;;;;;;;;;;;;;;;,          ,'
              ,        ;;;;;;;;;;;;;;;;;;;;;;;;;;;;        ,
               ,      ;;;;/\/ |  |\/  \/|  | \/\;;;;      ,
               ',     ;;;/     \/        \/     \;;;    ,'
                ',    ;;;\  /\              /\  /;;;   ,'
                  ',  ;;;;\|  |/\ /\  /\ /\|  |/;;;; ,',
                 ,' ',;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;'   ',
               ,'     ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;      ',
             ,'        ;;;;;;;;;;;;;;;;;;;;;;;;;;;;         ',
   ,',',',','           ;;;;;;;;;;;;;;;;;;;;;;;;;;            ',',',',','
                         ;;;;;;;;;;;;;;;;;;;;;;;;
                         ;;;;;;;;;;;;;;;;;;;;;;;;
                          ;;;;;;;;;;;;;;;;;;;;;;;
                           ;;;;;;         ;;;;;;
                           ;;;;;           ;;;;;
                            ;;;             ;;;
                             ;;             ;;
");

            Console.ResetColor();
        }

        // КЛАССЫ БОССА И ИГРОКА

        class Boss
        {
            public string name;
            public int HP = rand.Next(90, 720);

            public int damage;

            public int HeavyHit()
            {
                return damage;
            }
            
            public int Execute()
            {
                return damage * rand.Next(10, 50);
            }

            public void GetHeavyHitInfo()
            {
                Console.WriteLine($"\n{this.name} damaged: {damage}\n");
            }

            public void GetBossInfo()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n||| {this.name}: |||");
                Console.ResetColor();
                Console.WriteLine($"\nHP: {this.HP}\n");
            }
        }

        class Player
        {
            public int HP = rand.Next(100, 600);
            public int MANA = rand.Next(300, 500);
            public int damage;
            public int shield = 0;
            public int madness = 0;
            public int burn = 0;

            public int healthPotionQuantity = 3;
            public int manaPotionQuantity = 3;

            // INFO
            public void GetPlayerInfo()
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n||| Player: |||");
                Console.ResetColor();
                Console.WriteLine($"\nHP: {this.HP}" +
                    $"\nMANA: {this.MANA}" +
                    $"\nHOLINESS:  {this.shield}" +
                    $"\nMADNESS: {this.madness}" +
                    $"\nBURN:  {this.burn}");
            }
            ///////////

            // FIREBALL
            public int FireBall()
            {
                return this.damage;
            }

            public int FireBallManaCost()
            {
                return this.MANA -= 30;
            }

            public void FireBallInfo()
            {
                Console.WriteLine($"\nYou Damaged: {this.FireBall()}");
            }
            ///////////

            // Pyro Blast
            public int PyroBlast()
            {
                return this.damage + rand.Next(50, 100);
            }

            public int PyroBlastManaCost()
            {
                return this.MANA -= 100;
            }

            public void GetPyroBlastInfo()
            {
                Console.WriteLine($"\nYou Damaged: {this.PyroBlast()}");
            }
            ///////////
            
            // SUMMON FIRE PILLAR
            public int SummonFirePillar()
            {
                this.burn += 4;
                return this.damage += 20;
            }

            public int SummonFirePillarManaCost()
            {
                return this.MANA -= 30;
            }

            public void GetSummonFirePillarInfo()
            {
                Console.WriteLine("\nYou summon a pillar of fire." +
                    "\nThe enemy on fire for 3 turns");
            }
            ///////////

            // FIRE MADNESS
            public int FireMadness()
            {
                this.madness += 6;
                this.HP -= 20;
                return this.damage += 30;
            }
            public int FireMadnessManaCost()
            {
                return this.MANA -= 35;
            }

            public void GetFireMadnessInfo()
            {
                Console.WriteLine("\nFire completely takes over your mind, you are not in control." +
                    "\nYou get +30 Damage for 5 turns");
            }
            ///////////

            // HEAL
            public int Heal()
            {
                return this.HP += 70;
            }

            public int HealManaCost()
            {
                return this.MANA -= 65;
            }

            public void GetHealInfo()
            {
                Console.WriteLine($"You restored: {70} HP");
            }
            ///////////
            
            // DIVINE SHIELD
            public int DivineShield()
            {
                return this.shield += 5;
            }

            public int DivineShieldManaCost()
            {
                return this.HP -= 100;
            }

            public void GetDivineShieldInfo()
            {
                Console.WriteLine("\nYou feel the presence of supernatural forces." +
                    "\nYou get +100 shield points every turn for 6 turns");
            }

            ///////////

            // Potions
            public int HealthPotion()
            {
                this.healthPotionQuantity--;
                return this.HP += 50;
            }

            public int ManaPotion()
            {
                this.manaPotionQuantity--;
                return this.MANA += 70;
            }
            ///////////
        }

        static void Main()
        {
            int origWidth, width;
            int origHeight, height;

            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;

            width = origWidth / 2 + 25;
            height = origHeight * 2 - 10;
            Console.SetWindowSize(width, height);

            Boss Boss = new Boss();
            Player Player = new Player();

            string menuChoice;
            int spell;
            
            int turn = 1;

            int BossStartHP = Boss.HP;

            
            try
            {
                PrintGameArt();
                Console.Write("\t\t    Wirte ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[SD] ");
                Console.ResetColor();
                Console.Write("to open spells description");
                Console.Write("\n\t\t      Or just press to ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("START");
                Console.ResetColor();
                Console.Write(" the game > ");

                menuChoice = Console.ReadLine();

                if (menuChoice == "SD" || menuChoice == "sd")
                {
                    //ПОЖАЛУЙСТА ПРОПИШИТЕ ЗДЕСЬ ВЕРНЫЙ ПУТЬ К ТЕКСТОВОМУ ФАЙЛУ С ОПИСАНИЕМ ЗАКЛИНАНИЙ
                    string[] lines = System.IO.File.ReadAllLines(@"D:\DOCUMENTS\STADYING\PRACTICE\TrainingPractice_01\TDI_Task_04\spells_description.txt");
                    Console.WriteLine("\n======================SPELLS DESCRIPTION:======================");
                    foreach (string line in lines)
                    {
                        Console.WriteLine("/" + line);
                    }

                    Console.Write("\n\t\t\tPress to ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("START");
                    Console.ResetColor();
                    Console.Write(" the game > ");
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid input, try again . . .");
            }

            while (Player.HP > 0 || Boss.HP > 0)
            {
                if (BossStartHP <= 100)
                {
                    Boss.name = "SIMPLE SKELETON";
                    PrintBossSkeleton();
                }
                else if (BossStartHP <= 200)
                {
                    Boss.name = "OGRE";
                    PrintBossOgre();
                }
                else if (BossStartHP <= 300)
                {
                    Boss.name = "WEREWOLF";
                    PrintBossWerewolf();
                }
                else if (BossStartHP <= 400)
                {
                    Boss.name = "NECROMANCER";
                    PrintBossNecromancer();
                }
                else if (BossStartHP <= 500)
                {
                    Boss.name = "ANCIENT GIANT";
                    PrintBossAncientGiant();
                }
                else if (BossStartHP <= 600)
                {
                    Boss.name = "BELIAL";
                    PrintBossBelial();
                }
                else if (BossStartHP <= 700 || BossStartHP >= 700)
                {
                    Boss.name = "SATAN";
                    PrintBossSatan();
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"\nPLayer:");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\t\tBoss: ");
                Console.ResetColor();
                Console.WriteLine($"\n=======\t\t=======" +
                        $"\nHP: {Player.HP}\t\tHP: {Boss.HP}" +
                        $"\nMANA: {Player.MANA}");
                Console.WriteLine($"\nChoose spells in SPELLS or potion in BACKPACK" +
                    $"\nand write the spell or the potion number...");

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n\t\t======TURN: {turn}======");
                Console.ResetColor();
                turn++;

                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n======================SPELLS:======================");
                    Console.ResetColor();

                    Console.WriteLine("\nFIREBALL[1]\tPYROBLAST[2]\tHEAL[3]\t  DIVINE SHIELD[4]" +
                        "\nMana: 30\tMana: 100\tMana: 65  Mana: 100" +
                        "\n\nSUMMON FIRE PILLAR[5]\tFIRE MADNESS[6]" +
                        "\nMana: 30\t\tMana: 35");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n=====================BACKPACK:======================");
                    Console.ResetColor();

                    Console.WriteLine($"\nHealth Potion[7]   Mana Potion[8]" +
                        $"\n{Player.healthPotionQuantity} Left\t\t   {Player.manaPotionQuantity} Left");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nSpell or Potion > ");
                    Console.ResetColor();

                    spell = Convert.ToInt32(Console.ReadLine());

                    switch (spell)
                    {
                        case 1:

                            if (Player.MANA >= 30)
                            {
                                Player.damage = rand.Next(1, 85);

                                Boss.HP -= Player.FireBall();
                                Player.FireBallManaCost();
                                Player.FireBallInfo();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nYou trying to cast fireball\n" +
                                    "but YOU DON'T HAVE ENOUGH MANA!");
                                break;
                            }

                        case 2:

                            if (Player.MANA >= 100)
                            {
                                Player.damage = rand.Next(1, 85);

                                Boss.HP -= Player.PyroBlast();
                                Player.PyroBlastManaCost();
                                Player.GetPyroBlastInfo();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nYou trying to cast pyro blast\n" +
                                    "but YOU DON'T HAVE ENOUGH MANA!");
                                break;
                            }

                        case 3:

                            if (Player.MANA >= 70)
                            {
                                Player.Heal();
                                Player.HealManaCost();
                                Player.GetHealInfo();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nYou trying to cast healing spell\n" +
                                    "but YOU DON'T HAVE ENOUGH MANA!");
                                break;
                            }

                        case 4:

                            if (Player.MANA >= 100)
                            {
                                Player.DivineShield();
                                Player.DivineShieldManaCost();
                                Player.GetDivineShieldInfo();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nYou are trying to appeal to higher powers, but they do not hear you ...\n" +
                                    "YOU DON'T HAVE ENOUGH MANA!");
                                break;
                            }

                        case 5:

                            if (Player.MANA >= 30)
                            {
                                Player.SummonFirePillar();
                                Player.SummonFirePillarManaCost();
                                Player.GetSummonFirePillarInfo();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nYou are trying to summon a pillar of fire\n" +
                                    "but YOU DON'T HAVE ENOUGH MANA!");
                                break;
                            }

                        case 6:

                            if (Player.MANA >= 35)
                            {
                                Player.FireMadness();
                                Player.FireMadnessManaCost();
                                Player.GetFireMadnessInfo();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nYou are so tired that even fire cannot consume you ...\n" +
                                    "YOU DON'T HAVE ENOUGH MANA!");
                                break;
                            }

                        case 7:

                            if (Player.healthPotionQuantity > 0)
                            {
                                Player.HealthPotion();
                                Console.WriteLine("\nYou drinking health potion and restored 50 HP");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nYou are out of health potions!");
                                break;
                            }
                            
                        case 8:

                            if (Player.manaPotionQuantity > 0)
                            {
                                Player.ManaPotion();
                                Console.WriteLine("\nYou drinking mana potion and restored 70 MANA");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nYou are out of mana potions!");
                                break;
                            }
                            
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInvalid input\n\nGAME OVER");
                    break;
                }

                if (Player.shield > 0)
                {
                    Player.HP += 50;
                    Console.WriteLine("\n+100 HP from Divine Shield");

                    Player.shield--;
                }
                else if (Player.madness > 0)
                {
                    Player.madness--;

                    if (Player.madness == 0)
                    {
                        Player.damage -= 30;
                    }
                }
                else if (Player.burn > 0)
                {
                    Boss.HP -= 10;
                    Console.WriteLine($"\n{Boss.name} takes 10 burning damage");

                    Player.burn--;

                    if (Player.burn == 0)
                    {
                        Player.damage -= 10;
                    }
                }


                if (turn < 5)
                {
                    Boss.damage = rand.Next(1, 70);
                    Boss.GetHeavyHitInfo();
                    Player.HP -= Boss.HeavyHit();
                }
                else if (turn == 5)
                {
                    Console.WriteLine($"\nTHE {Boss.name} GETS FURIOUS!!!");
                }
                else if (turn >= 6)
                {
                    Boss.damage = rand.Next(20, 150);
                    Boss.GetHeavyHitInfo();
                    Player.HP -= Boss.HeavyHit();
                }

                Player.GetPlayerInfo();
                Boss.GetBossInfo();

                Console.Write("Press to");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" Next Turn");
                Console.ResetColor();
                Console.Write(" . . .");
                Console.ReadLine();
                Console.Clear();

                if (Player.HP - Boss.HeavyHit() <= 0)
                {
                    Player.HP = 0;

                    Console.ReadLine();
                    PrintLoseMessage();
                    Console.Write($"\nPlayer was KILLED in ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"{turn - 1} turns!");
                    Console.ResetColor();
                    
                    Player.GetPlayerInfo();
                    break;
                }
                else if (Boss.HP <= 0)
                {
                    Console.ReadLine();
                    PrintWinMessage();
                    Console.Write($"\n{Boss.name} was DISTROED in ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"{turn - 1} turns!!!");
                    Console.ResetColor();

                    Boss.GetBossInfo();
                    break;
                }
            }
        }
    }
}
