using System;

namespace RobloxExecutor.Core
{
    public static unsafe class Offsets
    {
        private static IntPtr _baseAddress;

        public static void Initialize()
        {
            _baseAddress = Native.GetModuleHandle(null);
        }

        private static IntPtr REBASE(long offset) => _baseAddress + (int)offset;

        // ===== Core Offsets =====
        public static IntPtr AppDataInfo => REBASE(0x7d023d8);
        public static IntPtr EnableLoadModule => REBASE(0x679c8f8);
        public static IntPtr FLogDataBank => REBASE(0x7a847b8);
        public static IntPtr IdentityPtr => REBASE(0x75007d8);
        public static IntPtr KTable => REBASE(0x74bff70);
        public static IntPtr LockViolationInstanceCrash => REBASE(0x67a2d30);

        public static IntPtr LuaH_DummyNode => REBASE(0x572ee98);
        public static IntPtr LuaO_NilObject => REBASE(0x572f788);
        public static IntPtr LuaT_Eventnames => REBASE(0x572f6e0);
        public static IntPtr LuaT_Typenames => REBASE(0x572f670);

        public static IntPtr OpcodeLookupTable => REBASE(0x5bf3a30);

        public static IntPtr TaskScheduler => REBASE(0x7e1bc88);
        public static IntPtr TaskSchedulerTargetFPS => REBASE(0x74bfee4);

        public static IntPtr GetLuaState => REBASE(0xd777d0);
        public static IntPtr GetGlobalState => REBASE(0xfea310);

        public static IntPtr FireMouseClick => REBASE(0x1e34610);
        public static IntPtr FireRightMouseClick => REBASE(0x1e347b0);
        public static IntPtr FireMouseHoverEnter => REBASE(0x1e35bb0);
        public static IntPtr FireMouseHoverLeave => REBASE(0x1e35d50);
        public static IntPtr FireProximityPrompt => REBASE(0x1e958a0);
        public static IntPtr FireTouchInterest => REBASE(0x21c50f0);

        public static IntPtr GetContextObject => REBASE(0xd777d0);
        public static IntPtr GetCurrentThreadId => REBASE(0xda73e0);

        public static IntPtr GetFFlag => REBASE(0x4e61110);
        public static IntPtr SetFFlag => REBASE(0x406f750);

        // Failed to dump GetIdentityStruct
        public static IntPtr GetModuleFromVMStateMap => REBASE(0x1127550);

        public static IntPtr GetProperty => REBASE(0xbefff0);
        public static IntPtr GetValues => REBASE(0xd8bda0);

        public static IntPtr LuaA_toobject => REBASE(0x37c2a80);
        public static IntPtr LuaC_step => REBASE(0x37ce460);
        public static IntPtr LuaD_throw => REBASE(0x37d1e30);
        public static IntPtr LuaL_checklstring => REBASE(0x37c65f0);
        public static IntPtr LuaL_getmetafield => REBASE(0x37c6a90);
        public static IntPtr LuaL_register => REBASE(0x37c7d90);
        public static IntPtr LuaM_visitgco => REBASE(0x3818a00);

        public static IntPtr LuaVM_Load => REBASE(0xe5e1e0);
        public static IntPtr Luau_execute => REBASE(0x37d93c0);

        public static IntPtr Print => REBASE(0x17c5100);

        public static IntPtr Pseudo2Addr => REBASE(0x37c29c0);

        public static IntPtr PushInstance1 => REBASE(0x106ea40);
        public static IntPtr PushInstance2 => REBASE(0x10328f7);

        public static IntPtr RaiseEventInvocation => REBASE(0x17844f0);

        public static IntPtr ScriptContextResume => REBASE(0x101c390);
        public static IntPtr SetProtoCapabilities => REBASE(0x33e9360);

        public static IntPtr TaskDefer => REBASE(0x1284ba0);
        public static IntPtr TaskSpawn => REBASE(0x127f4f0);
        public static IntPtr TaskDelay => REBASE(0x1cc9880);
        public static IntPtr TaskWait => REBASE(0x3c0e0b0);
        public static IntPtr TaskCancel => REBASE(0x1285ab0);

        public static IntPtr VariantCastArgs => REBASE(0xd8bda0);
        public static IntPtr VariantCastInt => REBASE(0x178abf0);
        public static IntPtr VariantCastInt64 => REBASE(0x178aef0);
        public static IntPtr VariantCastFloat => REBASE(0x404bb90);

        // ===== Roblox Structures =====
        public static class Roblox
        {
            public const int JobStart = 0x1D0;
            public const int JobEnd = 0x1D8;
            public const int JobName = 0x18;

            public const int ClassDescriptor = 0x18;
            public const int Properties = 0x5B8;
            public const int PropertyDescriptors = 0x38;
            public const int PropertyDescriptorBitFlags = 0x88;
            public const int PropertyDescriptorType = 0x48;
            public const int PropertyDescriptorGetSet = 0xA0;

            public const int ReflectionType = 0x30;
            public const int ScriptableMask = 0x10;
            public const int DescriptorName = 0x8;

            public const int Identity = 0x30;
            public const int Capabilities = 0x50;

            public static class Bytecode
            {
                // Failed to dump LocalscriptBytecode
                public const int ModulescriptBytecode = 0x150;
            }

            public static class Datamodel
            {
                public static IntPtr FakeDatamodel => REBASE(0x7d02728);
                public static IntPtr VisualEngine => REBASE(0x7a684f0);

                public const int VisualEngineToDatamodel = 0x700;
                public const int DatamodelOffset = 0x1C0;

                // Failed to dump ScriptContext
                public const int RequireBypass = 0x920;
                public const int IsCoreScript = 0x180;
                public const int GameLoaded = 0x671;
            }

            public static class Instance
            {
                // Failed to dump CallbackValue
                public const int Name = 0xB0;
                public const int Children = 0x70;
                public const int Parent = 0x8;
                public const int Primitive = 0x148;
                public const int Overlap = 0x1E0;
            }

            public static class Player
            {
                public const int LocalPlayer = 0x130;
                public const int UserId = 0x2A8;
            }
        }

        public static class Hyperion
        {
            // Failed to dump Bitmap
        }

        // Capability mask (kept from your example style)
        public const long MAXCAPABILITIES =
            (0x200000000000003L | 0xFFFFFFF00L) | (1L << 48);
    }
}
