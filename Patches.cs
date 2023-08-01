using UnityEngine;
using MelonLoader;

namespace BetterBlackrock
{
    public class Patches : MelonMod
    {
        public override void OnSceneWasInitialized(int level, string name)
        {
            if (name == "BlackrockPrisonSurvivalZone")
            {

                //Remove Fence Segments
                GameObject.Find("/StaticBarriersFloodLightsFencesWalls/STR_PrisonFencesAndWalls/OBJ_Fence_SecurityMetal_High_NestedA (96)/OBJ_Fence_SecurityMetal_HighB_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/StaticBarriersFloodLightsFencesWalls/STR_PrisonFencesAndWalls/OBJ_Fence_SecurityMetal_High_NestedA (94)/OBJ_Fence_SecurityMetal_HighB_Prefab").gameObject.SetActive(false);

                GameObject.Find("/Lightmapped Static Geo/STR_PrisonBarracks_Interior_Prefab/_NeedsRevertToOriginalLayer/OBJ_BedFrame_A_Prefab (4)").gameObject.SetActive(false);
                GameObject.Find("/Lightmapped Static Geo/STR_PrisonBarracks_Interior_Prefab/Interior_Objects/OBJ_BedFrame_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/Fences/OBJ_Fence_SecurityMetal_GateVehicleA_Prefab/OBJ_Fence_SecurityMetal_GateVehicleA_LOD0").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/Fences/OBJ_Fence_SecurityMetal_GateVehicleB_Prefab/OBJ_Fence_SecurityMetal_GateVehicleB_LOD0").gameObject.SetActive(false);

                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCeiling_L_Prefab/OBJ_PrisonRubbleCeiling_L").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCeiling_J_Prefab/OBJ_PrisonRubbleCeiling_J").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCeiling_J_Prefab (1)/OBJ_PrisonRubbleCeiling_J").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCeiling_J_Prefab (2)/OBJ_PrisonRubbleCeiling_J").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofPanel_B_Burnt_Prefab/OBJ_PrisonRoofPanel_B").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofPanel_B_Burnt_Prefab (1)/OBJ_PrisonRoofPanel_B").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofPanel_B_Burnt_Prefab (2)/OBJ_PrisonRoofPanel_B").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCement_F_Prefab/OBJ_PrisonRubbleCement_F").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCement_F_Prefab (1)/OBJ_PrisonRubbleCement_F").gameObject.SetActive(false);
                
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCement_C_Prefab/OBJ_PrisonRubbleCement_C").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCement_C_Prefab (1)/OBJ_PrisonRubbleCement_C").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCement_C_Prefab (2)/OBJ_PrisonRubbleCement_C").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCement_C_Prefab (3)/OBJ_PrisonRubbleCement_C").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_MetalDoor_PrisonCell_F_Burnt_Prefab/OBJ_MetalDoor_PrisonCell_F_Frame").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_MetalDoor_PrisonCell_F_Burnt_Prefab (1)/OBJ_MetalDoor_PrisonCell_F_Frame").gameObject.SetActive(false);
                //GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_MetalDoor_PrisonCell_F_Burnt_PrefaB/OBJ_MetalDoor_PrisonCell_D").gameObject.SetActive(false);
                //GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofMetalBeam_F_Prefab/OBJ_PrisonRoofMetalBeam_F").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofMetalBeam_F_Prefab (1)/OBJ_PrisonRoofMetalBeam_F").gameObject.SetActive(false);

                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCeiling_C_Prefab/OBJ_PrisonRubbleCeiling_C").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofMetalBeam_B_Prefab/OBJ_PrisonRoofMetalBeam_B").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofMetalBeam_B_Prefab (1)/OBJ_PrisonRoofMetalBeam_B").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofMetalBeam_B_Prefab (2)/OBJ_PrisonRoofMetalBeam_B").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCeiling_K_Prefab/OBJ_PrisonRubbleCeiling_K").gameObject.SetActive(false);

                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCeiling_I_Prefab/OBJ_PrisonRubbleCeiling_I").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRubbleCeiling_I_Prefab (1)/OBJ_PrisonRubbleCeiling_I").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofMetalBeam_C_Prefab/OBJ_PrisonRoofMetalBeam_C").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofMetalBeam_C_Prefab (1)/OBJ_PrisonRoofMetalBeam_C").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofMetalBeam_C_Prefab (2)/OBJ_PrisonRoofMetalBeam_C").gameObject.SetActive(false);
                GameObject.Find("/BlackRock_Art/BlackRock_Prison_ Buildings/STR_GatehouseA_Int_Damaged_Prefab/OBJ_PrisonRoofMetalBeam_C_Prefab (3)/OBJ_PrisonRoofMetalBeam_C").gameObject.SetActive(false);

                //GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/STR_PrisonHallway_Wires_Damage_Prefab").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/STR_PrisonHallway_Wires_Damage_Prefab").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/STR_PrisonHallway_Wires_Damage_Prefab").gameObject.SetActive(false);



                //Move Tree for Roof Access
                GameObject.Find("RegionScene_Art/Blackrock_ArtObjects_ForInstancing/PineTreeLog_Single/TRN_PineTreeLog_SingleD_Prefab (7)").transform.SetPositionAndRotation(new Vector3(-245.589f, 233.787f, 106.6892f), Quaternion.Euler(new Vector3(328.0584f, 83.5042f, 308.9954f)));
            }

            if (name == "BlackrockInteriorASurvival")
            {
                //Junk
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskBase_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalCounterB_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskBase_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskDrawer4_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskDrawer3_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/STR_WoodDoorInt_BStatic_Prefab (4)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskBase_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/STR_WoodDoorInt_BStatic_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_WoodShelfE_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskDrawer3_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_FoldingTableB_Prefab (4)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskBase_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskDrawer3_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskDrawer3_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalFileCabinet_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskBase_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalFileCabinetB_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalBenchA_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskBase_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/CONTAINER_TrashCanister (6)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskDrawer4_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskBase_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_1stFloor/OBJ_MetalDoor_PrisonCell_G_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/OBJ_SecurityGate_A_Prefab/OBJ_SecurityGate_Sliding_A").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonHallways/OBJ_SecurityGate_A_Prefab/OBJ_SecurityGate_Sliding_A").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRubbleCeiling_G_Prefab (6)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRubbleWall_J_Prefab (5)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofCementBeam_A_jnt").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofCementBeam_A_jnt (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofCementBeam_A_jnt (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/OBJ_SecurityGate_A_Prefab (5)/OBJ_SecurityGate_Sliding_A").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRoofCementBeam_A_jnt (2)/OBJ_PrisonRoofCementBeam_A_Burnt_Prefab/OBJ_PrisonRoofCementBeam_A").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRoofCementBeam_A_jnt (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Lrg_C_jnt/OBJ_PrisonPipes_Dmg_Lrg_C_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Lrg_C_jnt (1)/OBJ_PrisonPipes_Dmg_Lrg_C_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Lrg_C_jnt (2)/OBJ_PrisonPipes_Dmg_Lrg_C_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Lrg_C_jnt (3)/OBJ_PrisonPipes_Dmg_Lrg_C_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonPipes_Dmg_Lrg_C_jnt (2)/OBJ_PrisonPipes_Dmg_Lrg_C_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonPipes_Dmg_Lrg_C_jnt (2)/OBJ_PrisonPipes_Dmg_Lrg_C_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofSection_A_jnt").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_jnt/OBJ_PrisonPipes_Dmg_Sml_A_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_1_jnt/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_2_jnt/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_3_jnt/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_4_jnt/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (4)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_3_jnt (1)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_1_jnt (1)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_2_jnt (1)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_3_jnt (2)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_3_jnt (3)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_3_jnt (4)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_3_jnt (5)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_3_jnt (6)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_1_jnt (2)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_1_jnt (3)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_1_jnt (4)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_1_jnt/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_2_jnt/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_3_jnt/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_3_jnt (3)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_1_jnt (2)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_2_jnt (2)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_3_jnt (4)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_1_jnt (3)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (1)").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonHallways/OBJ_FluorescentLightF_NoBulbs_Prefab/OBJ_FluorescentLight_F1").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_3_jnt (5)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofPanel_L_jnt/OBJ_PrisonRoofPanel_L_Burnt_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/STR_PrisonHallway_BrickBeam_jnt (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofSection_A_jnt/OBJ_PrisonRoofSection_A_Burnt_Prefab/OBJ_PrisonRoofSection_A").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofSection_F_jnt/OBJ_PrisonRoofSection_F_Burnt_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Lrg_A_jnt/OBJ_PrisonPipes_Dmg_Lrg_A_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Lrg_C_jnt/OBJ_PrisonPipes_Dmg_Lrg_C_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofSection_E_jnt/OBJ_PrisonRoofSection_E_Burnt_Prefab/OBJ_PrisonRoofSection_E").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofSection_C_jnt/OBJ_PrisonRoofSection_C_Burnt_Prefab/OBJ_PrisonRoofSection_C").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofSection_B_jnt/OBJ_PrisonRoofSection_B_Burnt_Prefab/OBJ_PrisonRoofSection_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonPipes_Dmg_Sml_A_1_jnt (1)/OBJ_PrisonPipes_Dmg_Sml_A_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofPanel_J_jnt/OBJ_PrisonRoofPanel_J_Burnt_Prefab/OBJ_PrisonRoofPanel_J").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofPanel_J_jnt (1)/OBJ_PrisonRoofPanel_J_Burnt_Prefab/OBJ_PrisonRoofPanel_J").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofPanel_J_jnt (2)/OBJ_PrisonRoofPanel_J_Burnt_Prefab/OBJ_PrisonRoofPanel_J").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/STR_PrisonHallway_Wires_B_jnt/STR_PrisonHallway_Wires_B_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofSection_D_jnt/OBJ_PrisonRoofSection_D_Burnt_Prefab/OBJ_PrisonRoofSection_D").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_AirDucts_DamagedHallway_jnt/OBJ_AirDucts_DamagedHallway_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/OBJ_AirDucts_DamagedHallway_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofMetalBeam_A_jnt/OBJ_PrisonRoofMetalBeam_A_Prefab/OBJ_PrisonRoofMetalBeam_A").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_AirDucts_DamagedHallwayBend_jnt/OBJ_AirDucts_DamagedHallwayBend_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofPanel_F_jnt/OBJ_PrisonRoofPanel_F_Burnt_Prefab/OBJ_PrisonRoofPanel_F").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofMetalBeam_B_jnt/OBJ_PrisonRoofMetalBeam_B_Prefab/OBJ_PrisonRoofMetalBeam_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofMetalBeam_B_jnt (1)/OBJ_PrisonRoofMetalBeam_B_Prefab/OBJ_PrisonRoofMetalBeam_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofMetalBeam_B_jnt (2)/OBJ_PrisonRoofMetalBeam_B_Prefab/OBJ_PrisonRoofMetalBeam_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofPanel_D_jnt/OBJ_PrisonRoofPanel_D_Burnt_Prefab/OBJ_PrisonRoofPanel_D").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_FluorescentLight_F1_jnt/OBJ_FluorescentLightF_OneBlub_Prefab/OBJ_FluorescentLight_F1").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_FluorescentLight_F1_jnt/OBJ_FluorescentLightF_OneBlub_Prefab/OBJ_FluorescentLight_F1").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofSection_G_jnt/OBJ_PrisonRoofSection_G_Burnt_Prefab/OBJ_PrisonRoofSection_G").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofPanel_B_jnt/OBJ_PrisonRoofPanel_B_Burnt_Prefab/OBJ_PrisonRoofPanel_B").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofPanel_B_jnt(1)/OBJ_PrisonRoofPanel_B_Burnt_Prefab/OBJ_PrisonRoofPanel_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRoofPanel_B_jnt (2)/OBJ_PrisonRoofPanel_B_Burnt_Prefab/OBJ_PrisonRoofPanel_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRoofPanel_B_jnt (3)/OBJ_PrisonRoofPanel_B_Burnt_Prefab/OBJ_PrisonRoofPanel_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/OBJ_PrisonRoofMetalBeam_C_jnt/OBJ_PrisonRoofMetalBeam_C_Prefab/OBJ_PrisonRoofMetalBeam_C").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRoofPanel_B_jnt (3)/OBJ_PrisonRoofPanel_B_Burnt_Prefab/OBJ_PrisonRoofMetalBeam_C").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/OBJ_SecurityGate_A_Prefab (4)/OBJ_SecurityGate_Sliding_A").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble/STR_PrisonHallway_BrickBeam_jnt (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_North_Rubble").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (3)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (4)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (5)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (6)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (7)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (8)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (9)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (10)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (11)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (12)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (13)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (14)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Collision_Group/Collision (15)").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskBase_Prefab").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/CONTAINER_TrashCanister (6)").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskDrawer4_Prefab (2)").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalDeskBase_Prefab").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/PrisonOffice_1stFloor/OBJ_MetalDoor_PrisonCell_G_Prefab (2)").gameObject.SetActive(false);
                //GameObject.Find("/Root/Art/Geo/OBJ_SecurityGate_A_Prefab/OBJ_SecurityGate_Sliding_A").gameObject.SetActive(false);

                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonPipes_Dmg_Lrg_B_jnt (2)/OBJ_PrisonPipes_Dmg_Lrg_B_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRoofMetalBeam_B_jnt (2)/OBJ_PrisonRoofMetalBeam_B_Prefab/OBJ_PrisonRoofMetalBeam_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRubbleWall_H_Prefab (3)/OBJ_PrisonRubbleWall_H").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRubbleWall_M_Prefab (5)/OBJ_PrisonRubbleWall_M").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonPipes_Dmg_Lrg_A_jnt (2)/OBJ_PrisonPipes_Dmg_Lrg_A_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/STR_PrisonHallway_Pipes_Damaged_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/STR_PrisonHallway_Wires_Damage_Prefab").gameObject.SetActive(false);

                GameObject.Find("/Root/Art/Lighting/INTERACTIVE_FireBarrel").gameObject.SetActive(true);
                GameObject.Find("Root/Art/Lighting/INTERACTIVE_FireBarrel").transform.SetPositionAndRotation(new Vector3(1.8274f, 3.7864f, -19.2508f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonPipes_Dmg_Lrg_B_jnt (2)/OBJ_PrisonPipes_Dmg_Lrg_B_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRoofMetalBeam_B_jnt (2)/OBJ_PrisonRoofMetalBeam_B_Prefab/OBJ_PrisonRoofMetalBeam_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRubbleWall_H_Prefab (3)/OBJ_PrisonRubbleWall_H").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonRubbleWall_M_Prefab (5)/OBJ_PrisonRubbleWall_M").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Junction_Rubble/OBJ_PrisonPipes_Dmg_Lrg_A_jnt (2)/OBJ_PrisonPipes_Dmg_Lrg_A_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/STR_PrisonHallway_Wires_Damage_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/STR_PrisonHallway_Pipes_Damaged_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_MetalDoor_PrisonCell_A_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_MetalDoor_PrisonCell_A_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_MetalDoor_PrisonCell_A_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_bedBunkFrame_A_Prefab (4)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_bedBunkFrame_A_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_bedBunkFrame_A_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_bedBunkFrame_A_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_BedMattressI_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_BedMattressI_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_BedMattressI_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_BedMattressH_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_BedMattressH_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonerCellblock/OBJ_BedMattressH_Prefab").gameObject.SetActive(false);

                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalLockerC_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalLockerA_Prefab/OBJ_MetalLockerA_LOD0").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/STR_WoodDoorInt_BStatic_Prefab/OBJ_WoodDoorInt_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_WoodDoorInt_BStatic_Prefab/OBJ_WoodDoorInt_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonOffice_2ndFloor/OBJ_MetalFileCabinetB_Prefab/OBJ_MetalFileCabinet_LOD0").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/OBJ_AirDuctsLrg_Vent_Prefab (12)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/Recreation_Room/OBJ_AirDuctsLrg_DamagedSection_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/Recreation_Room/OBJ_AirDuctsLrg_DamagedSection_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_WoodDoorInt_BStatic_Prefab/OBJ_WoodDoorInt_B").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/STR_PrisonHallway_Wires_D_Prefab").gameObject.SetActive(false);

                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleCeiling_H_Prefab (6)/OBJ_PrisonRubbleCeiling_H").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleCeiling_J_Prefab (7)/OBJ_PrisonRubbleCeiling_J").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleCeiling_A_Prefab (5)").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleWall_K_Prefab (2)/OBJ_PrisonRubbleWall_K").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleCeiling_I_Prefab (2)/OBJ_PrisonRubbleCeiling_I").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleWall_J_Prefab (3)/OBJ_PrisonRubbleWall_J").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleCement_F_Prefab (1)/OBJ_PrisonRubbleCement_F").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleWall_J_Prefab (5)/OBJ_PrisonRubbleWall_J").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/OBJ_MetalDoor_PrisonCell_D_Damaged_Prefab/OBJ_MetalDoor_PrisonCell_D").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonPipes_Dmg_Lrg_A_jnt (2)/OBJ_PrisonPipes_Dmg_Lrg_A_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/OBJ_MetalDoor_PrisonCell_E_Damaged_Prefab/OBJ_MetalDoor_PrisonCell_E").gameObject.SetActive(false);
                GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleCement_A_Prefab (1)/OBJ_PrisonRubbleCement_A").gameObject.SetActive(false);

               //GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleWall_J_Prefab (4)/OBJ_PrisonRubbleWall_J").gameObject.SetActive(false);
               //GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleCeiling_G_Prefab (4)/OBJ_PrisonRubbleCeiling_G").gameObject.SetActive(false);
               //GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleCeiling_K_Prefab (5)/OBJ_PrisonRubbleCeiling_K").gameObject.SetActive(false);
               //GameObject.Find("/Root/Art/Geo/PrisonHallways/STR_PrisonHallways_Damaged_Prefab/PrisonHallways_Security_Rubble/OBJ_PrisonRubbleWall_H_Prefab (2)/OBJ_PrisonRubbleWall_H").gameObject.SetActive(false);
               //GameObject.Find("/Root/Art/Geo/PrisonHallways/OBJ_FluorescentLightH_NoBulbs_Prefab/OBJ_FluorescentLight_H1").gameObject.SetActive(false);

            }
        }
    }
}