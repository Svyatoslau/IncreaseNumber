namespace IncreaseNumberAPI.DAL.Entities;

public class Counter
{
    public int Id { get; set; }
    public int Value { get; set; }
    public DateTime LastChange { get; set; }
    public DateTime? PickedDate { get; set; }
}
