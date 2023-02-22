using System.ComponentModel.DataAnnotations;

namespace IncreaseNumberAPI.Models.API;

public sealed record Increment(
    [Required]
    [Range(1, Int32.MaxValue)]
    int value
    );

