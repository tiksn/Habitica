using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TIKSN.Habitica.Models;
using TIKSN.Habitica.Rest;

namespace TIKSN.Habitica.EisenhowerMatrix
{
    public class TagInitializer
    {
        private readonly IApplicationSettings _applicationSettings;
        private readonly IHabiticaClient _habiticaClient;

        public TagInitializer(IHabiticaClient habiticaClient, IApplicationSettings applicationSettings)
        {
            _habiticaClient = habiticaClient ?? throw new ArgumentNullException(nameof(habiticaClient));
            _applicationSettings = applicationSettings ?? throw new ArgumentNullException(nameof(applicationSettings));
        }

        public async Task InitializeDefaultsAsync(CancellationToken cancellationToken)
        {
        }

        private async Task<(TagsModel, TagData)> CreateOrGetTag(TagsModel tags, string name, CancellationToken cancellationToken)
        {
            var foundTag = tags.Data.FirstOrDefault(t => string.Equals(t.Name, name, StringComparison.OrdinalIgnoreCase));

            if (foundTag != null)
            {
                return (tags, foundTag);
            }

            var tagsAfterCreation = await _habiticaClient.CreateTagAsync(name, cancellationToken);

            var tag = tagsAfterCreation.Data.First(t => string.Equals(t.Name, name, StringComparison.OrdinalIgnoreCase));

            return (tagsAfterCreation, tag);
        }
    }
}