namespace Core.Persistence.Repositories;

public class BaseEntity<TId>
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime DeletedDate { get; set; }

    public BaseEntity()
    {
        
    }
    public BaseEntity(TId ıd, DateTime createdDate, DateTime updatedDate, DateTime deletedDate)
    {
        Id = ıd;
        CreatedDate = createdDate;
        UpdatedDate = updatedDate;
        DeletedDate = deletedDate;
    }
}
