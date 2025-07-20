using LanguageExt;

using Gay.Silverbranch.API.BLL.Database.V1;
using Gay.Silverbranch.API.BLL.Options.V1;
using Gay.Silverbranch.API.Models.Entities.V1;

namespace Gay.Silverbranch.API.BLL.Repository.Interface.V1;

public interface IModelRepository<T, TD>
    where T : BaseModel
    where TD : IDatabase
{
    Task<string> NextNanoId();

    Task<int> GetQueryTotal(GetAllModelsOptions options);

    Task<Fin<int>> TryCreateAsync(T model,
        CancellationToken token = default);
    Task<int> CreateAsync(T model,
        TD ctx,
        CancellationToken token = default);

    Task<Fin<IEnumerable<T>>> TryGetAllAsync(
        GetAllModelsOptions options,
        CancellationToken token = default);
    
    Task<IEnumerable<T>> GetAllAsync(
        GetAllModelsOptions options,
        TD ctx,
        CancellationToken token = default);

    Task<Fin<T>> TryGetByIdAsync(string id,
        CancellationToken token = default);
    
    Task<T> GetByIdAsync(string id, 
        TD ctx,
        CancellationToken token = default);
    
    Task<Fin<IEnumerable<T>>> TryGetRangeByIdsAsync(
        GetAllModelsOptions options,
        CancellationToken token = default);

    Task<IEnumerable<T>> GetRangeByIdsAsync(
        GetAllModelsOptions options,
        TD ctx,
        CancellationToken token = default);

    Task<Fin<int>> TryUpdateAsync(T model, 
        CancellationToken token = default);
    
    Task<int> UpdateAsync(
        T model, 
        TD ctx,
        CancellationToken token = default);
    
    Task<Fin<int>> TryUpdateToHiddenAsync(
        T model, 
        string user,
        CancellationToken token = default);
    
    Task<int> UpdateToHiddenAsync(
        T model,
        string user,
        TD ctx, 
        CancellationToken token = default);

    Task<Fin<int>> TryDeleteAsync(
        string id, 
        string user, 
        CancellationToken token = default);
    
    Task<int> DeleteAsync(
        string id, 
        string user, 
        TD ctx, 
        CancellationToken token = default);
}