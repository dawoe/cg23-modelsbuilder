using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Infrastructure.ModelsBuilder.Building;
using Umbraco.Extensions;

namespace Codegarden23.Core
{
    internal class CodegardenComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            //builder.Services.AddSingleton<IModelsGenerator, CodegardenModelsGenerator>();
        }
    }
}
