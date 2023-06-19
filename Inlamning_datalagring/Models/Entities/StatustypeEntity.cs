

namespace Inlamning_datalagring.Models.Entities;
internal class StatustypeEntity
{

    public int Id { get; set; }
    public string StatusName { get; set; } = null!;

    public ICollection<CaseEntity> Cases { get; set; } = new HashSet<CaseEntity>();

}
