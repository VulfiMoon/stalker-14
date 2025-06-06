/*
 * All right reserved to CrystallPunk.
 *
 * This file is sublicensed under Custom License Agreement for Stalker14 project (https://github.com/stalker14-project/stalker14) only
 *
 * See LICENSE.TXT file in the project root for full license information.
 * Copyright (c) 2024 TheShuEd (Github)
 */

using Content.Shared.Parallax.Biomes;
using Robust.Shared.Prototypes;

namespace Content.Server._Stalker.BiomesSpawner;

/// <summary>
/// fills the tile in which it is located with the contents of the biome. Includes: tile, decals and entities
/// </summary>
[RegisterComponent, Access(typeof(STBiomeSpawnerSystem))]
public sealed partial class STBiomeSpawnerComponent : Component
{
    [DataField]
    public ProtoId<BiomeTemplatePrototype> Biome = "STGrasslands";
}
