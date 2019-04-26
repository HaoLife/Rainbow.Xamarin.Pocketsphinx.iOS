using System;
using System.Runtime.InteropServices;

namespace NativeLibrary
{

    static class CFunctions
    {
        // uint16_t _OSSwapInt16 (uint16_t data);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern ushort _OSSwapInt16(ushort data);

        // uint32_t _OSSwapInt32 (uint32_t data);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern uint _OSSwapInt32(uint data);

        // extern unsigned int __builtin_bswap32 (unsigned int) __attribute__((nothrow)) __attribute__((const));
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern uint __builtin_bswap32(uint a);
    }

}