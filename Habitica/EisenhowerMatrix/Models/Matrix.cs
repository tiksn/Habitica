using System.Collections.Generic;
using TIKSN.Habitica.Models;

namespace TIKSN.Habitica.EisenhowerMatrix.Models
{
    public class Matrix
    {
        public List<TaskData> DelegateQuadrant { get; set; }

        public List<TaskData> DoFirstQuadrant { get; set; }

        public List<TaskData> DoNotDoQuadrant { get; set; }

        public List<TaskData> ScheduleQuadrant { get; set; }
    }
}