﻿namespace PKHeX.Core
{
    // Distribution Nest Encounters (BCAT)
    internal static partial class Encounters8Nest
    {
        // For distribution encounters, all commented out entries are duplicate with a prior distribution encounter. Only one encounter is necessary for matching purposes.

        internal static readonly EncounterStatic8ND[] Dist_Common =
        {
            // 11/15 - Butterfree
            new EncounterStatic8ND(40,05,3) { Species = 012, Ability = A4, Moves = new[]{ 676, 403, 202, 527 } }, // Butterfree
            new EncounterStatic8ND(40,05,3) { Species = 012, Ability = A4, Moves = new[]{ 676, 403, 202, 527 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(50,08,4) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 527, 078 } }, // Butterfree
            new EncounterStatic8ND(50,08,4) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 527, 078 }, CanGigantamax = true }, // Butterfree

            // 12/03 - Snorlax
            new EncounterStatic8ND(17,01,1) { Species = 446, Ability = A4, Moves = new[]{ 033, 044, 122, 111 } }, // Munchlax
            new EncounterStatic8ND(17,01,1) { Species = 446, Ability = A2, Moves = new[]{ 033, 044, 122, 111 } }, // Munchlax
            new EncounterStatic8ND(30,03,2) { Species = 143, Ability = A4, Moves = new[]{ 034, 242, 118, 111 } }, // Snorlax
            new EncounterStatic8ND(30,03,2) { Species = 143, Ability = A2, Moves = new[]{ 034, 242, 118, 111 } }, // Snorlax
            //new EncounterStatic8ND(40,05,3) { Species = 012, Ability = A4, Moves = new[]{ 676, 403, 202, 527 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(40,05,3) { Species = 143, Ability = A4, Moves = new[]{ 034, 667, 242, 281 } }, // Snorlax
            new EncounterStatic8ND(40,05,3) { Species = 143, Ability = A4, Moves = new[]{ 034, 667, 242, 281 }, CanGigantamax = true }, // Snorlax
            //new EncounterStatic8ND(50,08,4) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 527, 078 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(50,08,4) { Species = 143, Ability = A4, Moves = new[]{ 034, 667, 280, 523 } }, // Snorlax
            new EncounterStatic8ND(50,08,4) { Species = 143, Ability = A4, Moves = new[]{ 034, 667, 280, 523 }, CanGigantamax = true }, // Snorlax
            new EncounterStatic8ND(60,10,5) { Species = 143, Ability = A4, Moves = new[]{ 034, 442, 242, 428 } }, // Snorlax
            new EncounterStatic8ND(70,10,5) { Species = 143, Ability = A4, Moves = new[]{ 034, 442, 242, 428 }, CanGigantamax = true }, // Snorlax

            // 12/20 - Delibird
            //new EncounterStatic8ND(17,01,1) { Species = 446, Ability = A4, Moves = new[]{ 033, 044, 122, 111 } }, // Munchlax
            new EncounterStatic8ND(17,01,1) { Species = 225, Ability = A4, Moves = new[]{ 217, 229, 098, 420 } }, // Delibird
            //new EncounterStatic8ND(30,03,2) { Species = 143, Ability = A4, Moves = new[]{ 034, 242, 118, 111 } }, // Snorlax
            new EncounterStatic8ND(30,03,2) { Species = 225, Ability = A4, Moves = new[]{ 217, 065, 034, 693 } }, // Delibird
            //new EncounterStatic8ND(40,05,3) { Species = 012, Ability = A4, Moves = new[]{ 676, 403, 202, 527 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(40,05,3) { Species = 225, Ability = A4, Moves = new[]{ 217, 065, 280, 196 } }, // Delibird
            //new EncounterStatic8ND(40,05,3) { Species = 143, Ability = A4, Moves = new[]{ 034, 667, 242, 281 }, CanGigantamax = true }, // Snorlax
            //new EncounterStatic8ND(50,08,4) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 527, 078 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(50,08,4) { Species = 225, Ability = A4, Moves = new[]{ 217, 059, 034, 280 } }, // Delibird
            //new EncounterStatic8ND(50,08,4) { Species = 143, Ability = A4, Moves = new[]{ 034, 667, 280, 523 }, CanGigantamax = true }, // Snorlax
            new EncounterStatic8ND(70,10,5) { Species = 225, Ability = A4, Moves = new[]{ 217, 059, 065, 280 } }, // Delibird
            //new EncounterStatic8ND(70,10,5) { Species = 143, Ability = A4, Moves = new[]{ 034, 442, 242, 428 }, CanGigantamax = true }, // Snorlax

            // 12/30 - Magikarp
            new EncounterStatic8ND(17,01,1) { Species = 129, Ability = A4, Moves = new[]{ 150, 033, 000, 000 } }, // Magikarp
            new EncounterStatic8ND(17,01,1) { Species = 446, Ability = A4, Moves = new[]{ 033, 044, 122, 111 } }, // Munchlax
            new EncounterStatic8ND(30,03,2) { Species = 129, Ability = A4, Moves = new[]{ 150, 033, 175, 000 } }, // Magikarp
            //new EncounterStatic8ND(30,03,2) { Species = 143, Ability = A4, Moves = new[]{ 034, 242, 118, 111 } }, // Snorlax
            //new EncounterStatic8ND(40,05,3) { Species = 012, Ability = A4, Moves = new[]{ 676, 403, 202, 527 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(40,05,3) { Species = 129, Ability = A4, Moves = new[]{ 150, 033, 175, 000 } }, // Magikarp
            //new EncounterStatic8ND(40,05,3) { Species = 143, Ability = A4, Moves = new[]{ 034, 667, 242, 281 }, CanGigantamax = true }, // Snorlax
            //new EncounterStatic8ND(50,08,4) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 527, 078 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(50,08,4) { Species = 129, Ability = A4, Moves = new[]{ 150, 033, 175, 000 } }, // Magikarp
            //new EncounterStatic8ND(50,08,4) { Species = 143, Ability = A4, Moves = new[]{ 034, 667, 280, 523 }, CanGigantamax = true }, // Snorlax
            new EncounterStatic8ND(60,10,5) { Species = 129, Ability = A4, Moves = new[]{ 150, 033, 175, 340 } }, // Magikarp
            new EncounterStatic8ND(70,10,5) { Species = 129, Ability = A4, Moves = new[]{ 150, 033, 175, 340 } }, // Magikarp
            //new EncounterStatic8ND(70,10,5) { Species = 143, Ability = A4, Moves = new[]{ 034, 442, 242, 428 }, CanGigantamax = true }, // Snorlax

            // 1/8 - Applin
            new EncounterStatic8ND(17,01,1) { Species = 840, Ability = A4, Moves = new[]{ 110, 310, 389, 213 } }, // Applin
            new EncounterStatic8ND(17,01,1) { Species = 840, Ability = A2, Moves = new[]{ 110, 310, 389, 213 } }, // Applin
            new EncounterStatic8ND(17,01,1) { Species = 868, Ability = A4, Moves = new[]{ 577, 033, 186, 263 } }, // Milcery
            new EncounterStatic8ND(17,01,1) { Species = 868, Ability = A2, Moves = new[]{ 577, 033, 186, 263 } }, // Milcery
            new EncounterStatic8ND(30,03,2) { Species = 869, Ability = A4, Moves = new[]{ 577, 213, 033, 186 }, CanGigantamax = true }, // Alcremie

            // 1/31 - Milcery
            new EncounterStatic8ND(17,01,1) { Species = 868, Ability = A4, Moves = new[]{ 033, 186, 577, 496 }, CanGigantamax = true }, // Milcery
            new EncounterStatic8ND(30,03,2) { Species = 868, Ability = A4, Moves = new[]{ 577, 186, 263, 500 }, CanGigantamax = true }, // Milcery
            new EncounterStatic8ND(40,05,3) { Species = 868, Ability = A4, Moves = new[]{ 577, 605, 496, 213 }, CanGigantamax = true }, // Milcery
            new EncounterStatic8ND(50,08,4) { Species = 868, Ability = A4, Moves = new[]{ 577, 605, 496, 500 }, CanGigantamax = true }, // Milcery
            new EncounterStatic8ND(60,10,5) { Species = 868, Ability = A4, Moves = new[]{ 577, 605, 496, 500 }, CanGigantamax = true }, // Milcery

            // 2/6 - Toxtricity - Same as Milcery 1/31 (above)

            // 2/17 - Toxel
            new EncounterStatic8ND(17,01,1) { Species = 848, Ability = A4, Moves = new[]{ 609, 051, 496, 715 } }, // Toxel
        };

        internal static readonly EncounterStatic8ND[] Dist_SW =
        {
            // 11/15 - Butterfree
            new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 078 } }, // Butterfree
            new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 078 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(17,01,1) { Species = 843, Ability = A2, Moves = new[]{ 693, 523, 189, 103 } }, // Silicobra
            new EncounterStatic8ND(17,01,1) { Species = 843, Ability = A4, Moves = new[]{ 693, 523, 189, 103 } }, // Silicobra
            new EncounterStatic8ND(17,01,1) { Species = 833, Ability = A2, Moves = new[]{ 055, 044, 033, 213 } }, // Chewtle
            new EncounterStatic8ND(17,01,1) { Species = 833, Ability = A4, Moves = new[]{ 055, 044, 033, 213 } }, // Chewtle
            new EncounterStatic8ND(30,03,2) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 081, 079 } }, // Butterfree
            new EncounterStatic8ND(30,03,2) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 081, 079 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(30,03,2) { Species = 843, Ability = A2, Moves = new[]{ 693, 523, 029, 137 } }, // Silicobra
            new EncounterStatic8ND(30,03,2) { Species = 843, Ability = A4, Moves = new[]{ 693, 523, 029, 137 } }, // Silicobra
            new EncounterStatic8ND(30,03,2) { Species = 834, Ability = A2, Moves = new[]{ 317, 242, 055, 334 } }, // Drednaw
            new EncounterStatic8ND(30,03,2) { Species = 834, Ability = A4, Moves = new[]{ 317, 242, 055, 334 } }, // Drednaw
            new EncounterStatic8ND(40,05,3) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 407, 424 } }, // Sandaconda
            new EncounterStatic8ND(40,05,3) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 407, 424 }, CanGigantamax = true }, // Sandaconda
            new EncounterStatic8ND(40,05,3) { Species = 834, Ability = A4, Moves = new[]{ 157, 534, 034, 317 } }, // Drednaw
            new EncounterStatic8ND(40,05,3) { Species = 834, Ability = A4, Moves = new[]{ 157, 534, 034, 317 }, CanGigantamax = true }, // Drednaw
            new EncounterStatic8ND(50,08,4) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 342, 328 } }, // Sandaconda
            new EncounterStatic8ND(50,08,4) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 342, 328 }, CanGigantamax = true }, // Sandaconda
            new EncounterStatic8ND(50,08,4) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 350, 523 } }, // Drednaw
            new EncounterStatic8ND(50,08,4) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 350, 523 }, CanGigantamax = true }, // Drednaw
            new EncounterStatic8ND(60,10,5) { Species = 012, Ability = A4, Moves = new[]{ 405, 094, 542, 202 } }, // Butterfree
            new EncounterStatic8ND(70,10,5) { Species = 012, Ability = A4, Moves = new[]{ 405, 094, 542, 202 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(60,10,5) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 342, 328 } }, // Sandaconda
            new EncounterStatic8ND(70,10,5) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 342, 328 }, CanGigantamax = true }, // Sandaconda
            new EncounterStatic8ND(60,10,5) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 317, 334 } }, // Drednaw
            new EncounterStatic8ND(70,10,5) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 317, 334 }, CanGigantamax = true }, // Drednaw

            // 12/03 - Snorlax
            //new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 078 } }, // Butterfree
            //new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 078 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(17,01,1) { Species = 843, Ability = A4, Moves = new[]{ 693, 523, 189, 103 } }, // Silicobra
            //new EncounterStatic8ND(17,01,1) { Species = 833, Ability = A4, Moves = new[]{ 055, 044, 033, 213 } }, // Chewtle
            //new EncounterStatic8ND(30,03,2) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 081, 079 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(30,03,2) { Species = 843, Ability = A4, Moves = new[]{ 693, 523, 029, 137 } }, // Silicobra
            //new EncounterStatic8ND(30,03,2) { Species = 834, Ability = A4, Moves = new[]{ 317, 242, 055, 334 } }, // Drednaw
            //new EncounterStatic8ND(30,03,2) { Species = 834, Ability = A2, Moves = new[]{ 317, 242, 055, 334 } }, // Drednaw
            //new EncounterStatic8ND(40,05,3) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 407, 424 }, CanGigantamax = true }, // Sandaconda
            //new EncounterStatic8ND(40,05,3) { Species = 834, Ability = A4, Moves = new[]{ 157, 534, 034, 317 } }, // Drednaw
            //new EncounterStatic8ND(40,05,3) { Species = 834, Ability = A4, Moves = new[]{ 157, 534, 034, 317 }, CanGigantamax = true }, // Drednaw
            //new EncounterStatic8ND(50,08,4) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 342, 328 }, CanGigantamax = true }, // Sandaconda
            //new EncounterStatic8ND(50,08,4) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 350, 523 } }, // Drednaw
            //new EncounterStatic8ND(50,08,4) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 350, 523 }, CanGigantamax = true }, // Drednaw
            new EncounterStatic8ND(60,10,5) { Species = 012, Ability = A4, Moves = new[]{ 405, 094, 542, 202 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(70,10,5) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 342, 328 }, CanGigantamax = true }, // Sandaconda
            //new EncounterStatic8ND(60,10,5) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 317, 334 } }, // Drednaw
            //new EncounterStatic8ND(70,10,5) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 317, 334 }, CanGigantamax = true }, // Drednaw

            // 12/20 - Delibird
            //new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 078 } }, // Butterfree
            //new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 078 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(17,01,1) { Species = 843, Ability = A4, Moves = new[]{ 693, 523, 189, 103 } }, // Silicobra
            //new EncounterStatic8ND(17,01,1) { Species = 833, Ability = A4, Moves = new[]{ 055, 044, 033, 213 } }, // Chewtle
            //new EncounterStatic8ND(30,03,2) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 081, 079 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(30,03,2) { Species = 843, Ability = A4, Moves = new[]{ 693, 523, 029, 137 } }, // Silicobra
            //new EncounterStatic8ND(30,03,2) { Species = 834, Ability = A4, Moves = new[]{ 317, 242, 055, 334 } }, // Drednaw
            //new EncounterStatic8ND(40,05,3) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 407, 424 }, CanGigantamax = true }, // Sandaconda
            //new EncounterStatic8ND(40,05,3) { Species = 834, Ability = A4, Moves = new[]{ 157, 534, 034, 317 } }, // Drednaw
            //new EncounterStatic8ND(40,05,3) { Species = 834, Ability = A4, Moves = new[]{ 157, 534, 034, 317 }, CanGigantamax = true }, // Drednaw
            new EncounterStatic8ND(50,08,3) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 407, 424 }, CanGigantamax = true }, // Sandaconda
            //new EncounterStatic8ND(50,08,4) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 350, 523 } }, // Drednaw
            //new EncounterStatic8ND(50,08,4) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 350, 523 }, CanGigantamax = true }, // Drednaw
            //new EncounterStatic8ND(60,10,5) { Species = 012, Ability = A4, Moves = new[]{ 405, 094, 542, 202 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(70,10,5) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 342, 328 }, CanGigantamax = true }, // Sandaconda
            //new EncounterStatic8ND(60,10,5) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 317, 334 } }, // Drednaw
            //new EncounterStatic8ND(70,10,5) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 317, 334 }, CanGigantamax = true }, // Drednaw

            // 12/30 - Magikarp
            //new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 078 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(17,01,1) { Species = 843, Ability = A4, Moves = new[]{ 693, 523, 189, 103 } }, // Silicobra
            //new EncounterStatic8ND(17,01,1) { Species = 833, Ability = A4, Moves = new[]{ 055, 044, 033, 213 } }, // Chewtle
            //new EncounterStatic8ND(30,03,2) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 081, 079 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(30,03,2) { Species = 843, Ability = A4, Moves = new[]{ 693, 523, 029, 137 } }, // Silicobra
            //new EncounterStatic8ND(30,03,2) { Species = 834, Ability = A4, Moves = new[]{ 317, 242, 055, 334 } }, // Drednaw
            //new EncounterStatic8ND(40,05,3) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 407, 424 }, CanGigantamax = true }, // Sandaconda
            //new EncounterStatic8ND(40,05,3) { Species = 834, Ability = A4, Moves = new[]{ 157, 534, 034, 317 }, CanGigantamax = true }, // Drednaw
            //new EncounterStatic8ND(50,08,4) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 342, 328 }, CanGigantamax = true }, // Sandaconda
            //new EncounterStatic8ND(50,08,4) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 350, 523 }, CanGigantamax = true }, // Drednaw
            //new EncounterStatic8ND(60,10,5) { Species = 012, Ability = A4, Moves = new[]{ 405, 094, 542, 202 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(70,10,5) { Species = 844, Ability = A4, Moves = new[]{ 693, 529, 342, 328 }, CanGigantamax = true }, // Sandaconda
            //new EncounterStatic8ND(70,10,5) { Species = 834, Ability = A4, Moves = new[]{ 157, 710, 317, 334 }, CanGigantamax = true }, // Drednaw

            // 1/8 - Applin
            new EncounterStatic8ND(17,01,1) { Species = 837, Ability = A4, Moves = new[]{ 479, 033, 108, 189 } }, // Rolycoly
            new EncounterStatic8ND(17,01,1) { Species = 837, Ability = A2, Moves = new[]{ 479, 033, 108, 189 } }, // Rolycoly
            new EncounterStatic8ND(30,03,2) { Species = 841, Ability = A4, Moves = new[]{ 406, 491, 017, 225 } }, // Flapple
            new EncounterStatic8ND(30,03,2) { Species = 841, Ability = A2, Moves = new[]{ 406, 491, 017, 225 } }, // Flapple
            new EncounterStatic8ND(30,03,2) { Species = 838, Ability = A4, Moves = new[]{ 246, 510, 479, 189 } }, // Carkol
            new EncounterStatic8ND(30,03,2) { Species = 838, Ability = A2, Moves = new[]{ 246, 510, 479, 189 } }, // Carkol
            new EncounterStatic8ND(40,05,3) { Species = 841, Ability = A4, Moves = new[]{ 788, 406, 512, 491 } }, // Flapple
            new EncounterStatic8ND(40,05,3) { Species = 841, Ability = A4, Moves = new[]{ 788, 406, 512, 491 }, CanGigantamax = true }, // Flapple
            new EncounterStatic8ND(40,05,3) { Species = 869, Ability = A4, Moves = new[]{ 577, 605, 202, 186 }, Form = 3, CanGigantamax = true }, // Alcremie-3
            new EncounterStatic8ND(40,05,3) { Species = 869, Ability = A4, Moves = new[]{ 577, 605, 202, 186 }, Form = 4, CanGigantamax = true }, // Alcremie-4
            new EncounterStatic8ND(40,05,3) { Species = 839, Ability = A4, Moves = new[]{ 246, 510, 479, 488 } }, // Coalossal
            new EncounterStatic8ND(40,05,3) { Species = 839, Ability = A4, Moves = new[]{ 246, 510, 479, 488 }, CanGigantamax = true }, // Coalossal
            new EncounterStatic8ND(50,08,4) { Species = 841, Ability = A4, Moves = new[]{ 407, 788, 491, 334 } }, // Flapple
            new EncounterStatic8ND(50,08,4) { Species = 841, Ability = A4, Moves = new[]{ 407, 788, 491, 334 }, CanGigantamax = true }, // Flapple
            new EncounterStatic8ND(50,08,4) { Species = 869, Ability = A4, Moves = new[]{ 605, 202, 094, 151 }, Form = 1, CanGigantamax = true }, // Alcremie-1
            new EncounterStatic8ND(50,08,4) { Species = 869, Ability = A4, Moves = new[]{ 605, 202, 094, 151 }, Form = 2, CanGigantamax = true }, // Alcremie-2
            new EncounterStatic8ND(50,08,4) { Species = 839, Ability = A4, Moves = new[]{ 246, 053, 157, 261 } }, // Coalossal
            new EncounterStatic8ND(50,08,4) { Species = 839, Ability = A4, Moves = new[]{ 246, 053, 157, 261 }, CanGigantamax = true }, // Coalossal
            new EncounterStatic8ND(60,10,5) { Species = 841, Ability = A4, Moves = new[]{ 407, 788, 512, 349 } }, // Flapple
            new EncounterStatic8ND(60,10,5) { Species = 841, Ability = A4, Moves = new[]{ 407, 788, 512, 349 }, CanGigantamax = true }, // Flapple
            new EncounterStatic8ND(60,10,5) { Species = 869, Ability = A4, Moves = new[]{ 605, 202, 595, 500 }, Form = 5, CanGigantamax = true }, // Alcremie-5
            new EncounterStatic8ND(60,10,5) { Species = 869, Ability = A4, Moves = new[]{ 605, 202, 595, 500 }, Form = 6, CanGigantamax = true }, // Alcremie-6
            new EncounterStatic8ND(60,10,5) { Species = 839, Ability = A4, Moves = new[]{ 246, 053, 157, 523 } }, // Coalossal
            new EncounterStatic8ND(60,10,5) { Species = 839, Ability = A4, Moves = new[]{ 246, 053, 157, 523 }, CanGigantamax = true }, // Coalossal

            // 1/31 - Milcery
            //new EncounterStatic8ND(40,05,3) { Species = 841, Ability = A4, Moves = new[]{ 788, 406, 512, 491 }, CanGigantamax = true }, // Flapple
            //new EncounterStatic8ND(40,05,3) { Species = 839, Ability = A4, Moves = new[]{ 246, 510, 479, 488 }, CanGigantamax = true }, // Coalossal
            //new EncounterStatic8ND(50,08,4) { Species = 841, Ability = A4, Moves = new[]{ 788, 407, 491, 334 }, CanGigantamax = true }, // Flapple -- first two moves swapped match a prior distribution
            //new EncounterStatic8ND(50,08,4) { Species = 839, Ability = A4, Moves = new[]{ 246, 053, 157, 261 }, CanGigantamax = true }, // Coalossal
            //new EncounterStatic8ND(60,10,5) { Species = 841, Ability = A4, Moves = new[]{ 407, 788, 512, 349 }, CanGigantamax = true }, // Flapple
            //new EncounterStatic8ND(60,10,5) { Species = 839, Ability = A4, Moves = new[]{ 246, 053, 157, 523 }, CanGigantamax = true }, // Coalossal

            // 2/6 - Toxtricity
            new EncounterStatic8ND(40,05,3) { Species = 099, Ability = A4, Moves = new[]{ 534, 232, 023, 106 }, CanGigantamax = true }, // Kingler
            new EncounterStatic8ND(40,05,3) { Species = 860, Ability = A4, Moves = new[]{ 492, 577, 421, 141 } }, // Morgrem
            new EncounterStatic8ND(40,05,3) { Species = 849, Ability = A4, Moves = new[]{ 085, 474, 496, 103 }, CanGigantamax = true }, // Toxtricity
            new EncounterStatic8ND(50,08,4) { Species = 099, Ability = A4, Moves = new[]{ 359, 667, 157, 534 }, CanGigantamax = true }, // Kingler
            new EncounterStatic8ND(50,08,4) { Species = 861, Ability = A4, Moves = new[]{ 789, 793, 280, 409 }, CanGigantamax = true }, // Grimmsnarl
            new EncounterStatic8ND(50,08,4) { Species = 849, Ability = A4, Moves = new[]{ 786, 506, 474, 409 }, CanGigantamax = true }, // Toxtricity
            new EncounterStatic8ND(60,10,5) { Species = 099, Ability = A4, Moves = new[]{ 152, 667, 157, 404 }, CanGigantamax = true }, // Kingler
            new EncounterStatic8ND(60,10,5) { Species = 861, Ability = A4, Moves = new[]{ 789, 793, 409, 007 }, CanGigantamax = true }, // Grimmsnarl
            new EncounterStatic8ND(60,10,5) { Species = 849, Ability = A4, Moves = new[]{ 786, 586, 482, 506 }, CanGigantamax = true }, // Toxtricity

            // 2/17 - Toxel
            new EncounterStatic8ND(17,01,1) { Species = 098, Ability = A4, Moves = new[]{ 055, 043, 106, 232 } }, // Krabby
            new EncounterStatic8ND(17,01,1) { Species = 859, Ability = A4, Moves = new[]{ 044, 260, 590, 372 } }, // Impidimp
            new EncounterStatic8ND(30,03,2) { Species = 099, Ability = A4, Moves = new[]{ 232, 341, 061, 023 } }, // Kingler
            new EncounterStatic8ND(30,03,2) { Species = 099, Ability = A4, Moves = new[]{ 232, 341, 061, 023 }, CanGigantamax = true }, // Kingler
            new EncounterStatic8ND(30,03,2) { Species = 859, Ability = A4, Moves = new[]{ 389, 577, 260, 279 } }, // Impidimp
            new EncounterStatic8ND(30,03,2) { Species = 849, Ability = A4, Moves = new[]{ 474, 209, 268, 175 } }, // Toxtricity
            new EncounterStatic8ND(40,05,3) { Species = 099, Ability = A4, Moves = new[]{ 534, 232, 023, 106 } }, // Kingler
            //new EncounterStatic8ND(40,05,3) { Species = 099, Ability = A4, Moves = new[]{ 534, 232, 023, 106 }, CanGigantamax = true }, // Kingler
            //new EncounterStatic8ND(40,05,3) { Species = 860, Ability = A4, Moves = new[]{ 492, 577, 421, 141 } }, // Morgrem
            new EncounterStatic8ND(40,05,3) { Species = 849, Ability = A4, Moves = new[]{ 085, 474, 496, 103 } }, // Toxtricity
            //new EncounterStatic8ND(40,05,3) { Species = 849, Ability = A4, Moves = new[]{ 085, 474, 496, 103 }, CanGigantamax = true }, // Toxtricity
            new EncounterStatic8ND(50,08,4) { Species = 099, Ability = A4, Moves = new[]{ 359, 667, 157, 534 } }, // Kingler
            //new EncounterStatic8ND(50,08,4) { Species = 099, Ability = A4, Moves = new[]{ 359, 667, 157, 534 }, CanGigantamax = true }, // Kingler
            new EncounterStatic8ND(50,08,4) { Species = 861, Ability = A4, Moves = new[]{ 789, 793, 280, 409 } }, // Grimmsnarl
            //new EncounterStatic8ND(50,08,4) { Species = 861, Ability = A4, Moves = new[]{ 789, 793, 280, 409 }, CanGigantamax = true }, // Grimmsnarl
            new EncounterStatic8ND(50,08,4) { Species = 849, Ability = A4, Moves = new[]{ 786, 506, 474, 409 } }, // Toxtricity
            //new EncounterStatic8ND(50,08,4) { Species = 849, Ability = A4, Moves = new[]{ 786, 506, 474, 409 }, CanGigantamax = true }, // Toxtricity
            new EncounterStatic8ND(60,10,5) { Species = 099, Ability = A4, Moves = new[]{ 152, 667, 157, 404 } }, // Kingler
            //new EncounterStatic8ND(60,10,5) { Species = 099, Ability = A4, Moves = new[]{ 152, 667, 157, 404 }, CanGigantamax = true }, // Kingler
            new EncounterStatic8ND(60,10,5) { Species = 861, Ability = A4, Moves = new[]{ 789, 793, 409, 007 } }, // Grimmsnarl
            //new EncounterStatic8ND(60,10,5) { Species = 861, Ability = A4, Moves = new[]{ 789, 793, 409, 007 }, CanGigantamax = true }, // Grimmsnarl
            new EncounterStatic8ND(60,10,5) { Species = 849, Ability = A4, Moves = new[]{ 786, 586, 188, 506 } }, // Toxtricity
            new EncounterStatic8ND(60,10,5) { Species = 849, Ability = A4, Moves = new[]{ 786, 586, 188, 506 }, CanGigantamax = true }, // Toxtricity
        };

        internal static readonly EncounterStatic8ND[] Dist_SH =
        {
            // 11/15 - Butterfree
            new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 079 } }, // Butterfree
            new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 079 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(17,01,1) { Species = 821, Ability = A2, Moves = new[]{ 365, 031, 526, 064 } }, // Rookidee
            new EncounterStatic8ND(17,01,1) { Species = 821, Ability = A4, Moves = new[]{ 365, 031, 526, 064 } }, // Rookidee
            new EncounterStatic8ND(17,01,1) { Species = 850, Ability = A2, Moves = new[]{ 044, 172, 450, 693 } }, // Sizzlipede
            new EncounterStatic8ND(17,01,1) { Species = 850, Ability = A4, Moves = new[]{ 044, 172, 450, 693 } }, // Sizzlipede
            new EncounterStatic8ND(30,03,2) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 081, 077 } }, // Butterfree
            new EncounterStatic8ND(30,03,2) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 081, 077 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(30,03,2) { Species = 822, Ability = A2, Moves = new[]{ 365, 263, 179, 468 } }, // Corvisquire
            new EncounterStatic8ND(30,03,2) { Species = 822, Ability = A4, Moves = new[]{ 365, 263, 179, 468 } }, // Corvisquire
            new EncounterStatic8ND(30,03,2) { Species = 851, Ability = A2, Moves = new[]{ 172, 242, 450, 257 } }, // Centiskorch
            new EncounterStatic8ND(30,03,2) { Species = 851, Ability = A4, Moves = new[]{ 172, 242, 450, 257 } }, // Centiskorch
            new EncounterStatic8ND(40,05,3) { Species = 823, Ability = A4, Moves = new[]{ 065, 211, 034, 103 } }, // Corviknight
            new EncounterStatic8ND(40,05,3) { Species = 823, Ability = A4, Moves = new[]{ 065, 211, 034, 103 }, CanGigantamax = true }, // Corviknight
            new EncounterStatic8ND(40,05,3) { Species = 851, Ability = A4, Moves = new[]{ 141, 438, 053, 489 } }, // Centiskorch
            new EncounterStatic8ND(40,05,3) { Species = 851, Ability = A4, Moves = new[]{ 141, 438, 053, 489 }, CanGigantamax = true }, // Centiskorch
            new EncounterStatic8ND(50,08,4) { Species = 823, Ability = A4, Moves = new[]{ 065, 442, 034, 334 } }, // Corviknight
            new EncounterStatic8ND(50,08,4) { Species = 823, Ability = A4, Moves = new[]{ 065, 442, 034, 334 }, CanGigantamax = true }, // Corviknight
            new EncounterStatic8ND(50,08,4) { Species = 851, Ability = A4, Moves = new[]{ 141, 424, 422, 242 } }, // Centiskorch
            new EncounterStatic8ND(50,08,4) { Species = 851, Ability = A4, Moves = new[]{ 141, 424, 422, 242 }, CanGigantamax = true }, // Centiskorch
            new EncounterStatic8ND(60,10,5) { Species = 012, Ability = A4, Moves = new[]{ 405, 094, 403, 079 } }, // Butterfree
            new EncounterStatic8ND(70,10,5) { Species = 012, Ability = A4, Moves = new[]{ 405, 094, 403, 079 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(60,10,5) { Species = 823, Ability = A4, Moves = new[]{ 413, 442, 249, 103 } }, // Corviknight
            new EncounterStatic8ND(70,10,5) { Species = 823, Ability = A4, Moves = new[]{ 413, 442, 249, 103 }, CanGigantamax = true }, // Corviknight
            new EncounterStatic8ND(60,10,5) { Species = 851, Ability = A4, Moves = new[]{ 679, 257, 083, 438 } }, // Centiskorch
            new EncounterStatic8ND(70,10,5) { Species = 851, Ability = A4, Moves = new[]{ 679, 257, 083, 438 }, CanGigantamax = true }, // Centiskorch

            // 12/03 - Snorlax
            //new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 079 } }, // Butterfree
            //new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 079 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(17,01,1) { Species = 821, Ability = A4, Moves = new[]{ 403, 031, 116, 064 } }, // Rookidee
            new EncounterStatic8ND(17,01,1) { Species = 850, Ability = A4, Moves = new[]{ 044, 172, 404, 693 } }, // Sizzlipede
            //new EncounterStatic8ND(30,03,2) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 081, 077 }, CanGigantamax = true }, // Butterfree
            new EncounterStatic8ND(30,03,2) { Species = 822, Ability = A4, Moves = new[]{ 403, 263, 179, 468 } }, // Corvisquire
            new EncounterStatic8ND(30,03,2) { Species = 851, Ability = A4, Moves = new[]{ 172, 242, 404, 257 } }, // Centiskorch
            new EncounterStatic8ND(30,03,2) { Species = 851, Ability = A2, Moves = new[]{ 172, 242, 404, 257 } }, // Centiskorch
            //new EncounterStatic8ND(40,05,3) { Species = 823, Ability = A4, Moves = new[]{ 065, 211, 034, 103 }, CanGigantamax = true }, // Corviknight
            //new EncounterStatic8ND(40,05,3) { Species = 851, Ability = A4, Moves = new[]{ 141, 438, 053, 489 } }, // Centiskorch
            //new EncounterStatic8ND(40,05,3) { Species = 851, Ability = A4, Moves = new[]{ 141, 438, 053, 489 }, CanGigantamax = true }, // Centiskorch
            //new EncounterStatic8ND(50,08,4) { Species = 823, Ability = A4, Moves = new[]{ 065, 442, 034, 334 }, CanGigantamax = true }, // Corviknight
            //new EncounterStatic8ND(50,08,4) { Species = 851, Ability = A4, Moves = new[]{ 141, 424, 422, 242 } }, // Centiskorch
            //new EncounterStatic8ND(50,08,4) { Species = 851, Ability = A4, Moves = new[]{ 141, 424, 422, 242 }, CanGigantamax = true }, // Centiskorch
            new EncounterStatic8ND(60,10,5) { Species = 012, Ability = A4, Moves = new[]{ 405, 094, 403, 079 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(70,10,5) { Species = 823, Ability = A4, Moves = new[]{ 413, 442, 249, 103 }, CanGigantamax = true }, // Corviknight
            //new EncounterStatic8ND(60,10,5) { Species = 851, Ability = A4, Moves = new[]{ 679, 257, 083, 438 } }, // Centiskorch
            //new EncounterStatic8ND(70,10,5) { Species = 851, Ability = A4, Moves = new[]{ 679, 257, 083, 438 }, CanGigantamax = true }, // Centiskorch

            // 12/20 - Delibird
            //new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 079 } }, // Butterfree
            //new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 079 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(17,01,1) { Species = 821, Ability = A4, Moves = new[]{ 403, 031, 116, 064 } }, // Rookidee
            new EncounterStatic8ND(17,01,1) { Species = 850, Ability = A4, Moves = new[]{ 044, 172, 141, 693 } }, // Sizzlipede
            //new EncounterStatic8ND(30,03,2) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 081, 077 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(30,03,2) { Species = 822, Ability = A4, Moves = new[]{ 403, 263, 179, 468 } }, // Corvisquire
            //new EncounterStatic8ND(30,03,2) { Species = 851, Ability = A4, Moves = new[]{ 172, 242, 404, 257 } }, // Centiskorch
            //new EncounterStatic8ND(40,05,3) { Species = 823, Ability = A4, Moves = new[]{ 065, 211, 034, 103 }, CanGigantamax = true }, // Corviknight
            //new EncounterStatic8ND(40,05,3) { Species = 851, Ability = A4, Moves = new[]{ 141, 438, 053, 489 } }, // Centiskorch
            //new EncounterStatic8ND(40,05,3) { Species = 851, Ability = A4, Moves = new[]{ 141, 438, 053, 489 }, CanGigantamax = true }, // Centiskorch
            //new EncounterStatic8ND(50,08,4) { Species = 823, Ability = A4, Moves = new[]{ 065, 442, 034, 334 }, CanGigantamax = true }, // Corviknight
            //new EncounterStatic8ND(50,08,4) { Species = 851, Ability = A4, Moves = new[]{ 141, 424, 422, 242 } }, // Centiskorch
            //new EncounterStatic8ND(50,08,4) { Species = 851, Ability = A4, Moves = new[]{ 141, 424, 422, 242 }, CanGigantamax = true }, // Centiskorch
            //new EncounterStatic8ND(60,10,5) { Species = 012, Ability = A4, Moves = new[]{ 405, 094, 403, 079 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(70,10,5) { Species = 823, Ability = A4, Moves = new[]{ 413, 442, 249, 103 }, CanGigantamax = true }, // Corviknight
            //new EncounterStatic8ND(60,10,5) { Species = 851, Ability = A4, Moves = new[]{ 679, 257, 083, 438 } }, // Centiskorch
            //new EncounterStatic8ND(70,10,5) { Species = 851, Ability = A4, Moves = new[]{ 679, 257, 083, 438 }, CanGigantamax = true }, // Centiskorch

            // 12/30 - Magikarp
            //new EncounterStatic8ND(17,01,1) { Species = 012, Ability = A4, Moves = new[]{ 405, 060, 016, 079 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(17,01,1) { Species = 821, Ability = A4, Moves = new[]{ 403, 031, 116, 064 } }, // Rookidee
            //new EncounterStatic8ND(17,01,1) { Species = 850, Ability = A4, Moves = new[]{ 044, 172, 141, 693 } }, // Sizzlipede
            //new EncounterStatic8ND(30,03,2) { Species = 012, Ability = A4, Moves = new[]{ 405, 403, 081, 077 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(30,03,2) { Species = 822, Ability = A4, Moves = new[]{ 403, 263, 179, 468 } }, // Corvisquire
            //new EncounterStatic8ND(30,03,2) { Species = 851, Ability = A4, Moves = new[]{ 172, 242, 404, 257 } }, // Centiskorch
            //new EncounterStatic8ND(40,05,3) { Species = 823, Ability = A4, Moves = new[]{ 065, 211, 034, 103 }, CanGigantamax = true }, // Corviknight
            //new EncounterStatic8ND(40,05,3) { Species = 851, Ability = A4, Moves = new[]{ 141, 438, 053, 489 }, CanGigantamax = true }, // Centiskorch
            //new EncounterStatic8ND(50,08,4) { Species = 823, Ability = A4, Moves = new[]{ 065, 442, 034, 334 }, CanGigantamax = true }, // Corviknight
            //new EncounterStatic8ND(50,08,4) { Species = 851, Ability = A4, Moves = new[]{ 141, 424, 422, 242 }, CanGigantamax = true }, // Centiskorch
            //new EncounterStatic8ND(60,10,5) { Species = 012, Ability = A4, Moves = new[]{ 405, 094, 403, 079 }, CanGigantamax = true }, // Butterfree
            //new EncounterStatic8ND(70,10,5) { Species = 823, Ability = A4, Moves = new[]{ 413, 442, 249, 103 }, CanGigantamax = true }, // Corviknight
            //new EncounterStatic8ND(70,10,5) { Species = 851, Ability = A4, Moves = new[]{ 679, 257, 083, 438 }, CanGigantamax = true }, // Centiskorch

            // 1/8 - Applin
            new EncounterStatic8ND(17,01,1) { Species = 131, Ability = A4, Moves = new[]{ 055, 496, 045, 047 } }, // Lapras
            new EncounterStatic8ND(17,01,1) { Species = 131, Ability = A2, Moves = new[]{ 055, 496, 045, 047 } }, // Lapras
            new EncounterStatic8ND(30,03,2) { Species = 842, Ability = A4, Moves = new[]{ 787, 029, 389, 073 } }, // Appletun
            new EncounterStatic8ND(30,03,2) { Species = 842, Ability = A2, Moves = new[]{ 787, 029, 389, 073 } }, // Appletun
            new EncounterStatic8ND(30,03,2) { Species = 131, Ability = A4, Moves = new[]{ 352, 420, 109, 047 } }, // Lapras
            new EncounterStatic8ND(30,03,2) { Species = 131, Ability = A2, Moves = new[]{ 352, 420, 109, 047 } }, // Lapras
            new EncounterStatic8ND(40,05,3) { Species = 842, Ability = A4, Moves = new[]{ 787, 496, 406, 523 } }, // Appletun
            new EncounterStatic8ND(40,05,3) { Species = 842, Ability = A4, Moves = new[]{ 787, 496, 406, 523 }, CanGigantamax = true }, // Appletun
            new EncounterStatic8ND(40,05,3) { Species = 869, Ability = A4, Moves = new[]{ 577, 605, 202, 186 }, Form = 1, CanGigantamax = true }, // Alcremie-1
            new EncounterStatic8ND(40,05,3) { Species = 869, Ability = A4, Moves = new[]{ 577, 605, 202, 186 }, Form = 2, CanGigantamax = true }, // Alcremie-2
            new EncounterStatic8ND(40,05,3) { Species = 131, Ability = A4, Moves = new[]{ 352, 420, 109, 034 } }, // Lapras
            new EncounterStatic8ND(40,05,3) { Species = 131, Ability = A4, Moves = new[]{ 352, 420, 109, 034 }, CanGigantamax = true }, // Lapras
            new EncounterStatic8ND(50,08,4) { Species = 842, Ability = A4, Moves = new[]{ 787, 202, 406, 089 } }, // Appletun
            new EncounterStatic8ND(50,08,4) { Species = 842, Ability = A4, Moves = new[]{ 787, 202, 406, 089 }, CanGigantamax = true }, // Appletun
            new EncounterStatic8ND(50,08,4) { Species = 869, Ability = A4, Moves = new[]{ 605, 202, 094, 151 }, Form = 7, CanGigantamax = true }, // Alcremie-7
            new EncounterStatic8ND(50,08,4) { Species = 869, Ability = A4, Moves = new[]{ 605, 202, 094, 151 }, Form = 8, CanGigantamax = true }, // Alcremie-8
            new EncounterStatic8ND(50,08,4) { Species = 131, Ability = A4, Moves = new[]{ 057, 058, 246, 523 } }, // Lapras
            new EncounterStatic8ND(50,08,4) { Species = 131, Ability = A4, Moves = new[]{ 057, 058, 246, 523 }, CanGigantamax = true }, // Lapras
            new EncounterStatic8ND(60,10,5) { Species = 842, Ability = A4, Moves = new[]{ 787, 406, 412, 089 } }, // Appletun
            new EncounterStatic8ND(60,10,5) { Species = 842, Ability = A4, Moves = new[]{ 787, 406, 412, 089 }, CanGigantamax = true }, // Appletun
            new EncounterStatic8ND(60,10,5) { Species = 869, Ability = A4, Moves = new[]{ 605, 202, 595, 500 }, Form = 3, CanGigantamax = true }, // Alcremie-3
            new EncounterStatic8ND(60,10,5) { Species = 869, Ability = A4, Moves = new[]{ 605, 202, 595, 500 }, Form = 4, CanGigantamax = true }, // Alcremie-4
            new EncounterStatic8ND(60,10,5) { Species = 131, Ability = A4, Moves = new[]{ 057, 196, 573, 329 } }, // Lapras
            new EncounterStatic8ND(60,10,5) { Species = 131, Ability = A4, Moves = new[]{ 057, 196, 573, 329 }, CanGigantamax = true }, // Lapras

            // 1/31 - Milcery
            //new EncounterStatic8ND(40,05,3) { Species = 842, Ability = A4, Moves = new[]{ 787, 496, 406, 523 }, CanGigantamax = true }, // Appletun
            //new EncounterStatic8ND(40,05,3) { Species = 131, Ability = A4, Moves = new[]{ 352, 420, 109, 034 }, CanGigantamax = true }, // Lapras
            //new EncounterStatic8ND(50,08,4) { Species = 842, Ability = A4, Moves = new[]{ 787, 202, 406, 089 }, CanGigantamax = true }, // Appletun
            //new EncounterStatic8ND(50,08,4) { Species = 131, Ability = A4, Moves = new[]{ 057, 058, 246, 523 }, CanGigantamax = true }, // Lapras
            //new EncounterStatic8ND(60,10,5) { Species = 842, Ability = A4, Moves = new[]{ 787, 406, 412, 089 }, CanGigantamax = true }, // Appletun
            //new EncounterStatic8ND(60,10,5) { Species = 131, Ability = A4, Moves = new[]{ 057, 196, 573, 329 }, CanGigantamax = true }, // Lapras

            // 2/6 - Toxtricity
            new EncounterStatic8ND(40,05,3) { Species = 826, Ability = A4, Moves = new[]{ 522, 060, 109, 202 }, CanGigantamax = true }, // Orbeetle
            new EncounterStatic8ND(40,05,3) { Species = 857, Ability = A4, Moves = new[]{ 605, 345, 399, 500 } }, // Hattrem
            new EncounterStatic8ND(40,05,3) { Species = 849, Ability = A4, Moves = new[]{ 085, 599, 496, 103 }, Form = 1, CanGigantamax = true }, // Toxtricity-1
            new EncounterStatic8ND(50,08,4) { Species = 826, Ability = A4, Moves = new[]{ 405, 094, 202, 247 }, CanGigantamax = true }, // Orbeetle
            new EncounterStatic8ND(50,08,4) { Species = 858, Ability = A4, Moves = new[]{ 605, 094, 595, 247 }, CanGigantamax = true }, // Hatterene
            new EncounterStatic8ND(50,08,4) { Species = 849, Ability = A4, Moves = new[]{ 786, 506, 599, 409 }, Form = 1, CanGigantamax = true }, // Toxtricity-1
            new EncounterStatic8ND(60,10,5) { Species = 826, Ability = A4, Moves = new[]{ 405, 094, 247, 347 }, CanGigantamax = true }, // Orbeetle
            new EncounterStatic8ND(60,10,5) { Species = 858, Ability = A4, Moves = new[]{ 605, 094, 595, 500 }, CanGigantamax = true }, // Hatterene
            new EncounterStatic8ND(60,10,5) { Species = 849, Ability = A4, Moves = new[]{ 786, 586, 482, 506 }, Form = 1, CanGigantamax = true }, // Toxtricity-1

            // 2/17 - Toxel
            new EncounterStatic8ND(17,01,1) { Species = 825, Ability = A4, Moves = new[]{ 093, 522, 113, 115 } }, // Dottler
            new EncounterStatic8ND(17,01,1) { Species = 856, Ability = A4, Moves = new[]{ 093, 589, 791, 574 } }, // Hatenna
            new EncounterStatic8ND(30,03,2) { Species = 826, Ability = A4, Moves = new[]{ 405, 060, 496, 095 } }, // Orbeetle
            new EncounterStatic8ND(30,03,2) { Species = 826, Ability = A4, Moves = new[]{ 405, 060, 496, 095 }, CanGigantamax = true }, // Orbeetle
            new EncounterStatic8ND(30,03,2) { Species = 856, Ability = A4, Moves = new[]{ 605, 060, 345, 347 } }, // Hatenna
            new EncounterStatic8ND(30,03,2) { Species = 849, Ability = A4, Moves = new[]{ 599, 209, 268, 175 }, Form = 1 }, // Toxtricity-1
            new EncounterStatic8ND(40,05,3) { Species = 826, Ability = A4, Moves = new[]{ 405, 060, 202, 109 } }, // Orbeetle
            new EncounterStatic8ND(40,05,3) { Species = 826, Ability = A4, Moves = new[]{ 405, 060, 202, 109 }, CanGigantamax = true }, // Orbeetle
            //new EncounterStatic8ND(40,05,3) { Species = 857, Ability = A4, Moves = new[]{ 605, 345, 399, 500 } }, // Hattrem
            new EncounterStatic8ND(40,05,3) { Species = 849, Ability = A4, Moves = new[]{ 085, 599, 496, 103 }, Form = 1 }, // Toxtricity-1
            //new EncounterStatic8ND(40,05,3) { Species = 849, Ability = A4, Moves = new[]{ 085, 599, 496, 103 }, Form = 1, CanGigantamax = true }, // Toxtricity-1
            new EncounterStatic8ND(50,08,4) { Species = 826, Ability = A4, Moves = new[]{ 405, 094, 202, 247 } }, // Orbeetle
            //new EncounterStatic8ND(50,08,4) { Species = 826, Ability = A4, Moves = new[]{ 405, 094, 202, 247 }, CanGigantamax = true }, // Orbeetle
            new EncounterStatic8ND(50,08,4) { Species = 858, Ability = A4, Moves = new[]{ 605, 094, 595, 247 } }, // Hatterene
            //new EncounterStatic8ND(50,08,4) { Species = 858, Ability = A4, Moves = new[]{ 605, 094, 595, 247 }, CanGigantamax = true }, // Hatterene
            new EncounterStatic8ND(50,08,4) { Species = 849, Ability = A4, Moves = new[]{ 786, 506, 599, 409 }, Form = 1 }, // Toxtricity-1
            //new EncounterStatic8ND(50,08,4) { Species = 849, Ability = A4, Moves = new[]{ 786, 506, 599, 409 }, Form = 1, CanGigantamax = true }, // Toxtricity-1
            new EncounterStatic8ND(60,10,5) { Species = 826, Ability = A4, Moves = new[]{ 405, 094, 247, 347 } }, // Orbeetle
            //new EncounterStatic8ND(60,10,5) { Species = 826, Ability = A4, Moves = new[]{ 405, 094, 247, 347 }, CanGigantamax = true }, // Orbeetle
            new EncounterStatic8ND(60,10,5) { Species = 858, Ability = A4, Moves = new[]{ 605, 094, 595, 500 } }, // Hatterene
            //new EncounterStatic8ND(60,10,5) { Species = 858, Ability = A4, Moves = new[]{ 605, 094, 595, 500 }, CanGigantamax = true }, // Hatterene
            new EncounterStatic8ND(60,10,5) { Species = 849, Ability = A4, Moves = new[]{ 786, 586, 188, 506 }, Form = 1 }, // Toxtricity-1
            new EncounterStatic8ND(60,10,5) { Species = 849, Ability = A4, Moves = new[]{ 786, 586, 188, 506 }, Form = 1, CanGigantamax = true }, // Toxtricity-1
        };
    }
}
