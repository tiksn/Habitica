using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TIKSN.Habitica.Models;
using TIKSN.Habitica.Rest;
using TIKSN.Habitica.Settings;

namespace TIKSN.Habitica.EisenhowerMatrix
{
    public class TagInitializer : ITagInitializer
    {
        private readonly IHabiticaClient _habiticaClient;
        private readonly ITagSettings _tagSettings;

        public TagInitializer(IHabiticaClient habiticaClient, ITagSettings tagSettings)
        {
            _habiticaClient = habiticaClient ?? throw new ArgumentNullException(nameof(habiticaClient));
            _tagSettings = tagSettings ?? throw new ArgumentNullException(nameof(tagSettings));
        }

        public async Task InitializeDefaultsAsync(CancellationToken cancellationToken)
        {
            var tags = await _habiticaClient.GetTagsAsync(cancellationToken);
            TagData tag;

            (tags, tag) = await CreateOrGetTag(tags, "Important", cancellationToken);
            _tagSettings.ImportantTag = tag.Id;

            (tags, tag) = await CreateOrGetTag(tags, "Urgent", cancellationToken);
            _tagSettings.UrgentTag = tag.Id;

            (tags, tag) = await CreateOrGetTag(tags, "Less Important", cancellationToken);
            _tagSettings.LessImportantTag = tag.Id;

            (tags, tag) = await CreateOrGetTag(tags, "Less Urgent", cancellationToken);
            _tagSettings.LessUrgentTag = tag.Id;
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