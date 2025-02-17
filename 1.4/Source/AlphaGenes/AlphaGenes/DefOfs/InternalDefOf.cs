﻿
using RimWorld;
using Verse;


namespace AlphaGenes
{
	[DefOf]
	public static class InternalDefOf
	{
		public static ThingDef AG_Alphapack;
		public static ThingDef AG_Mixedpack;
		public static PawnKindDef Rat;
		public static PawnKindDef Wolf_Timber;
		public static PawnKindDef Bear_Polar;

		public static AbilityDef AG_MinorSummon;


        public static ThoughtDef AG_PukedRats;
		public static ThoughtDef AG_Implanted;
		public static ThoughtDef AG_Implanted_Social;
        public static ThoughtDef AG_Parasite;
        public static ThoughtDef AG_Parasite_Social;

        public static QuestScriptDef AG_OpportunitySite_AbandonedBiotechLab;

		public static GeneDef AG_BrittleBones;
		public static GeneDef AG_UnsettlingAppearance;
		public static GeneDef AG_LungRotStrength;
		public static GeneDef AG_FastGestation;
		public static GeneDef AG_SlowGestation;
		public static GeneDef AG_MetalEater;
		public static GeneDef AlphaGenes_Randomizer;
        public static GeneDef AG_Thalassophobia;
		public static GeneDef AG_BloodVomit;
		public static GeneDef AG_RatVomit;
		public static GeneDef AG_Beauty_Angelic;
        public static GeneDef AlphaGenes_ExoticOrganism;
		public static GeneDef AG_Male;
		public static GeneDef AG_Female;
		public static GeneDef AG_Sensitivity_Lethal;
		public static GeneDef AG_Teratogenesis;
		public static GeneDef AG_EldritchVisage;

		public static GeneDef AG_UnstableMutation;
        public static GeneDef AG_UnstableMutationMajor;
        public static GeneDef AG_UnstableMutationCatastrophic;

        public static HediffDef AG_LungRotStrengthHediff;
		public static HediffDef AG_GeneRemovalComa;
		public static HediffDef AG_MineralCraving;
		public static HediffDef AG_MineralFueled;
		public static HediffDef AG_ReactiveArmourHediff;
		public static HediffDef AG_MineralOverdriveHediff;
		public static HediffDef AG_XenogerminationComa;
		public static HediffDef AG_TemporarySummon;

		public static HediffDef AG_DevouredShooting;
        public static HediffDef AG_DevouredMelee;
        public static HediffDef AG_DevouredConstruction;
        public static HediffDef AG_DevouredMining;
        public static HediffDef AG_DevouredCooking;
        public static HediffDef AG_DevouredPlants;
        public static HediffDef AG_DevouredAnimals;
        public static HediffDef AG_DevouredCrafting;
        public static HediffDef AG_DevouredArtistic;
        public static HediffDef AG_DevouredMedical;
        public static HediffDef AG_DevouredSocial;
        public static HediffDef AG_DevouredIntellectual;



        public static RulePackDef AG_NamerAlphapack;
		public static RulePackDef AG_NamerMixedpack;

		public static JobDef AG_ConsumeMetal;
		public static JobDef AG_FeedMetal;
		public static JobDef AG_DeliverMetal;

		public static MentalStateDef AG_SelectiveManhunter;

        static InternalDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOf));
		}
	}
}
