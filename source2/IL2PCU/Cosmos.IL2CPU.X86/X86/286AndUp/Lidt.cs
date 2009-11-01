﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmos.IL2CPU.X86 {
    [OpCode("lidt")]
	public class Lidt: InstructionWithDestination {
        public static void InitializeEncodingData(Instruction.InstructionData aData) {
            aData.EncodingOptions.Add(new InstructionData.InstructionEncodingOption {
                OpCode = new byte[]{0x0F, 0x01},
                NeedsModRMByte = true,
                InitialModRMByteValue = 0x18,
                DestinationMemory = true,
                ReverseRegisters = true
            });
        }
	}
}