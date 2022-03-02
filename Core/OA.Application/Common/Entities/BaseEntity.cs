namespace OA.Application.Common.Entities;

public class BaseEntity
{
    public Guid Id { get; set; }
    public Boolean IsDelete { get; set; }

    public BaseEntity()
    {
        this.Id = Guid.NewGuid();
        this.IsDelete = false;
    }
}
