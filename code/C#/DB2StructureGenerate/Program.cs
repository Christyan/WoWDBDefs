using System.Diagnostics;
using System.Text;

namespace DB2StructureGenerate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> AfterData = new Dictionary<string, string>
            {
                {
                    "AreaTableEntry",
"    EnumFlag<AreaFlags> GetFlags() const { return static_cast<AreaFlags>(Flags[0]); }\n" +
"    EnumFlag<AreaFlags2> GetFlags2() const { return static_cast<AreaFlags2>(Flags[1]); }\n" +
"    EnumFlag<AreaMountFlags> GetMountFlags() const { return static_cast<AreaMountFlags>(MountFlags); }\n" +
"    \n" +
"    bool IsSanctuary() const\n" +
"    {\n" +
"        return GetFlags().HasFlag(AreaFlags::NoPvP);\n" +
"    }" },
                {
                    "BattlePetSpeciesEntry",
"    EnumFlag<BattlePetSpeciesFlags> GetFlags() const { return static_cast<BattlePetSpeciesFlags>(Flags); }"

                },
                {
                    "BattlemasterListEntry",
"    EnumFlag<BattlemasterListFlags> GetFlags() const { return static_cast<BattlemasterListFlags>(Flags); }"
                },
                {
                    "Cfg_CategoriesEntry",
"    EnumFlag<CfgCategoriesCharsets> GetCreateCharsetMask() const { return static_cast<CfgCategoriesCharsets>(CreateCharsetMask); }\n" +
"    EnumFlag<CfgCategoriesCharsets> GetExistingCharsetMask() const { return static_cast<CfgCategoriesCharsets>(ExistingCharsetMask); }\n" +
"    EnumFlag<CfgCategoriesFlags> GetFlags() const { return static_cast<CfgCategoriesFlags>(Flags); }"
                },
                {
                    "CharacterLoadoutEntry",
"    bool IsForNewCharacter() const { return Purpose == 9; }"
                },
                {
                    "ChatChannelsEntry",
"    EnumFlag<ChatChannelFlags> GetFlags() const { return static_cast<ChatChannelFlags>(Flags); }\n" +
"    ChatChannelRuleset GetRuleset() const { return static_cast<ChatChannelRuleset>(Ruleset); }"
                },
                {
                    "ChrCustomizationReqEntry",
"    EnumFlag<ChrCustomizationReqFlag> GetFlags() const { return static_cast<ChrCustomizationReqFlag>(Flags); }"
                },
                {
                    "ChrRacesEntry",
"    EnumFlag<ChrRacesFlag> GetFlags() const { return static_cast<ChrRacesFlag>(Flags); }"
                },
                {
                    "ChrSpecializationEntry",
"    EnumFlag<ChrSpecializationFlag> GetFlags() const { return static_cast<ChrSpecializationFlag>(Flags); }\n" +
"    ChrSpecializationRole GetRole() const { return static_cast<ChrSpecializationRole>(Role); }\n" +
"\n" +
"    bool IsPetSpecialization() const\n" +
"    {\n" +
"        return ClassID == 0;\n" +
"    }"
                },
                {
                    "ContentTuningEntry",
"    EnumFlag<ContentTuningFlag> GetFlags() const { return static_cast<ContentTuningFlag>(Flags); }\n" +
"\n" +
"    int32 GetScalingFactionGroup() const\n" +
"    {\n" +
"        EnumFlag<ContentTuningFlag> flags = GetFlags();\n" +
"        if (flags.HasFlag(ContentTuningFlag::Horde))\n" +
"            return 5;\n" +
"\n" +
"        if (flags.HasFlag(ContentTuningFlag::Alliance))\n" +
"            return 3;\n" +
"\n" +
"        return 0;\n" +
"    }"
                },
                {
                    "CreatureModelDataEntry",
"    EnumFlag<CreatureModelDataFlags> GetFlags() const { return static_cast<CreatureModelDataFlags>(Flags); }"
                },
                {
                    "CriteriaEntry",
"    EnumFlag<CriteriaFlags> GetFlags() const { return static_cast<CriteriaFlags>(Flags); }"
                },
                {
                    "CriteriaTreeEntry",
"    EnumFlag<CriteriaTreeFlags> GetFlags() const { return static_cast<CriteriaTreeFlags>(Flags); }}"
                },
                {
                    "CurrencyTypesEntry",
"    EnumFlag<CurrencyTypesFlags> GetFlags() const { return static_cast<CurrencyTypesFlags>(Flags[0]); }\n" +
"    EnumFlag<CurrencyTypesFlagsB> GetFlagsB() const { return static_cast<CurrencyTypesFlagsB>(Flags[1]); }\n" +
"\n" +
"    // Helpers\n" +
"    int32 GetScaler() const\n" +
"    {\n" +
"        return GetFlags().HasFlag(CurrencyTypesFlags::_100_Scaler) ? 100 : 1;\n" +
"    }\n" +
"\n" +
"    bool HasMaxEarnablePerWeek() const\n" +
"    {\n" +
"        return MaxEarnablePerWeek || GetFlags().HasFlag(CurrencyTypesFlags::ComputedWeeklyMaximum);\n" +
"    }\n" +
"\n" +
"    bool HasMaxQuantity(bool onLoad = false, bool onUpdateVersion = false) const\n" +
"    {\n" +
"        if (onLoad && GetFlags().HasFlag(CurrencyTypesFlags::IgnoreMaxQtyOnLoad))\n" +
"            return false;\n" +
"\n" +
"        if (onUpdateVersion && GetFlags().HasFlag(CurrencyTypesFlags::UpdateVersionIgnoreMax))\n" +
"            return false;\n" +
"\n" +
"        return MaxQty || GetFlags().HasFlag(CurrencyTypesFlags::DynamicMaximum);\n" +
"    }\n" +
"\n" +
"    bool HasTotalEarned() const\n" +
"    {\n" +
"        return GetFlagsB().HasFlag(CurrencyTypesFlagsB::UseTotalEarnedForEarned);\n" +
"    }\n" +
"\n" +
"    bool IsAlliance() const\n" +
"    {\n" +
"        return GetFlags().HasFlag(CurrencyTypesFlags::IsAllianceOnly);\n" +
"    }\n" +
"\n" +
"    bool IsHorde() const\n" +
"    {\n" +
"        return GetFlags().HasFlag(CurrencyTypesFlags::IsHordeOnly);\n" +
"    }\n" +
"\n" +
"    bool IsSuppressingChatLog(bool onUpdateVersion = false) const\n" +
"    {\n" +
"        if ((onUpdateVersion && GetFlags().HasFlag(CurrencyTypesFlags::SuppressChatMessageOnVersionChange)) ||\n" +
"            GetFlags().HasFlag(CurrencyTypesFlags::SuppressChatMessages))\n" +
"            return true;\n" +
"\n" +
"        return false;\n" +
"    }\n" +
"\n" +
"    bool IsTrackingQuantity() const\n" +
"    {\n" +
"        return GetFlags().HasFlag(CurrencyTypesFlags::TrackQuantity);\n" +
"    }"
                },
                {
                    "FactionEntry",
"    bool CanHaveReputation() const\n" +
"    {\n" +
"        return ReputationIndex >= 0;\n" +
"    }"
                },
                {
                    "FactionTemplateEntry",
"    bool IsFriendlyTo(FactionTemplateEntry const* entry) const\n" +
"    {\n" +
"        if (this == entry)\n" +
"            return true;\n" +
"        if (entry->Faction)\n" +
"        {\n" +
"            for (int32 i = 0; i < MAX_FACTION_RELATIONS; ++i)\n" +
"                if (Enemies[i] == entry->Faction)\n" +
"                    return false;\n" +
"            for (int32 i = 0; i < MAX_FACTION_RELATIONS; ++i)\n" +
"                if (Friend[i] == entry->Faction)\n" +
"                    return true;\n" +
"        }\n" +
"        return (FriendGroup & entry->FactionGroup) || (FactionGroup & entry->FriendGroup);\n" +
"    }\n" +
"    bool IsHostileTo(FactionTemplateEntry const* entry) const\n" +
"    {\n" +
"        if (this == entry)\n" +
"            return false;\n" +
"        if (entry->Faction)\n" +
"        {\n" +
"            for (int32 i = 0; i < MAX_FACTION_RELATIONS; ++i)\n" +
"                if (Enemies[i] == entry->Faction)\n" +
"                    return true;\n" +
"            for (int32 i = 0; i < MAX_FACTION_RELATIONS; ++i)\n" +
"                if (Friend[i] == entry->Faction)\n" +
"                    return false;\n" +
"        }\n" +
"        return (EnemyGroup & entry->FactionGroup) != 0;\n" +
"    }\n" +
"    bool IsHostileToPlayers() const { return (EnemyGroup & FACTION_MASK_PLAYER) != 0; }\n" +
"    bool IsNeutralToAll() const\n" +
"    {\n" +
"        for (int i = 0; i < MAX_FACTION_RELATIONS; ++i)\n" +
"            if (Enemies[i] != 0)\n" +
"                return false;\n" +
"        return EnemyGroup == 0 && FriendGroup == 0;\n" +
"    }\n" +
"    bool IsContestedGuardFaction() const { return (Flags & FACTION_TEMPLATE_FLAG_CONTESTED_GUARD) != 0; }"
                },
                {
                    "LFGDungeonsEntry",
"    uint32 Entry() const { return ID + (TypeID << 24); }"
                },
                {
                    "MapEntry",
"    uint8 Expansion() const { return ExpansionID; }\n" +
"\n" +
"    bool IsDungeon() const { return (InstanceType == MAP_INSTANCE || InstanceType == MAP_RAID || InstanceType == MAP_SCENARIO) && !IsGarrison(); }\n" +
"    bool IsNonRaidDungeon() const { return InstanceType == MAP_INSTANCE; }\n" +
"    bool Instanceable() const { return InstanceType == MAP_INSTANCE || InstanceType == MAP_RAID || InstanceType == MAP_BATTLEGROUND || InstanceType == MAP_ARENA || InstanceType == MAP_SCENARIO; }\n" +
"    bool IsRaid() const { return InstanceType == MAP_RAID; }\n" +
"    bool IsBattleground() const { return InstanceType == MAP_BATTLEGROUND; }\n" +
"    bool IsBattleArena() const { return InstanceType == MAP_ARENA; }\n" +
"    bool IsBattlegroundOrArena() const { return InstanceType == MAP_BATTLEGROUND || InstanceType == MAP_ARENA; }\n" +
"    bool IsScenario() const { return InstanceType == MAP_SCENARIO; }\n" +
"    bool IsWorldMap() const { return InstanceType == MAP_COMMON; }\n" +
"\n" +
"    bool IsContinent() const\n" +
"    {\n" +
"        switch (ID)\n" +
"        {\n" +
"            case 0:\n" +
"            case 1:\n" +
"            case 530:\n" +
"            case 571:\n" +
"            case 870:\n" +
"            case 1116:\n" +
"            case 1220:\n" +
"            case 1642:\n" +
"            case 1643:\n" +
"            case 2222:\n" +
"            case 2444:\n" +
"                return true;\n" +
"            default:\n" +
"                return false;\n" +
"        }\n" +
"    }\n" +
"\n" +
"    bool IsDynamicDifficultyMap() const { return GetFlags().HasFlag(MapFlags::DynamicDifficulty); }\n" +
"    bool IsFlexLocking() const { return GetFlags().HasFlag(MapFlags::FlexibleRaidLocking); }\n" +
"    bool IsGarrison() const { return GetFlags().HasFlag(MapFlags::Garrison); }\n" +
"    bool IsSplitByFaction() const\n" +
"    {\n" +
"        return ID == 609 || // Acherus (DeathKnight Start)\n" +
"            ID == 1265 ||   // Assault on the Dark Portal (WoD Intro)\n" +
"            ID == 1481 ||   // Mardum (DH Start)\n" +
"            ID == 2175 ||   // Exiles Reach - NPE\n" +
"            ID == 2570;     // Forbidden Reach (Dracthyr/Evoker Start)\n" +
"    }\n" +
"\n" +
"    EnumFlag<MapFlags> GetFlags() const { return static_cast<MapFlags>(Flags[0]); }\n" +
"    EnumFlag<MapFlags2> GetFlags2() const { return static_cast<MapFlags2>(Flags[1]); }\n"
                },
                {
                    "MapDifficultyEntry",
"    bool HasResetSchedule() const { return ResetInterval != MAP_DIFFICULTY_RESET_ANYTIME; }\n" +
"    bool IsUsingEncounterLocks() const { return GetFlags().HasFlag(MapDifficultyFlags::UseLootBasedLockInsteadOfInstanceLock); }\n" +
"    bool IsRestoringDungeonState() const { return GetFlags().HasFlag(MapDifficultyFlags::ResumeDungeonProgressBasedOnLockout); }\n" +
"    bool IsExtendable() const { return !GetFlags().HasFlag(MapDifficultyFlags::DisableLockExtension); }\n" +
"\n" +
"    uint32 GetRaidDuration() const\n" +
"    {\n" +
"        if (ResetInterval == MAP_DIFFICULTY_RESET_DAILY)\n" +
"            return 86400;\n" +
"        if (ResetInterval == MAP_DIFFICULTY_RESET_WEEKLY)\n" +
"            return 604800;\n" +
"        return 0;\n" +
"    }\n" +
"\n" +
"    EnumFlag<MapDifficultyFlags> GetFlags() const { return static_cast<MapDifficultyFlags>(Flags); }"
                },
                {
                    "MountEntry",
"    bool IsSelfMount() const { return (Flags & MOUNT_FLAG_SELF_MOUNT) != 0; }"
                },
                {
                    "PhaseEntry",
"    EnumFlag<PhaseEntryFlags> GetFlags() const { return static_cast<PhaseEntryFlags>(Flags); }"
                },
                {
                    "PowerTypeEntry",
"    EnumFlag<PowerTypeFlags> GetFlags() const { return static_cast<PowerTypeFlags>(Flags); }"
                },
                {
                    "PrestigeLevelInfoEntry",
"    bool IsDisabled() const { return (Flags & PRESTIGE_FLAG_DISABLED) != 0; }"
                },
                {
                    "PVPDifficultyEntry",
"    BattlegroundBracketId GetBracketId() const { return BattlegroundBracketId(RangeIndex); }"
                },
                {
                    "ScenarioStepEntry",
"    bool IsBonusObjective() const\n" +
"    {\n" +
"        return Flags & SCENARIO_STEP_FLAG_BONUS_OBJECTIVE;\n" +
"    }"
                },
                {
                    "ScalingStatValuesEntry",
"    int32 getssdMultiplier(uint32 mask) const\n" +
"    {\n" +
"        if (mask & 0x4001F)\n" +
"        {\n" +
"            if (mask & 0x00000001) return ShoulderBudget;\n" +
"            if (mask & 0x00000002) return TrinketBudget;\n" +
"            if (mask & 0x00000004) return WeaponBudget1H;\n" +
"            if (mask & 0x00000008) return PrimaryBudget;\n" +
"            if (mask & 0x00000010) return RangedBudget;\n" +
"            if (mask & 0x00040000) return TertiaryBudget;\n" +
"        }\n" +
"        return 0;\n" +
"    }\n" +
"\n" +
"    int32 getArmorMod(uint32 mask) const\n" +
"    {\n" +
"        if (mask & 0x00F001E0)\n" +
"        {\n" +
"            if (mask & 0x00000020) return ClothShoulderArmor;\n" +
"            if (mask & 0x00000040) return LeatherShoulderArmor;\n" +
"            if (mask & 0x00000080) return MailShoulderArmor;\n" +
"            if (mask & 0x00000100) return PlateShoulderArmor;\n" +
"\n" +
"            if (mask & 0x00080000) return ClothCloakArmor;\n" +
"            if (mask & 0x00100000) return ClothChestArmor;\n" +
"            if (mask & 0x00200000) return LeatherChestArmor;\n" +
"            if (mask & 0x00400000) return MailChestArmor;\n" +
"            if (mask & 0x00800000) return PlateChestArmor;\n" +
"        }\n" +
"        return 0;\n" +
"    }\n" +
"\n" +
"    int32 getDPSMod(uint32 mask) const\n" +
"    {\n" +
"        if (mask & 0x7E00)\n" +
"        {\n" +
"            if (mask & 0x00000200) return WeaponDPS1H;\n" +
"            if (mask & 0x00000400) return WeaponDPS2H;\n" +
"            if (mask & 0x00000800) return SpellcasterDPS1H;\n" +
"            if (mask & 0x00001000) return SpellcasterDPS2H;\n" +
"            if (mask & 0x00002000) return RangedDPS;\n" +
"            if (mask & 0x00004000) return WandDPS;\n" +
"        }\n" +
"        return 0;\n" +
"    }\n" +
"\n" +
"    bool isTwoHand(uint32 mask) const\n" +
"    {\n" +
"        if (mask & 0x7E00)\n" +
"        {\n" +
"            if (mask & 0x00000400) return true;\n" +
"            if (mask & 0x00001000) return true;\n" +
"        }\n" +
"        return false;\n" +
"    }\n" +
"\n" +
"    int32 getSpellBonus(uint32 mask) const\n" +
"    {\n" +
"        if (mask & 0x00008000) return SpellPower;\n" +
"        return 0;\n" +
"    }"
                },
                {
                    "SkillLineEntry",
"    EnumFlag<SkillLineFlags> GetFlags() const { return static_cast<SkillLineFlags>(Flags); };"
                },
                {
                    "SkillLineAbilityEntry",
"    EnumFlag<SkillLineAbilityFlags> GetFlags() const { return static_cast<SkillLineAbilityFlags>(Flags); };"
                },
                {
                    "SpellEffectEntry",
"    SpellEffectAttributes GetEffectAttributes() const { return static_cast<SpellEffectAttributes>(EffectAttributes); };"
                },
                {
                    "SpellItemEnchantmentEntry",
"    EnumFlag<SpellItemEnchantmentFlags> GetFlags() const { return static_cast<SpellItemEnchantmentFlags>(Flags); };"
                },
                {
                    "SpellShapeshiftFormEntry",
"    EnumFlag<SpellShapeshiftFormFlags> GetFlags() const { return static_cast<SpellShapeshiftFormFlags>(Flags); };"
                },
                {
                    "SummonPropertiesEntry",
"    EnumFlag<SummonPropertiesFlags> GetFlags() const { return static_cast<SummonPropertiesFlags>(Flags[0]); };"
                },
                {
                    "TaxiNodesEntry",
"    EnumFlag<TaxiNodeFlags> GetFlags() const { return static_cast<TaxiNodeFlags>(Flags); }\n" +
"\n" +
"    bool IsPartOfTaxiNetwork() const\n" +
"    {\n" +
"        return GetFlags().HasFlag(TaxiNodeFlags::ShowOnAllianceMap | TaxiNodeFlags::ShowOnHordeMap)\n" +
"            // manually whitelisted nodes\n" +
"            || ID == 1985   // [Hidden] Argus Ground Points Hub (Ground TP out to here, TP to Vindicaar from here)\n" +
"            || ID == 1986   // [Hidden] Argus Vindicaar Ground Hub (Vindicaar TP out to here, TP to ground from here)\n" +
"            || ID == 1987   // [Hidden] Argus Vindicaar No Load Hub (Vindicaar No Load transition goes through here)\n" +
"            || ID == 2627   // [Hidden] 9.0 Bastion Ground Points Hub (Ground TP out to here, TP to Sanctum from here)\n" +
"            || ID == 2628   // [Hidden] 9.0 Bastion Ground Hub (Sanctum TP out to here, TP to ground from here)\n" +
"            || ID == 2732   // [HIDDEN] 9.2 Resonant Peaks - Teleport Network - Hidden Hub (Connects all Nodes to each other without unique paths)\n" +
"            || ID == 2835   // [Hidden] 10.0 Travel Network - Destination Input\n" +
"            || ID == 2843   // [Hidden] 10.0 Travel Network - Destination Output\n" +
"        ;\n" +
"    }"
                },
                {
                    "TraitCondEntry",
"    TraitConditionType GetCondType() const { return static_cast<TraitConditionType>(CondType); }"
                },
                {
                    "TraitCurrencyEntry",
"    TraitCurrencyType GetType() const { return static_cast<TraitCurrencyType>(Type); }"
                },
                {
                    "TraitDefinitionEffectPointsEntry",
"    TraitPointsOperationType GetOperationType() const { return static_cast<TraitPointsOperationType>(OperationType); }"
                },
                {
                    "TraitNodeEntry",
"    TraitNodeType GetType() const { return static_cast<TraitNodeType>(Type); }"
                },
                {
                    "TraitNodeEntryEntry",
"    TraitNodeEntryType GetNodeEntryType() const { return static_cast<TraitNodeEntryType>(NodeEntryType); }"
                },
                {
                    "TraitTreeEntry",
"    EnumFlag<TraitTreeFlag> GetFlags() const { return static_cast<TraitTreeFlag>(Flags); }"
                },
                {
                    "UiMapEntry",
"    EnumFlag<UiMapFlag> GetFlags() const { return static_cast<UiMapFlag>(Flags); }"
                },
                {
                    "UnitConditionEntry",
"    EnumFlag<UnitConditionFlags> GetFlags() const { return static_cast<UnitConditionFlags>(Flags); }"
                },
                {
                    "VehicleSeatEntry",
"    inline bool HasFlag(VehicleSeatFlags flag) const { return !!(Flags & flag); }\n" +
"    inline bool HasFlag(VehicleSeatFlagsB flag) const { return !!(FlagsB & flag); }\n" +
"\n" +
"    inline bool CanEnterOrExit() const { return HasFlag(VehicleSeatFlags(VEHICLE_SEAT_FLAG_CAN_ENTER_OR_EXIT | VEHICLE_SEAT_FLAG_CAN_CONTROL | VEHICLE_SEAT_FLAG_SHOULD_USE_VEH_SEAT_EXIT_ANIM_ON_VOLUNTARY_EXIT)); }\n" +
"    inline bool CanSwitchFromSeat() const { return HasFlag(VEHICLE_SEAT_FLAG_CAN_SWITCH); }\n" +
"    inline bool IsUsableByOverride() const {\n" +
"        return HasFlag(VehicleSeatFlags(VEHICLE_SEAT_FLAG_UNCONTROLLED | VEHICLE_SEAT_FLAG_UNK18))\n" +
"            || HasFlag(VehicleSeatFlagsB(VEHICLE_SEAT_FLAG_B_USABLE_FORCED | VEHICLE_SEAT_FLAG_B_USABLE_FORCED_2 |\n" +
"                VEHICLE_SEAT_FLAG_B_USABLE_FORCED_3 | VEHICLE_SEAT_FLAG_B_USABLE_FORCED_4));\n" +
"    }\n" +
"    inline bool IsEjectable() const { return HasFlag(VEHICLE_SEAT_FLAG_B_EJECTABLE); }"
                }
            };


            DBDefsLib.DBDReader reader = new DBDefsLib.DBDReader();
            var files = Directory.GetFiles(@"../../../../../../definitions/");
            int count = 0;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("/*\n" +
" * This file is part of the TrinityCore Project. See AUTHORS file for Copyright information\n" +
" *\n" +
" * This program is free software; you can redistribute it and/or modify it\n" +
" * under the terms of the GNU General Public License as published by the\n" +
" * Free Software Foundation; either version 2 of the License, or (at your\n" +
" * option) any later version.\n" +
" *\n" +
" * This program is distributed in the hope that it will be useful, but WITHOUT\n" +
" * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or\n" +
" * FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for\n" +
" * more details.\n" +
" *\n" +
" * You should have received a copy of the GNU General Public License along\n" +
" * with this program. If not, see <http://www.gnu.org/licenses/>.\n" +
" */\n" +
"\n" +
"#ifndef TRINITY_DB2STRUCTURE_H\n" +
"#define TRINITY_DB2STRUCTURE_H\n" +
"\n" +
"#include \"Common.h\"\n" +
"#include \"DBCEnums.h\"\n" +
"#include \"FlagsArray.h\"\n" +
"#include \"RaceMask.h\"\n" +
"\n" +
"#pragma pack(push, 1)\n");

            foreach (var fullfilename in files) {
                string filename = Path.GetFileName(fullfilename);
                var dbdData = reader.Read(fullfilename);
                // Console.WriteLine("sdasd a " + filename);

                var result = dbdData.versionDefinitions.Where(x => x.builds.Any(y => y.build == 44833));
                if (result.Any())
                {
                    DBDefsLib.Structs.VersionDefinitions versionDef = result.First();
                    ++count;

                    string entryName = filename.Replace(".dbd", "") + "Entry";

                    stringBuilder.AppendLine("struct " + entryName);
                    stringBuilder.AppendLine("{");

                    foreach (var def in versionDef.definitions)
                    {
                        DBDefsLib.Structs.ColumnDefinition columnData = dbdData.columnDefinitions[def.name];
                        string structline = GetCppLineFromDef(def, columnData);
                        stringBuilder.AppendLine("    " + structline);
                    }

                    if (AfterData.ContainsKey(entryName))
                    {
                        stringBuilder.AppendLine();
                        stringBuilder.AppendLine("    // helpers");
                        stringBuilder.AppendLine(AfterData[entryName]);
                    }

                    stringBuilder.AppendLine("}");
                    stringBuilder.AppendLine();
                }


            }

            stringBuilder.AppendLine();
            stringBuilder.AppendLine("#pragma pack(pop)");
            stringBuilder.AppendLine("#endif");

            Console.WriteLine("Total structure: " + count);

            File.WriteAllText("DB2Structure.h", stringBuilder.ToString());
        }

        static string GetCppLineFromDef(DBDefsLib.Structs.Definition versionDef, DBDefsLib.Structs.ColumnDefinition columnda)
        {
            string returnValue = "";
            string type = "";


            bool isSigned = versionDef.isSigned;
            if (versionDef.name == "ID")
            {
                Debug.Assert(versionDef.size == 32);
                isSigned = false;
            }

            switch (versionDef.size)
            {
                case 0:
                    if (versionDef.name.Contains("_lang"))
                        type += "LocalizedString";
                    else
                    {
                        if (columnda.type == "float")
                        {
                            type += "float";
                        }
                        else
                        {
                            Debug.Assert(columnda.type == "string");
                            type += "char const*";
                        }
                    }
                    break;
                case 8:
                    if (!isSigned)
                        type += "u";
                    type += "int8";
                    break;
                case 16:
                    if (!isSigned)
                        type += "u";
                    type += "int16";
                    break;
                case 32:
                    if (!isSigned)
                        type += "u";
                    type += "int32";
                    break;
                case 64:
                    if (!isSigned)
                        type += "u";
                    type += "int64";
                    break;
                default:
                    Debug.Assert(false);
                    break;
            }

            if (versionDef.arrLength > 1)
                returnValue += "std::array<" + type + ", " + versionDef.arrLength + ">";
            else
                returnValue += type;

            string name = versionDef.name;

            if (versionDef.size != 0)
                name = name.Replace("_", "");

            returnValue += " " + name + ";";

            return returnValue;
        }
    }
}
