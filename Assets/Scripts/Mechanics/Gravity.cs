using System.Collections.Generic;

namespace Assets.Scripts.Systems
{
    public class Gravity: Mechanics
    {
        private static HashSet<SubstanceId> substancesAffected = new HashSet<SubstanceId>() {SubstanceId.Sand};

        private Board currentBoard = null;

        public override void Apply(Board baord)
        {
            currentBoard = baord;
            baord.ForEach(ApplyForField);
        }

        private void ApplyForField(Field field)
        {
            if (substancesAffected.Contains(field.SubstanceId)
                && field.Row - 1 >= 0
                 && currentBoard.GetField(field.Row -1, field.Column).SubstanceId == SubstanceId.Empty)
            {
                currentBoard.GetField(field.Row - 1, field.Column).SwapSubstances(field);
            }
        }
    }

}