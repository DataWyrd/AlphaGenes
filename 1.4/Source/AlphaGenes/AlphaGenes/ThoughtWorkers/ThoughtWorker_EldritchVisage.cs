﻿
using RimWorld;
using Verse;
namespace AlphaGenes
{
	public class ThoughtWorker_EldritchVisage : ThoughtWorker
	{
		protected override ThoughtState CurrentSocialStateInternal(Pawn pawn, Pawn other)
		{
			if (!other.RaceProps.Humanlike || !RelationsUtility.PawnsKnowEachOther(pawn, other))
			{
				return false;
			}

			if (other.genes?.GetGene(InternalDefOf.AG_EldritchVisage)?.Active == true && pawn.genes?.HasGene(InternalDefOf.AG_EldritchVisage) == false)

			{
				return ThoughtState.ActiveAtStage(0);
			}

			return false;
		}
	}
}