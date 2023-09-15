namespace Digitalia.Models.V1;

public class Base
{
	public int StatusId { get; set; }
	public bool IsDeleted { get; set; }
	public DateTime CreatedOn { get; set; }
	public string? CreatedBy { get; set; }
	public DateTime LastModifiedOn { get; set; }
	public string? LastModifiedBy { get; set; }
}