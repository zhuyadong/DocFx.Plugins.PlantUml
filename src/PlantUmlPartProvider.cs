using Microsoft.DocAsCode.Dfm;
using System.Collections.Generic;
using System.Composition;

namespace DocFx.Plugins.PlantUml
{
    [Export(typeof(IDfmCustomizedRendererPartProvider))]
    public class PlantUmlPartProvider : IDfmCustomizedRendererPartProvider
    {
        public IEnumerable<IDfmCustomizedRendererPart> CreateParts(IReadOnlyDictionary<string, object> parameters)
        {
            DocFxPlantUmlSettings settings = new DocFxPlantUmlSettings(parameters);
            yield return new PlantUmlMarkdownRenderer(settings);
        }
    }
}
