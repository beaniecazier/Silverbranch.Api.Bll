using LanguageExt;

using Gay.Silverbranch.Api.Bll.Options.V1;
using Gay.Silverbranch.Api.Models.Entities.V1;

namespace Gay.Silverbranch.Api.Bll.Services.Interface.V1;

public interface IModelService<T> where T : BaseModel
{
    Task<string> GetNewValidId();
    
    Task<int> GetQueryTotal(GetAllModelsOptions options);
    
    
    Task<Fin<int>> CreateAsync(
        T model,
        CancellationToken token = default);
    
    Task<Fin<int>> UpdateAsync(
        string user,
        T model,
        bool isTrusted = false,
        CancellationToken token = default);
    
    Task<Fin<T>> GetByIdAsync(
        string id,
        bool isTrusted = false,
        CancellationToken token = default);

    Task<Fin<IEnumerable<T>>> GetByIdRangeAsync(
        GetAllModelsOptions options,
        bool isTrusted = false,
        CancellationToken token = default);
    
    Task<Fin<IEnumerable<T>>> GetAllAsync(
        GetAllModelsOptions options,
        CancellationToken token = default);
    
    Task<Fin<T>> DeleteAsync(
        string user,
        string id,
        CancellationToken token = default);
}