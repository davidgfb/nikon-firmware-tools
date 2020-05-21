﻿namespace Nikon_Patch
{
    class D610_0101 : Firmware
    {
        Patch[] patch_1080_36mbps_NQ = {
            new Patch(1, 0x23DD2, Sys.mbps24 , Sys.mbps40 ),
            new Patch(1, 0x23DD8, Sys.mbps20 , Sys.mbps36 ),
            new Patch(1, 0x23DE6, Sys.mbps12 , Sys.mbps24 ),
            new Patch(1, 0x23DEC, Sys.mbps10 , Sys.mbps20 ),

            new Patch(1, 0x23E4A, Sys.mbps24 , Sys.mbps40 ),
            new Patch(1, 0x23E50, Sys.mbps20 , Sys.mbps36 ),
            new Patch(1, 0x23E5E, Sys.mbps12 , Sys.mbps24 ),
            new Patch(1, 0x23E64, Sys.mbps10 , Sys.mbps20 ),

            new Patch(1, 0x23EDC, Sys.mbps24 , Sys.mbps40 ),
            new Patch(1, 0x23EE2, Sys.mbps20 , Sys.mbps36 ),
            new Patch(1, 0x23EF0, Sys.mbps12 , Sys.mbps24 ),
            new Patch(1, 0x23EF6, Sys.mbps10 , Sys.mbps20 ),
        };

        Patch[] patch_1080_54mbps_NQ = {
            new Patch(1, 0x23DD2, Sys.mbps24 , Sys.mbps57 ),
            new Patch(1, 0x23DD8, Sys.mbps20 , Sys.mbps53 ),
            new Patch(1, 0x23DE6, Sys.mbps12 , Sys.mbps24 ),
            new Patch(1, 0x23DEC, Sys.mbps10 , Sys.mbps20 ),

            new Patch(1, 0x23E4A, Sys.mbps24 , Sys.mbps57 ),
            new Patch(1, 0x23E50, Sys.mbps20 , Sys.mbps53 ),
            new Patch(1, 0x23E5E, Sys.mbps12 , Sys.mbps24 ),
            new Patch(1, 0x23E64, Sys.mbps10 , Sys.mbps20 ),

            new Patch(1, 0x23EDC, Sys.mbps24 , Sys.mbps57 ),
            new Patch(1, 0x23EE2, Sys.mbps20 , Sys.mbps53 ),
            new Patch(1, 0x23EF0, Sys.mbps12 , Sys.mbps24 ),
            new Patch(1, 0x23EF6, Sys.mbps10 , Sys.mbps20 ),
        };


        Patch[] patch_1080_720_64mbps_NQ = {
            // 1080 0 24 fps
            new Patch(1, 0x23DD2, Sys.mbps24 , Sys.mbps64 ),
            new Patch(1, 0x23DD8, Sys.mbps20 , Sys.mbps60 ),
            new Patch(1, 0x23DE6, Sys.mbps12 , Sys.mbps24 ),
            new Patch(1, 0x23DEC, Sys.mbps10 , Sys.mbps20 ),

            // 1080 2 30 fps
            new Patch(1, 0x23DFE, Sys.mbps24 , Sys.mbps64 ),
            new Patch(1, 0x23E04, Sys.mbps20 , Sys.mbps60 ),
            new Patch(1, 0x23E12, Sys.mbps12 , Sys.mbps24 ),
            new Patch(1, 0x23E18, Sys.mbps10 , Sys.mbps20 ),

            // 1080 6 25 fps
            new Patch(1, 0x23E4A, Sys.mbps24 , Sys.mbps64 ),
            new Patch(1, 0x23E50, Sys.mbps20 , Sys.mbps60 ),
            new Patch(1, 0x23E5E, Sys.mbps12 , Sys.mbps24 ),
            new Patch(1, 0x23E64, Sys.mbps10 , Sys.mbps20 ),

            
            // 720 0 24 fps
            new Patch(1, 0x23EB0, Sys.mbps10, Sys.mbps64 ),
            new Patch(1, 0x23EB6, Sys.mbps8 , Sys.mbps60 ),
            new Patch(1, 0x23EC4, Sys.mbps6 , Sys.mbps24 ),
            new Patch(1, 0x23ECA, Sys.mbps5 , Sys.mbps20 ),

            // 720 1 60 fps
            new Patch(1, 0x23EDC, Sys.mbps24 , Sys.mbps64 ),
            new Patch(1, 0x23EE2, Sys.mbps20 , Sys.mbps60 ),
            new Patch(1, 0x23EF0, Sys.mbps12 , Sys.mbps24 ),
            new Patch(1, 0x23EF6, Sys.mbps10 , Sys.mbps20 ),

            // 720 2 30 fps
            new Patch(1, 0x23F08, Sys.mbps12, Sys.mbps64 ),
            new Patch(1, 0x23F0E, Sys.mbps10, Sys.mbps60 ),
            new Patch(1, 0x23F1C, Sys.mbps8 , Sys.mbps24 ),
            new Patch(1, 0x23F22, Sys.mbps6 , Sys.mbps20 ),

            // 720 5 50 fps
            new Patch(1, 0x23F54, Sys.mbps24 , Sys.mbps64 ),
            new Patch(1, 0x23F5A, Sys.mbps20 , Sys.mbps60 ),
            new Patch(1, 0x23F68, Sys.mbps12 , Sys.mbps24 ),
            new Patch(1, 0x23F6E, Sys.mbps10 , Sys.mbps20 ),

                                       };

        Patch[] patch_Language_Fix = {
            new Patch(1, 0x380258, new byte[] { 0xE2, 0x08 }, new byte[] { 0xE0, 0x08 }),
            new Patch(1, 0x385758, new byte[] { 0xE2, 0x11 }, new byte[] { 0xE0, 0x11 }),
            new Patch(1, 0x41E638, new byte[] { 0xE2, 0x06 }, new byte[] { 0xE0, 0x06 }),
            //new Patch(1, 0x3E320C, new byte[] { 0xB1, 0xF4 }, new byte[] { 0xC0, 0x04 }), this case (from 3200) was not found
                          };

		Patch[] patch_dark_current_menu = {
			new Patch(1, 0x42378C, new byte[] { 0x9E, 0x45, 0x40, 0x8C, 0x97, 0x94, 0xC0, 0x1D, 0x82, 0x4D, 0xE2, 0x02, 0x91, 0x40, 0xE0, 0x01, 0x81, 0xB0 } , new byte[] { 0x00, 0x5A, 0xD0, 0x00, 0x97, 0x00, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0 } ),
			new Patch(1, 0x56D000, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } , new byte[] { 0x9F, 0x8D, 0x9F, 0x07, 0xEC, 0xB4, 0x9B, 0x00, 0x4E, 0x5A, 0xC0, 0x04, 0x11, 0x04, 0xA4, 0x40, 0x11, 0x04, 0x9B, 0x00, 0x4F, 0x5E, 0x11, 0x04, 0xA4, 0x40, 0x11, 0x04, 0x9B, 0x00, 0x50, 0x62, 0x11, 0x04, 0xA4, 0x40, 0x11, 0x04, 0x9B, 0x04, 0x80, 0x00, 0x9B, 0x00, 0x05, 0xEA, 0x11, 0x04, 0x9B, 0x00, 0x06, 0x1E, 0x11, 0x04, 0x9B, 0x00, 0x06, 0x52, 0x11, 0x04, 0x9F, 0x8D, 0x9E, 0x45, 0x41, 0x21, 0x91, 0x2D, 0x9F, 0x80, 0x00, 0x46, 0x37, 0x9A, 0x97, 0x00 } ),
			new Patch(1, 0x7149E8, new byte[] { 0x4A, 0x50, 0x45, 0x47, 0x20, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x69, 0x6F, 0x6E } , new byte[] { 0x41, 0x73, 0x74, 0x72, 0x6F, 0x70, 0x68, 0x6F, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79 } ),
			new Patch(1, 0x714A05, new byte[] { 0x4F, 0x70, 0x74, 0x69, 0x6D, 0x61, 0x6C, 0x20, 0x71, 0x75, 0x61, 0x6C, 0x69, 0x74, 0x79 } , new byte[] { 0x53, 0x65, 0x6E, 0x73, 0x6F, 0x72, 0x20, 0x52, 0x41, 0x57, 0x20, 0x4F, 0x6E, 0x21, 0x20 } ),
			new Patch(1, 0x715F87, new byte[] { 0x4A, 0x50, 0x45, 0x47, 0x20, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x69, 0x6F, 0x6E } , new byte[] { 0x41, 0x73, 0x74, 0x72, 0x6F, 0x70, 0x68, 0x6F, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79 } ),
			new Patch(1, 0x71CC91, new byte[] { 0x43, 0x68, 0x6F, 0x6F, 0x73, 0x65, 0x20, 0x68, 0x6F, 0x77, 0x20, 0x4A, 0x50, 0x45, 0x47, 0x20, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x73, 0x20, 0x28, 0x66, 0x69, 0x6E, 0x65, 0x2C, 0x20, 0x6E, 0x6F, 0x72 } , new byte[] { 0x54, 0x6F, 0x20, 0x72, 0x65, 0x63, 0x6F, 0x72, 0x64, 0x20, 0x75, 0x6E, 0x63, 0x6F, 0x6F, 0x6B, 0x65, 0x64, 0x20, 0x52, 0x41, 0x57, 0x20, 0x66, 0x72, 0x6F, 0x6D, 0x20, 0x74, 0x68, 0x65, 0x20, 0x69 } ),
			new Patch(1, 0x71CCB4, new byte[] { 0x6C, 0x2C, 0x0A, 0x61, 0x6E, 0x64, 0x20, 0x62, 0x61, 0x73, 0x69, 0x63, 0x29, 0x20, 0x77, 0x69, 0x6C, 0x6C, 0x20, 0x62, 0x65, 0x20, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x65, 0x64, 0x2E } , new byte[] { 0x67, 0x65, 0x0A, 0x73, 0x65, 0x6E, 0x73, 0x6F, 0x72, 0x20, 0x66, 0x6F, 0x72, 0x20, 0x61, 0x73, 0x74, 0x72, 0x6F, 0x70, 0x68, 0x6F, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79, 0x2E, 0x20, 0x20 } ),
			new Patch(1, 0x71CCE5, new byte[] { 0x41, 0x6C, 0x6C, 0x20, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x73, 0x20, 0x61 } , new byte[] { 0x53, 0x65, 0x74, 0x74, 0x69, 0x6E, 0x67, 0x20, 0x62, 0x65, 0x66, 0x6F } ),
			new Patch(1, 0x71CCF4, new byte[] { 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x65, 0x64, 0x0A, 0x74, 0x6F, 0x20, 0x61, 0x72, 0x6F, 0x75, 0x6E, 0x64, 0x20, 0x74, 0x68, 0x65, 0x20, 0x73, 0x61, 0x6D, 0x65, 0x20, 0x66, 0x69, 0x6C, 0x65, 0x20, 0x73, 0x69, 0x7A, 0x65, 0x2E, 0x02, 0x4F, 0x70, 0x74, 0x69, 0x6D, 0x61, 0x6C, 0x20, 0x71, 0x75, 0x61, 0x6C, 0x69, 0x74, 0x79, 0x3A, 0x20, 0x50, 0x72, 0x69, 0x6F, 0x72, 0x69, 0x74, 0x79, 0x20, 0x69, 0x73, 0x20, 0x67, 0x69, 0x76 } , new byte[] { 0x66, 0x69, 0x72, 0x6D, 0x77, 0x61, 0x72, 0x65, 0x0A, 0x75, 0x70, 0x64, 0x61, 0x74, 0x65, 0x20, 0x69, 0x73, 0x20, 0x6B, 0x65, 0x70, 0x74, 0x20, 0x75, 0x6E, 0x63, 0x68, 0x61, 0x6E, 0x67, 0x65, 0x64, 0x2E, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x02, 0x53, 0x65, 0x6E, 0x73, 0x6F, 0x72, 0x20, 0x52, 0x41, 0x57, 0x3A, 0x20, 0x54, 0x65, 0x6D, 0x70, 0x6F, 0x72, 0x61, 0x72, 0x69, 0x6C, 0x79, 0x20, 0x65, 0x6E, 0x61, 0x62, 0x6C, 0x65, 0x20, 0x73 } ),
			new Patch(1, 0x71CD3F, new byte[] { 0x20, 0x74, 0x6F, 0x0A, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x20, 0x71, 0x75, 0x61, 0x6C, 0x69, 0x74, 0x79, 0x2E, 0x20, 0x46, 0x69, 0x6C, 0x65, 0x20, 0x73, 0x69, 0x7A, 0x65, 0x73, 0x20, 0x6D, 0x61, 0x79, 0x20, 0x64, 0x69, 0x66, 0x66, 0x65, 0x72, 0x2E } , new byte[] { 0x73, 0x6F, 0x72, 0x0A, 0x52, 0x41, 0x57, 0x2E, 0x20, 0x50, 0x6F, 0x77, 0x65, 0x72, 0x2F, 0x4D, 0x65, 0x74, 0x65, 0x72, 0x69, 0x6E, 0x67, 0x20, 0x6F, 0x66, 0x66, 0x20, 0x74, 0x6F, 0x20, 0x72, 0x65, 0x73, 0x65, 0x74, 0x2E, 0x20, 0x20, 0x20, 0x20 } ),
		};

		public D610_0101()
        {
            p = new Package();
            Model = "D610";
            Version = "1.01";

            Patches.Add(new PatchSet(PatchLevel.Released, "Multi-Language Support", patch_Language_Fix));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 36mbps Bit-rate NQ old HQ", patch_1080_36mbps_NQ, patch_1080_54mbps_NQ, patch_1080_720_64mbps_NQ));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 54mbps Bit-rate NQ old HQ", patch_1080_54mbps_NQ, patch_1080_36mbps_NQ, patch_1080_720_64mbps_NQ));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080/720 HQ 64mbps Bit-rate NQ old HQ", patch_1080_720_64mbps_NQ, patch_1080_36mbps_NQ, patch_1080_54mbps_NQ));
			Patches.Add(new PatchSet(PatchLevel.Beta, "True Dark Current - Menu based", patch_dark_current_menu));
		}
	}

    class D610_0102 : Firmware
    {
        public D610_0102()
        {
            p = new Package();
            Model = "D610";
            Version = "1.02";
        }
    }
}