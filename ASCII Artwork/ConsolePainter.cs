using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ASCIIArtwork{
    public class ConsolePainter {
        public static void Paint() {

        }
        public static void RunCommand(string commandLine) {

        }
        public static StringReader ASCIIPainterScript { get; set; }
        public static string FormatString(string format) {
            // In script command: f$"(5a)*3+2#*3" -> "     a     a     a  ###"
            /*
             * f$"(#*5\n)*3" ->
             * #####
             * #####
             * #####
             */
            // that's awesome!! Ha?!
            return null;
        }
        private static class Commanding {
            delegate void Command(string[] param);
            static Dictionary<string, Command> Commands = new Dictionary<string, Command>() {
                {"setchar",setchar },
                {"rndchar",rndchar },
                {"waitms",waitms },
                {"wait",wait },
                {"setprop",setprop },
                {"clear",clear },
                {"setcur",setcur },
                {"elias",elias }
            };

            static void setchar(string[] param) {

            }
            static void rndchar(string[] param) {

            }
            static void waitms(string[] param) {

            }
            static void wait(string[] param) {

            }
            static void setprop(string[] param) {

            }
            static void clear(string[] param) {

            }
            static void setcur(string[] param) {

            }
            static void elias(string[] param) {

            }
        }
    }
}
