using System.Runtime.ConstrainedExecution;
using UnityEngine;

namespace Assets.Scripts
{
    public class Field
    {
        public Field(int row, int column, SubstanceId initialSubstanceId)
        {
            Row = row;
            Column = column;
            SubstanceId = initialSubstanceId;
        }

        public Field(Field field)
        {
            Row = field.Row;
            Column = field.Column;
            SubstanceId = field.SubstanceId;
        }

        public int Row { get; }

        public int Column { get; }

        public SubstanceId SubstanceId { get; private set; }

        public void SwapSubstances(Field other)
        {
            var newSubstanceId = other.SubstanceId;
            other.SubstanceId = this.SubstanceId;
            SubstanceId = newSubstanceId;
        }
    }
}