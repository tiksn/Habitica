using System;
using System.Threading;
using System.Threading.Tasks;
using TIKSN.Habitica.EisenhowerMatrix.Models;
using TIKSN.Habitica.Models;
using TIKSN.Habitica.Rest;
using TIKSN.Habitica.Settings;

namespace TIKSN.Habitica.EisenhowerMatrix
{
    public class MatrixAndBacklogService : IMatrixAndBacklogService
    {
        private readonly IHabiticaClient _habiticaClient;
        private readonly ITagSettings _tagSettings;

        public MatrixAndBacklogService(IHabiticaClient habiticaClient, ITagSettings tagSettings)
        {
            _habiticaClient = habiticaClient ?? throw new ArgumentNullException(nameof(habiticaClient));
            _tagSettings = tagSettings ?? throw new ArgumentNullException(nameof(tagSettings));
        }

        public async Task<MatrixAndBacklog> GetMatrixAndBacklogAsync(CancellationToken cancellationToken)
        {
            // LINQ is not used for performance
            var result = new MatrixAndBacklog();
            var todos = await _habiticaClient.GetUserToDosAsync(cancellationToken);

            foreach (var todo in todos.Data)
            {
                var isImportant = todo.Tags.Contains(_tagSettings.ImportantTag);
                var isUrgent = todo.Tags.Contains(_tagSettings.UrgentTag);
                var isLessImportant = todo.Tags.Contains(_tagSettings.LessImportantTag);
                var isLessUrgent = todo.Tags.Contains(_tagSettings.LessUrgentTag);

                AddToResult(result, todo, isImportant, isUrgent, isLessImportant, isLessUrgent);
            }

            return result;
        }

        private void AddToResult(MatrixAndBacklog result, TaskData todo, bool isImportant, bool isUrgent, bool isLessImportant, bool isLessUrgent)
        {
            // because of transient network failures, it is possible that only one of necessary tags
            // are set that kind of to-dos should remain in backlog

            var noAnomalies = (isImportant != isLessImportant) && (isUrgent != isLessUrgent);

            if (isImportant && isUrgent && noAnomalies)
                result.Matrix.DoFirstQuadrant.Add(todo);
            else if (isImportant && isLessUrgent && noAnomalies)
                result.Matrix.DelegateQuadrant.Add(todo);
            else if (isLessImportant && isUrgent && noAnomalies)
                result.Matrix.DelegateQuadrant.Add(todo);
            else if (isLessImportant && isLessUrgent && noAnomalies)
                result.Matrix.DoNotDoQuadrant.Add(todo);
            else
                result.Backlog.Add(todo);
        }
    }
}