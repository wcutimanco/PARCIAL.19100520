using PARCIAL._19100520.DOMAIN.Infrastructure.Data;

namespace PARCIAL._19100520.DOMAIN.Core.Interfaces
{
    public interface IAutoPartsRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<AutoParts>> GetAutoParts();
        Task<int> Insert(AutoParts autoParts);
        Task<bool> Update(AutoParts autoParts);
    }
}