using System.Collections.Generic;
using TIKSN.Habitica.Models;

namespace TIKSN.Habitica.EisenhowerMatrix.Models
{
    public class Matrix
    {
        public Matrix()
        {
            DoFirstQuadrant = new List<TaskData>();
            ScheduleQuadrant = new List<TaskData>();
            DelegateQuadrant = new List<TaskData>();
            DoNotDoQuadrant = new List<TaskData>();
        }

        public List<TaskData> DelegateQuadrant { get; }

        public List<TaskData> DoFirstQuadrant { get; }

        public List<TaskData> DoNotDoQuadrant { get; }

        public List<TaskData> ScheduleQuadrant { get; }
    }
}