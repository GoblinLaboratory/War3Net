﻿// ------------------------------------------------------------------------------
// <copyright file="ForceFlags.cs" company="Drake53">
// Copyright (c) 2019 Drake53. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// ------------------------------------------------------------------------------

using System;

namespace War3Net.Build.Info
{
    [Flags]
    public enum ForceFlags
    {
        Allied = 0x01,
        AlliedVictory = 0x02,
        // 0x04
        ShareVision = 0x08,
        ShareUnitControl = 0x10,
        ShareAdvancedUnitControl = 0x20,
    }
}