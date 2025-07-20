using Microsoft.Data.SqlClient;
using Swashbuckle.AspNetCore.Annotations;

using Gay.Silverbranch.API.Models.Enum.V1;

namespace Gay.Silverbranch.API.BLL.Options.V1;

public class GetAllModelsOptions
{
    [SwaggerSchema(Description = "hi", Format = "7")]
    public string? Username { get; set; }

    [SwaggerSchema(Description = "hi", Format = "7")]
    public eModelOwnershipScope ModelOwnershipScope { get; set; } = eModelOwnershipScope.Error;
    
    public bool HasFilters => !string.IsNullOrWhiteSpace(NameSearchTerm) ||
                                !string.IsNullOrWhiteSpace(NotesSearchTerm) ||
                                AfterDate.HasValue ||
                                BeforeDate.HasValue ||
                                // GreaterThanOrEqualToId.HasValue ||
                                // LessThanOrEqualToId.HasValue ||
                                AllowDeleted.HasValue ||
                                AllowHidden.HasValue || 
                                SpecificIds?.Length > 0;

    [SwaggerSchema(Description = "hi", Format = "7")]
    public string? NameSearchTerm { get; init; }
    
    [SwaggerSchema(Description = "hi", Format = "7")]
    public string? NotesSearchTerm { get; init; }
    
    [SwaggerSchema(Description = "hi", Format = "7")]
    public DateTime? AfterDate { get; init; }
    
    [SwaggerSchema(Description = "hi", Format = "7")]
    public DateTime? BeforeDate { get; init; }
    
    [SwaggerSchema(Description = "hi", Format = "7")]
    public bool? AllowHidden { get; init; }
    
    [SwaggerSchema(Description = "hi", Format = "7")]
    public bool? AllowDeleted { get; init; }
    
    // [SwaggerSchema(Description = "hi", Format = "7")]
    // public int? GreaterThanOrEqualToId { get; init; }
    //
    // [SwaggerSchema(Description = "hi", Format = "7")]
    // public int? LessThanOrEqualToId { get; init; }
    
    [SwaggerSchema(Description = "hi", Format = "7")]
    public string[]? SpecificIds { get; init; }
    
    //Pagination Properties
    [SwaggerSchema(Description = "hi", Format = "7")]
    public int PageIndex { get; set; } = 0;
    
    [SwaggerSchema(Description = "hi", Format = "7")]
    public int PageSize { get; set; } = 10;

    //Sorting Properties
    public string? SortBy { get; init; }
    public SortOrder? SortDirection { get; init; } = Microsoft.Data.SqlClient.SortOrder.Unspecified;
}