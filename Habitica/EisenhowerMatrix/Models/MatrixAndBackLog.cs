using System.Collections.Generic;
using TIKSN.Habitica.Models;

namespace TIKSN.Habitica.EisenhowerMatrix.Models
{
    public class MatrixAndBacklog
    {
        public List<TaskData> Backlog { get; set; }

        public Matrix Matrix { get; set; }
    }
}