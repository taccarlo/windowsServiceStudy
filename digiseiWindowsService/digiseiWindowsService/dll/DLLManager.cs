using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace digiseiWindowsService.dll
{
    class DLLManager
    {
        [DllImport("Cico_protocol_DIGISEI.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int DLLVersion();
        // extern "C" CICO_PROTOCOL_API int CICO_DIGI_CloseSocket();
        
        public DLLManager()
        {

        }

        public int DLLFunction()
        {
            return DLLVersion();

        }
    }
}
