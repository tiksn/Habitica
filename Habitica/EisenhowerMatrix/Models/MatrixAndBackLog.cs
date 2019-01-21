using System.Collections.Generic;
using TIKSN.Habitica.Models;

namespace TIKSN.Habitica.EisenhowerMatrix.Models
{
    public class MatrixAndBacklog
    {
        public MatrixAndBacklog()
        {
            Backlog = new List<TaskData>();
            Matrix = new Matrix();
        }

        public List<TaskData> Backlog { get; }

        public Matrix Matrix { get; }
    }
}