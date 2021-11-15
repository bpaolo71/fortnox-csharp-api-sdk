using System.Threading.Tasks;
using Fortnox.SDK.Connectors.Base;
using Fortnox.SDK.Entities;
using Fortnox.SDK.Interfaces;
using Fortnox.SDK.Search;
using Fortnox.SDK.Utility;

namespace Fortnox.SDK.Connectors;

internal class PredefinedVoucherSeriesConnector : SearchableEntityConnector<PredefinedVoucherSeries, PredefinedVoucherSeries, PredefinedVoucherSeriesSearch>, IPredefinedVoucherSeriesConnector
{
    public PredefinedVoucherSeriesConnector()
    {
        Resource = Endpoints.PredefinedVoucherSeries;
    }

    public PredefinedVoucherSeries Get(string id)
    {
        return GetAsync(id).GetResult();
    }

    public PredefinedVoucherSeries Update(PredefinedVoucherSeries predefinedVoucherSeries)
    {
        return UpdateAsync(predefinedVoucherSeries).GetResult();
    }

    public EntityCollection<PredefinedVoucherSeries> Find(PredefinedVoucherSeriesSearch searchSettings)
    {
        return FindAsync(searchSettings).GetResult();
    }

    public async Task<EntityCollection<PredefinedVoucherSeries>> FindAsync(PredefinedVoucherSeriesSearch searchSettings)
    {
        return await BaseFind(searchSettings).ConfigureAwait(false);
    }

    public async Task<PredefinedVoucherSeries> UpdateAsync(PredefinedVoucherSeries predefinedVoucherSeries)
    {
        return await BaseUpdate(predefinedVoucherSeries, predefinedVoucherSeries.Name).ConfigureAwait(false);
    }

    public async Task<PredefinedVoucherSeries> GetAsync(string id)
    {
        return await BaseGet(id).ConfigureAwait(false);
    }
}